using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
using HomaGames.HomaBelly;

public class VipCustomerSlot : Stand, IMoneyArea
{
    [SerializeField] GameObject canvasProductGO, canvasDeliveringGO;
    [SerializeField] Image imageFill;
    [SerializeField] List<int> cooldownTimeList = new List<int>();
    [SerializeField] float cooldownTime;
    [SerializeField] MoneyArea moneyArea;

    [SerializeField] Transform carCreateTR, carGoTR;
    [SerializeField] List<Transform> carStandPosList;
    [SerializeField] GameObject carPrefab;
    [SerializeField] List<GameObject> carPrefabList = new List<GameObject>();

    GameObject currentCar;
    [SerializeField] string standNameLevel;
    public int[] extraMoney;
    public Vector2[] boxCountTotal;
    //public int[] _fishCountTotal;

    int carLevel = 0;
    [SerializeField] float fishCoun_Factor;

    public int[] productTypeCount;
    [SerializeField] int[] productTypeCountTotal;
    [SerializeField] List<GameObject> productTextGOList;
    [SerializeField] List<TextMeshProUGUI> productTextList;
    public int[] typeCount;
    Vector3 firstColliderOffset;
    public int[] tempIdList;

    public Sprite[] vipImgList;

    public bool specialVehicle = false;
    public Animator goatAnim;
    public AudioSource carSoundAS;

    public CinemachineVirtualCamera vipCarCamera;
    public StandFishTezgah standFishTezgah;



    [SerializeField] int firstVipTime = 900;
    public int firstVipTimeCounter = 0;

