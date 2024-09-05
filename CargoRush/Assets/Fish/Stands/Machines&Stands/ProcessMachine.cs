using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;

public class ProcessMachine : Stand, IStandUpgrade, IMachineActive
{
    [SerializeField] Transform fishInTR, converFishtoCannedTR, fishOutTR, outTR2;
    [SerializeField] Transform fishInTR_Second;
    public Collectable[] productsPrefab;
   
    public Transform[] fishPosTR;


    public Transform[] productPosTR;


    public List<Collectable> productCollectionList = new List<Collectable>();


    public CollectProduct _CollectProducts;
    [SerializeField] Animator machineAnimator;
    [SerializeField] Animator machineAnimator2;
    [SerializeField] public List<CollectProduct> _CollectProductStands;
    [SerializeField] int extraCustomerCount;

    [SerializeField] GameObject fullTextGO;
    [SerializeField] GameObject stoppedTextGO;


    public MineCrusher mineCrusher;
    public int rawCountPerProduct = 1;
    public Collectable[] rawPrefabs;
    public Collectable[] productPrefabs;
    //public int machineId;
    public bool missionActive = true;
    public bool missionUpdateActive = true;
    public int machineLevel;
    public int collectableLevel;
    public bool machinePopUpActive = true;


    public int standLevel { get; set; }

    public int[] capacitiesRaw;
    public int[] capacitiesProduct;
    public float[] speedFactors;
    //public int[] bandPerPackCount;
    //public int[] bandCapacity;

    float speedFactor = 1f;
    public AIPath aiPath;
    [SerializeField] List<GameObject> trayList = new List<GameObject>();
    public bool isVipActivator = false;
    public bool kizakRunning = false;


    public bool machineErrorActivator = false;

    [SerializeField] int errorTime = 60;
    [SerializeField] int errorTimeCounter = 0;
    public bool machineErrored = false;
    public CinemachineVirtualCamera errorCamera;
    public int repairTime = 60;
    public int repairTimeCounter = 0;
    public MachineRepairArea machineRepairArea;
    public RepairWorker repairWorker;
    public GameObject repairProgressGO;
    public Image repairProgressImg;
    public TextMeshProUGUI repairProgressText;
    public List<CollectProduct> collectProducts = new List<CollectProduct>();
    public string productName;
    public bool skinActivator = false;

    public GameObject standOnlineGO;

    public StandRaw otherRawStand;
    public int bandPerPackageCount = 5;
    int packageCount = 0;

    public Transform repairWorkerWaitingPos_TR;
    public bool errorActive { get; set; }

    public GameObject machineDurable_GO;
    public GameObject machineError_GO;

    public AudioSource bandSoundAS;
    public GameObject cleanSparkleGO;

