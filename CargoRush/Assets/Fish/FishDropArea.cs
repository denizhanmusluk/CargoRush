using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Cinemachine;
using UnityEngine.UI;

[System.Serializable]
public struct productType
{
    public List<Collectable> productList;
}

public class FishDropArea : MonoBehaviour
{
    private static FishDropArea _instance = null;
    public static FishDropArea Instance => _instance;
    [SerializeField] CinemachineVirtualCamera productViewCamera;
    //public float createPeriod = 1f;
    public float[] createPeriodTime;
    public float reactiveRate = 1f;
   [SerializeField] float reactiveRateCurrent = 1f;

    public GameObject[] garbagePrefabs;
    public Transform[] fishPosTR;
    public Transform[] gemPosTR;
    public List<Collectable> fishCollectable;
    int posNo = 0;
    int gemPosNo = 0;
    public bool targetActive = true;
    public int requirementCount = 0;
    public int collectLevel;
    [SerializeField] CollectProduct _CollectProduct;
    public List<Stand> standList;
    public List<CollectProduct> CollectProductList;
    [SerializeField] BigAquarium bigAquarium;
    public List<Collectable> collectableList;

    public GameObject gemCollectable;

    public Transform createPos, forceDirPos;
    public List<Transform> createPosList = new List<Transform>();
    public List<Transform> firstCreatePosList = new List<Transform>();

    public int totalProductCapacity = 50;

   public List<productType> proType = new List<productType>();
    public MineCrusher mineCrusher;
    public List<GameObject> wallListGO = new List<GameObject>();
    bool colliderResetActive = true;
    //[SerializeField] int gemCreatePerDropCount;
    int dropCount = 0;

    public bool[] productDropActive = new bool[4];

    public List<StandFishCar> carSlotList = new List<StandFishCar>();

    int extraProduct = 0;

    public Image errorFill;