    [SerializeField] int vipCyclePeriod = 180;
    public int vipCycleCount = 0;
    [SerializeField] GameObject bonusGO;
    [SerializeField] GameObject obstacleGO;
    void StartCounter()
    {
        if (PlayerPrefs.GetInt("vipactive") == 0)
        {
            if (PlayerPrefs.GetInt("firstVipTimeCompleted") == 0)
            {
                StartCoroutine(FirstVipCounter());
            }
            else
            {
                StartCoroutine(VipCycleCounter());
            }
        }
        else
        {
            CarCreate();
        }
    }
    IEnumerator FirstVipCounter()
    {
        //FishDropArea.Instance.loadingAreaTextGO.SetActive(true);

        firstVipTimeCounter = PlayerPrefs.GetInt("firstVipTimeCounter");

        while (firstVipTimeCounter < firstVipTime)
        {
            firstVipTimeCounter++;
            PlayerPrefs.SetInt("firstVipTimeCounter", firstVipTimeCounter);

            yield return new WaitForSeconds(1);
        }
        PlayerPrefs.SetInt("firstVipTimeCompleted", 1);

        CarCreate();

        {
            //DayCycleRestart();
        }
    }
    IEnumerator VipCycleCounter()
    {

        vipCycleCount = PlayerPrefs.GetInt("vipCycleCount");

        while (vipCycleCount < vipCyclePeriod)
        {
            vipCycleCount++;
            PlayerPrefs.SetInt("vipCycleCount", vipCycleCount);
       
            yield return new WaitForSeconds(1);
        }

        CarCreate();

        {
            //DayCycleRestart();
        }
    }
    void DayCycleRestart()
    {
        vipCycleCount = 0;
        PlayerPrefs.SetInt("vipCycleCount", vipCycleCount);
        PlayerPrefs.SetInt("vipactive", 0);
        StartCoroutine(VipCycleCounter());
    }
    void TextInitCheck()
    {
        for (int i = 0; i < productTypeCount.Length; i++)
        {
            productTextList[i].text = (productTypeCountTotal[i] - productTypeCount[i]).ToString() + "/" + (productTypeCountTotal[i]).ToString();

            if (productTypeCount[i] == 0)
            {
                productTextGOList[i].SetActive(false);
                collectIDList[i] = -1;
            }
            else
            {
                productTextGOList[i].SetActive(true);
                collectIDList[i] = tempIdList[i];
            }
        }
    }
    public void MoneySave()
    {
        PlayerPrefs.SetInt(standNameLevel + "banknotcount" + PlayerPrefs.GetInt("level"), 0);
    }
    public override void CollectableCountSet()
    {

    }
    private void Awake()
    {
        //LevelInit();
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(MoneyCreate());
    }
    int totalBoxCount = 0;
    public void LevelInit()
    {
        carLevel = PlayerPrefs.GetInt(standNameLevel + PlayerPrefs.GetInt("level"));
        cooldownTime = cooldownTimeList[carLevel];

        totalBoxCount = (int)Random.Range(boxCountTotal[carLevel].x, (Globals.collectableLevel + 1) * boxCountTotal[carLevel].y + 1);
        VipActive();
        canvasProductGO.SetActive(true);
        Quaternion cameraRot = Camera.main.transform.rotation;
        canvasProductGO.transform.rotation = Quaternion.Euler(cameraRot.eulerAngles.x, cameraRot.eulerAngles.y, cameraRot.eulerAngles.z);

    }
    public void LevelUp()
    {
        int lvl = PlayerPrefs.GetInt(standNameLevel + PlayerPrefs.GetInt("level"));
        lvl++;
        PlayerPrefs.SetInt(standNameLevel + PlayerPrefs.GetInt("level"), lvl);

        carLevel = PlayerPrefs.GetInt(standNameLevel + PlayerPrefs.GetInt("level"));
        if (currentCar != null)
        {
            if (StandActive)
            {
                ResetStand();
            }
        }
        fishCountCurrent += (totalBoxCount - fishCountTotal);
    }
    public override void SpecificStart()
    {

        firstColliderOffset = moneyArea.GetComponent<BoxCollider>().center;
        StartCoroutine(SpecificStartDelay());

        //foreach (var wrkArea in workAreaList)
        //{
        //    wrkArea.standList.Add(this);
        //    wrkArea.standCourierList.Add(this);
        //}


    }
    IEnumerator SpecificStartDelay()
    {
        yield return new WaitForSeconds(2f);
        StartCounter();
        //CarCreate();
    }
    public override void SpecificReset()
    {
        if (specialVehicle)
        {
            //MissionManager.Instance.specialOrderMission.MissionUpdate();

            if (PlayerPrefs.GetInt("level") == 0)
            {
                Globals.myShareValue += 100;
            }
            else if (PlayerPrefs.GetInt("level") == 1)
            {
                Globals.myShareValue += 150;
            }
            else
            {
                Globals.myShareValue += 250;
            }
            PlayerPrefs.SetInt("myShareValue", Globals.myShareValue);
        }
        else
        {
            //if (MissionManager.Instance.orderMission.mission_Active)
            //{
            //    MissionManager.Instance.orderMission.gameObject.SetActive(true);
            //}
            //MissionManager.Instance.orderMission.MissionUpdate();

            if (PlayerPrefs.GetInt("level") == 0)
            {
                Globals.myShareValue += 30;
            }
            else if (PlayerPrefs.GetInt("level") == 1)
            {
                Globals.myShareValue += 50;
            }
            else
            {
                Globals.myShareValue += 80;
            }
        }
        ResetStand();

        PlayerPrefs.SetInt("completerodercount", PlayerPrefs.GetInt("completerodercount") + 1);


        GameManager.Instance.CourierLevelCompleted(PlayerPrefs.GetInt("completerodercount"));

    }



