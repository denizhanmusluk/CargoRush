using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vagon : MonoBehaviour
{
    public Transform targetFollowTR;
    public Transform jointTR;
    [SerializeField] float jointDistance = 0.1f;
    public float moveSpeed = 5f;
    public float acceleration = 1f;
    public float angleBounding = 60f;
    public float rotateSpeed = 5f;
    [SerializeField] CharacterUpgradeSettings characterUpgradeSettings;

    [SerializeField] StackCollect stackCollect;
    [SerializeField] List<Transform> stack_PosList;

    void Start()
    {
        stackCollect = PlayerController.Instance._stackCollect;
        characterUpgradeSettings = LevelManager.Instance._currnetCharacterUpgradeSettings;
        foreach(var stckPos in stack_PosList)
        {
            stackCollect.stackLevel_2_PosList.Add(stckPos);
        }
        stackCollect.stackLevel = 1;
        //StartCoroutine(StartDelay());
    }
    private void OnEnable()
    {
        transform.parent = null;
        transform.rotation = targetFollowTR.rotation;
        transform.position = targetFollowTR.position - targetFollowTR.forward * 3.25f;
    }

    //IEnumerator StartDelay()
    //{
    //    yield return new WaitForSeconds(5f);
    //    ConfigurableJoint joint = GetComponent<ConfigurableJoint>();

    //    JointDrive positionDrive = new JointDrive
    //    {
    //        positionSpring = 500,
    //        positionDamper = 500,
    //        maximumForce = 5000
    //    };

    //    joint.zDrive = positionDrive;
    //}
    private void Update()
    {
        FollowingTranslate();
        RotateVagon();
    }
    void FollowingTranslate()
    {
        float accelFactor = (characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel] * characterUpgradeSettings.trainSpeedFactor) / (characterUpgradeSettings.characterSpeed[0] * characterUpgradeSettings.trainSpeedFactor);

        float _jointDistance = Vector3.Distance(jointTR.position, targetFollowTR.position);
        float vagonDistance = Vector3.Distance(transform.position, targetFollowTR.position);
        float vagonDistance2 = Vector3.Distance(transform.position, jointTR.position);

        float distanceSpeedFactor = vagonDistance * acceleration * accelFactor;

        //if (_jointDistance > jointDistance)
        {
            if (vagonDistance > _jointDistance && vagonDistance > vagonDistance2)
            {
                transform.position = Vector3.Lerp(transform.position, targetFollowTR.position, (distanceSpeedFactor + moveSpeed) * Time.deltaTime);
            }

         
        }
    }
    void RotateVagon()
    {
        if(Mathf.Abs( transform.eulerAngles.y - targetFollowTR.eulerAngles.y) > angleBounding)
        {
            float andleDif = YAciFarkiniHesapla(transform, targetFollowTR);

            int rotAxis = -1;
            if (andleDif > 0)
            {
                rotAxis = 1;
            }
                //transform.rotation = Quaternion.Lerp(transform.rotation, targetFollowTR.rotation, rotateSpeed * Time.deltaTime);
                transform.RotateAround(targetFollowTR.position, rotAxis * Vector3.up, rotateSpeed * Time.deltaTime);

        }
        Vector3 direction = targetFollowTR.position - transform.position;

        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }
    float YAciFarkiniHesapla(Transform a, Transform b)
    {
        // Obje A ve Obje B'nin Y eksenindeki rotasyon açýsýný al
        float aciA = a.eulerAngles.y;
        float aciB = b.eulerAngles.y;

        // Açý farkýný hesapla
        float aciFarki = aciB - aciA;

        // Açý farkýný -180 ile 180 arasýnda tutarak iþareti dikkate al
        if (aciFarki > 180) aciFarki -= 360;
        if (aciFarki < -180) aciFarki += 360;

        return aciFarki;
    }
}
