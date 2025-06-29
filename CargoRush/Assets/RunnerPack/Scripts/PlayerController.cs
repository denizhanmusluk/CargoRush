﻿using Cinemachine;
using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    private static PlayerController _instance = null;
    public static PlayerController Instance => _instance;

    public static Action OnControl, OnUpdate, GoToCeo_Update;

    public enum Controls { runner, joystick, swing, none }
    public Controls ControlType;

    public enum Move { AutoMove, PressMove }
    public Move moveSelect;
    [SerializeField] GameObject confettiParticles;
    [SerializeField] private controlSettings character_Settings;
    [SerializeField] public CharacterUpgradeSettings _characterUpgradeSettings;
    [SerializeField] private CameraSettings camera_Settings;
    [SerializeField] public Transform cameraFollowPoint;
    [SerializeField] CinemachineVirtualCamera PlayerCam;
    [SerializeField] CinemachineVirtualCamera PlayerCamZoomIn;
    [SerializeField] CinemachineVirtualCamera PlayerCamZoomInVip;
    [SerializeField] public Animator animator;
    [SerializeField] NavMeshAgent navmeshAgent;
    //[SerializeField] Transform camLastPoint;
    Vector3 playerFirstPos;
    Vector3 camFirstPoint;

    public Vector2 firstPressPos;
    private Vector2 secondPressPos;
    private Vector2 currentSwipe;
    Vector3 direction;


    float Xmove = 0f;
    //float speed = 15;

    private float preX = 0f;
    private float preY = 0f;
    private float dX = 0f;
    private float dY = 0f;
    private float dX_Sum = 0f;
    public bool pressJoystick = false;
    bool rotSet = true;
    float animationRot = 0f;
    [SerializeField] bool startActive = false;
    //[SerializeField] public GameObject moneyTarget;
    //public RectTransform moneylabel;
    public CollisionController magnet;
    public StackCollect _stackCollect;
    [SerializeField] GameObject pointText;

    public bool dropActive = true;
    public FloatingJoystick _FloatingJoystick;
    public bool moveRotToCamera;
    public Transform posTR;
    public Board _board;
    public List<GameObject> modelList = new List<GameObject>();
    public GameObject modelParentGO;
    public GameObject bandBoard;
    public Transform bandBoardCreatePos;

    public GameObject skateBoard;
    public Transform skateCreatePos;

    public GameObject hoverBoard;
    public Transform hoverBoardCreatePos;

    public Transform characterSkinParent;
    public Vector3 characterLocomotivePos;

    public GameObject nullVehicleGO;
    public Player _player;
    public GameObject fullTextGO;
    public List<GameObject> vagons = new List<GameObject>();
    public GameObject locomotiveGO;

    void Awake()
    {
        _instance = this;

        playerFirstPos = transform.position;
        camFirstPoint = cameraFollowPoint.localPosition;
    }
    public void PlayerSetPos()
    {
        transform.parent.position = posTR.position;
        StartCoroutine(SetNavMesh());
    }
    IEnumerator SetNavMesh()
    {
        navmeshAgent.enabled = false;
        yield return null;
        navmeshAgent.enabled = true;
    }
    private void Start()
    {
        _characterUpgradeSettings = LevelManager.Instance._currnetCharacterUpgradeSettings;
        _FloatingJoystick = FindObjectOfType<FloatingJoystick>();
        Init();

        //moneyTarget = GameObject.Find("MoneyTarget");
        //moneylabel = GameObject.Find("moneyLabel").GetComponent<RectTransform>();
        //moneyTarget.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(moneylabel.transform.position.x, moneylabel.transform.position.y, Camera.main.WorldToScreenPoint(moneyTarget.transform.position).z));

        //if (startActive)
        //{
        //    GameStart();
        //}
        StartCoroutine(StartDelay());
        if (PlayerPrefs.GetInt("gamefirstopen") == 0)
        {
            PlayerPrefs.SetInt("gamefirstopen", 1);
            PlayerSetPos();
        }
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        //ModelSelect();
        ModelSelector.Instance.CreatePlayer();
        ModelSelector.Instance.FirstOpenPlayerUI();
        AudioManager.Instance.transform.parent = transform;
        AudioManager.Instance.transform.localPosition = Vector3.zero;
    }
    public void SkateBoardActive()
    {
        if (!Globals.trainActive)
        {
            if (_board != null)
            {
                Destroy(_board.gameObject);
                _board = null;
            }
            nullVehicleGO.SetActive(false);
            Board _sakteboard = Instantiate(skateBoard, skateCreatePos.position, skateCreatePos.rotation, skateCreatePos).GetComponent<Board>();
            _board = _sakteboard;
            StartCoroutine(AnimationSet("singlewheel"));
            _stackCollect.stackLevel_1_PosList[0].transform.localPosition = new Vector3(_stackCollect.stackLevel_1_PosList[0].transform.localPosition.x, _stackCollect.stackLevel_1_PosList[0].transform.localPosition.y, -0.6f);
        }
    }
    public void BandBoardActive()
    {
        if (!Globals.trainActive)
        {
            if (_board != null)
            {
                Destroy(_board.gameObject);
                _board = null;
            }
            nullVehicleGO.SetActive(false);
            Board _sakteboard = Instantiate(bandBoard, bandBoardCreatePos.position, bandBoardCreatePos.rotation, bandBoardCreatePos).GetComponent<Board>();
            _board = _sakteboard;
            StartCoroutine(AnimationSet("singlewheel"));
            _stackCollect.stackLevel_1_PosList[0].transform.localPosition = new Vector3(_stackCollect.stackLevel_1_PosList[0].transform.localPosition.x, _stackCollect.stackLevel_1_PosList[0].transform.localPosition.y, 0.5f);
            //transform.localPosition = new Vector3(transform.localPosition.x, 0.65f, transform.localPosition.z);
        }
    }
    public void HoverBoardActive()
    {
        if (!Globals.trainActive)
        {
            if (_board != null)
            {
                Destroy(_board.gameObject);
                _board = null;
            }
            nullVehicleGO.SetActive(false);
            Board _sakteboard = Instantiate(hoverBoard, skateCreatePos.position, hoverBoardCreatePos.rotation, hoverBoardCreatePos).GetComponent<Board>();
            _board = _sakteboard;
            StartCoroutine(AnimationSet("hoverboard"));
            _stackCollect.stackLevel_1_PosList[0].transform.localPosition = new Vector3(_stackCollect.stackLevel_1_PosList[0].transform.localPosition.x, _stackCollect.stackLevel_1_PosList[0].transform.localPosition.y, 0.5f);
        }
    }
    public void NoneVehicle()
    {
        if (_board != null)
        {
            Destroy(_board.gameObject);
            _board = null;


            StartCoroutine(AnimationSet("null"));
            nullVehicleGO.SetActive(true);
            _stackCollect.stackLevel_1_PosList[0].transform.localPosition = new Vector3(_stackCollect.stackLevel_1_PosList[0].transform.localPosition.x, _stackCollect.stackLevel_1_PosList[0].transform.localPosition.y, 0.1f);
            transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);

        }
    }
    public void ModelSelect()
    {

        foreach (var mdl in modelList)
        {
            mdl.SetActive(false);
        }
        _board = null;
        modelList[PlayerPrefs.GetInt("modelselect")].SetActive(true);
        if (modelList[PlayerPrefs.GetInt("modelselect")].GetComponent<Board>() != null)
            _board = modelList[PlayerPrefs.GetInt("modelselect")].GetComponent<Board>();
        //StartCoroutine(AnimationSet("singlewheel"));

    }
    public void CharacterSelect(GameObject model)
    {
        if (characterSkinParent.childCount > 0)
        {
            Destroy(characterSkinParent.GetChild(0).gameObject);
        }
        model.transform.parent = characterSkinParent;
        model.transform.localPosition = Vector3.zero;
        //model.transform.localScale = Vector3.one;
        model.transform.localRotation = Quaternion.Euler(0, 0, 0);
        animator = model.GetComponent<Animator>();

        if (_stackCollect.collectionTrs.Count > 0)
        {
            _stackCollect.StackAnimation();
        }
    }
    IEnumerator AnimationSet(string animationName)
    {
        animator.SetBool("singlewheel", false);
        animator.SetBool("hoverboard", false);
        animator.SetBool("null", false);

        //animator.SetBool("walk", false);
        yield return new WaitForSeconds(0.1f);
        animator.SetTrigger("reset");
        animator.SetBool(animationName, true);
        /*
       if (PlayerPrefs.GetInt("modelselect") == 0)
       {
           animator.SetBool("null", true);
       }
       else
       {
           animator.SetBool("null", false);
       }


       if (PlayerPrefs.GetInt("modelselect") == 1)
       {
           animator.SetBool("singlewheel", true);
       }
       else
       {
           animator.SetBool("singlewheel", false);
       }


       if (PlayerPrefs.GetInt("modelselect") == 2)
       {
           animator.SetBool("hoverboard", true);
       }
       else
       {
           animator.SetBool("hoverboard", false);
       }



       if (PlayerPrefs.GetInt("modelselect") == 3)
       {
       }
       else
       {
       }
       */
    }
    public void DropActivator()
    {
        StartCoroutine(DropActivate());
    }
    IEnumerator DropActivate()
    {
        dropActive = false;
        yield return new WaitForSeconds(0.1f);
        dropActive = true;
    }
    public void GameStart()
    {
        OnUpdate += _Update;
        animator.SetBool("working", false);
        Globals.playerStackActive = true;
    }
    public void PlayerControl_ReActive()
    {
        Globals.playerStackActive = true;
        if (!_FloatingJoystick.pressActive)
        {
            firstPressPos = (Vector2)Input.mousePosition;
        }
        else
        {
            pressJoystick = true;

        }
        OnUpdate = null;
        animator.SetBool("working", false);
        StartCoroutine(ReactiveDelay());
    }
    bool reactivator = true;
    IEnumerator ReactiveDelay()
    {
        float delayRnd = UnityEngine.Random.Range(0.1f, 0.5f);
        yield return new WaitForSeconds(delayRnd);
        if (OnUpdate == null)
        {
            OnUpdate += _Update;
            reactivator = false;
        }
    }
    public void OnDisable()
    {
        OnUpdate = null;
    }

    void Init()
    {
        PlayerCam = CameraManager.Instance.vCamPlayer;
        PlayerCamZoomIn = CameraManager.Instance.vCamPlayerZoomIn;
        PlayerCamZoomInVip = CameraManager.Instance.vCamPlayerZoomInVip;

        direction = transform.parent.transform.forward;
        switch (moveSelect)
        {
            case Move.AutoMove:
                {
                    OnControl += autoMove;
                }
                break;
            case Move.PressMove:
                {
                    OnControl += pressMove;
                }
                break;
        }
        switch (ControlType)
        {
            case Controls.runner:
                {
                    //speed = character_Settings._runnerMoveSpeed;
                    OnControl += runnerControl;
                }
                break;
            case Controls.joystick:
                {
                    //speed = _characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel];
                    OnControl += joystickControl;
                    PlayerCam.Follow = transform.parent;
                    PlayerCamZoomIn.Follow = transform.parent;
                    PlayerCamZoomInVip.Follow = transform.parent;

                    PlayerCam.LookAt = transform.parent;
                    PlayerCamZoomIn.LookAt = transform.parent;
                    PlayerCamZoomInVip.LookAt = transform.parent;
                }
                break;
            case Controls.swing:
                {
                    //speed = character_Settings._swingMoveSpeed;
                    OnControl += swingControl;
                }
                break;
            case Controls.none:
                {

                }
                break;
        }
    }
    void _Update()
    {
        generalControl();
        OnControl?.Invoke();
    }
    void Update()
    {
        moneyTextCreateTR.rotation = Quaternion.Euler(moneyTextCreateTR.eulerAngles.x, 42.038f, moneyTextCreateTR.eulerAngles.z);

        OnUpdate?.Invoke();
        GoToCeo_Update?.Invoke();
        //if (Input.GetKeyDown(KeyCode.Alpha0))
        //{
        //    NoneVehicle();
        //    //PlayerPrefs.SetInt("modelselect", 0);
        //    //ModelSelect();
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha1))
        //{
        //    SkateBoardActive();
        //    //PlayerPrefs.SetInt("modelselect", 1);
        //    //ModelSelect();
        //}

        //if (Input.GetKeyDown(KeyCode.Alpha2))
        //{
        //    BandBoardActive();
        //    //PlayerPrefs.SetInt("modelselect", 2);
        //    //ModelSelect();
        //}
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TrainActive();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CloseTrain();
        }

    }
    public void PlayerControlDeActive()
    {
        reactivator = true;
        Globals.playerStackActive = false;
        OnUpdate = null;
        pressJoystick = false;
        secondPressPos = (Vector2)Input.mousePosition;
        currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

        dX_Sum = 0;
        dX = 0f;
        dY = 0f;

        if (moveSelect == Move.PressMove)
        {
            StartCoroutine(smoothStop());
            StartCoroutine(CameraVerticalMove(0, false));
            playerStop();
        }

    }
    public void PlayerDisperseCollected()
    {
        //_stackCollect.DisperseCollected();
        //StartCoroutine(MoveTarget(targetPosTR));
    }
    IEnumerator MoveTarget(Transform targetPosTR)
    {
        Vector3 firstPos = transform.parent.position;
        navmeshAgent.isStopped = false;

        float counter = 0f;
        while (0.1f < Vector3.Distance(transform.parent.position, targetPosTR.position))
        {
            animator.SetFloat("x", 0);
            animator.SetFloat("y", 1);
            navmeshAgent.SetDestination(targetPosTR.position);
            //float yAngle = Vector3.Angle(transform.parent.position, targetPosTR.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(transform.eulerAngles.x, Quaternion.LookRotation(navmeshAgent.velocity.normalized).eulerAngles.y, transform.eulerAngles.z), Time.deltaTime * 300);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.Euler(transform.eulerAngles.x, Quaternion.LookRotation(targetPosTR.position).eulerAngles.y, transform.eulerAngles.z), Time.deltaTime * 100);
            //transform.parent.position = Vector3.Lerp(firstPos, targetPosTR.position, counter);
            yield return null;
        }

        while (counter < 1f)
        {
            counter += Time.deltaTime;
            animator.SetFloat("x", 0);
            animator.SetFloat("y", 0);
            navmeshAgent.SetDestination(targetPosTR.position);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetPosTR.rotation, counter);
            yield return null;
        }
        navmeshAgent.isStopped = true;
        animator.SetBool("working", true);
    }
    public bool pressActive = true;
    private void generalControl()
    {
        if (Input.GetMouseButtonDown(0) && pressActive)
        {
            preX = Input.mousePosition.x;
            preY = Input.mousePosition.y;
            dX = 0f;
            dY = 0f;
            dX_Sum = 0;

            firstPressPos = (Vector2)Input.mousePosition;

            pressJoystick = true;
            if (moveSelect == Move.PressMove)
            {
                StartCoroutine(CameraVerticalMove(camera_Settings._VerticalDamping, true));
            }
            if (_board != null)
            {
                foreach (var fltrwr in _board.flameThrowers)
                {
                    fltrwr.BurnActive();
                }
            }
        }


        if (pressJoystick && pressActive)
        {
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

            pressJoystick = false;
            if (moveSelect == Move.PressMove)
            {
                StartCoroutine(smoothStop());
                StartCoroutine(CameraVerticalMove(0, false));
                playerStop();
            }
            if (_board != null)
            {
                foreach (var fltrwr in _board.flameThrowers)
                {
                    fltrwr.BurnPassive();
                }
            }
        }
        dX_Sum = Mathf.Clamp(dX_Sum, -100 / character_Settings._swingSensivity, 100 / character_Settings._swingSensivity);
        Xmove = character_Settings._controlSensivity * dX / (Time.deltaTime * 25);
    }
    public void autoMove()
    {
        Moving();
    }
    public void pressMove()
    {
        if (pressJoystick)
        {
            Moving();
        }
    }
    void Moving()
    {
        Vector3 moveDirection;
        if (ControlType == Controls.runner)
        {
            moveDirection = transform.parent.transform.forward;
        }
        else
        {
            moveDirection = direction;
        }
        if (moveRotToCamera)
        {
            Quaternion rotationQuaternion = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0);
            Matrix4x4 rotationMatrix = Matrix4x4.Rotate(rotationQuaternion);
            Vector3 rotatedDirection = rotationMatrix.MultiplyPoint3x4(direction);
            moveDirection = rotatedDirection;
            //moveSpeed /= 2;
        }
        float trainSpeedFactor = _characterUpgradeSettings.trainSpeedFactor;
        if (!Globals.trainActive)
        {
            trainSpeedFactor = 1f;
        }
        transform.parent.transform.Translate(trainSpeedFactor * moveDirection * Time.deltaTime * (_characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel] * Globals.extraSpeedSkins * Globals.extraSpeed));

    }
    private void runnerControl()
    {

        if (Xmove != 0)
        {
            Vector3 horizontal = new Vector3(playerFirstPos.x + (Xmove / Math.Abs(Xmove)) * character_Settings._HorizontalBounding, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, horizontal, Time.deltaTime * Mathf.Abs(Xmove));
            animationRot = directionSet(1);
            playerMovingDirection(animationRot);

        }
        else
        {
            if (Math.Abs(animationRot) > 5)
            {
                if (animationRot > 0)
                {
                    animationRot -= 200 * Time.deltaTime;
                }
                if (animationRot < 0)
                {
                    animationRot += 200 * Time.deltaTime;
                }
                playerMovingDirection(animationRot);
            }
            else
            {
                animationRot = 0;
                if (pressJoystick)
                {
                    playerMovingDirection(animationRot);
                }
            }

        }


        cameraFollowPoint.localPosition = new Vector3(-transform.localPosition.x * camera_Settings._HorizontalDamping, cameraFollowPoint.localPosition.y, cameraFollowPoint.localPosition.z);
    }
    private void swingControl()
    {
        if (dX_Sum == 0)
        {
            Quaternion rot = Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0);
            transform.parent.rotation = Quaternion.RotateTowards(transform.parent.rotation, rot, character_Settings._turnSmooth * Time.deltaTime);
        }
        else
        {
            Quaternion rot = Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, (dX_Sum / (Math.Abs(dX_Sum))) * character_Settings._maxTurnAngle * Mathf.Abs(character_Settings._swingSensivity * dX_Sum / 100));
            transform.parent.rotation = Quaternion.RotateTowards(transform.parent.rotation, rot, character_Settings._turnSmooth * Time.deltaTime);
        }
        cameraFollowPoint.localPosition = new Vector3(-transform.localPosition.x * camera_Settings._HorizontalDamping, cameraFollowPoint.localPosition.y, cameraFollowPoint.localPosition.z);
    }
    private void joystickControl()
    {

        float targetAngle = directionSet(0);
        Quaternion newRot = Quaternion.Euler(0, targetAngle, 0);
        if (moveRotToCamera)
        {
            newRot = Quaternion.Euler(0, targetAngle + Camera.main.transform.eulerAngles.y, 0);
        }


        if (pressJoystick)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRot, character_Settings._sensivity * 100 * Time.deltaTime);
            playerMovingDirection(targetAngle);
        }
    }
    float directionSet(float GO)
    {
        secondPressPos = (Vector2)Input.mousePosition;
        currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y).normalized;
        if (GO == 1)
        {
            Debug.Log(currentSwipe.x);
            direction = new Vector3(currentSwipe.x, 0f, GO);

        }
        else
        {
            direction = new Vector3(currentSwipe.x, 0f, currentSwipe.y);
        }
        return Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

    }

    IEnumerator CameraVerticalMove(float moveDistance, bool pressActive)
    {
        float offset = 2.5f;
        float acceleretion = camera_Settings._VerticalDampingSpeed;
        while (Vector3.Distance(cameraFollowPoint.localPosition, new Vector3(cameraFollowPoint.localPosition.x, cameraFollowPoint.localPosition.y, camFirstPoint.z - offset * moveDistance)) > 0.1f && pressJoystick == pressActive)
        {
            cameraFollowPoint.localPosition = Vector3.Lerp(cameraFollowPoint.localPosition, new Vector3(cameraFollowPoint.localPosition.x, cameraFollowPoint.localPosition.y, camFirstPoint.z - offset * moveDistance), acceleretion * Time.deltaTime);
            yield return null;
        }
    }

    IEnumerator smoothStop()
    {
        float counter = _characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel] * Globals.extraSpeedSkins * Globals.extraSpeed;
        if (Vector2.Distance(secondPressPos, firstPressPos) == 0f)
        {
            counter = 0f;
        }

        Vector3 tempDirection = transform.forward;
        while (counter > 0 && !pressJoystick)
        {
            counter -= character_Settings._SmoothStop * Time.deltaTime;
            if (counter < 0)
            {
                counter = 0f;
            }
            transform.parent.transform.Translate(tempDirection * Time.deltaTime * counter);
            if (pressJoystick)
            {
                break;
            }
            yield return null;
        }
        animator.speed = 1;
    }
    public void playerMovingDirection(float RotY)
    {
        animator.speed = 0.75f + 0.02f * Globals.characterSpeedLevel;
        if (animator != null)
        {
            animator.SetBool("walk", true);

            animator.SetFloat("x", Mathf.Cos((transform.localEulerAngles.y - RotY + 90) * Mathf.Deg2Rad));
            animator.SetFloat("y", Mathf.Sin((transform.localEulerAngles.y - RotY + 90) * Mathf.Deg2Rad));
        }
    }
    public void playerStop()
    {
        animator.SetBool("walk", false);
        float firstAngleX = Mathf.Cos((transform.localEulerAngles.y + 90) * Mathf.Deg2Rad);
        float firstAngleY = Mathf.Sin((transform.localEulerAngles.y + 90) * Mathf.Deg2Rad);
        LeanTween.value(firstAngleX, 0, 2 * (_characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel] * Globals.extraSpeedSkins * Globals.extraSpeed) / (character_Settings._SmoothStop)).setOnUpdate((float val) =>
        {
            if (animator != null)
                animator.SetFloat("x", val);
        });
        LeanTween.value(firstAngleY, 0, 2 * (_characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel] * Globals.extraSpeedSkins * Globals.extraSpeed) / (character_Settings._SmoothStop)).setOnUpdate((float val) =>
        {
            if (animator != null)
                animator.SetFloat("y", val);
        });
    }
    public void CharacterScaling()
    {
        StartCoroutine(Scaling());
    }
    IEnumerator Scaling()
    {
        float counter = 0f;
        float value = 0f;
        float scaleSpeed = 5f;
        float scaleFactor = 0.2f;
        while (counter < Mathf.PI)
        {
            counter += scaleSpeed * Time.deltaTime;
            value = Mathf.Sin(counter);
            transform.localScale = Vector3.one + value * Vector3.one * scaleFactor;
            yield return null;
        }
        transform.localScale = Vector3.one;
    }
    public void UpgradeTextSpawn(string upgradeName)
    {
        Text3D pnt = Instantiate(pointText, transform.position + new Vector3(0, 2, 0), Quaternion.identity).GetComponent<Text3D>();
        pnt.PointInit(upgradeName);
        GameObject confetti = Instantiate(confettiParticles, transform.position + new Vector3(0, 2, 0), Quaternion.identity);
        Destroy(confetti, 5f);
    }
    //public void JumpToHoleCenter(Transform holeTR)
    //{
    //    _stackCollect.DisperseCollected();
    //    StartCoroutine(SetRot(holeTR));
    //}
    IEnumerator SetRot(Transform holeTR)
    {
        Vector3 _direction = holeTR.position - transform.position;
        _direction.y = transform.position.y;

        Quaternion firstRot = transform.rotation;
        Quaternion targetRot = Quaternion.LookRotation(_direction);

        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            transform.rotation = Quaternion.Lerp(firstRot, Quaternion.Euler(transform.eulerAngles.x, targetRot.eulerAngles.y, transform.eulerAngles.z), counter);
            yield return null;
        }
        transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRot.eulerAngles.y, transform.eulerAngles.z);
        StartCoroutine(MoveCenter(holeTR));

    }
    IEnumerator MoveCenter(Transform holeTR)
    {
        animator.SetBool("jump", true);
        Vector3 firstPos = transform.parent.position;
        Vector3 targetPos = holeTR.position;
        targetPos.y = firstPos.y;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 1 * Time.deltaTime;
            transform.parent.position = Vector3.Lerp(firstPos, targetPos, counter);
            yield return null;
        }
        yield return new WaitForSeconds(4f);
        animator.SetBool("jump", false);
    }




    public NavMeshAgent navMeshAgent;

    public bool characterStayActive = false;
    public bool isStayHoldActive = false;
    public bool followActive = false;
    public Transform ceoPos;
    public void PlayerRotReset()
    {
        StartCoroutine(RotReset());
    }
    IEnumerator RotReset()
    {
        Quaternion firstRot = transform.localRotation;
        Quaternion targetRot = Quaternion.Euler(0, 0, 0);
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            transform.localRotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
    }
    IEnumerator RotSetTarget(Transform targetTR)
    {
        navMeshAgent.enabled = false;
        float rotDelta = transform.parent.eulerAngles.y;

        //Quaternion firstRotParent = transform.parent.rotation;
        Quaternion firstLocalRot = transform.localRotation;
        Quaternion firstRot = transform.rotation;

        transform.localRotation = Quaternion.Euler(0, firstLocalRot.eulerAngles.y - rotDelta, 0);
        transform.parent.rotation = Quaternion.Euler(0, 0, 0);
        //Quaternion targetRotParent = Quaternion.Euler(0, 0, 0);

        Quaternion targetRot = Quaternion.Euler(0, targetTR.eulerAngles.y, 0);

        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            //transform.parent.rotation = Quaternion.Lerp(firstRotParent, targetRotParent, counter);
            transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        navMeshAgent.enabled = true;

        //transform.parent.rotation = targetRotParent;
        //transform.rotation = targetRot;
    }
    IEnumerator RotReset2()
    {
        float rotDelta = transform.parent.eulerAngles.y;
        Quaternion firstRotParent = transform.parent.rotation;
        Quaternion targetRotParent = Quaternion.Euler(0, firstRotParent.eulerAngles.y - rotDelta, 0);

        Quaternion firstRot = transform.localRotation;
        Quaternion targetRot = Quaternion.Euler(0, firstRot.eulerAngles.y + rotDelta, 0);

        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            transform.parent.rotation = Quaternion.Lerp(firstRotParent, targetRotParent, counter);
            transform.localRotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }

        transform.localRotation = targetRot;

    }
    public NewLevelBoss newLevelBoss;
    public void FollowShareCeo()
    {
        PlayerCamZoomIn.Priority = 0;
        isStayHoldActive = false;
        followActive = true;
        OnUpdate = null;
        GoToCeo_Update = null;
        GoToCeo_Update += GoToShareCeo;
    }
    void GoToShareCeo()
    {
        _stackCollect.RemoveAll();
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(ShareCeo.Instance.playerTargetPosTR.position.x, ShareCeo.Instance.playerTargetPosTR.position.z)) > 0.25f)
        {
            if (OnUpdate != null)
            {
                OnUpdate = null;
            }
            characterStayActive = false;

            Vector3 targetPos = new Vector3(ShareCeo.Instance.playerTargetPosTR.position.x, transform.position.y, ShareCeo.Instance.playerTargetPosTR.position.z);
            animator.SetBool("walk", true);


            navMeshAgent.SetDestination(targetPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            animator.SetBool("walk", false);
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                navMeshAgent.ResetPath();
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                GoToCeo_Update = null;

                StartCoroutine(RotSetTarget(ShareCeo.Instance.playerTargetPosTR));
                ShareCeo.Instance.CharacterArrivedCeo();
                //OnUpdate = null;
                //PlayerRotReset();
                PlayerControl_ReActive();
                Globals.goToCeoActive = false;
            }
        }
    }
    public void FollowCeo()
    {
        //PlayerCamZoomIn.LookAt = null;
        PlayerCamZoomIn.Priority = 0;
        isStayHoldActive = false;
        followActive = true;
        OnUpdate = null;
        GoToCeo_Update = null;
        GoToCeo_Update += GoToCeoStand;

    }
    void GoToCeoStand()
    {
        _stackCollect.RemoveAll();
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(newLevelBoss.playerTargetPosTR.position.x, newLevelBoss.playerTargetPosTR.position.z)) > 0.25f)
        {
            if (OnUpdate != null)
            {
                OnUpdate = null;
            }
            characterStayActive = false;

            Vector3 targetPos = new Vector3(newLevelBoss.playerTargetPosTR.position.x, transform.position.y, newLevelBoss.playerTargetPosTR.position.z);
            animator.SetBool("walk", true);


            navMeshAgent.SetDestination(targetPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            animator.SetBool("walk", false);
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                navMeshAgent.ResetPath();
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                GoToCeo_Update = null;

                StartCoroutine(RotSetTarget(newLevelBoss.playerTargetPosTR));
                BossTutorialPanel.Instance.newLevelBoss.CharacterArrivedBoss();
                //OnUpdate = null;
                //PlayerRotReset();
                //PlayerControl_ReActive();
                Globals.goToCeoActive = false;
            }
        }
    }
    public void YesSir()
    {
        PlayerCamZoomIn.Priority = 0;
        PlayerControl_ReActive();
        navMeshAgent.ResetPath();
    }
    public void CapacityUp()
    {
        SkinnedMeshRenderer skin = null;
        foreach (var skn in GetComponentsInChildren<SkinnedMeshRenderer>())
        {
            skin = skn;
        }
        if (skin != null && _player.blendShapeActive)
        {
            BlendScale(skin, 0f, 150f, 1f, Ease.InElastic);
        }
    }

    public void CapacityReset()
    {
        SkinnedMeshRenderer skin = null;
        foreach (var skn in GetComponentsInChildren<SkinnedMeshRenderer>())
        {
            skin = skn;
        }
        if (skin != null && _player.blendShapeActive)
        {
            BlendScale(skin, 150f, 0f, 1f, Ease.InElastic);
        }
    }
    public Tween BlendScale(SkinnedMeshRenderer skin, float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                skin.SetBlendShapeWeight(0, value);
            }).OnComplete(delegate ()
            {
            });
        return tween;
    }
    public MoneyPoint moneyPrefab;
    public Transform moneyTextCreateTR;
    public void CreateMoneyText(int mnyCount)
    {
        MoneyPoint mny = Instantiate(moneyPrefab, moneyTextCreateTR.position, moneyTextCreateTR.rotation, moneyTextCreateTR).GetComponent<MoneyPoint>();
        mny.PointInit(mnyCount);
    }


    public void FollowVipCustomer()
    {
        PlayerCamZoomInVip.LookAt = null;
        PlayerCamZoomInVip.Priority = 10;
        isStayHoldActive = false;
        followActive = true;
        OnUpdate = null;
        OnUpdate += GoToVipNear;

    }

    void GoToVipNear()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(MarketCustomerManager.Instance.currentVipCustomer.playerFollowPosTR.position.x, MarketCustomerManager.Instance.currentVipCustomer.playerFollowPosTR.position.z)) > 0.25f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(MarketCustomerManager.Instance.currentVipCustomer.playerFollowPosTR.position.x, transform.position.y, MarketCustomerManager.Instance.currentVipCustomer.playerFollowPosTR.position.z);
            animator.SetBool("walk", true);


            navMeshAgent.SetDestination(targetPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            animator.SetBool("walk", false);
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                navMeshAgent.ResetPath();
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                OnUpdate = null;
                StartCoroutine(VipAfterDelay());
                //OnUpdate = null;
                //PlayerRotReset();
            }
        }
    }

    IEnumerator VipAfterDelay()
    {
        Debug.Log("viptutorial" + PlayerPrefs.GetInt("viptutorial"));
        if (PlayerPrefs.GetInt("viptutorial") == 0)
        {
            PlayerPrefs.SetInt("viptutorial", 1);
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(RotReset2());
        yield return new WaitForSeconds(1f);
        //MarketCustomerManager.Instance.currentVipCustomer.vipStackActive = true;
        PlayerControl_ReActive();
        PlayerCamZoomInVip.Priority = 0;
        //IndicatorManager.Instance.IndicaorActive(MarketCustomerManager.Instance.phoneMachine._CollectProducts.transform);

    }

    public void CharacterRepairPosSet(Transform repairPosTR)
    {
        StartCoroutine(RepairPosSet(repairPosTR));
    }
    IEnumerator RepairPosSet(Transform repairPosTR)
    {
        Vector3 firstPos = transform.parent.position;
        Quaternion firstRot = transform.rotation;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            transform.parent.position = Vector3.Lerp(firstPos, repairPosTR.position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, repairPosTR.rotation, counter);
            yield return null;
        }
        transform.parent.position = repairPosTR.position;
        transform.rotation = repairPosTR.rotation;
    }

    public void TrainActive()
    {
        Globals.trainActive = true;
        locomotiveGO.SetActive(true);
        OpenVagons();
        _stackCollect.stackLevel = 1;
        _stackCollect.CollectedListReset();

        characterSkinParent.localPosition = characterLocomotivePos;
        animator.SetBool("sitting", true);
        magnet.MagnetLevelUp(1);
        modelParentGO.SetActive(false);
        NoneVehicle();
        GetComponent<CapsuleCollider>().radius = 1;
    }
    public void OpenVagons()
    {
        int vagonCount = MRCUpgradeManager.Instance._characterUpgradeSettings.trainWagonCount[Globals.trainWagonLevel];
        if (Globals.trainActive)
        {
            for(int i = 0; i < vagonCount; i++)
            {
                vagons[i].SetActive(true);
            }
        }
        TrainManager.Instance.train.OpenVagons();
    }
    public void CloseTrain()
    {

        Globals.trainActive = false;
        locomotiveGO.SetActive(false);
        _stackCollect.CollectionsNullParent();
        for (int i = 0; i < vagons.Count; i++)
        {
            vagons[i].SetActive(false);
            vagons[i].transform.parent = transform.parent;
        }
        _stackCollect.stackLevel = 0;
        _stackCollect.CollectedListReset();
        characterSkinParent.localPosition = Vector3.zero;

        animator.SetBool("sitting", false);
        magnet.MagnetLevelUp(0);
        modelParentGO.SetActive(true);
        GetComponent<CapsuleCollider>().radius = 0.5f;

        if (PlayerPrefs.GetInt("purchasespeedboost") == 1)
        {
            BandBoardActive();
        }

        if (Globals.hoverboardActive)
        {
            int rewardSelect = PlayerPrefs.GetInt("speedskil") % 3;

            if (rewardSelect == 0)
            {
                BandBoardActive();
            }
            else if (rewardSelect == 1)
            {
                SkateBoardActive();
            }
            else
            {
                HoverBoardActive();
            }
        }
    }
}