    private void Awake()
    {
        errorActive = false;
        FishDropArea.Instance.packMachines.Add(this);

    }
    void MachineErroredCheckStart()
    {
        if (PlayerPrefs.GetInt(machineName + "iserror" + PlayerPrefs.GetInt("level")) == 0)
        {
            machineErrored = false;
            errorActive = false;
            //Globals.machineErrorActive = false;
        }
        else
        {
            machineErrored = true;
            errorActive = true;
            machineRepairArea.gameObject.SetActive(true);
            Globals.machineErrorActive = true;
        }
    }
    public void MachineErrored()
    {
        errorActive = true;
        machineErrored = true;
        machineRepairArea.gameObject.SetActive(true);
        PlayerPrefs.SetInt(machineName + "iserror" + PlayerPrefs.GetInt("level"), 1);
        CollectProgressManager.Instance.dirtyActiveImgGO.SetActive(true);
        Globals.machineErrorActive = true;
        ShareManager.Instance.ErrorCounter();
        machineDurable_GO.SetActive(false);
        machineError_GO.SetActive(true);
}
    public void MachineRepaired()
    {
        if (errorActive)
        {
            errorActive = false;
            PlayerPrefs.SetInt(machineName + "iserror" + PlayerPrefs.GetInt("level"), 0);
            CollectProgressManager.Instance.dirtyActiveImgGO.SetActive(false);
            FishDropArea.Instance.RepairProgressSet();
            foreach (var repairs in machineRepairArea.machineRepairListAll)
            {
                repairs.gameObject.SetActive(false);
            }
            machineRepairArea.gameObject.SetActive(false);
            StartCoroutine(RepairAnimation());
        }
    }
    IEnumerator RepairAnimation()
    {
        cleanSparkleGO.SetActive(true);
        machineError_GO.GetComponent<Animator>().SetTrigger("repair");
        yield return new WaitForSeconds(2f);
        machineDurable_GO.SetActive(true);
        machineError_GO.SetActive(false);

        machineErrored = false;
        Globals.machineErrorActive = false;
        cleanSparkleGO.SetActive(false);

    }
    void CollectProducts_CollectActivator(bool active)
    {
        //foreach(var cltPrd in collectProducts)
        //{
        //    cltPrd.collectActive = active;
        //}
    }
    public void RepairStarter()
    {
        PlayerPrefs.SetInt(machineName + "repairStarted" + PlayerPrefs.GetInt("level"), 1);

        StartCoroutine(MachineRepairCounter());
    }
    IEnumerator RepairManReactiveDelay()
    {
       
        //repairWorker.transform.position = machineRepairArea.repairCreatePos.position;
        yield return new WaitForSeconds(0.1f);
        repairWorker.gameObject.SetActive(true);
        repairWorker.GoToMachine();

        yield return new WaitForSeconds(0.5f);

        repairWorker.showBuyRapairReward.showActive = true;
        repairWorker.showBuyRapairReward.Canvas.SetActive(true);

    }
    IEnumerator MachineRepairCounter()
    {
        repairProgressGO.SetActive(true);
        repairProgressText.text = "00:00";
        repairTimeCounter = PlayerPrefs.GetInt(machineName + "repairTimeCounter" + PlayerPrefs.GetInt("level"));
        while (repairTimeCounter < repairTime)
        {
            repairTimeCounter++;
            repairProgressImg.fillAmount = (float)repairTimeCounter / (float)repairTime;
            repairProgressText.text = ConvertSecondToMinSec.Converter(repairTime - repairTimeCounter);
            PlayerPrefs.SetInt(machineName + "repairTimeCounter" + PlayerPrefs.GetInt("level"), repairTimeCounter);
            yield return new WaitForSeconds(1f / Globals.repairSpeedSkin);
        }
        repairTimeCounter = 0;
        PlayerPrefs.SetInt(machineName + "repairTimeCounter" + PlayerPrefs.GetInt("level"), repairTimeCounter);
        PlayerPrefs.SetInt(machineName + "iserror" + PlayerPrefs.GetInt("level"), 0);
        PlayerPrefs.SetInt(machineName + "repairStarted" + PlayerPrefs.GetInt("level"), 0);
        machineErrored = false;
        Globals.machineErrorActive = false;
        CollectProducts_CollectActivator(true);
        FishDropArea.Instance.productDropActive[collectableLevel] = true;
        repairWorker.GoExit();
        repairProgressGO.SetActive(false);
        StartCoroutine(MachineErrorCounter());
        TutorialManager.Instance.repairFinishedGO.SetActive(true);
        FishDropArea.Instance.ReactiveActivator();

    }
    IEnumerator MachineErrorCounter()
    {
        errorTimeCounter = PlayerPrefs.GetInt(machineName + "errorTimeCounter" + PlayerPrefs.GetInt("level"));
        while (errorTimeCounter < errorTime)
        {
            if (!Globals.machineErrorActive && Globals.machineErrorActivator)
            {
                errorTimeCounter++;
                PlayerPrefs.SetInt(machineName + "errorTimeCounter" + PlayerPrefs.GetInt("level"), errorTimeCounter);
            }
            yield return new WaitForSeconds(1f);
        }
        PlayerPrefs.SetInt(machineName + "iserror" + PlayerPrefs.GetInt("level"), 1);
        errorTimeCounter = 0;
        PlayerPrefs.SetInt(machineName + "errorTimeCounter" + PlayerPrefs.GetInt("level"), errorTimeCounter);

        machineErrored = true;
        Globals.machineErrorActive = true;
        CollectProducts_CollectActivator(false);

        machineRepairArea.gameObject.SetActive(true);
        //FishDropArea.Instance.productDropActive[collectableLevel] = false;
        //FishDropArea.Instance.DeleteErrorProduct(collectableLevel);
        //FishDropArea.Instance.CarSlotsReset();

        errorCamera.Priority = 50;
        yield return new WaitForSeconds(2f);
        errorCamera.Priority = 0;
    }
    public override void CollectableCountSet()
    {
        PlayerPrefs.SetInt(machineName + "rawcount" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);
        PlayerPrefs.SetInt(machineName + "col" + PlayerPrefs.GetInt("level"), productCollectionList.Count);
        TraySet();

    }
    public override void SpecificStart()
    {
        if (skinActivator)
        {
            //TutorialManager.Instance.SkinTutorialStart();

            //PlayerPrefs.SetInt("skinactive", 1);
            //StoreManager.Instance.storeButton.SetActive(true);

        }
        if (isVipActivator)
        {
            Globals.vipCreateActive = true;
        }
        if (Globals.collectableLevel < collectableLevel)
        {
            Globals.collectableLevel = collectableLevel;
            SkillManager.Instance.ResetRewardedPos();
        }
        IndicatorManager.Instance.machines.Add(this);

        if(collectType == CollectType.Type1)
        {
            Globals.productType1 = true;
        }
        if (collectType == CollectType.Type2)
        {
            Globals.productType2 = true;
        }
        if (collectType == CollectType.Type3)
        {
            Globals.productType3 = true;
        }
        if (collectType == CollectType.Type4)
        {
            Globals.productType4 = true;
        }
        if (collectType == CollectType.Type5)
        {
            Globals.productType5 = true;
        }

        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    Globals.extraCustomerCount_Electronics += extraCustomerCount;
                }
                break;