    void CarCreate()
    {
        obstacleGO.SetActive(true);
        bonusGO.SetActive(false);
        if (goatAnim != null)
        {
            goatAnim.SetBool("openactive", true);
        }
        LevelInit();


        currentCar = Instantiate(carPrefabList[carLevel], carCreateTR.position, Quaternion.identity);
        currentCar.GetComponent<VipDrone>().stand = this;
        currentCar.GetComponent<VipDrone>().standPos = carStandPosList[carLevel];
        currentCar.GetComponent<VipDrone>().carGoPos = carGoTR;
        currentCar.GetComponent<VipDrone>().createPos = carCreateTR;

        //if (thisVip)
        {
            currentCar.GetComponent<VipDrone>().vipCanvasGo.SetActive(true);
        }

        productTypeCount = new int[Globals.collectableLevel + 1];
        productTypeCountTotal = new int[Globals.collectableLevel + 1];

        int typcnt = typeCount[carLevel];

        if (typcnt > Globals.collectableLevel + 1)
        {
            typcnt = Globals.collectableLevel + 1;
        }


        List<int> typeTempList = new List<int>();
        for (int i = 0; i < Globals.collectableLevel + 1; i++)
        {
            typeTempList.Add(i);
        }

        List<int> typeList = new List<int>();

        for (int i = 0; i < typcnt; i++)
        {
            int rndm = Random.Range(0, typeTempList.Count);
            typeList.Add(typeTempList[rndm]);
            typeTempList.Remove(typeTempList[rndm]);
        }


        int productCount = fishCountTotal;
        for (int i = 0; i <= Globals.collectableLevel; i++)
        {
            for (int t = 0; t < typeList.Count; t++)
            {
                if (i == typeList[t] && FishDropArea.Instance.productDropActive[i])
                {
                    productTypeCount[i] = Random.Range(0, productCount);
                    productCount -= productTypeCount[i];
                    break;
                }
            }


        }
        if (productCount > 0)
        {
            int randomSelect = Random.Range(0, typeList.Count);

            int maxLoopCount = 10;
            int loopCounter = 0;
            do
            {
                loopCounter++;
                randomSelect = Random.Range(0, typeList.Count);
                if (loopCounter >= maxLoopCount)
                {
                    break;
                }
            }
            while (!FishDropArea.Instance.productDropActive[typeList[randomSelect]]);

            productTypeCount[typeList[randomSelect]] += productCount;
            productCount -= productTypeCount[typeList[randomSelect]];
        }
        for (int i = 0; i < productTypeCountTotal.Length; i++)
        {
            productTypeCountTotal[i] = productTypeCount[i];
        }
        TextInitCheck();


        GameManager.Instance.CourierLevelStartedAnalytic(PlayerPrefs.GetInt("completerodercount"));
    }


    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        if (collectAmount > 0 && fishCountCurrent > 0 && _stackCollect.collectionTrs[0] != null)
        {
            _stackCollect.collectActive = false;
            StartCoroutine(DropSequantial(collectAmount, _stackCollect));
        }
    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {
        Collectable droppingCollection = null;

        for (int i = 0; i < _stackCollect.collectionTrs.Count; i++)
        {
            foreach (int cltId in collectIDList)
            {
                if (_stackCollect.collectionTrs[i].collectID == cltId)
                {
                    //if (collectType2 == CollectType.All || collectType == CollectType.All || _stackCollect.collectionTrs[i].collectType == collectType || _stackCollect.collectionTrs[i].collectType == collectType2)
                    {
                        bool loopActive = true;
                        for (int j = 0; j < productTypeCount.Length; j++)
                        {
                            if (productTypeCount.Length > 0 && _stackCollect.collectionTrs[i].collectType == CollectType.Type1 && productTypeCount[0] > 0)
                            {
                                if (PlayerPrefs.GetInt("boxcounteractive" + PlayerPrefs.GetInt("level")) == 0)
                                {
                                    PlayerPrefs.SetInt("1boxcounter" + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt("1boxcounter" + PlayerPrefs.GetInt("level")) + 1);
                                    //Debug.Log("boxcount  " + PlayerPrefs.GetInt("1boxcounter" + PlayerPrefs.GetInt("level")));

                                }
                                productTypeCount[0]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (productTypeCount.Length > 1 && _stackCollect.collectionTrs[i].collectType == CollectType.Type2 && productTypeCount[1] > 0)
                            {
                                if (PlayerPrefs.GetInt("boxcounteractive" + PlayerPrefs.GetInt("level")) == 0)
                                {
                                    PlayerPrefs.SetInt("2boxcounter" + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt("2boxcounter" + PlayerPrefs.GetInt("level")) + 1);
                                    //Debug.Log("boxcount  " + PlayerPrefs.GetInt("2boxcounter" + PlayerPrefs.GetInt("level")));

                                }
                                productTypeCount[1]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (productTypeCount.Length > 2 && _stackCollect.collectionTrs[i].collectType == CollectType.Type3 && productTypeCount[2] > 0)
                            {
                                if (PlayerPrefs.GetInt("boxcounteractive" + PlayerPrefs.GetInt("level")) == 0)
                                {
                                    PlayerPrefs.SetInt("3boxcounter" + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt("3boxcounter" + PlayerPrefs.GetInt("level")) + 1);
                                    //Debug.Log("boxcount  " + PlayerPrefs.GetInt("3boxcounter" + PlayerPrefs.GetInt("level")));

                                }
                                productTypeCount[2]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (productTypeCount.Length > 3 && _stackCollect.collectionTrs[i].collectType == CollectType.Type4 && productTypeCount[3] > 0)
                            {
                                if (PlayerPrefs.GetInt("boxcounteractive" + PlayerPrefs.GetInt("level")) == 0)
                                {
                                    PlayerPrefs.SetInt("4boxcounter" + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt("4boxcounter" + PlayerPrefs.GetInt("level")) + 1);
                                }
                                productTypeCount[3]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (productTypeCount.Length > 4 && _stackCollect.collectionTrs[i].collectType == CollectType.Type5 && productTypeCount[4] > 0)
                            {
                                productTypeCount[4]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                        }
                        if (!loopActive)
                        {
                            break;
                        }
                    }

                }
            }
        }
        if (droppingCollection != null)
        {
            Collectable deletedCollect = droppingCollection;

            _stackCollect.collectionTrs.Remove(deletedCollect);



            droppedCollectionList.Add(droppingCollection);
            PlayerPrefs.SetInt(machineName + "rawcount" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);

            yield return null;
            droppingCollection.collectActive = false;
            float deltaY = 0;
            deltaY = (droppedCollectionList.Count - 1) / currentCar.GetComponent<VipDrone>().fishPosTR.Length;
            Transform targetTR = currentCar.GetComponent<VipDrone>().fishPosTR[(droppedCollectionList.Count - 1) % currentCar.GetComponent<VipDrone>().fishPosTR.Length];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollection, Time.deltaTime));
            if (PlayerPrefs.GetInt("completerodercount") == 2)
            {
                HRUpgradeManager.Instance.UpgradeButtonOpener();
            }
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
                AudioManager.Instance.StackDropSound();
            }

            fishCountCurrent -= 1;

            //fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            TextInitCheck();

            if (fishCountCurrent == 0 && !resetActive)
            {
                resetActive = true;
                SpecificReset();
            }
        }


        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;

    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {

        yield return new WaitForSeconds(waitTime);
        collectable.transform.parent = null;

        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        if (collectable.gameObject != null)
        {
            collectable.CollectSave();
            collectable.transform.parent = null;
            firstPos = collectable.transform.position;
            firstRot = collectable.transform.rotation;
        }

        float timeCounter = 0;


        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        timeCounter = 0f;



        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;

            angle = timeCounter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, dropPosTR.rotation, timeCounter);
            }

            yield return null;
        }
        collectable.transform.position = dropPos;
        if (collectable.gameObject != null)
        {
            collectable.transform.parent = currentCar.GetComponent<VipDrone>().fishPosParent;

        }

    }

