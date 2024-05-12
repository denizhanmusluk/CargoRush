using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishButcher : Stand
{
    [SerializeField] Transform fishButchPosTR;
    [SerializeField] Transform fishCookPosTR;

    public GameObject butchFishPrefab;
    public GameObject sushiPrefab;

    public Transform[] fishPosTR;
    public Transform[] butchPosTR;


    public List<Collectable> butchCollectionList = new List<Collectable>();
    [SerializeField] CollectProduct _CollectProduct;
    [SerializeField] Animator butcherAnimator;
    [SerializeField] Animator cookerAnimator;

    bool machineActive = false;
    [SerializeField] int totalProductCount;
    public override void CollectableCountSet()
    {

    }
    public override void SpecificStart()
    {
        _CollectProduct.collectables = butchCollectionList;
        //StandManager.Instance.standList.Add(this);
        //_FishDropArea.CollectProductList.Add(_CollectProduct);
        //_FishDropArea.standList.Add(this);
        StandReActive();

        FishCountInit();
        //SushiCustomerManager.Instance.CustomerStart();

        StartCoroutine(CreatorChecking());
    }
    void FishCountInit()
    {
        //FishManager.Instance.fishCount[2] += fishCountTotal * 2;
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
            if (cannedCount < butchPosTR.Length)
            {
                //yield return new WaitForSeconds(0.1f);
                creatingActive = true;

                StartCoroutine(CannedCreator());
            }
            if (!creatingActive)
            {
                foreach (var lst in butchCollectionList)
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

        //float waitTime = 2.5f;
        while (droppedCollectionList.Count > 0 && cannedCount < totalProductCount)
        {
            StandActive = false;
            //creatingActive = true;
            machineActive = true;
            cannedCount++;
            Collectable fish = droppedCollectionList[droppedCollectionList.Count - 1];
            droppedCollectionList.Remove(droppedCollectionList[droppedCollectionList.Count - 1]);
            StartCoroutine(CreateCanned(waitTime, fish));
            dropActive = false;
            fishCountCurrent++;
            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            yield return new WaitForSeconds(waitTime);

        }
        machineActive = false;
        yield return new WaitForSeconds(2f);
        cannedCount = butchCollectionList.Count;
        MachineStop();
        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }


    IEnumerator CreateCanned(float waitTime, Collectable fish)
    {

        foreach(var lst in butchCollectionList)
        {
            lst.productCollectActive = true;
        }
        Vector3 firstPos = fish.transform.position;
        Quaternion firstRot = fish.transform.rotation;

        Quaternion targetRot = fishButchPosTR.transform.rotation;
        Vector3 dropPos = fishButchPosTR.transform.position;


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


        StandActive = true;
        // converting

        Vector3 firstScale = fish.transform.localScale;
        firstPos = fish.transform.position;
        firstRot = fish.transform.rotation;
        Destroy(fish.gameObject);


        GameObject croppedFish = Instantiate(butchFishPrefab, firstPos, firstRot);
        croppedFish.GetComponent<Collectable>().collectActive = false;
        //croppedFish.GetComponent<Collectable>().fishCollectable = butchCollectionList;

        butcherAnimator.SetTrigger("butch");
        counter = 0f;
        croppedFish.GetComponent<CroppedFish>().plate.SetActive(true);

        yield return new WaitForSeconds(1.5f);
        // converting finish

        croppedFish.GetComponent<CroppedFish>().plate.SetActive(false);

        firstPos = croppedFish.transform.position;
        firstRot = croppedFish.transform.rotation;

        targetRot = fishCookPosTR.transform.rotation;
        dropPos = fishCookPosTR.transform.position;

        angle = 0f;
        posY = 0f;
        posY_Factor = 0.5f;
        counter = 0f;

        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);

            croppedFish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            croppedFish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        croppedFish.transform.position = fishCookPosTR.position;
        croppedFish.transform.parent = fishCookPosTR;


        cookerAnimator.SetTrigger("cook");
        yield return new WaitForSeconds(2f);
        croppedFish.transform.parent = null;



        firstPos = croppedFish.transform.position;
        firstRot = croppedFish.transform.rotation;
        Destroy(croppedFish.gameObject, 0.15f);


        GameObject sushiFish = Instantiate(sushiPrefab, firstPos, firstRot);
        sushiFish.GetComponent<Collectable>().collectActive = false;
        sushiFish.GetComponent<Collectable>().fishCollectable = butchCollectionList;







        butchCollectionList.Add(sushiFish.GetComponent<Collectable>());

        float deltaY = 0;

        deltaY = (butchCollectionList.Count - 1) / butchPosTR.Length;
        Transform targetTR = butchPosTR[(butchCollectionList.Count - 1) % butchPosTR.Length];

        dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        //icedFish.GetComponent<Collectable>().productCollectActive = true;

        //if (productGoActive)
        //{
            StartCoroutine(GoCannedPos(sushiFish.GetComponent<Collectable>(), targetTR, dropPos));
        //}
        sushiFish.transform.localScale = firstScale;
    }
    IEnumerator GoCannedPos(Collectable icedFish, Transform targetTR, Vector3 dropPos)
    {

        Vector3 firstPos = icedFish.transform.position;
        Quaternion firstRot = icedFish.transform.rotation;

        Quaternion targetRot = targetTR.transform.rotation;

        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 0.5f;
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

        droppedCollectionList.Add(droppingCollection);
        //yield return null;
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

        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
        //_FishDropArea.ShuffleList();
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