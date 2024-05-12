using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishIced : Stand
{
    public GameObject icedFishPrefab;
    public Transform[] fishPosTR;
    public Transform[] icedFishPosTR;


    public List<Collectable> icedCollectionList = new List<Collectable>();

    [SerializeField] CollectProduct _CollectProduct;
    [SerializeField] CollectProduct _CollectProductRaf;
    bool machineActive = false;
    public override void CollectableCountSet()
    {

    }
    public override void SpecificStart()
    {
        _CollectProduct.collectables = icedCollectionList;
        //StandManager.Instance.standList.Add(this);


        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);
            wrkArea.CollectProductList.Add(_CollectProduct);
        }
        StandReActive();

        FishCountInit();
        _CollectProductRaf.machineActive = true;
        StartCoroutine(CreatorChecking());
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
    IEnumerator CreatorChecking()
    {
        creatingActive = false;
        while (!creatingActive)
        {
            if (cannedCount < icedFishPosTR.Length)
            {
                //yield return new WaitForSeconds(0.5f);
                //yield return new WaitForSeconds(0.1f);

                creatingActive = true;
                StartCoroutine(IcedCreator());
            }
            if (!creatingActive)
            {
                foreach (var lst in icedCollectionList)
                {
                    lst.productCollectActive = true;
                }
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator IcedCreator()
    {

        yield return new WaitForSeconds(0.5f);
        while(droppedCollectionList.Count > 0 && cannedCount < icedFishPosTR.Length)
        {
            machineActive = true;

            //creatingActive = true;
            cannedCount++;
            Collectable fish = droppedCollectionList[droppedCollectionList.Count - 1];
            droppedCollectionList.Remove(droppedCollectionList[droppedCollectionList.Count - 1]);
            StartCoroutine(CreateIce(waitTime, fish));
            dropActive = false;

            fishCountCurrent++;
            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            yield return new WaitForSeconds(waitTime);

        }
        machineActive = false;
        yield return new WaitForSeconds(3f);
        cannedCount = icedCollectionList.Count;

        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }
    IEnumerator CreateIce(float waitTime, Collectable fish)
    {
        foreach (var lst in icedCollectionList)
        {
            lst.productCollectActive = true;
        }
        Vector3 firstScale = fish.transform.localScale;
        Vector3 firstPos = fish.transform.position;
        Quaternion firstRot = fish.transform.rotation;
        GameObject icedFish = Instantiate(icedFishPrefab, firstPos, firstRot);
        icedFish.GetComponent<Collectable>().collectActive = false;
        //icedFish.transform.localScale = Vector3.zero;



        icedFish.GetComponent<Collectable>().fishCollectable = icedCollectionList;
        float counter = 0f;
        yield return null;
        while (counter < waitTime)
        {
            counter += Time.deltaTime;
            icedFish.transform.localScale = Vector3.Lerp(Vector3.zero, firstScale, counter / waitTime);
            yield return null;
        }


        icedCollectionList.Add(icedFish.GetComponent<Collectable>());
        //yield return null;

        float deltaY = 0;

        deltaY = (icedCollectionList.Count - 1) / icedFishPosTR.Length;
        Transform targetTR = icedFishPosTR[(icedCollectionList.Count - 1) % icedFishPosTR.Length];

        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        //icedFish.GetComponent<Collectable>().productCollectActive = true;
        //if (productGoActive)
        //{
            StartCoroutine(GoIcedPos(icedFish.GetComponent<Collectable>(), targetTR, dropPos));
        //}
        icedFish.transform.localScale = firstScale;
        Destroy(fish.gameObject);

    }
    IEnumerator GoIcedPos(Collectable icedFish, Transform targetTR, Vector3 dropPos)
    {

        Vector3 firstPos = icedFish.transform.position;
        Quaternion firstRot = icedFish.transform.rotation;
    
        Quaternion targetRot = targetTR.transform.rotation;

        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 3f;
        float counter = 0f;
        while(counter < 1f)
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
        //if(droppedCollectionList.Count == 0)
        //{
        //    StartCoroutine(IcedCreator());
        //}
        if (collectAmount > 0)
        {
            //VibratoManager.Instance.MediumMultiVibration();
            _stackCollect.collectActive = false;
        }
        StartCoroutine(DropSequantial(collectAmount, _stackCollect));
    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {
        yield return null;

        List<Collectable> droppingCollectionList = new List<Collectable>();

        int amount = collectAmount;
        int loopCount = _stackCollect.collectionTrs.Count;
        for (int i = 0; i < loopCount; i++)
        {
            foreach (var clListId in collectIDList)
            {
                if (_stackCollect.collectionTrs[i].collectID == clListId && amount > 0)
                {
                    yield return null;
                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

                    amount--;
                    break;
                }
            }
        }


        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            Collectable deletedCollect = droppingCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
            //Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            droppedCollectionList.Add(droppingCollectionList[i]);
            yield return null;
            droppingCollectionList[i].collectActive = false;
            float deltaY = 0;
            deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
            Transform targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollectionList[i], i * 0.05f));
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