    public GameObject loadingAreaTextGO;
    private void Awake()
    {
        _instance = this;

        for(int i = 0; i < productDropActive.Length; i++)
        {
            productDropActive[i] = true;
        }
    }
    public void ReactiveActivator()
    {
        StartCoroutine(ReactiveActivatorDelay());
    }
    IEnumerator ReactiveActivatorDelay()
    {
        createTime = 0.1f;
        reactiveRateCurrent = 1;
        extraProduct = 75;
        yield return new WaitForSeconds(2f);
        reactiveRateCurrent = reactiveRate;
        yield return new WaitForSeconds(5f);
        extraProduct = 0;
    }
    public void WallColliderReset()
    {
        if (colliderResetActive)
        {
            StartCoroutine(WallCollReset());
        }
    }
    IEnumerator WallCollReset()
    {
        colliderResetActive = false;
        foreach (GameObject wall in wallListGO)
        {
            wall.GetComponent<BoxCollider>().isTrigger = true;
        }
        yield return new WaitForSeconds(2f);
        foreach (GameObject wall in wallListGO)
        {
            wall.GetComponent<BoxCollider>().isTrigger = false;
        }
        colliderResetActive = true;
    }
    void Start()
    {
        errorFill = CollectProgressManager.Instance.errorFill;

        createTime = createPeriodTime[mineCrusher.standLevel];
        _CollectProduct.collectables = fishCollectable;
        //FishManager.Instance.rubbishDropArea = this;
        //IndicatorManager.Instance._FishDropAreaList.Add(this);
        CollectProductList.Add(_CollectProduct);
        //_CollectProduct._FishDropArea = this;

        if (PlayerPrefs.GetInt("firstcreateproduct") == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                GarbageCreate(0);
            }
            PlayerPrefs.SetInt("firstcreateproduct", 1);
        }
        else
        {
            StartCoroutine(GarbageDropping());
        }
        //CarSlotsReset();
        StartCoroutine(StartDelay());
    }
   [SerializeField] float createTime;
    public void GarbageDroppingAfterTutorial()
    {
        StartCoroutine(GarbageDropping());
    }
    IEnumerator GarbageDropping()
    {
        while (true)
        {
            //int garbageSelect = Random.Range(0, garbagePrefabs.Length);

            while ((Globals.collectableLevel + 1) * totalProductCapacity + extraProduct <= collectableList.Count)
            {
                createTime = createPeriodTime[mineCrusher.standLevel];

                while ((float)(Globals.collectableLevel + 1) * (float)totalProductCapacity * reactiveRateCurrent + 1 < collectableList.Count)
                {
                    createTime = 0.1f;

                    Globals.productCollectWorkerActive = true;

                    yield return new WaitForSeconds(1f);
                }

                yield return new WaitForSeconds(1f);
            }

            int garbageSelect = LeastIdCheck();
            if (productDropActive[garbageSelect])
            {
                Globals.productCollectWorkerActive = false;
                GarbageCreate(garbageSelect);
            }
            yield return new WaitForSeconds(createTime);
        }
    }
    int LeastIdCheck()
    {
        int minId = 0;
        int count = 0;
        if (collectableList.Count > 0)
        {
            count = proType[0].productList.Count;
            for (int i = 0; i <= Globals.collectableLevel; i++)
            {
                if (proType[i].productList.Count < count && productDropActive[i])
                {
                    count = proType[i].productList.Count;
                    minId = i;
                }
            }
        }
        return minId;
    }
    public void GarbageCreate(int id)
    {
        dropCount++;
        int createPosSelect = Random.Range(0, createPosList.Count);
        //if (PlayerPrefs.GetInt("firstcreateproduct") == 0)
        //{
        //    createPosSelect = createPosList.Count - 1;
        //}
        Collectable _fishCollect;
        GameObject fsh;

        if (PlayerPrefs.GetInt("firstcreateproduct") == 0)
        {
            fsh = Instantiate(garbagePrefabs[id], firstCreatePosList[dropCount % firstCreatePosList.Count].position, Quaternion.identity);
        }
        else 
        {
            fsh = Instantiate(garbagePrefabs[id], createPosList[createPosSelect].position, Quaternion.identity);
        }
        //GameObject fsh = Instantiate(garbagePrefabs[id], fishPosTR[posNo % fishPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        posNo++;

        _fishCollect = fsh.GetComponent<Collectable>();
        _fishCollect.collectActive = true;
        collectableList.Add(_fishCollect);
        _fishCollect.collectableList = collectableList;

        proType[id].productList.Add(_fishCollect);

        if (fsh.GetComponent<Collector>() != null)
        {
            //Vector3 forceDir = (forceDirPos.position - createPos.position).normalized;
            Vector3 forceDir = (-createPosList[createPosSelect].up).normalized;
            fsh.GetComponent<Collector>().FirstPush(forceDir);
        }
        //if (dropCount % gemCreatePerDropCount == 0)
        //{
        //    GemCreating();
        //}
    }
    public void GemCreating()
    {
        int createPosSelect = Random.Range(0, createPosList.Count);
        Collectable _fishCollect;
        GameObject fsh = Instantiate(gemCollectable, createPosList[createPosSelect].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);

        _fishCollect = fsh.GetComponent<Collectable>();
        _fishCollect.collectActive = true;
        collectableList.Add(_fishCollect);
        _fishCollect.collectableList = collectableList;


        if (fsh.GetComponent<Collector>() != null)
        {
            //Vector3 forceDir = (forceDirPos.position - createPos.position).normalized;
            Vector3 forceDir = (-createPosList[createPosSelect].up).normalized;
            fsh.GetComponent<Collector>().FirstPush(forceDir);
        }
    }

    public void GemCreating2()
    {
        GameObject fsh = Instantiate(gemCollectable, gemPosTR[gemPosNo % gemPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, 0, 0);
        gemPosNo++;
    }
    public void BigFishCreate(int fishID)
    {
        Collectable _fishCollect;
        GameObject fsh = Instantiate(garbagePrefabs[fishID], fishPosTR[posNo % fishPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        posNo++;

        _fishCollect = fsh.GetComponent<Collectable>();

        //_fishCollect.fishArea = this;
        fishCollectable.Add(_fishCollect);
        _fishCollect.fishCollectable = fishCollectable;

        if(_fishCollect.GetComponent<BigFish>() != null)
        {
            _fishCollect.GetComponent<BigFish>().bigAquarium = bigAquarium;
        }
    }

    public void TargetArrived(AIWorker aiWorker)
    {
        StartCoroutine(Staying(aiWorker));
    }
    IEnumerator Staying(AIWorker character)
    {
        //character.aiPopUp.OpenOperationPopUp(5);
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        //character.aiPopUp.ClosedAllPopUp();

        if (character.followActive)
        {
            character.TargetFishStandSelect();
        }
        yield return new WaitForSeconds(1f);

        //targetActive = true;
    }

    public void ShuffleList()
    {
        List<Stand> sortedList = standList.OrderBy(x => (x.fishCountCurrent)).ToList();
        standList = sortedList;
        //Shuffle(standList);
    }

    public void DeleteErrorProduct(int productID)
    {
        for (int i = 0; i < proType[productID].productList.Count; i++)
        {
            collectableList.Remove(proType[productID].productList[i]);
            Destroy(proType[productID].productList[i].gameObject);
        }
        proType[productID].productList.Clear();
    }



    public void CarSlotsReset()
    {
        foreach(var carSlot in carSlotList)
        {
            for(int i = 0; i < productDropActive.Length && i < carSlot.productTypeCount.Length; i++)
            {
                if (!productDropActive[i] && carSlot.productTypeCount[i] > 0)
                {
                    carSlot.ResetStand();
                    break;
                }

            }
        }
    }

    public void NewProductActive(string newProductName)
    {
        StartCoroutine(ViewCamera(newProductName));
    }
    IEnumerator ViewCamera(string newProductName)
    {
        TutorialManager.Instance.newProductTutorialGO.SetActive(true);
        TutorialManager.Instance.newProducttext.text = newProductName;
        productViewCamera.Priority = 2;
        yield return new WaitForSeconds(5f);
        productViewCamera.Priority = 0;
        TutorialManager.Instance.newProductTutorialGO.SetActive(false);
    }


    int errorCounter = 0;

    public List<IMachineActive> packMachines = new List<IMachineActive>();
    public void BoxPackageCounter()
    {
        if (Globals.repairManActive)
        {
            PlayerPrefs.SetInt("totalboxpackagecount", 1);
        }
        else
        {
            PlayerPrefs.SetInt("totalboxpackagecount", PlayerPrefs.GetInt("totalboxpackagecount") + 1);
            //if (Globals.machineErrorActive)
            //{
            //    errorFill.fillAmount = 1f;
            //}
            //else
            {
                errorFill.fillAmount = (float)(PlayerPrefs.GetInt("totalboxpackagecount") % ((Globals.collectableLevel + 1) * 125)) / (float)((Globals.collectableLevel + 1) * 125);
            }
            if (PlayerPrefs.GetInt("totalboxpackagecount") % ((Globals.collectableLevel + 1) * 125) == 0)
            {

                List<IMachineActive> packMachinesTemp = new List<IMachineActive>();

                for (int i = 0; i < packMachines.Count; i++)
                {
                    if (!packMachines[i].errorActive)
                    {
                        packMachinesTemp.Add(packMachines[i]);
                    }
                }
                if (packMachinesTemp.Count > 0)
                {
                    int randomSelectMach = errorCounter % packMachinesTemp.Count;
                    packMachinesTemp[randomSelectMach].MachineErrored();
                    PlayerPrefs.SetInt("machineerrorcount", PlayerPrefs.GetInt("machineerrorcount") + 1);

                    if(PlayerPrefs.GetInt("machineerrorcount") == 2)
                    {
                        RepairManager.Instance.OpenRepairWorker();
                    }
                }


                errorCounter++;
            }
        }
    }
    int boxPackCount = 0;

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(4f);
        errorFill.fillAmount = (float)(PlayerPrefs.GetInt("totalboxpackagecount") % ((Globals.collectableLevel + 1) * 125)) / (float)((Globals.collectableLevel + 1) * 125);
    }
    public void RepairProgressSet()
    {
        StartCoroutine(RepairDelay());
    }
    IEnumerator RepairDelay()
    {
        float counter = 0f;
        float value;
        while(counter < 1f)
        {
            counter += Time.deltaTime;
            value = Mathf.Lerp(1f, 0f, counter);
            errorFill.fillAmount = value;
           yield return null;
        }
    }
    public void AllMachineRepair()
    {
        foreach(var mch in packMachines)
        {
            mch.MachineRepaired();
        }
    }
}
