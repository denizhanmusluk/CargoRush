using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCanned : Stand
{
    [SerializeField] Transform fishInTR, converFishtoCannedTR, fishOutTR;
    public Collectable[] productsPrefab;
    public Transform[] fishPosTR;
    public Transform[] silverProductPosTR;
    public Transform[] goldProductPosTR;
    public Transform[] diamondProductPosTR;

    public List<Collectable> silverCollectionList = new List<Collectable>();
    public List<Collectable> goldCollectionList = new List<Collectable>();
    public List<Collectable> diamondCollectionList = new List<Collectable>();

    [SerializeField] List<CollectProduct> _CollectProducts;
    [SerializeField] Animator machineAnimator;
    [SerializeField] CollectProduct _CollectProductRaf;
    bool machineActive = false;
    [SerializeField] List<StandFishCar> standFishCarList;
    [SerializeField] GameObject fullTextGO;

    bool goldAreaOpener = true;
    bool diamondAreaOpener = true;
    [SerializeField] List<Transform> L2list;
    [SerializeField] List<Transform> L3list;
    //void CheckMinePNG()
    //{
    //    BG1.SetActive(true);
    //    BG2.SetActive(false);
    //    BG3.SetActive(false);

    //    mine1.SetActive(true);
    //    mine2.SetActive(false);
    //    mine3.SetActive(false);

    //    if (PlayerPrefs.GetInt("buygoldrayon" + Globals.currentLevelIndex.ToString()) == 1)
    //    {
    //        BG1.SetActive(false);
    //        BG2.SetActive(true);
    //        BG3.SetActive(false);

    //        mine1.SetActive(true);
    //        mine2.SetActive(true);
    //        mine3.SetActive(false);
    //    }
    //    if (PlayerPrefs.GetInt("buydiamondrayon" + Globals.currentLevelIndex.ToString()) == 1)
    //    {
    //        BG1.SetActive(false);
    //        BG2.SetActive(false);
    //        BG3.SetActive(true);

    //        mine1.SetActive(true);
    //        mine2.SetActive(true);
    //        mine3.SetActive(true);
    //    }

    //}
    public MineCrusher mineCrusher;

    public override void CollectableCountSet()
    {

    }
    public override void SpecificStart()
    {
        _CollectProducts[0].collectables = silverCollectionList;
        _CollectProducts[1].collectables = goldCollectionList;
        _CollectProducts[2].collectables = diamondCollectionList;

        //StandManager.Instance.standList.Add(this);
        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);
            for (int i = 0; i < _CollectProducts.Count; i++)
            {
                wrkArea.CollectProductList.Add(_CollectProducts[_CollectProducts.Count - i - 1]);
            }
        }

        StandReActive();
        FishCountInit();
        //_CollectProductRaf.machineActive = true;
        StartCoroutine(CreatorChecking());
        StandCarCollectIdSet();
        MinesDropAreaCheck();
        //mineCrusher.ManuealGemCreate();

        //if (PlayerPrefs.GetInt("minecrushmach") == 0)
        //{
        //    PlayerPrefs.SetInt("minecrushmach", 1);
        //    IndicatorManager.Instance.IndicatorTargeterActive();
        //    mineCrusher.ManuealGemCreate();
        //}
    }
    void StandCarCollectIdSet()
    {
        //foreach (var car in standFishCarList)
        //{
        //    car.collectIDList[0] = _CollectProducts[0].CollectId;
        //}
    }
    void FishCountInit()
    {
        FishManager.Instance.fishCount[1] += fishCountTotal * 2;
    }
    public override void SpecificReset()
    {
        //ResetStand();
    }
    bool creatingActive = false;
    void MachineActive()
    {
        machineAnimator.SetBool("kizak", true);
    }
    void MachineStop()
    {
        machineAnimator.SetBool("kizak", false);
    }
    IEnumerator CreatorChecking()
    {
        //CheckMinePNG();
        creatingActive = false;
        while (!creatingActive)
        {
            if (cannedCount < productCountTotal)
            {
                //yield return new WaitForSeconds(0.1f);
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
                foreach (var lst in silverCollectionList)
                {
                    lst.productCollectActive = true;
                }
                foreach (var lst in goldCollectionList)
                {
                    lst.productCollectActive = true;
                }
                foreach (var lst in diamondCollectionList)
                {
                    lst.productCollectActive = true;
                }
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    //public void CannedCountSet()
    //{
    //    cannedCount = cannedCollectionList.Count;
    //}

    IEnumerator CannedCreator()
    {
        MinesDropAreaCheck();

        yield return new WaitForSeconds(0.1f);
        if (droppedCollectionList.Count > 0 && cannedCount < productCountTotal)
        {
            MachineActive();
        }

        //float waitTime = 1f;
        while (droppedCollectionList.Count > 0 && cannedCount < productCountTotal)
        {
            MinesDropAreaCheck();
            //CheckMinePNG();
            machineActive = true;
            //creatingActive = true;
            cannedCount++;
            Collectable fish = droppedCollectionList[droppedCollectionList.Count - 1];
            droppedCollectionList.Remove(droppedCollectionList[droppedCollectionList.Count - 1]);
            StartCoroutine(CreateCanned(waitTime, fish));
            dropActive = false;
            fishCountCurrent++;
            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            yield return new WaitForSeconds(waitTime);

        }
        MinesDropAreaCheck();
        machineActive = false;
        yield return new WaitForSeconds(3f);
        cannedCount = silverCollectionList.Count + goldCollectionList.Count + diamondCollectionList.Count;
        MachineStop();
        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }

    void MinesDropAreaCheck()
    {
        if (PlayerPrefs.GetInt("buygoldrayon" + Globals.currentLevelIndex.ToString()) == 1)
        {
            if (goldAreaOpener)
            {
                goldAreaOpener = false;
                _CollectProducts[0].gameObject.SetActive(true);
                _CollectProducts[1].gameObject.SetActive(true);
                _CollectProducts[0].transform.position = L2list[0].position;
                _CollectProducts[1].transform.position = L2list[1].position;
            }
        }
        if (PlayerPrefs.GetInt("buydiamondrayon" + Globals.currentLevelIndex.ToString()) == 1)
        {
            if (diamondAreaOpener)
            {
                diamondAreaOpener = false;
                _CollectProducts[0].gameObject.SetActive(true);
                _CollectProducts[1].gameObject.SetActive(true);
                _CollectProducts[2].gameObject.SetActive(true);
                _CollectProducts[0].transform.position = L3list[0].position;
                _CollectProducts[1].transform.position = L3list[1].position;
                _CollectProducts[2].transform.position = L3list[2].position;
            }
        }
    }
    IEnumerator CreateCanned(float waitTime, Collectable fish)
    {
        foreach (var lst in silverCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in goldCollectionList)
        {
            lst.productCollectActive = true;
        }
        foreach (var lst in diamondCollectionList)
        {
            lst.productCollectActive = true;
        }
        Vector3 firstPos = fish.transform.position;
        Quaternion firstRot = fish.transform.rotation;

        Quaternion targetRot = fishInTR.transform.rotation;
        Vector3 dropPos = fishInTR.transform.position;


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

            fish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            fish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }



        // go convert position

        firstPos = fish.transform.position;
        counter = 0f;
        while (counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            fish.transform.position = Vector3.Lerp(firstPos, converFishtoCannedTR.transform.position, counter);

            yield return null;
        }

        int prefabSelect = 0;
        for (int i = 0; i < productsPrefab.Length; i++)
        {
            if (productsPrefab[i].collectType == fish.collectType)
            {
                prefabSelect = i;
                break;
            }
        }

        // converting
        Destroy(fish.gameObject, 1f);

        Vector3 firstScale = fish.transform.localScale;
        firstPos = fish.transform.position;
        firstRot = fish.transform.rotation;



        GameObject newProduct = Instantiate(productsPrefab[prefabSelect].gameObject, firstPos, firstRot);
        newProduct.GetComponent<Collectable>().collectActive = false;
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

        if (prefabSelect == 0)
        {
            newProduct.GetComponent<Collectable>().fishCollectable = silverCollectionList;

            silverCollectionList.Add(newProduct.GetComponent<Collectable>());
        }
        else if (prefabSelect == 1)
        {
            newProduct.GetComponent<Collectable>().fishCollectable = goldCollectionList;

            goldCollectionList.Add(newProduct.GetComponent<Collectable>());
        }
        else
        {
            newProduct.GetComponent<Collectable>().fishCollectable = diamondCollectionList;

            diamondCollectionList.Add(newProduct.GetComponent<Collectable>());
        }
        //yield return null;

        float deltaY = 0;
        Transform targetTR;

        if (prefabSelect == 0)
        {
            deltaY = (silverCollectionList.Count - 1) / silverProductPosTR.Length;
            targetTR = silverProductPosTR[(silverCollectionList.Count - 1) % silverProductPosTR.Length];
        }
        else if (prefabSelect == 1)
        {
            deltaY = (goldCollectionList.Count - 1) / goldProductPosTR.Length;
            targetTR = goldProductPosTR[(goldCollectionList.Count - 1) % goldProductPosTR.Length];
        }
        else
        {
            deltaY = (diamondCollectionList.Count - 1) / diamondProductPosTR.Length;
            targetTR = diamondProductPosTR[(diamondCollectionList.Count - 1) % diamondProductPosTR.Length];
        }


        dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        newProduct.transform.parent = targetTR.parent;

        //icedFish.GetComponent<Collectable>().productCollectActive = true;

        //if (productGoActive)
        //{
        StartCoroutine(GoCannedPos(newProduct.GetComponent<Collectable>(), targetTR, dropPos));
        //}
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

        //for (int i = 0; i < droppingCollectionList.Count; i++)
        //{
        //    Collectable deletedCollect = droppingCollectionList[i];

        //    _stackCollect.collectionTrs.Remove(deletedCollect);
        //    //Destroy(deletedCollect.gameObject,4f);
        //}
        //for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            droppedCollectionList.Add(droppingCollection);
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
            //yield return null;
        }

        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {
        collectable.isCollected = false;

        //collectable.animator.SetTrigger("stop");
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


        Quaternion targetAngle = dropPosTR.rotation;
        //Quaternion targetAngle = Quaternion.Euler(dropPosTR.eulerAngles.x, dropPosTR.eulerAngles.y + Random.Range(-30f, 30f), dropPosTR.eulerAngles.z + Random.Range(-30f, 30f));

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

        if (collectable.gameObject != null)
        {
            //collectable.animator.SetTrigger("stop");

        }
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
}