            case MarketType.Sports:
                {
                    Globals.extraCustomerCount_Sports += extraCustomerCount;
                }
                break;

            case MarketType.Toys:
                {
                    Globals.extraCustomerCount_Toys += extraCustomerCount;
                }
                break;
        }
        _CollectProducts.collectables = productCollectionList;

        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);
            wrkArea.CollectProductList.Add(_CollectProducts);
        }
        workAreaList[0].machineStand = this;

        StandReActive();
        FishCountInit();

        StartCoroutine(CreatorChecking());
        StandCarCollectIdSet();
        ManuealRawCreate();
        ManuealProductCreate();
        CapacityInit();
        MachineErroredCheckStart();
        //if (machineErrorActivator)
        //{
        //    if (PlayerPrefs.GetInt(machineName + "iserror" + PlayerPrefs.GetInt("level")) == 0)
        //    {
        //        machineErrored = false;
        //        Globals.machineErrorActive = false;
        //        CollectProducts_CollectActivator(true);

        //        StartCoroutine(MachineErrorCounter());
        //    }
        //    else
        //    {
        //        machineErrored = true;
        //        Globals.machineErrorActive = true;
        //        CollectProducts_CollectActivator(false);

        //        if (PlayerPrefs.GetInt(machineName + "repairStarted" + PlayerPrefs.GetInt("level")) == 1)
        //        {
        //            RepairStarter();
        //            StartCoroutine(RepairManReactiveDelay());
        //        }
        //        else
        //        {
        //            FishDropArea.Instance.productDropActive[collectableLevel] = false;
        //            machineRepairArea.gameObject.SetActive(true);
        //            FishDropArea.Instance.DeleteErrorProduct(collectableLevel);
        //            FishDropArea.Instance.CarSlotsReset();
        //        }
        //    }
        //}

        StartCoroutine(StartDelay());
        if(standOnlineGO != null)
        {
            standOnlineGO.SetActive(true);
        }
        RepairManager.Instance.processMachines.Add(this);
    }
    IEnumerator StartDelay()
    {
        if (missionActive)
        {
            MissionManager.Instance.TapingLineMissionStart();
        }
        yield return new WaitForSeconds(1f);

        if (PlayerPrefs.GetInt(machineName + "firstopen" + PlayerPrefs.GetInt("level")) == 0)
        {
            PlayerPrefs.SetInt(machineName + "firstopen" + PlayerPrefs.GetInt("level"), 1);

            if (MissionManager.Instance.tapingLineBuyMission.mission_Active)
            {
                MissionManager.Instance.tapingLineBuyMission.gameObject.SetActive(true);
            }
            if (collectableLevel == 1 && PlayerPrefs.GetInt("level") == 0)
            {
                FishDropArea.Instance.NewProductActive(productName);
            }
            FishDropArea.Instance.ReactiveActivator();

            yield return new WaitForSeconds(5);
            if (missionUpdateActive)
            {
                MissionManager.Instance.tapingLineBuyMission.MissionUpdate();
            }
        }


    }
    void StandCarCollectIdSet()
    {
        
    }
    void FishCountInit()
    {
    }
    public override void SpecificReset()
    {
    }
    bool creatingActive = false;
    void MachineActive()
    {
        machineAnimator2.SetBool("kizak", true);
        machineActive = true;
    }
    void MachineStop()
    {
        if (!kizakRunning)
        {
            machineAnimator2.SetBool("kizak", false);
            machineActive = false;
        }
    }
    bool machineIsFull = false;
    IEnumerator CreatorChecking()
    {
        creatingActive = false;
        while (!creatingActive)
        {
            if (cannedCount < productCountTotal && !machineErrored)
            {
                creatingActive = true;

                StartCoroutine(CannedCreator());
                fullTextGO.SetActive(false);
                stoppedTextGO.SetActive(false);
                machineIsFull = false;
            }
            else
            {
                kizakRunning = false;
                MachineStop();
                if (cannedCount >= productCountTotal)
                {
                    fullTextGO.SetActive(true);
                }
                stoppedTextGO.SetActive(true);
                machineIsFull = true;
            }
            if (!creatingActive)
            {
                foreach (var lst in productCollectionList)
                {
                    lst.productCollectActive = true;
                }
             
            }
            yield return new WaitForSeconds(0.1f);
            if (missionActive)
            {
                MissionManager.Instance.TapingLineMissionStart();
            }
        }
    }


    public bool bandActive = false;
    IEnumerator CannedCreator()
    {

        yield return new WaitForSeconds(0.1f);
        if (droppedCollectionList.Count > rawCountPerProduct - 1 && cannedCount < productCountTotal && !machineErrored)
        {
            if (otherRawStand != null)
            {
                if (otherRawStand.currentBandCount > 0 && bandActive)
                {
                    MachineActive();
                }
            }
            else
            {
                MachineActive();
            }
        }
        if (otherRawStand != null)
        {
            while (bandActive && otherRawStand.currentBandCount > 0 && droppedCollectionList.Count > rawCountPerProduct - 1 && cannedCount < productCountTotal && !machineErrored)
            {
                cannedCount++;
                Collectable raws = droppedCollectionList[droppedCollectionList.Count - 1];
                droppedCollectionList.Remove(droppedCollectionList[droppedCollectionList.Count - 1]);
                PlayerPrefs.SetInt(machineName + "rawcount" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);
                StartCoroutine(CreateCanned(raws));
                dropActive = false;
                fishCountCurrent += rawCountPerProduct;
                fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
                yield return new WaitForSeconds((waitTime / Globals.repairSpeedSkin) / speedFactor);
                workAreaList[0].StnadFullCheck();
                MissionManager.Instance.TapeBoxMissionStart();
                MissionManager.Instance.tapeBoxMission.MissionUpdate();

                if (PlayerPrefs.GetInt("level") == 0)
                {
                    Globals.myShareValue += 1;
                }
                else if (PlayerPrefs.GetInt("level") == 1)
                {
                    Globals.myShareValue += 3;
                }
                else
                {
                    Globals.myShareValue += 6;
                }
                PlayerPrefs.SetInt("myShareValue", Globals.myShareValue);
                FishDropArea.Instance.BoxPackageCounter();
                packageCount++;

                if (packageCount % bandPerPackageCount == 0)
                {
                    otherRawStand.currentBandCount--;
                    otherRawStand.CollectableCountSet();

                    if(otherRawStand.currentBandCount == 0)
                    {
                        bandActive = false;
                        otherRawStand.EmptyBand();
                    }
                }
            }
        }
        else
        {
            while (droppedCollectionList.Count > rawCountPerProduct - 1 && cannedCount < productCountTotal && !machineErrored)
            {
                cannedCount++;
                Collectable raws = droppedCollectionList[droppedCollectionList.Count - 1];
                droppedCollectionList.Remove(droppedCollectionList[droppedCollectionList.Count - 1]);
                PlayerPrefs.SetInt(machineName + "rawcount" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);
                StartCoroutine(CreateCanned(raws));
                dropActive = false;
                fishCountCurrent += rawCountPerProduct;
                fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
                yield return new WaitForSeconds((waitTime / Globals.repairSpeedSkin) / speedFactor);
                workAreaList[0].StnadFullCheck();
                MissionManager.Instance.TapeBoxMissionStart();
                if (MissionManager.Instance.tapeBoxMission.mission_Active)
                {
                    MissionManager.Instance.tapeBoxMission.gameObject.SetActive(true);
                }
                MissionManager.Instance.tapeBoxMission.MissionUpdate();

                if (PlayerPrefs.GetInt("level") == 0)
                {
                    Globals.myShareValue += 1;
                }
                else if (PlayerPrefs.GetInt("level") == 1)
                {
                    Globals.myShareValue += 3;
                }
                else
                {
                    Globals.myShareValue += 6;
                }
                PlayerPrefs.SetInt("myShareValue", Globals.myShareValue);
                FishDropArea.Instance.BoxPackageCounter();
            }
        }

        yield return new WaitForSeconds(2f);
        cannedCount = productCollectionList.Count;
        MachineStop();
        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }
  
    IEnumerator CreateCanned(Collectable raws)
    {


        foreach (var lst in productCollectionList)
        {
            lst.productCollectActive = true;
        }
        Vector3 firstPoss;
        Quaternion firstRots;
        Vector3 dropPoss;
        Quaternion targetRots;

        firstPoss = raws.transform.position;
        firstRots = raws.transform.rotation;

        dropPoss = fishInTR.transform.position;
        targetRots = fishInTR.transform.rotation;




        // go in position
        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 1f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);
            raws.transform.position = Vector3.Lerp(firstPoss, new Vector3(dropPoss.x, dropPoss.y + posY, dropPoss.z), counter);
            raws.transform.rotation = Quaternion.Lerp(firstRots, targetRots, counter);
       
            yield return null;
        }

        if (fishInTR_Second != null)
        {
            firstPoss = raws.transform.position;
            firstRots = raws.transform.rotation;

            counter = 0f;
            while (counter < 1f)
            {
                counter += 2 * Time.deltaTime;

                raws.transform.position = Vector3.Lerp(firstPoss, fishInTR_Second.transform.position, counter);
                raws.transform.rotation = Quaternion.Lerp(firstRots, fishInTR_Second.rotation, counter);

                yield return null;
            }
        }

        // go convert position
        firstPoss = raws.transform.position;
        firstRots = raws.transform.rotation;
      
        counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            raws.transform.position = Vector3.Lerp(firstPoss, converFishtoCannedTR.transform.position, counter);

            yield return null;
        }

        int prefabSelect = 0;
        float _speedFactor = 1f;

        machineAnimator.SetFloat("speed", speedFactor * _speedFactor);
        machineAnimator.SetTrigger("band");
        if (PlayerPrefs.GetInt("soundclose") == 0)
        {
            bandSoundAS.Play();
        }
        // converting
        Destroy(raws.gameObject, 0f);


        Vector3 firstPos = converFishtoCannedTR.position;
        Quaternion firstRot = converFishtoCannedTR.rotation;



        GameObject newProduct = Instantiate(productsPrefab[prefabSelect].gameObject, firstPos, firstRot);
        newProduct.GetComponent<Collectable>().collectActive = false;
        newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;

        newProduct.GetComponent<Collectable>().anim.SetTrigger("etiket");
        newProduct.GetComponent<Collectable>().anim.SetFloat("speed", speedFactor * _speedFactor);

        counter = 0f;

        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            newProduct.transform.position = Vector3.Lerp(firstPos, fishOutTR.transform.position, counter);

            yield return null;
        }
        firstPos = fishOutTR.position;

        newProduct.GetComponent<Collectable>().bantGO.SetActive(true);
        newProduct.GetComponent<Collectable>().bantGO.GetComponent<Animator>().SetFloat("speed", speedFactor * _speedFactor);
       counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            newProduct.transform.position = Vector3.Lerp(firstPos, outTR2.transform.position, counter);

            yield return null;
        }
        // converting finish


   


        StartCoroutine(GoBand(newProduct.GetComponent<Collectable>()));



        yield return new WaitForSeconds(1);
        newProduct.GetComponent<Collectable>().box.SetActive(false);
        newProduct.GetComponent<Collectable>().boxSinglePart.SetActive(true);
        //productCollectionList.Add(newProduct.GetComponent<Collectable>());
        //PlayerPrefs.SetInt(machineName + "col", productCollectionList.Count);
        //float deltaY = 0;

        //deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
        //Transform targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

        //Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);

        //StartCoroutine(GoCannedPos(newProduct.GetComponent<Collectable>(), targetTR, dropPos));
    }

    IEnumerator GoBand(Collectable box)
    {
        float moveSpeed = 6f;
        float rotSpeed = 8f;
        for(int i = 0; i < aiPath.aiNodes.Count; i++)
        {
            kizakRunning = true;
            while (Vector3.Distance( box.transform.position,aiPath.aiNodes[i].transform.position ) > 0.5f)
            {
                while (machineIsFull || machineErrored)
                {
                    yield return null;
                }
                Vector3 direction = (aiPath.aiNodes[i].transform.position - box.transform.position).normalized;


                Quaternion targetRotation = Quaternion.LookRotation(direction);
                box.transform.rotation = Quaternion.Slerp(box.transform.rotation, targetRotation, speedFactor * rotSpeed * Time.deltaTime);

                box.transform.Translate(box.transform.forward * moveSpeed * speedFactor * Time.deltaTime, Space.World);

                yield return null;
            }

        }
        kizakRunning = false;

        productCollectionList.Add(box);
        PlayerPrefs.SetInt(machineName + "col" + PlayerPrefs.GetInt("level"), productCollectionList.Count);
        float deltaY = 0;

        deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
        Transform targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 3f, 0);

        StartCoroutine(GoCannedPos(box, targetTR, dropPos));
    }
    //IEnumerator CreateCanned(List<Collectable> raws)
    //{
    //    if (missionActive)
    //    {
    //        if (_CollectProducts.CollectId >= 3)
    //        {
    //            MissionManager.Instance.MachineMission_Start(_CollectProducts.CollectId - 2);
    //        }
    //    }

    //    foreach (var lst in productCollectionList)
    //    {
    //        lst.productCollectActive = true;
    //    }
    //    Vector3[] firstPoss = new Vector3[raws.Count];
    //    Quaternion[] firstRots = new Quaternion[raws.Count];
    //    Vector3[] dropPoss = new Vector3[raws.Count];
    //    Quaternion[]  targetRots = new Quaternion[raws.Count];

    //    for (int i = 0; i < raws.Count; i++)
    //    {
    //        firstPoss[i] = raws[i].transform.position;
    //        firstRots[i] = raws[i].transform.rotation;

    //        dropPoss[i] = fishInTR.transform.position + new Vector3(0, i * 0.3f, 0);
    //        targetRots[i] = fishInTR.transform.rotation;
    //    }


    //    // go in position
    //    float angle = 0f;
    //    float posY = 0f;
    //    float psoY_Factor = 1f;
    //    float counter = 0f;
    //    while (counter < 1f)
    //    {
    //        counter += 4 * Time.deltaTime;

    //        angle = counter * Mathf.PI;
    //        posY = psoY_Factor * Mathf.Sin(angle);
    //        for (int i = 0; i < raws.Count; i++)
    //        {
    //            raws[i].transform.position = Vector3.Lerp(firstPoss[i], new Vector3(dropPoss[i].x, dropPoss[i].y + posY, dropPoss[i].z), counter);
    //            raws[i].transform.rotation = Quaternion.Lerp(firstRots[i], targetRots[i], counter);
    //        }
    //        yield return null;
    //    }



    //    // go convert position

    //    for (int i = 0; i < raws.Count; i++)
    //    {
    //        firstPoss[i] = raws[i].transform.position;
    //        firstRots[i] = raws[i].transform.rotation;
    //    }
    //    counter = 0f;
    //    while (counter < 1f)
    //    {
    //        counter += 4 * Time.deltaTime;

    //        for (int i = 0; i < raws.Count; i++)
    //        {
    //            raws[i].transform.position = Vector3.Lerp(firstPoss[i], converFishtoCannedTR.transform.position, counter);
    //        }
    //        yield return null;
    //    }

    //    int prefabSelect = 0;

    //    // converting
    //    for (int i = 0; i < raws.Count; i++)
    //    {
    //        Destroy(raws[i].gameObject, 1f);
    //    }

    //    Vector3 firstPos = converFishtoCannedTR.position;
    //    Quaternion firstRot = converFishtoCannedTR.rotation;



    //    GameObject newProduct = Instantiate(productsPrefab[prefabSelect].gameObject, firstPos, firstRot);
    //    newProduct.GetComponent<Collectable>().collectActive = false;
    //    newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;

    //    MissionManager.Instance.ProductMission_Start(_CollectProducts.CollectId - 2, (float)productPrefabs[0].price / 5);

    //    if (MissionManager.Instance.productMissionList[_CollectProducts.CollectId - 2].gameObject.activeInHierarchy)
    //    {
    //        MissionManager.Instance.productMissionList[_CollectProducts.CollectId - 2].MissionUpdateProduce(_CollectProducts.CollectId - 2);
    //    }
    //    MissionManager.Instance.SalingMission_Start(_CollectProducts.CollectId - 2, (float)productPrefabs[0].price / 5);

    //    MissionManager.Instance.StandMission_Start(_CollectProducts.CollectId - 2);

    //    if (_CollectProducts.CollectId >= 3)
    //    {
    //        MissionManager.Instance.MachineMission_Start(_CollectProducts.CollectId - 2);
    //    }


    //    counter = 0f;
    //    yield return null;
    //    while (counter < 1f)
    //    {
    //        counter += 4 * Time.deltaTime;
    //        newProduct.transform.position = Vector3.Lerp(firstPos, fishOutTR.transform.position, counter);

    //        yield return null;
    //    }
    //    // converting finish
    //    productCollectionList.Add(newProduct.GetComponent<Collectable>());
    //    PlayerPrefs.SetInt(machineName + "col", productCollectionList.Count);
    //    float deltaY = 0;

    //    deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
    //    Transform targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

    //    Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);

    //    StartCoroutine(GoCannedPos(newProduct.GetComponent<Collectable>(), targetTR, dropPos));
    //}
    IEnumerator GoCannedPos(Collectable newProduct, Transform targetTR, Vector3 dropPos)
    {

        Vector3 firstPos = newProduct.transform.position;
        Quaternion firstRot = newProduct.transform.rotation;

        Quaternion targetRot = targetTR.transform.rotation;

        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 1f;
        float counter = 0f;
        while (counter < 1f && !newProduct.isCollected)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            newProduct.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            newProduct.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        if (!newProduct.isCollected)
        {
            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;
        }
        yield return new WaitForSeconds(0.2f);
        newProduct.productCollectActive = true;
        TraySet();

        //icedFish.collectActive = true;

    }
    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        //if (droppedCollectionList.Count == 0)
        //{
        //    StartCoroutine(CannedCreator());
        //}
        if (collectAmount > 0 && fishCountCurrent > 0 && _stackCollect.collectionTrs[0] != null)
        {
            //VibratoManager.Instance.MediumMultiVibration();
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
                    if (collectType2 == CollectType.All || collectType == CollectType.All || _stackCollect.collectionTrs[i].collectType == collectType || _stackCollect.collectionTrs[i].collectType == collectType2)
                    {
                        droppingCollection = _stackCollect.collectionTrs[i];
                        i = _stackCollect.collectionTrs.Count;
                        break;
                    }

                }
            }
        }
        Collectable deletedCollect = droppingCollection;

        _stackCollect.collectionTrs.Remove(deletedCollect);



        droppedCollectionList.Add(droppingCollection);
        PlayerPrefs.SetInt(machineName + "rawcount" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);

        yield return null;
        droppingCollection.collectActive = false;
        float deltaY = 0;
        deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;

        Transform targetTR;
        if(droppedCollectionList.Count == 0)
        {
            targetTR = fishPosTR[0];
        }
        else
        {
            targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];
        }
        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
        StartCoroutine(Drop(targetTR, dropPos, droppingCollection, Time.deltaTime));
        if (_stackCollect.player)
        {
            VibratoManager.Instance.LightVibration();
            AudioManager.Instance.StackDropSound();
        }


        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
        foreach (var wrkArea in workAreaList)
        {
            wrkArea.ShuffleStandList();
            wrkArea.ShuffleCollectProductList();
        }
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {
        collectable.isCollected = false;

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


        Quaternion targetAngle = dropPosTR.rotation;

        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;

            angle = timeCounter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, targetAngle, timeCounter);
            }
            yield return null;
        }
        collectable.transform.position = dropPos;


    }



    void ResetStand()
    {
        StartCoroutine(ResetDelay());
        Debug.Log("reset");
    }
    IEnumerator ResetDelay()
    {
        //DropMoney();
        StandActive = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(1f);
        droppedCollectionList.Clear();
        yield return new WaitForSeconds(0.1f);
        TextInit();
    }
    public void ManuealRawCreate()
    {
        StartCoroutine(ManuealRawCreator());
    }
    IEnumerator ManuealRawCreator()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "rawcount" + PlayerPrefs.GetInt("level")); i++)
        {
            GameObject newProduct = Instantiate(rawPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = droppedCollectionList;
            newProduct.GetComponent<Collectable>().InitInstancedMaterial();

            newProduct.GetComponent<Collectable>().box.SetActive(false);
            newProduct.GetComponent<Collectable>().boxSinglePart.SetActive(true);

            droppedCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
            targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;
            fishCountCurrent -= 1;
            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            yield return null;
        }
    }
    public void ManuealProductCreate()
    {
        StartCoroutine(ManuealProductCreator());
    }
    IEnumerator ManuealProductCreator()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col" + PlayerPrefs.GetInt("level")); i++)
        {
            GameObject newProduct = Instantiate(productPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;
            newProduct.GetComponent<Collectable>().anim.SetTrigger("etiket");
            newProduct.GetComponent<Collectable>().anim.SetFloat("speed" , 1);
            newProduct.GetComponent<Collectable>().bantGO.SetActive(true);
            newProduct.GetComponent<Collectable>().bantGO.GetComponent<Animator>().SetFloat("speed", 1);
            newProduct.GetComponent<Collectable>().InitInstancedMaterial();

            newProduct.GetComponent<Collectable>().box.SetActive(false);
            newProduct.GetComponent<Collectable>().boxSinglePart.SetActive(true);

            productCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
            targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 3f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;

            yield return null;
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            TraySet();
        }
    }



    public void ManuealProductCreateTutorial()
    {
        StartCoroutine(ManuealProductCreatorTut());
    }
    IEnumerator ManuealProductCreatorTut()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < 5; i++)
        {
            GameObject newProduct = Instantiate(productPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;
            newProduct.GetComponent<Collectable>().anim.SetTrigger("etiket");
            newProduct.GetComponent<Collectable>().anim.SetFloat("speed", 1);

            newProduct.GetComponent<Collectable>().bantGO.SetActive(true);
            newProduct.GetComponent<Collectable>().bantGO.GetComponent<Animator>().SetFloat("speed", 1);
            newProduct.GetComponent<Collectable>().InitInstancedMaterial();

            productCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
            targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 3f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;

            yield return null;
            newProduct.GetComponent<Collectable>().productCollectActive = true;
            TraySet();
        }
    }

    public void UpgradeValueInit()
    {
        UpgradeTextSpawn();
        CapacityInit();
    }
    void CapacityInit()
    {
        fishCountTotal = capacitiesRaw[standLevel];
        productCountTotal = capacitiesProduct[standLevel];
        fishCountCurrent = capacitiesRaw[standLevel] - droppedCollectionList.Count;
        speedFactor = speedFactors[standLevel];

        if (otherRawStand != null)
        {
            //bandPerPackageCount = bandPerPackCount[standLevel];
            otherRawStand.maxBandCapacity = standLevel + 5;
            otherRawStand.bandStock.fishCountTotal = standLevel + 5;
            otherRawStand.bandStock.productCountTotal = standLevel + 5;
        }
        fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();

    }

    public void TraySet()
    {
        int trayCount = (productCollectionList.Count) / productPosTR.Length;

        if (trayCount > trayList.Count)
        {
            trayCount = trayList.Count;
        }
        for (int i = 0; i < trayList.Count; i++)
        {
            if (i < trayCount)
            {
                trayList[i].SetActive(true);
            }
            else
            {
                trayList[i].SetActive(false);
            }
        }
        //for (int i = 0; i < trayCount; i++)
        //{
        //    trayList[i].SetActive(true);
        //}
    }
    [SerializeField] GameObject pointText;
    [SerializeField] GameObject confettiParticles;
    [SerializeField] Transform textSpawnPos;
    [SerializeField] Transform confettiSpawnPos;

    public void UpgradeTextSpawn()
    {
        string[] upgradeNames = { "+Capacity", "+Speed" };
        int upgradeNameSelect = 0;

        upgradeNameSelect = Random.Range(0, upgradeNames.Length);

        Text3D pnt = Instantiate(pointText, textSpawnPos.position, textSpawnPos.rotation).GetComponent<Text3D>();
        pnt.transform.localScale *= 1.5f;
        pnt.PointInit(upgradeNames[upgradeNameSelect]);
        GameObject confetti = Instantiate(confettiParticles, confettiSpawnPos.position, confettiSpawnPos.rotation);
        Destroy(confetti, 5f);
    }
}