    void DropMoney(List<Collectable> droppingCollectionList)
    {
        StartCoroutine(DroppingMoney(droppingCollectionList));
    }
    IEnumerator DroppingMoney(List<Collectable> droppingCollectionList)
    {
        int stepNo = 0;

    

        int moneyListCount = moneyArea.moneyList.Count;
        int totalMoney = 0;
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            totalMoney += droppingCollectionList[i].price;
        }

        totalMoney /= 2;
        totalMoney = (int)((float)totalMoney * moneyFactor);
        if (Globals.doubleIncomeActive)
        {
            totalMoney = (int)((float)totalMoney * 2f);
        }
        totalMoney = (int)((float)totalMoney * Globals.extraMoneySkin);
        for (int i = 0; i < totalMoney; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = 2;
            moneyArea.moneyList.Add(banknot);

            stepNo++;
            if (stepNo % 50 == 0)
            {
                yield return null;
            }
        }



        droppedCollectionList.Clear();
        PlayerPrefs.SetInt(standNameLevel + "banknotcount" + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt(standNameLevel + "banknotcount" + PlayerPrefs.GetInt("level")) + totalMoney);

        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ColliderReset());

    }
    IEnumerator MoneyCreate()
    {
        int banknotVal = 2;
        for (int i = 0; i < PlayerPrefs.GetInt(standNameLevel + "banknotcount" + PlayerPrefs.GetInt("level")); i++)
        {
            float deltaY = 0;
            deltaY = (i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = banknotVal;
            moneyArea.moneyList.Add(banknot);

            int stepNo = 0;
            stepNo++;
            if (stepNo % 50 == 0)
            {
                yield return null;
            }
        }

        yield return null;
    }
    IEnumerator ColliderReset()
    {
        Vector3 beginOffset = new Vector3(firstColliderOffset.x, -20, firstColliderOffset.z);
        moneyArea.GetComponent<BoxCollider>().center = beginOffset;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            moneyArea.GetComponent<BoxCollider>().center = Vector3.Lerp(beginOffset, firstColliderOffset, counter);
            yield return null;
        }
        moneyArea.GetComponent<BoxCollider>().center = firstColliderOffset;
    }
    void NotCompleteOrder()
    {
        StartCoroutine(NotCompleteOrder_Delay());
    }
    IEnumerator NotCompleteOrder_Delay()
    {

        droppedCollectionList.Clear();

        StartCoroutine(CarSoundPlay());
        //DropMoney();
        StandActive = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(0.11f);
        if (vipWaiting)
        {
            vipWaiting = false;
            //DropMoney(droppedCollectionList);
            vipCounter = 0;
        }
 


        currentCar.GetComponent<VipDrone>().CarGoOut();
        obstacleGO.SetActive(false);

        if (thisVip)
        {
            thisVip = false;
        }


        canvasProductGO.SetActive(false);

        imageFill.fillAmount = 1;
        canvasDeliveringGO.SetActive(false);
        TextInit();
        DayCycleRestart();

        yield return new WaitForSeconds(1f);
        resetActive = false;
    }
    public void ResetStand()
    {
        StartCoroutine(ResetDelay());
    }
    IEnumerator CarSoundPlay()
    {
        yield return new WaitForSeconds(1);
        if (PlayerPrefs.GetInt("soundclose") == 0)
        {
            carSoundAS.Play();
        }
    }
    IEnumerator ResetDelay()
    {
        int totalMoney = 0;
        for (int i = 0; i < droppedCollectionList.Count; i++)
        {
            totalMoney += droppedCollectionList[i].price;
        }

        totalMoney = (int)((float)totalMoney * moneyFactor);
        totalBonus = totalMoney;
        totalBonusText.text = totalBonus.ToString();


        StartCoroutine(CarSoundPlay());
        //DropMoney();
        StandActive = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(0.11f);
        if (vipWaiting)
        {
            vipWaiting = false;
            //DropMoney(droppedCollectionList);
            vipCounter = 0;
        }
        //else
        //{
        //    droppedCollectionList.Clear();
        //}
        bonusGO.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        canvasDeliveringGO.SetActive(true);

        float counter = 0f;
        while (counter < cooldownTime && thisVip)
        {
            counter += Time.deltaTime;
            imageFill.fillAmount = counter / cooldownTime;
            yield return null;
        }


        currentCar.GetComponent<VipDrone>().CarGoOut();
        obstacleGO.SetActive(false);

        if (thisVip)
        {
            thisVip = false;
            DropMoney(droppedCollectionList);
        }
 

        canvasProductGO.SetActive(false);

        imageFill.fillAmount = 1;
        canvasDeliveringGO.SetActive(false);
        //LevelInit();
        //fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
        TextInit();
        //CarCreate();
        DayCycleRestart();

        yield return new WaitForSeconds(1f);
        resetActive = false;


    }

    public void VipActive()
    {
        RewardPanel.Instance.vipCar = this;
   
        thisVip = true;

        StartCoroutine(DigitalCounter(180));

    }
    bool thisVip = false;
    public int vipCounter;
    bool vipWaiting = false;

    IEnumerator DigitalCounter(int _time)
    {
        vipWaiting = true;
        vipCounter = _time;
        RewardPanel.Instance.vipPanelGO.SetActive(true);
        RewardPanel.Instance.vipImg.sprite = vipImgList[carLevel];

        while (vipCounter > 0)
        {
            int minute = Mathf.FloorToInt(vipCounter / 60);
            int second = Mathf.FloorToInt(vipCounter % 60);

            RewardPanel.Instance.vipCounterText.text = minute.ToString() + ":" + ($"{second}");
            if (minute < 10)
            {
                RewardPanel.Instance.vipCounterText.text = "0" + minute.ToString() + ":" + ($"{second}");

            }
            if (second < 10)
            {
                RewardPanel.Instance.vipCounterText.text = minute.ToString() + ":0" + ($"{second}");
                if (minute < 10)
                {
                    RewardPanel.Instance.vipCounterText.text = "0" + minute.ToString() + ":0" + ($"{second}");

                }
                if (vipCounter <= 3)
                {
                    StartCoroutine(CounterTextColorSet(RewardPanel.Instance.vipCounterText));
                    VibratoManager.Instance.LightVibration();
                }
            }
            vipCounter--;
            yield return new WaitForSeconds(1);

        }

        RewardPanel.Instance.vipCounterText.text = "00:00";
        yield return new WaitForSeconds(0.5f);
        RewardPanel.Instance.vipPanelGO.SetActive(false);
        if (vipWaiting)
        {
            
            NotCompleteOrder();
        }
        vipWaiting = false;

    }
    IEnumerator CounterTextColorSet(TextMeshProUGUI txt)
    {
        float counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            value = (Mathf.Sin(Mathf.PI * counter));
            //holeTimerBG_Image.color = Color.Lerp(firstColor, targetColor, value);
            txt.color = Color.Lerp(Color.white, Color.red, value);
            yield return null;
        }
        txt.color = Color.white;
    }

    private void OnTriggerExit(Collider other)
    {
        if (PlayerPrefs.GetInt("tutorialcompleted") == 1 && PlayerPrefs.GetInt("recycletutorial") == 1 && PlayerController.Instance._stackCollect.collectionTrs.Count > 0 && other.GetComponent<PlayerController>() != null && resetActive)
        {
            PlayerPrefs.SetInt("recycletutorial", 2);
            if (standFishTezgah != null)
            {
                standFishTezgah.tutorialPosTR.SetActive(true);
                IndicatorManager.Instance.IndicaorActive(standFishTezgah.tutorialPosTR.transform);
            }
            TutorialManager.Instance.rceycleTutorialGO.SetActive(true);
            IndicatorManager.Instance.TutorialStepStart(31);

        }
    }
    public void VipViewCamera()
    {
        StartCoroutine(VipView());
    }
    IEnumerator VipView()
    {
        vipCarCamera.Priority = 10;
        yield return new WaitForSeconds(4f);
        vipCarCamera.Priority = 0;
        RewardPanel.Instance.vipViewButton.interactable = true;
    }

    public bool missionActive = true;
    public bool missionUpdateActive = true;

    public float moneyFactor = 1.5f;

    public int totalBonus = 0;
    public TextMeshProUGUI totalBonusText;
    public void ClaimButtonClick()
    {
        thisVip = false;
        GameManager.Instance.ui.MoneyCreateVip(totalBonus, false);
        bonusGO.SetActive(false);
        droppedCollectionList.Clear();
    }

    public void DoubleRewardedClickButton()
    {
        string _tag = "";

        ADVManager.Instance.RewardedStart(DoubleRewardedAdvEnd, _tag, false);
    }
    public void DoubleRewardedAdvEnd(bool ticketActive)
    {
        string _tag = "";

        if (ticketActive)
        {
            //Analytics.ItemObtained(_tag, 0, ItemFlowReason.Progression);
            //Analytics.ItemConsumed(_tag, 0, ItemFlowReason.Progression);
        }
        else
        {
            //Analytics.ItemObtained(_tag, 0, ItemFlowReason.RewardedVideoAd);
            //Analytics.ItemConsumed(_tag, 0, ItemFlowReason.RewardedVideoAd);
        }
        thisVip = false;
        GameManager.Instance.ui.MoneyCreateVip((int)(totalBonus * 1.5f), false);
        bonusGO.SetActive(false);
        droppedCollectionList.Clear();

    }
}
