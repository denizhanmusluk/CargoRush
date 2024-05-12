using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using Dreamteck.Splines;
using UnityStandardAssets.Vehicles.Car;
using DG.Tweening;
public class CarManager : MonoBehaviour
{
    private static CarManager _instance = null;
    public static CarManager Instance => _instance;
    [SerializeField] GameObject characterGO;
    [SerializeField] Sprite carLogo;
    public SplineFollower spline;
    [SerializeField] Transform carChild;
    [SerializeField] AICar aiCar;
    [SerializeField] Vector2[] gearSpeed_During;
    public Transform partCreatePointTR;
    [SerializeField] GameObject[] carPartsArr;
    public bool[] envBoolList;
    public int[] envListCounter;

    List<GameObject> collectedEnvList = new List<GameObject>();
    [SerializeField] CinemachineVirtualCamera carRunnerCamera, carMergeCameraDown, carMergeCameraUp;
    [SerializeField]
    CinemachineVirtualCamera finalCamera1, finalCamera2;
    [SerializeField] float currentSpeed;
    bool raceActive = true;
    int totalEnvCount = 0;
    int collectedEnvCount = 0;
    float completeRatio = 0f;
    int gearLevel;
    float maxSpeed;
    [SerializeField] float speedRatio;
    TextMeshProUGUI speedText, gearText;
    [SerializeField] int wheelCount = 0;

    [SerializeField] Wheel FL, FR, BL, BR;
    [SerializeField] GameObject FL_spark, FR_spark, BL_spark, BR_spark;
    [SerializeField] GameObject fireRight, fireLeft;
    [SerializeField] Wheel[] allWheels;
    [SerializeField] GameObject carCrashSmokeGO;
    [SerializeField] SplineFollower finishLine;
    [SerializeField] SplineFollower startLine;

    [SerializeField] WheelEffects[] wheelsEffects;



