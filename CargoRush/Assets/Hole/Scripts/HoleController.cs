using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Cinemachine;
using ObserverSystem;

public class HoleController : Observer
{
    private static HoleController _instance = null;
    public static HoleController Instance => _instance;

    public static Action OnControl, OnUpdate;
    [SerializeField] Vector2 holeBounding_X;
    [SerializeField] Vector2 holeBounding_Y;

    [SerializeField] private controlSettings character_Settings;
    [SerializeField] private HoleUpgradeSettings _holeUpgradeSettings;
    [SerializeField] private CameraSettings camera_Settings;
    [SerializeField] public Transform cameraFollowPoint;
    [SerializeField] CinemachineVirtualCamera PlayerCam;


    Vector3 playerFirstPos;
    Vector3 camFirstPoint;


    private Vector2 firstPressPos;
    private Vector2 secondPressPos;
    private Vector2 currentSwipe;
    Vector3 direction;

    float Xmove = 0f;

    private float preX = 0f;
    private float preY = 0f;
    private float dX = 0f;
    private float dY = 0f;
    private float dX_Sum = 0f;
   public bool press = false;
    bool rotSet = true;
    float animationRot = 0f;

    public Vector3 objPosition;
    public Vector3 camFirstPosition;
    Collider _collider;
    void Awake()
    {
        _collider = GetComponent<Collider>();
        _instance = this;
        playerFirstPos = transform.position;
        camFirstPoint = cameraFollowPoint.localPosition;
        Init();
    }
    void Start()
    {
        ObserverManager.Instance.RegisterObserver(this, SubjectType.GameState);//observer register
        _holeUpgradeSettings = LevelManager.Instance._holeUpgradeSettings;

    }
    public override void OnNotify(NotificationType notificationType) //observer notify
    {
        switch (notificationType)
        {
            case NotificationType.Start:
                {
                    //if (PlayerPrefs.GetInt("gameopened") == 0)
                    //{
                    //    GameStart();
                    //}
                }
                break;
            case NotificationType.End:
                {

                }
                break;
            case NotificationType.Win:
                {
                    //Invoke("WinState", 1);
                    //Debug.Log("win");
                }
                break;
            case NotificationType.Fail:
                {
                    //Invoke("FailState", 1);
                    //Debug.Log("fail");
                }
                break;

        }
    }
    void Init()
    {
        direction = transform.parent.transform.forward;
        OnControl += pressMove;
        //OnControl += joystickControl;
        //PlayerCam.Follow = cameraFollowPoint;
        //PlayerCam.LookAt = transform.parent;
        camFirstPosition = cameraFollowPoint.position;

    }
    public void HoleControlDeActive()
    {
        StartCoroutine(HoleSetStartPos());
        OnUpdate = null;
        secondPressPos = (Vector2)Input.mousePosition;
        currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

        dX_Sum = 0;
        dX = 0f;
        dY = 0f;

        press = false;
    }
    IEnumerator HoleSetStartPos()
    {
        yield return new WaitForSeconds(4f);
        HoleManager.Instance.HolePositionReset();
    }
    public void GameStart()
    {
        _collider.enabled = true;
        OnUpdate += _Update;
    }
    void FixedUpdate()
    {
        OnUpdate?.Invoke();
    }
    void _Update()
    {
        generalControl();
        OnControl?.Invoke();
    }
    public void pressMove()
    {

        if (press)
        {
            move();
        }
    }
    void move()
    {
        Vector3 moveDirection;
        secondPressPos = (Vector2)Input.mousePosition;
        currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y).normalized;
        moveDirection = new Vector3(currentSwipe.x, 0f, currentSwipe.y).normalized;


        //float speed = _holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel] * (1f - (0.05f * Globals.holeRadiusLevel));
        float speed = _holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel];

        if (speed < _holeUpgradeSettings.holeSpeed[0])
        {
            speed = _holeUpgradeSettings.holeSpeed[0];
        }
        //Debug.Log("SPEEEDD   " + speed);

        objPosition += moveDirection * Time.deltaTime * speed;

        objPosition = new Vector3(Mathf.Clamp(objPosition.x, holeBounding_X.x + transform.localScale.x, holeBounding_X.y - transform.localScale.x), objPosition.y, Mathf.Clamp(objPosition.z, holeBounding_Y.x + transform.localScale.x, holeBounding_Y.y- transform.localScale.x));

        transform.parent.transform.position = Vector3.MoveTowards(transform.parent.transform.position, objPosition, Time.deltaTime * _holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel] * 2 );
        //transform.parent.transform.position = Vector3.Lerp(transform.parent.transform.position, objPosition, Time.deltaTime * _holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel]);
        cameraFollowPoint.position = Vector3.Lerp(cameraFollowPoint.position, new Vector3(objPosition.x,objPosition.y, camFirstPosition.z), Time.deltaTime * _holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel]);
        //transform.parent.transform.Translate(objPosition);
        //cameraFollowPoint.Translate(new Vector3(0,0, -objPosition.z) * Time.deltaTime * speed);
        //cameraFollowPoint.position = new Vector3(cameraFollowPoint.position.x, cameraFollowPoint.position.y, -moveDirection.z);
    }
    //private void joystickControl()
    //{
    //    float targetAngle = directionSet(0);
    //    Quaternion newRot = Quaternion.Euler(0, targetAngle, 0);

    //    if (press)
    //    {
    //        transform.rotation = Quaternion.RotateTowards(transform.rotation, newRot, character_Settings._sensivity * 100 * Time.deltaTime);
    //    }
    //}
    //float directionSet(float GO)
    //{
    //    secondPressPos = (Vector2)Input.mousePosition;
    //    currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y).normalized;
    //    if (GO == 1)
    //    {
    //        Debug.Log(currentSwipe.x);
    //        direction = new Vector3(currentSwipe.x, 0f, GO);

    //    }
    //    else
    //    {
    //        direction = new Vector3(currentSwipe.x, 0f, currentSwipe.y);
    //    }
    //    return Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

    //}
    public void FirstClick()
    {
        preX = Input.mousePosition.x;
        preY = Input.mousePosition.y;
        dX = 0f;
        dY = 0f;
        dX_Sum = 0;

        firstPressPos = (Vector2)Input.mousePosition;

        press = true;
    }
    private void generalControl()
    {

        if (Input.GetMouseButtonDown(0))
        {

            preX = Input.mousePosition.x;
            preY = Input.mousePosition.y;
            dX = 0f;
            dY = 0f;
            dX_Sum = 0;

            firstPressPos = (Vector2)Input.mousePosition;

            press = true;
   
        }

        if (Input.GetMouseButton(0))
        {
            press = true;

            dX = (Input.mousePosition.x - preX) / 10f;
            dY = (Input.mousePosition.y - preY) / 10f;
            dX_Sum += dX;

            secondPressPos = (Vector2)Input.mousePosition;

            if (Vector2.Distance(secondPressPos, firstPressPos) > 200f)
            {
                firstPressPos = Vector2.Lerp(firstPressPos, secondPressPos, 2 * Time.deltaTime);
            }

            preX = Input.mousePosition.x;
            preY = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            secondPressPos = (Vector2)Input.mousePosition;
            currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

            dX_Sum = 0;
            dX = 0f;
            dY = 0f;

            press = false;
        }
        dX_Sum = Mathf.Clamp(dX_Sum, -100 / character_Settings._swingSensivity, 10 / character_Settings._swingSensivity);
        Xmove = character_Settings._controlSensivity * dX / (Time.deltaTime * 25);
    }
}
