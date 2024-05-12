using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquidCooker : Stand
{
    [SerializeField] Transform fishCookPosTR;
    public GameObject sushiPrefab;
    public Transform[] fishPosTR;
    public Transform[] sushiPosTR;


    public List<Collectable> sushiCollectionList = new List<Collectable>();
    [SerializeField] CollectProduct _CollectProduct;
    [SerializeField] Animator cookerAnimator;
    bool machineActive = false;
    public bool sushiCustomerManager;
    [SerializeField] Collectable cuttedFish;


    [SerializeField] int holeFishID;
    [SerializeField] int holeFishCount;
    [SerializeField] int totalProductCount;
    public override void CollectableCountSet()
    {

    }
    public override void SpecificStart()
    {
        _CollectProduct.collectables = sushiCollectionList;
        //StandManager.Instance.standList.Add(this);
        //_FishDropArea.CollectProductList.Add(_CollectProduct);
        //_FishDropArea.standList.Add(this);
        StandReActive();
        FishCountInit();
        if (sushiCustomerManager)
        {
            //SushiCustomerManager.Instance.CustomerStart();
        }
        StartCoroutine(CreatorChecking());
    }
    void FishCountInit()
    {
        FishManager.Instance.fishCount[holeFishID] += holeFishCount;
    }
    public override void SpecificReset()
    {
        //ResetStand();
    }
    bool creatingActive = false;
    void MachineActive()
    {

    }
    void MachineStop()
    {

    }
    IEnumerator CreatorChecking()
    {
        creatingActive = false;
        while (!creatingActive)
        {
            if (cannedCount < sushiPosTR.Length)
            {
                //yield return new WaitForSeconds(0.1f);
                creatingActive = true;

                StartCoroutine(CannedCreator());
            }
            if (!creatingActive)
            {
                foreach (var lst in sushiCollectionList)
                {
                    lst.productCollectActive = true;
                }
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator CannedCreator()
    {
        yield return new WaitForSeconds(0.5f);
        if (droppedCollectionList.Count > 0 && cannedCount < totalProductCount)
        {
            MachineActive();
        }

        //float waitTime = 3f;
        while (droppedCollectionList.Count > 0 && cannedCount < totalProductCount)
        {
            
            //creatingActive = true;
            machineActive = true;
            cannedCount++;
            Collectable fish = droppedCollectionList[droppedCollectionList.Count - 1];
            droppedCollectionList.Remove(fish);
            StartCoroutine(CreateCanned(waitTime, fish));
            dropActive = false;
            fishCountCurrent++;
            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            yield return new WaitForSeconds(waitTime);

        }
        machineActive = false;
        yield return new WaitForSeconds(2f);
        cannedCount = sushiCollectionList.Count;
        MachineStop();
        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }


    IEnumerator CreateCanned(float waitTime, Collectable fish)
    {
        Debug.Log(fish.transform.name);
        foreach (var lst in sushiCollectionList)
        {
            lst.productCollectActive = true;
        }
        Vector3 firstPos = fish.transform.position;
        Quaternion firstRot = fish.transform.rotation;

        Quaternion targetRot = fishCookPosTR.transform.rotation;
        Vector3 dropPos = fishCookPosTR.transform.position;


        // go in position
        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 0.5f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);

            fish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            fish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        fish.transform.position = fishCookPosTR.position;
        fish.transform.parent = fishCookPosTR;

        fish.GetComponent<CroppedFish>().plate.SetActive(false);

        // converting
        cookerAnimator.SetTrigger("cook");
        yield return new WaitForSeconds(2f);
        fish.transform.parent = null;


        Vector3 firstScale = fish.transform.localScale;
        firstPos = fish.transform.position;
        firstRot = fish.transform.rotation;
        Destroy(fish.gameObject, 0.15f);


        GameObject icedFish = Instantiate(sushiPrefab, firstPos, firstRot);
        icedFish.GetComponent<Collectable>().collectActive = false;
        icedFish.GetComponent<Collectable>().fishCollectable = sushiCollectionList;


        counter = 0f;

        // converting finish


        sushiCollectionList.Add(icedFish.GetComponent<Collectable>());

        float deltaY = 0;

        deltaY = (sushiCollectionList.Count - 1) / sushiPosTR.Length;
        Transform targetTR = sushiPosTR[(sushiCollectionList.Count - 1) % sushiPosTR.Length];

        dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        //icedFish.GetComponent<Collectable>().productCollectActive = true;

        //if (productGoActive)
        //{
        StartCoroutine(GoCannedPos(icedFish.GetComponent<Collectable>(), targetTR, dropPos));
        //}
        icedFish.transform.localScale = firstScale;
    }
    IEnumerator GoCannedPos(Collectable icedFish, Transform targetTR, Vector3 dropPos)
    {

        Vector3 firstPos = icedFish.transform.position;
        Quaternion firstRot = icedFish.transform.rotation;

        Quaternion targetRot = targetTR.transform.rotation;

        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 1.5f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            icedFish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            icedFish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        icedFish.transform.position = dropPos;
        icedFish.transform.rotation = targetRot;
        yield return new WaitForSeconds(0.2f);
        icedFish.productCollectActive = true;
        //icedFish.collectActive = true;

    }
    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        //if (droppedCollectionList.Count == 0)
        //{
        //    StartCoroutine(CannedCreator());
        //}
        if (collectAmount > 0)
        {
            //VibratoManager.Instance.MediumMultiVibration();
            _stackCollect.collectActive = false;
            StartCoroutine(DropSequantial(collectAmount, _stackCollect));
        }
    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {

        Collectable droppingCollection = null;

        int loopCount = _stackCollect.collectionTrs.Count;
        for (int i = 0; i < loopCount; i++)
        {
            foreach (var clListId in collectIDList)
            {
                if (_stackCollect.collectionTrs[i].collectID == clListId)
                {
                    droppingCollection = _stackCollect.collectionTrs[i];
                    i = _stackCollect.collectionTrs.Count;
                    break;
                }
            }
        }
        Collectable deletedCollect = droppingCollection;

        _stackCollect.collectionTrs.Remove(deletedCollect);

        Collectable cut = Instantiate(cuttedFish.gameObject, droppingCollection.transform.position, droppingCollection.transform.rotation).GetComponent<Collectable>();
        droppingCollection.gameObject.SetActive(false);
        Destroy(droppingCollection.gameObject,2f);
        droppedCollectionList.Add(cut);

        //droppedCollectionList.Add(droppingCollection);
        //yield return null;
        cut.collectActive = false;
        float deltaY = 0;
        deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
        Transform targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];
        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        StartCoroutine(Drop(targetTR, dropPos, cut, Time.deltaTime));
        if (_stackCollect.player)
        {
            VibratoManager.Instance.LightVibration();
        }

        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
        //_FishDropArea.ShuffleList();
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {

        //collectable.animator.SetTrigger("stop");
        yield return new WaitForSeconds(waitTime);
        foreach (var anim in collectable.GetComponentsInChildren<Animator>())
        {
            anim.enabled = false;
        }
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
        //droppedCollectionList.Remove(collectable);

        //Collectable cut = Instantiate(cuttedFish.gameObject, collectable.transform.position, collectable.transform.rotation).GetComponent<Collectable>();
        //Destroy(collectable.gameObject);
        //droppedCollectionList.Add(cut);

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