using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessMachineDoubleRaw : Stand
{
    [SerializeField] Transform fishInTR, converFishtoCannedTR, fishOutTR;

    [SerializeField] Transform otherIn1;
    public Collectable[] productsPrefab;

    public Transform[] fishPosTR;


    public Transform[] productPosTR;


    public List<Collectable> productCollectionList = new List<Collectable>();


    [SerializeField] CollectProduct _CollectProducts;
    [SerializeField] Animator machineAnimator;
    [SerializeField] public List<CollectProduct> _CollectProductStands;
    [SerializeField] int extraCustomerCount;

    [SerializeField] GameObject fullTextGO;


    public Stand otherRawStand;


    public int rawCountPerProduct = 1;
    public int otherRawCountPerProduct = 1;
    public Collectable[] rawPrefabs;
    public Collectable[] productPrefabs;
    public int machineId;
    public bool missionActive = true;

    public int machineLevel;
    public override void CollectableCountSet()
    {
        PlayerPrefs.SetInt(machineName + "rawcount", droppedCollectionList.Count);
        PlayerPrefs.SetInt(machineName + "col", productCollectionList.Count);

    }
    public override void SpecificStart()
    {
        IndicatorManager.Instance.machines.Add(this);
        if (PlayerPrefs.GetInt(machineName + "firstopen") == 0)
        {
            Globals.machineLevel = machineLevel;
            PlayerPrefs.SetInt("machineLevel", Globals.machineLevel);

            if (HRUpgradeManager.Instance.HRWorkerGO != null)
            {       
                HRUpgradeManager.Instance.InitButtonValues();
                HRUpgradeManager.Instance.HRWorkerGO.SetActive(true);

                //if (PlayerPrefs.GetInt("workerNoLevel") <= Globals.machineLevel)
                //{
                //    HRUpgradeManager.Instance._upgradeAreaWorkers.workerBuyAreaList[PlayerPrefs.GetInt("workerNoLevel")].gameObject.SetActive(true);
                //}
            }
            PlayerPrefs.SetInt(machineName + "firstopen", 1);
            //PopUpManager.Instance.PopUpOpen(machineId);
        }
        if (collectType == CollectType.Type1)
        {
            Globals.productType1 = true;
        }
        if (collectType == CollectType.Type4)
        {
            Globals.productType4 = true;
        }
        if (collectType == CollectType.Type3)
        {
            Globals.productType3 = true;
        }
        if (collectType == CollectType.Type2)
        {
            Globals.productType2 = true;
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
        //if (PlayerPrefs.GetInt("minecrushmach") == 0)
        //{
        //    PlayerPrefs.SetInt("minecrushmach", 1);
        //    IndicatorManager.Instance.IndicatorTargeterActive();
        //    mineCrusher.ManuealGemCreate();
        //}
        foreach (var stands in _CollectProductStands)
        {
            stands.machineActive = true;
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
        machineAnimator.SetBool("kizak", true);
        machineActive = true;
    }
    void MachineStop()
    {
        machineAnimator.SetBool("kizak", false);
        machineActive = false;
    }
    IEnumerator CreatorChecking()
    {
        creatingActive = false;
        while (!creatingActive)
        {
            if (cannedCount < productCountTotal)
            {
                creatingActive = true;

                StartCoroutine(CannedCreator());
                fullTextGO.SetActive(false);
            }
            else
            {
                fullTextGO.SetActive(true);
            }
            if (!creatingActive)
            {
                foreach (var lst in productCollectionList)
                {
                    lst.productCollectActive = true;
                }

            }
            yield return new WaitForSeconds(0.1f);
        }
    }



    IEnumerator CannedCreator()
    {

        yield return new WaitForSeconds(0.1f);
        if (otherRawStand.droppedCollectionList.Count > otherRawCountPerProduct - 1 && droppedCollectionList.Count > rawCountPerProduct - 1 && cannedCount < productCountTotal)
        {
            MachineActive();
        }

        while (otherRawStand.droppedCollectionList.Count > otherRawCountPerProduct - 1 && droppedCollectionList.Count > rawCountPerProduct - 1 && cannedCount < productCountTotal)
        {
            // MinesDropAreaCheck();
            //CheckMinePNG();
            //creatingActive = true;
            cannedCount++;



            List<Collectable> raws = new List<Collectable>();
            for (int i = 0; i < rawCountPerProduct; i++)
            {
                raws.Add(droppedCollectionList[droppedCollectionList.Count - 1]);
                droppedCollectionList.Remove(droppedCollectionList[droppedCollectionList.Count - 1]);
                PlayerPrefs.SetInt(machineName + "rawcount", droppedCollectionList.Count);
            }

            List<Collectable> rawsOther = new List<Collectable>();
            for (int i = 0; i < otherRawCountPerProduct; i++)
            {
                raws.Add(otherRawStand.droppedCollectionList[otherRawStand.droppedCollectionList.Count - 1]);
                otherRawStand.droppedCollectionList.Remove(otherRawStand.droppedCollectionList[otherRawStand.droppedCollectionList.Count - 1]);
                otherRawStand.CollectableCountSet();
            }

            StartCoroutine(CreateCanned(waitTime, raws, rawsOther));
            dropActive = false;
            fishCountCurrent += rawCountPerProduct;
            otherRawStand.fishCountCurrent += otherRawCountPerProduct;
            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            otherRawStand.fishCountText.text = (otherRawStand.fishCountTotal - otherRawStand.fishCountCurrent).ToString() + "/" + (otherRawStand.fishCountTotal).ToString();
            yield return new WaitForSeconds(waitTime / Globals.machineSpeedSkin);
            workAreaList[0].StnadFullCheck();
        }
        //  MinesDropAreaCheck();
        yield return new WaitForSeconds(2f);
        cannedCount = productCollectionList.Count;
        MachineStop();
        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }


    IEnumerator CreateCanned(float waitTime, List<Collectable> raws, List<Collectable> rawsOther)
    {



        foreach (var lst in productCollectionList)
        {
            lst.productCollectActive = true;
        }
        Vector3[] firstPoss = new Vector3[raws.Count];
        Quaternion[] firstRots = new Quaternion[raws.Count];

        Vector3[] dropPoss = new Vector3[raws.Count];
        Quaternion[] targetRots = new Quaternion[raws.Count];


        Vector3[] firstPossOther = new Vector3[rawsOther.Count];
        Quaternion[] firstRotsOther = new Quaternion[rawsOther.Count];

        Vector3[] dropPossOther = new Vector3[rawsOther.Count];
        Quaternion[] targetRotsOther = new Quaternion[rawsOther.Count];

        for (int i = 0; i < raws.Count; i++)
        {
            firstPoss[i] = raws[i].transform.position;
            firstRots[i] = raws[i].transform.rotation;

            dropPoss[i] = fishInTR.transform.position + new Vector3(0, i * 0.3f, 0);
            targetRots[i] = fishInTR.transform.rotation;
        }

        for (int i = 0; i < rawsOther.Count; i++)
        {
            firstPossOther[i] = rawsOther[i].transform.position;
            firstRotsOther[i] = rawsOther[i].transform.rotation;

            dropPossOther[i] = otherIn1.transform.position + new Vector3(0, (i + raws.Count) * 0.3f, 0);
            targetRotsOther[i] = otherIn1.transform.rotation;
        }



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
            for (int i = 0; i < raws.Count; i++)
            {
                raws[i].transform.position = Vector3.Lerp(firstPoss[i], new Vector3(dropPoss[i].x, dropPoss[i].y + posY, dropPoss[i].z), counter);
                raws[i].transform.rotation = Quaternion.Lerp(firstRots[i], targetRots[i], counter);
            }

            for (int i = 0; i < rawsOther.Count; i++)
            {
                rawsOther[i].transform.position = Vector3.Lerp(firstPossOther[i], new Vector3(dropPossOther[i].x, dropPossOther[i].y + posY, dropPossOther[i].z), counter);
                rawsOther[i].transform.rotation = Quaternion.Lerp(firstRotsOther[i], targetRotsOther[i], counter);
            }
            //fish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            //fish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }



        // go convert position

        //firstPos = fish.transform.position;
        for (int i = 0; i < raws.Count; i++)
        {
            firstPoss[i] = raws[i].transform.position;
            firstRots[i] = raws[i].transform.rotation;
        }

        for (int i = 0; i < rawsOther.Count; i++)
        {
            firstPossOther[i] = rawsOther[i].transform.position;
            firstRotsOther[i] = rawsOther[i].transform.rotation;
        }
        counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;

            for (int i = 0; i < raws.Count; i++)
            {
                raws[i].transform.position = Vector3.Lerp(firstPoss[i], converFishtoCannedTR.transform.position, counter);
            }

            for (int i = 0; i < rawsOther.Count; i++)
            {
                rawsOther[i].transform.position = Vector3.Lerp(firstPossOther[i], converFishtoCannedTR.transform.position, counter);
            }
            yield return null;
        }

        int prefabSelect = 0;
        //for (int i = 0; i < productsPrefab.Length; i++)
        //{
        //    if (productsPrefab[i].collectType == fish.collectType)
        //    {
        //        prefabSelect = i;
        //        break;
        //    }
        //}

        // converting
        for (int i = 0; i < raws.Count; i++)
        {
            raws[i].gameObject.SetActive(false);
            Destroy(raws[i].gameObject, 1f);
        }
        for (int i = 0; i < rawsOther.Count; i++)
        {
            rawsOther[i].gameObject.SetActive(false);
            Destroy(rawsOther[i].gameObject, 1f);
        }


        //Vector3 firstScale = fish.transform.localScale;
        Vector3 firstPos = converFishtoCannedTR.position;
        Quaternion firstRot = converFishtoCannedTR.rotation;



        GameObject newProduct = Instantiate(productsPrefab[prefabSelect].gameObject, firstPos, firstRot);
        newProduct.GetComponent<Collectable>().collectActive = false;
        newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;

  
        //MissionManager.Instance.saleMissionList[_CollectProducts.CollectId - 2].MissionUpdateProduce(_CollectProducts.CollectId - 2);


        //newProduct.GetComponent<Collectable>().fishCollectable = cannedCollectionList;


        counter = 0f;
        yield return null;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            newProduct.transform.position = Vector3.Lerp(firstPos, fishOutTR.transform.position, counter);

            yield return null;
        }
        // converting finish
        productCollectionList.Add(newProduct.GetComponent<Collectable>());
        PlayerPrefs.SetInt(machineName + "col", productCollectionList.Count);

        float deltaY = 0;

        deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
        Transform targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);

        StartCoroutine(GoCannedPos(newProduct.GetComponent<Collectable>(), targetTR, dropPos));
        //newProduct.transform.localScale = firstScale;


    }
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
            PlayerPrefs.SetInt(machineName + "rawcount", droppedCollectionList.Count);

            yield return null;
            droppingCollection.collectActive = false;
            float deltaY = 0;
            deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
            Transform targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollection, Time.deltaTime));
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
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
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "rawcount"); i++)
        {
            GameObject newProduct = Instantiate(rawPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = droppedCollectionList;

            droppedCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
            targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
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
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col"); i++)
        {
            GameObject newProduct = Instantiate(productPrefabs[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = productCollectionList;

            productCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (productCollectionList.Count - 1) / productPosTR.Length;
            targetTR = productPosTR[(productCollectionList.Count - 1) % productPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;
        
           
            yield return null;
            newProduct.GetComponent<Collectable>().productCollectActive = true;
        }
    }
}