    CollectProgressManager _collectProgressManager;
    [SerializeField] ParticleSystem confetti, finishConfetti;
    [SerializeField] ParticleSystem wind;
    public GameObject point;
    bool shiftActive = false;
    List<Wheel> frontWheelAll = new List<Wheel>();
    public Tween RunnerCameraFovSet(float value, float lastValue, float duration, DG.Tweening.Ease type)
    {
       
        Tween tween = DOTween.To
            (() => value, x => value = x, lastValue, duration).SetEase(type).OnUpdate(delegate ()
            {
                carRunnerCamera.m_Lens.FieldOfView = value;
            }).OnComplete(delegate ()
            {

            });
        return tween;
    }
    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        finishLine.spline = spline.spline;
        startLine.spline = spline.spline;
        Init();
        AllPartsPosSet();
        _collectProgressManager = CollectProgressManager.Instance;
        CollectProgressManager.Instance.carLogo.sprite = carLogo;
    }
    void AllPartsPosSet()
    {
        for (int i = 0; i < carPartsArr.Length; i++)
        {
            carPartsArr[i].GetComponent<Part>().targetPos = carPartsArr[i].transform.position;
            carPartsArr[i].GetComponent<Part>().targetRot = carPartsArr[i].transform.rotation;
            carPartsArr[i].GetComponent<Part>().firstPos = partCreatePointTR.position;
        }
    }
    void Init()
    {

        spline.followSpeed = 0;
        maxSpeed = gearSpeed_During[gearSpeed_During.Length - 1].x;
        //carCam = CameraManager.Instance.vCamPlayer;
        //carCam.Follow = transform;
        //carCam.LookAt = transform;
    }

    private void Update()
    {
        Tachometer.Instance.speedPlayerTextTemp.text = "Player Speed  :  " + ((int)currentSpeed).ToString();
        Tachometer.Instance.speedAITextTemp.text = "AI Speed  :  " + ((int)aiCar.currentSpeed).ToString();
    }
    public void EnvCollect(int envId, int collectCount, Environments env)
    {
        envListCounter[envId]++;
        if (envListCounter[envId] >= collectCount)
        {
            envBoolList[envId] = true;
            collectedEnvList.Add(carPartsArr[envId]);
            if (env.GetComponent<Wheel>() != null)
            {
                //wheelCount++;
            }
        }
    }
    public void CarOpenParts()
    {
        CompleteRatioCheck();
        StartCoroutine(CameraSet());
        StartCoroutine(CarOpenDelay());
    }
    IEnumerator CameraSet()
    {
        Fade.Instance.Show();

        //_fade.Hide();
        //var a = Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time;
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 0;
        carMergeCameraDown.Priority = 10;
        yield return new WaitForSeconds(1f);
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 4;
        carMergeCameraDown.Priority = 0;
        carMergeCameraUp.Priority = 10;

    }
    void CompleteRatioCheck()
    {
        totalEnvCount = envBoolList.Length;
        for (int i = 0; i < envBoolList.Length; i++)
        {
            if (envBoolList[i])
            {
                collectedEnvCount++;
            }
        }
        completeRatio = (float)collectedEnvCount / (float)totalEnvCount;
        if (completeRatio < 0.85f)
        {
            speedRatio = maxSpeed * completeRatio;
        }
        else
        {
            speedRatio = maxSpeed * 2;
        }
    }
    //IEnumerator CarOpenDelay()
    //{
    //    yield return new WaitForSeconds(1f);


    //    int t = 0;
    //    for (int i = 0; i < carPartsArr.Length; i++)
    //    {
    //        if (envBoolList[i])
    //        {
    //            carPartsArr[i].SetActive(true);
    //            carPartsArr[i].GetComponent<Part>().MoveObj();

    //            float deltaTime = Time.deltaTime;
    //            float frameCount = 3f / deltaTime;
    //            float x = collectedEnvCount / frameCount;
    //            if (x < 1)
    //            {
    //                x = 1;
    //            }
    //            if (t % (int)x == 0)
    //            {
    //                yield return new WaitForSeconds(deltaTime);
    //            }
    //            t++;
    //        }
    //    }
    //    yield return new WaitForSeconds(1f);
    //    GameManager.Instance.ui.runnerStarter.SetActive(true);

    //    Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 1;

    //    carRunnerCamera.Priority = 20;
    //}
    IEnumerator CarOpenDelay()
    {
        yield return new WaitForSeconds(1f);
        CollectProgressManager.Instance.carRatioPanel.SetActive(true);

        int countPerFrame = 1 + collectedEnvCount / 60;
        int t = 0;
        int partCount = 0;
        for (int i = 0; i < carPartsArr.Length; i++)
        {
            if (envBoolList[i])
            {
                partCount++;
                carPartsArr[i].SetActive(true);
                carPartsArr[i].GetComponent<Part>().MoveObj(point);
                //CollectProgressManager.Instance.CarRatioTextInit(partCount);
                
                if (t % countPerFrame == 0)
                {
                    yield return null;
                }
                t++;
            }
        }
        characterGO.GetComponent<Animator>().SetTrigger("jumptocar");
        yield return new WaitForSeconds(1f);
        confetti.Play();
        //CollectProgressManager.Instance.Car_RatioClose();
        yield return new WaitForSeconds(1f);
        GameManager.Instance.ui.runnerStarter.SetActive(true);

        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 1;

        carRunnerCamera.Priority = 20;

        foreach(var whl in allWheels)
        {
            if (whl.frontWheel)
            {
                frontWheelAll.Add(whl);
            }
        }
    }
    void WheelSparkleOpen()
    {
        if (FL.gameObject.activeInHierarchy)
        {
            wheelCount++;
        }
        else
        {
            FL_spark.SetActive(true);

        }

        if (FR.gameObject.activeInHierarchy)
        {
            wheelCount++;
        }
        else
        {
            FR_spark.SetActive(true);


        }

        if (BL.gameObject.activeInHierarchy)
        {
            wheelCount++;
        }
        else
        {
            BL_spark.SetActive(true);

        }

        if (BR.gameObject.activeInHierarchy)
        {
            wheelCount++;
        }
        else
        {
            BR_spark.SetActive(true);

        }
    }
    void WheelSparkleClose()
    {
        FL_spark.SetActive(false);
        FR_spark.SetActive(false);
        BL_spark.SetActive(false);
        BR_spark.SetActive(false);
        fireLeft.SetActive(false);
    }
    void TyreSmoke()
    {
        foreach (WheelEffects whl_effects in wheelsEffects)
        {
            if (whl_effects.gameObject.activeInHierarchy)
            {
                whl_effects.EmitTyreSmoke();
            }
        }
    }
    void TyreSkidFull()
    {
        foreach (WheelEffects whl_effects in wheelsEffects)
        {
            if (whl_effects.gameObject.activeInHierarchy)
            {
                whl_effects.EmitTyreSkidFull();
            }
        }
    }
    void TyreSkidFull_End()
    {
        foreach (WheelEffects whl_effects in wheelsEffects)
        {
            if (whl_effects.gameObject.activeInHierarchy)
            {
                whl_effects.skiddingFull = false;
            }
        }
    }
    void TyreSkid()
    {
        foreach (WheelEffects whl_effects in wheelsEffects)
        {
            if (whl_effects.gameObject.activeInHierarchy)
            {
                whl_effects.EmitTyreSkid();
            }
        }
    }
    void EndTyreSkid()
    {
        foreach (WheelEffects whl_effects in wheelsEffects)
        {
            if (whl_effects.gameObject.activeInHierarchy)
            {
                whl_effects.EndSkidTrail();
            }
        }
    }
    IEnumerator Patinate()
    {
        if (BL.gameObject.activeInHierarchy)
        {
            fireLeft.SetActive(true);
        }
        if (BR.gameObject.activeInHierarchy)
        {
            fireRight.SetActive(true);
        }


        TyreSmoke();
         Quaternion firstRot = carChild.localRotation;
        float firstRotYWheel = -90f;
        foreach (var whl in frontWheelAll)
        {
            firstRotYWheel = whl.transform.localEulerAngles.y;
        }

            float firstRotY = carChild.localEulerAngles.y;
        float counter = 0f;
        float angle = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            angle = 10 * Mathf.Sin(counter * 5);

            carChild.localRotation = Quaternion.Euler(carChild.localEulerAngles.x, firstRotY + angle, carChild.localEulerAngles.z);
            foreach(var whl in frontWheelAll)
            {
                whl.transform.localRotation = Quaternion.Euler(whl.transform.localEulerAngles.x, firstRotYWheel - angle * 3, whl.transform.localEulerAngles.z);

            }
            TyreSkid();
            yield return null;
        }

        EndTyreSkid();

        counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            value = Mathf.Lerp(angle, 0, counter);
            carChild.localRotation = Quaternion.Euler(carChild.localEulerAngles.x, firstRotY + value, carChild.localEulerAngles.z);
            foreach (var whl in frontWheelAll)
            {
                whl.transform.localRotation = Quaternion.Euler(whl.transform.localEulerAngles.x, firstRotYWheel - value, whl.transform.localEulerAngles.z);

            }
            TyreSkid();
            yield return null;
        }
        EndTyreSkid();
        if (BL.gameObject.activeInHierarchy)
        {
            fireLeft.transform.parent = null;
        }
        if (BR.gameObject.activeInHierarchy)
        {
            fireRight.transform.parent = null;
        }
    }
    public void RaceStart()
    {
        Tachometer.Instance.Counter();
    }
    public void StartGo()
    {
        WheelSparkleOpen();

        if (wheelCount == 0)
        {
            HardFail();
            return;
        }
        StartCoroutine(Patinate());
        TyreSkidFull();
        //GameManager.Instance.ui.tachometerPanelGO.SetActive(true);
        Tachometer.Instance.tachoMeterPanel.SetActive(true);
        speedText = Tachometer.Instance.speedText;
        gearText = Tachometer.Instance.gearText;

        gearLevel = 0;
        gearText.text = (gearLevel + 1).ToString();
        speedText.text = "0 km/h";
        StartCoroutine(Accelerate());
        aiCar.StartRace();
    }
    public void IncreaseGear()
    {
        Tachometer.Instance.ShiftText(currnetNeedleRot);
        shiftPress = true;
        //StopCoroutine(Accelerate());
        gearLevel++;
        gearText.text = (gearLevel + 1).ToString();
        StartCoroutine(StopAngle(2f, 3f));
        RunnerCameraFovSet(60, 56, 1f, Ease.OutElastic);
        StartCoroutine(Accelerate());
        GameManager.Instance.ui.gearShiftTapGO.SetActive(false);
        if(gearLevel == 2)
        {
            wind.Play();
        }
    }
    bool shiftPress = false;
    //IEnumerator EngineGear()
    //{

    //}
    IEnumerator NeedleDown()
    {
        TyreSmoke();
        needleRotActive = false;
        Transform _needle = Tachometer.Instance.needle;
        float currnetAngle = _needle.eulerAngles.z;
        float minAngle = Tachometer.Instance.minAngle;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 5 * Time.deltaTime;
            float _currnetNeedleRot = Mathf.Lerp(currnetAngle, currnetNeedleRot, counter);
            _needle.rotation = Quaternion.Euler(0, 180, _currnetNeedleRot);
            TyreSkid();
            yield return null;
        }
        EndTyreSkid();
        needleRotActive = true;
    }
    float currnetNeedleRot = 0;
    bool needleRotActive = true;
    IEnumerator Accelerate()
    {
        yield return null;
        shiftActive = true;
        Transform _needle = Tachometer.Instance.needle;
        float minAngle, maxAngle, lastAngle;
        float perfectShiftAngle = Tachometer.Instance.perfectShiftAngle;
        minAngle = Tachometer.Instance.minAngle;
        maxAngle = Tachometer.Instance.maxAngle;
        lastAngle = Tachometer.Instance.lastAngle;

        float firstSpeed = currentSpeed;
        if (gearLevel > 0)
        {
            StartCoroutine(NeedleDown());
            //firstSpeed = gearSpeed_During[gearLevel - 1].x;
        }
        float counter = 0f;
        while (counter < 1f && raceActive && !shiftPress)
        {
            counter += Time.deltaTime / gearSpeed_During[gearLevel].y;
            currentSpeed = Mathf.Lerp(firstSpeed, gearSpeed_During[gearLevel].x, counter);
            spline.followSpeed = currentSpeed;
            foreach (Wheel whl in allWheels)
            {
                whl.rotateSpeed = currentSpeed;
            }
            speedText.text = ((int)(currentSpeed * 2.5f)).ToString() + " km/h";
            currnetNeedleRot = Mathf.Lerp(minAngle, maxAngle, counter);
            if (needleRotActive)
            {
                _needle.rotation = Quaternion.Euler(0, 180, currnetNeedleRot);
            }
            float maxRange = (float)spline.GetPercent() * (maxSpeed / currentSpeed);
            if(currentSpeed < 1f)
            {
                maxRange = 1;
            }
            //_collectProgressManager.PlayerProgressSet((float)spline.GetPercent(), maxRange);
            //_collectProgressManager.AIProgressSet((float)aiCar.spline.GetPercent(), maxRange);
            if (raceActive && shiftActive && perfectShiftAngle < currnetNeedleRot && gearLevel < 4)
            {
                shiftActive = false;
                OpenGearShiftCanvas();
                Tachometer.Instance.GreenBGAnimationStart();
            }
            CheckWin();
            yield return null;
        }


        if (!shiftActive)
        {
            counter = 0f;
            while (counter < 1f && raceActive && needleRotActive && !shiftPress)
            {
                counter += 1.25f * Time.deltaTime / gearSpeed_During[gearLevel].y;
                if (needleRotActive)
                {
                    currnetNeedleRot = Mathf.Lerp(maxAngle, lastAngle, counter);
                    _needle.rotation = Quaternion.Euler(0, 180, currnetNeedleRot);
                }
                float maxRange = (float)spline.GetPercent() * (maxSpeed / currentSpeed);
                if (currentSpeed < 1f)
                {
                    maxRange = 1;
                }
                //_collectProgressManager.PlayerProgressSet((float)spline.GetPercent(), maxRange);
                //_collectProgressManager.AIProgressSet((float)aiCar.spline.GetPercent(), maxRange);

                yield return null;
            }
            if (currnetNeedleRot >= lastAngle)
            {
                Fail();
            }
        }
        shiftPress = false;
    }
    public void OpenGearShiftCanvas()
    {
        GameManager.Instance.ui.gearShiftTapGO.SetActive(true);
    }
    void CheckWin()
    {
        if (currentSpeed >= maxSpeed)
        {
            raceActive = false;
            Win();
        }
        if (currentSpeed > speedRatio)
        {
            raceActive = false;
            Fail();
        }
    }
    void Win()
    {

        CollectProgressManager.Instance.raceProgressGO.SetActive(false);

        CollectProgressManager.Instance.raceActive = false;
        Vector3 finishLineTargetPos = transform.forward * 20;
        finishLine.SetPercent(spline.GetPercent() + 0.02f);
        WheelSparkleClose();
        
        if (spline.GetPercent() > aiCar.spline.GetPercent())
        {
            aiCar.StopCar();
         
            GameManager.Instance.ui.NextLevel();
            StartCoroutine(WinSmoothStop(1));
        }
        else
        {
            if (aiCar.spline.GetPercent() - spline.GetPercent() < 0.01f)
            {
                aiCar.SmoothStop();
            }
            else
            {
                aiCar.StopCar();
                aiCar.spline.SetPercent(spline.GetPercent() + 0.025f);
            }

            GameManager.Instance.ui.Fail();
            StartCoroutine(WinSmoothStop(2));
        }

    }
    IEnumerator StopAngle(float rotateSpeed, float rotateAngle)
    {
        float firstRotY = carChild.localEulerAngles.x;
        float angle = 0;
        float counter = 0;
        while (counter < 1f)
        {
            counter += rotateSpeed * Time.deltaTime;
            angle = rotateAngle * Mathf.Sin(counter * Mathf.PI);

            carChild.localRotation = Quaternion.Euler(firstRotY - angle, carChild.localEulerAngles.y, carChild.localEulerAngles.z);

            yield return null;
        }
        carChild.localRotation = Quaternion.Euler(firstRotY, carChild.localEulerAngles.y, carChild.localEulerAngles.z);

    }
    IEnumerator WinSmoothStop(int arr)
    {
        wind.Stop();
        if (arr == 1)
        {
            Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 1;
            carRunnerCamera.Priority = 0;
            finalCamera1.Priority = 10;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine(PatinateStop());
        StartCoroutine(StopAngle(2f, 5f));
        TyreSmoke();

        float firstSpd = currentSpeed;

        Transform _needle = Tachometer.Instance.needle;
        float currnetAngle = _needle.eulerAngles.z;
        float counter = 0;
        while (counter < 1f)
        {
            counter += 0.7f * Time.deltaTime;
            float _currnetNeedleRot = Mathf.Lerp(currnetAngle, currnetNeedleRot, counter);
            _needle.rotation = Quaternion.Euler(0, 180, _currnetNeedleRot);
            currentSpeed = Mathf.Lerp(firstSpd, 0, counter);
            spline.followSpeed = currentSpeed;
            foreach (Wheel whl in allWheels)
            {
                whl.rotateSpeed = currentSpeed;
            }
            TyreSkid();

            yield return null;
        }

        if (arr == 1)
        {
            Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend.m_Time = 5;

            carRunnerCamera.Priority = 0;
            finalCamera1.Priority = 0;
            finalCamera2.Priority = 10;
            characterGO.GetComponent<Animator>().SetTrigger("getout");
            finishConfetti.Play();
        }
        yield return new WaitForSeconds(3f);
        LevelEndPanel.Instance.LevelEndPanelOpen(arr, completeRatio);

        //DnzEvents.TyreSmokeEvent();

    }
    IEnumerator PatinateStop()
    {
        float firstRotYWheel = -90f;
        foreach (var whl in frontWheelAll)
        {
            firstRotYWheel = whl.transform.localEulerAngles.y;
        }

        float firstRotY = carChild.localEulerAngles.y;
        float counter = 0f;
        float angle = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            angle = 45 * Mathf.Sin(counter * Mathf.PI / 2);

            carChild.localRotation = Quaternion.Euler(carChild.localEulerAngles.x, firstRotY + angle, carChild.localEulerAngles.z);
            foreach (var whl in frontWheelAll)
            {
                whl.transform.localRotation = Quaternion.Euler(whl.transform.localEulerAngles.x, firstRotYWheel - angle, whl.transform.localEulerAngles.z);

            }
            yield return null;
        }

        counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            value = Mathf.Lerp(angle, 0, counter);
            carChild.localRotation = Quaternion.Euler(carChild.localEulerAngles.x, firstRotY + value, carChild.localEulerAngles.z);
            foreach (var whl in frontWheelAll)
            {
                whl.transform.localRotation = Quaternion.Euler(whl.transform.localEulerAngles.x, firstRotYWheel - value, whl.transform.localEulerAngles.z);

            }
            TyreSkid();
            yield return null;
        }
    }

    void HardFail()
    {
        wind.Stop();
        CollectProgressManager.Instance.raceActive = false;
        CollectProgressManager.Instance.raceProgressGO.SetActive(false);
        Tachometer.Instance.GearBGClose();
        TyreSkidFull_End();
        WheelSparkleClose();
        EndTyreSkid();
        raceActive = false;
        GameManager.Instance.ui.Fail();
        StartCoroutine(NeedleFail());
        StartCoroutine(HardExplosion());
        StartCoroutine(CharacterFallDown());
    }
    IEnumerator HardExplosion()
    {
        for (int i = 0; i < collectedEnvList.Count; i++)
        {
            collectedEnvList[i].GetComponent<Collider>().enabled = true;


            collectedEnvList[i].transform.parent = null;
            collectedEnvList[i].GetComponent<Rigidbody>().isKinematic = false;
            collectedEnvList[i].GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1f, 1f), Random.Range(1f, 2f), Random.Range(-1f, 1f)) * 350);
            collectedEnvList[i].GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-2, 1), Random.Range(-2, 1), Random.Range(-2, 1) * 2500));

            yield return null;
        }
        spline.followSpeed = currentSpeed = 0;
        yield return new WaitForSeconds(3f);
        LevelEndPanel.Instance.LevelEndPanelOpen(2, completeRatio);
    }
    void Fail()
    {
        wind.Stop();
        CollectProgressManager.Instance.raceActive = false;
        CollectProgressManager.Instance.raceProgressGO.SetActive(false);
        Tachometer.Instance.GearBGClose();
        TyreSkidFull_End();
        WheelSparkleClose();
        EndTyreSkid();
        raceActive = false;
        GameManager.Instance.ui.Fail();
        StartCoroutine(NeedleFail());
        StartCoroutine(EvnExplosion());
        StartCoroutine(CharacterFallDown());
    }
    IEnumerator CharacterFallDown()
    {
        yield return new WaitForSeconds(0.2f);
        characterGO.transform.parent = null;
        characterGO.GetComponent<Ragdoll>().RagdollActivateWithForce(true, Vector3.up, gearLevel);
    }
    IEnumerator NeedleFail()
    {
        Transform _needle = Tachometer.Instance.needle;
        float currnetAngle = _needle.eulerAngles.z;
        float deltaAngle = 0f;
        float counter = 0f;
        //float firstSpd = currentSpeed;
        while (counter < 2f)
        {
            counter += Time.deltaTime;
            //currentSpeed = Mathf.Lerp(firstSpd, 0, counter / 2f);
            //spline.followSpeed = currentSpeed;
            deltaAngle = 10 * Mathf.Abs(Mathf.Sin(counter * 10));
            float _currnetNeedleRot = currnetAngle + deltaAngle;
            _needle.rotation = Quaternion.Euler(0, 180, _currnetNeedleRot);
            yield return null;
        }
        //spline.followSpeed = currentSpeed = 0;
    }
    IEnumerator EvnExplosion()
    {
        bool colliderSetActive = false;
        if(collectedEnvList.Count > 60)
        {
            colliderSetActive = true;
        }
        int countPerFrame = 1 + collectedEnvCount / 60;
        int t = 0;

        //carCrashSmokeGO.SetActive(true);
        float firstSpd = currentSpeed;
        int enveCount = collectedEnvList.Count;
        int currentCount = 0;
        for (int i = 0; i < collectedEnvList.Count; i++)
        {
            currentCount++;

            if (!colliderSetActive)
            {
                collectedEnvList[i].GetComponent<Collider>().enabled = true;
                collectedEnvList[i].GetComponent<Part>().SetRigidbody(1f);
            }
            else
            {
                if(collectedEnvList.Count - i < 60)
                {
                    collectedEnvList[i].GetComponent<Collider>().enabled = true;
                    collectedEnvList[i].GetComponent<Part>().SetRigidbody(1f);
                }
                else
                {
                    collectedEnvList[i].GetComponent<Part>().SetRigidbody(0.3f);
                }
            }

            collectedEnvList[i].transform.parent = null;
            collectedEnvList[i].GetComponent<Rigidbody>().isKinematic = false;
            collectedEnvList[i].GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-1f, 1f), Random.Range(1f, 2f), Random.Range(-1f, 1f)) * 350);
            collectedEnvList[i].GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-2, 1), Random.Range(-2, 1), Random.Range(-2, 1) * 2500));
            currentSpeed = Mathf.Lerp(firstSpd, 0, (float)currentCount / (float)enveCount);
            carCrashSmokeGO.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, (float)currentCount / (float)enveCount);


            spline.followSpeed = currentSpeed;


            if (t % countPerFrame == 0)
            {
                yield return null;
            }
            t++;
            //yield return new WaitForSeconds(0.01f);
        }
        carCrashSmokeGO.GetComponent<ParticleSystem>().Stop();

        spline.followSpeed = currentSpeed = 0;
        yield return new WaitForSeconds(3f);
        LevelEndPanel.Instance.LevelEndPanelOpen(2, completeRatio);
    }
}