using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
public class StandFishCar : Stand,IMoneyArea
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

    public Transform characterBackPosTR;
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
    public void CollectTrash()
    {
        if (PlayerPrefs.GetInt("trashtutorial") == 1)
        {
            PlayerPrefs.SetInt("trashtutorial", 2);
            if (trashStand != null)
            {
                IndicatorManager.Instance.IndicaorActive(trashStand.transform);
                IndicatorManager.Instance.TutorialStepCompleted();
                IndicatorManager.Instance.TutorialStepStart(82);

            }
        }
    }
    private void Awake()
    {
        Globals.carSlotCount++;
        LevelInit();
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        //if (missionActive)
        //{
        //    MissionManager.Instance.ShippingLineMissionStart();
        //}
        StartCoroutine(MoneyCreate());

        if (PlayerPrefs.GetInt("firstindactive") == 0)
        {
            PlayerPrefs.SetInt("firstindactive", 1);
            IndicatorManager.Instance.IndicatorTargeterActive();
        }
        if (!specialVehicle && missionUpdateActive)
        {
            if (PlayerPrefs.GetInt(standNameLevel + "firstopen" + PlayerPrefs.GetInt("level")) == 0)
            {
                PlayerPrefs.SetInt(standNameLevel + "firstopen" + PlayerPrefs.GetInt("level"), 1);

                yield return new WaitForSeconds(4);
                //MissionManager.Instance.shippingBuyMission.MissionUpdate();
            }
        }

    }
    int totalBoxCount = 0;
    public void LevelInit()
    {
        carLevel = PlayerPrefs.GetInt(standNameLevel + PlayerPrefs.GetInt("level"));
        cooldownTime = cooldownTimeList[carLevel];



        totalBoxCount = (int)Random.Range(boxCountTotal[carLevel].x, boxCountTotal[carLevel].y + 1);
        
        
        if (PlayerPrefs.GetInt("tutorialseq1") == 0)
        {
            fishCountTotal = 3;
        }
        else
        {
            fishCountTotal = totalBoxCount;
        }
        if (PlayerPrefs.GetInt("completerodercount") == 1)
        {
            fishCountTotal = 4;
        }
    }
    public void LevelUp()
    {
        int lvl = PlayerPrefs.GetInt(standNameLevel + PlayerPrefs.GetInt("level"));
        lvl++;
        PlayerPrefs.SetInt(standNameLevel + PlayerPrefs.GetInt("level"), lvl);

        carLevel = PlayerPrefs.GetInt(standNameLevel + PlayerPrefs.GetInt("level"));
        if (currentCar != null)
        {
            //currentCar.GetComponent<FishCar>().CarLevelCreate(carLevel);
            if (StandActive)
            {
                ResetStand();
            }
        }
        fishCountCurrent += (totalBoxCount - fishCountTotal);


        //LevelInit();
        //fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
    }
    public override void SpecificStart()
    {
        //if (specialVehicle)
        //{
        //    MissionManager.Instance.specialShippingBuyMission.MissionUpdate();
        //}
        Globals.openedCarSlotCount++;
        FishDropArea.Instance.carSlotList.Add(this);
        firstColliderOffset = moneyArea.GetComponent<BoxCollider>().center;
        StartCoroutine(SpecificStartDelay());
        //_FishDropArea.standList.Add(this);
        FishCountInit();
        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);
            wrkArea.standCourierList.Add(this);
            wrkArea.CollectProductList.Add(_CollectProducts);
        }

        _CollectProducts.collectables = trashList;

    }
    IEnumerator SpecificStartDelay()
    {
        yield return new WaitForSeconds(2f);
        CarCreate();
    }
    void FishCountInit()
    {
        //FishManager.Instance.fishCount[0] += (int)(fishCountTotal * fishCoun_Factor);
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

            if (QuestManager.Instance.orderSpecialQuest != null)
            {
                QuestManager.Instance.orderSpecialQuest.QuestUpdate(1);
            }
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


            if (QuestManager.Instance.orderQuest != null)
            {
                QuestManager.Instance.orderQuest.QuestUpdate(1);
            }
        }
        ResetStand();

        PlayerPrefs.SetInt("completerodercount", PlayerPrefs.GetInt("completerodercount") + 1);

        //if (PlayerPrefs.GetInt("completerodercount") == 3)
        //{
        //    HRUpgradeManager.Instance.UpgradeButtonOpener();
        //}
        if (PlayerPrefs.GetInt("completerodercount") == 1)
        {
            FishDropArea.Instance.GarbageDroppingAfterTutorial();
        }
        GameManager.Instance.CourierLevelCompleted(PlayerPrefs.GetInt("completerodercount"));

    }



    void CarCreate()
    {
        numberOfTrips++;
        if (goatAnim != null)
        {
            goatAnim.SetBool("openactive", true);
        }


        currentCar = Instantiate(carPrefabList[carLevel], carCreateTR.position, Quaternion.identity);
        //currentCar.GetComponent<FishCar>().CarLevelCreate(carLevel);
        currentCar.GetComponent<FishCar>().stand = this;
        currentCar.GetComponent<FishCar>().standPos = carStandPosList[carLevel];
        currentCar.GetComponent<FishCar>().carGoPos = carGoTR;

        if (thisVip)
        {
            currentCar.GetComponent<FishCar>().vipCanvasGo.SetActive(true);
        }

        productTypeCount = new int[Globals.collectableLevel + 1];
        productTypeCountTotal = new int[Globals.collectableLevel + 1];

        int typcnt = typeCount[carLevel];

        if(typcnt > Globals.collectableLevel + 1)
        {
            typcnt = Globals.collectableLevel + 1;
        }


        List<int> typeTempList = new List<int>();
        for(int i = 0; i < Globals.collectableLevel + 1; i++)
        {
            typeTempList.Add(i);
        }

        List<int> typeList = new List<int>();

        for(int i = 0; i < typcnt; i++)
        {
            int rndm = Random.Range(0, typeTempList.Count);
            typeList.Add(typeTempList[rndm]);
            typeTempList.Remove(typeTempList[rndm]);
        }

        
        int productCount = fishCountTotal;
        for(int i = 0; i <= Globals.collectableLevel; i++)
        {
            for (int t = 0; t < typeList.Count; t++)
            {
                if(i == typeList[t] && FishDropArea.Instance.productDropActive[i])
                {
                    productTypeCount[i] = Random.Range(0, productCount);
                    productCount -= productTypeCount[i];
                    break;
                }
            }

       
        }
        if(productCount > 0)
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

            productTypeCount[typeList[ randomSelect]] += productCount;
            productCount -= productTypeCount[typeList[randomSelect]];
        }
        for (int i = 0; i < productTypeCountTotal.Length; i++)
        {
            productTypeCountTotal[i] = productTypeCount[i];
        }
        TextInitCheck();


        //if (specialVehicle)
        //{
        //    MissionManager.Instance.SpecialOrderMissionStart();
        //}
        //else
        //{
        //    MissionManager.Instance.OrderMissionStart();
        //}
        //if (missionActive)
        //{
        //    MissionManager.Instance.ShippingLineMissionStart();
        //}


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
                                if (PlayerPrefs.GetInt("boxcounteractive"+ PlayerPrefs.GetInt("level")) == 0)
                                {
                                    PlayerPrefs.SetInt("1boxcounter"  + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt("1boxcounter" + PlayerPrefs.GetInt("level")) + 1);
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
                                if (PlayerPrefs.GetInt("boxcounteractive"+ PlayerPrefs.GetInt("level")) == 0)
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
                                if (PlayerPrefs.GetInt("boxcounteractive"+ PlayerPrefs.GetInt("level")) == 0)
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
            deltaY = (droppedCollectionList.Count - 1) / currentCar.GetComponent<FishCar>().fishPosTR.Length;
            Transform targetTR = currentCar.GetComponent<FishCar>().fishPosTR[(droppedCollectionList.Count - 1) % currentCar.GetComponent<FishCar>().fishPosTR.Length];
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
        //Vector3 tempPosition = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(1f, 2f), Random.Range(-0.5f, 0.5f));
        //Quaternion tempAngle = Quaternion.Euler(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        //while (timeCounter < 1f)
        //{
        //    timeCounter += 4 * Time.deltaTime;


        //    if (collectable.gameObject != null)
        //    {
        //        collectable.transform.position = Vector3.Lerp(firstPos, transform.position + tempPosition, timeCounter);
        //        collectable.transform.rotation = Quaternion.Lerp(firstRot, tempAngle, timeCounter);
        //    }
        //    yield return null;
        //}
        //if (collectable.gameObject != null)
        //{
        //    firstPos = collectable.transform.position;
        //    firstRot = collectable.transform.rotation;
        //}
        //yield return new WaitForSeconds(0.1f);

        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        timeCounter = 0f;


        //Quaternion targetAngle = Quaternion.Euler(dropPosTR.eulerAngles.x, dropPosTR.eulerAngles.y + Random.Range(-30f, 30f), dropPosTR.eulerAngles.z + Random.Range(-30f, 30f));

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
            collectable.transform.parent = currentCar.GetComponent<FishCar>().fishPosParent;

        }
    
    }

    void DropMoney(List<Collectable> droppingCollectionList)
    {
        StartCoroutine(DroppingMoney(droppingCollectionList));
    }
    IEnumerator DroppingMoney(List<Collectable> droppingCollectionList)
    {
        int stepNo = 0;

        float moneyFactor = 1f;
        if (thisVip)
        {
            moneyFactor = 1.5f;
        }

        int moneyListCount = moneyArea.moneyList.Count;
        int totalMoney = 0;
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            totalMoney += droppingCollectionList[i].price + extraMoney[carLevel] + MRCUpgradeManager.Instance._characterUpgradeSettings.customerEarning[Globals.customerEarningLevel];
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




        //float moneyFactor = 1f;
        //if (thisVip)
        //{
        //    moneyFactor = 1.5f;
        //}
      
        //int moneyListCount = moneyArea.moneyList.Count;
        //for (int i = 0; i < droppingCollectionList.Count; i++)
        //{
        //    float deltaY = 0;
        //    deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
        //    Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
        //    Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
        //    BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
        //    banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
        //    banknot.banknotValue = extraMoney[carLevel] + (int)((float)droppingCollectionList[i].price * moneyFactor);
        //    moneyArea.moneyList.Add(banknot);
        //    yield return null;
        //}

        //moneyListCount = moneyArea.moneyList.Count;
        //for (int i = 0; i < extraMoney[carLevel]; i++)
        //{
        //    float deltaY = 0;
        //    deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
        //    Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
        //    Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
        //    BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
        //    banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
        //    banknot.banknotValue = 1;
        //    moneyArea.moneyList.Add(banknot);
        //    yield return null;
        //}

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
    public TrashStand trashStand;
    IEnumerator ResetDelay()
    {
        StartCoroutine(CarSoundPlay());
         //DropMoney();
         StandActive = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(0.11f);
        if (!thisVip)
        {
            DropMoney(droppedCollectionList);
        }
        else if (vipWaiting)
        {
            vipWaiting = false;
            DropMoney(droppedCollectionList);
            vipCounter = 0;
        }
        else
        {
            droppedCollectionList.Clear();
        }
        currentCar.GetComponent<FishCar>().CarGoOut();

        int _trashDropPerCustomer = trashDropPerCustomer[carLevel];
        if (PlayerPrefs.GetInt("trashtutorial", 0) == 0)
        {
            _trashDropPerCustomer = 8;
        }

        if (numberOfTrips % _trashDropPerCustomer == 0)
        {
            if (PlayerPrefs.GetInt("trashtutorial", 0) == 0)
            {
                yield return new WaitForSeconds(4);
                PlayerPrefs.SetInt("trashtutorial", 1);
                //PlayerController.Instance.transform.parent.position = characterBackPosTR.position;
                IndicatorManager.Instance.IndicaorActive(transform);
                IndicatorManager.Instance.TutorialStepStart(81);

            }
            StartCoroutine(TrashCreating());
            trashIcon_GO.SetActive(true);
            triggerPlaneGO.SetActive(false);
            numberOfTrips = 0;


        }

        yield return new WaitForSeconds(0.1f);

        if (goatAnim != null)
        {
            goatAnim.SetBool("openactive", false);
        }

        canvasDeliveringGO.SetActive(true);
        canvasProductGO.SetActive(false);
        float _cooldownTime = (cooldownTime / MRCUpgradeManager.Instance._characterUpgradeSettings.customerCooldown[Globals.customerCooldownLevel]);
        float counter = 0f;
        while(counter < _cooldownTime)
        {
            counter += Time.deltaTime;
            imageFill.fillAmount = counter / _cooldownTime;
            yield return null;
        }

        while (trashList.Count > 0)
        {
            yield return null;
        }

        trashIcon_GO.SetActive(false);
        triggerPlaneGO.SetActive(true);

        if (thisVip)
        {
            thisVip = false;
        }
        imageFill.fillAmount = 1;
        canvasDeliveringGO.SetActive(false);
        canvasProductGO.SetActive(true);
        LevelInit();
        //fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
        TextInit();
        CarCreate();

        yield return new WaitForSeconds(1f);
        resetActive = false;


    }

    public void VipActive()
    {
        //RewardPanel.Instance.vipCar = this;

        thisVip = true;

        StartCoroutine(DigitalCounter(150));

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
            ResetStand();
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

    //private void OnTriggerExit(Collider other)
    //{
    //    if (PlayerPrefs.GetInt("tutorialcompleted") == 1 && PlayerPrefs.GetInt("recycletutorial") == 1 && PlayerController.Instance._stackCollect.collectionTrs.Count > 0 && other.GetComponent<PlayerController>() != null && resetActive)
    //    {
    //        PlayerPrefs.SetInt("recycletutorial", 2);
    //        if (standFishTezgah != null)
    //        {
    //            standFishTezgah.tutorialPosTR.SetActive(true);
    //            IndicatorManager.Instance.IndicaorActive(standFishTezgah.tutorialPosTR.transform);
    //        }
    //        TutorialManager.Instance.rceycleTutorialGO.SetActive(true);
    //        IndicatorManager.Instance.TutorialStepStart(31);

    //    }
    //}
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

    public GameObject triggerPlaneGO;
    IEnumerator TrashCreating()
    {
        for(int i = 0; i < trashCount; i++)
        {
            Vector3 firstPos = trashCreatePosTR.position;
            Quaternion firstRot = trashCreatePosTR.rotation;
            int trashPrefabSelect = Random.Range(0, trashPrefabList_GO.Count);
            GameObject newTrash = Instantiate(trashPrefabList_GO[trashPrefabSelect], firstPos, firstRot);
            Collectable trashCollectable = newTrash.GetComponent<Collectable>();

            trashCollectable.collectActive = false;
            trashCollectable.fishCollectable = trashList;
            trashList.Add(trashCollectable);


            float deltaY = 0;

            deltaY = (trashList.Count - 1) / trashPosList.Count;
            Transform targetTR = trashPosList[(trashList.Count - 1) % trashPosList.Count];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 3f, 0);

            StartCoroutine(TrashDropping(trashCollectable, targetTR, dropPos));


            yield return null;
        }
    }


    IEnumerator TrashDropping(Collectable trashCollectable, Transform targetTR, Vector3 dropPos)
    {
        trashCollectable.productCollectActive = true;

        Vector3 firstPos = trashCollectable.transform.position;
        Quaternion firstRot = trashCollectable.transform.rotation;

        Quaternion targetRot = targetTR.transform.rotation;

        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 1f;
        float counter = 0f;
        while (counter < 1f && !trashCollectable.isCollected)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            trashCollectable.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            trashCollectable.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        trashCollectable.productCollectActive = true;
        trashCollectable.collectActive = true;
        if (!trashCollectable.isCollected)
        {
            trashCollectable.transform.position = dropPos;
            trashCollectable.transform.rotation = targetRot;
        }

    }



    public CollectProduct _CollectProducts;


    [SerializeField] List<GameObject> trashPrefabList_GO = new List<GameObject>();
    [SerializeField] int[] trashDropPerCustomer;
    [SerializeField] int trashCount;
    [SerializeField] List<Collectable> trashList = new List<Collectable>();
    [SerializeField] Transform trashCreatePosTR;
    [SerializeField] List<Transform> trashPosList = new List<Transform>();
    [SerializeField] GameObject trashIcon_GO;

    int numberOfTrips = 0;

}
