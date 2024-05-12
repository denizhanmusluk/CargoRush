using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandFishTezgah : Stand
{
    public CollectProduct _CollectProduct;

    public Transform[] productPosTR;
    [SerializeField] int customerCount;
    public CollectType collectTypeMachine;
    public Collectable[] productsPrefab;
    private void Awake()
    {
        GetComponent<Collider>().enabled = false;
    }
    public override void CollectableCountSet()
    {
        PlayerPrefs.SetInt(machineName + "col", droppedCollectionList.Count);
        _CollectProduct.ratio = (float)droppedCollectionList.Count / (float)fishCountTotal;
    }
    public override void SpecificStart()
    {
        //GetComponent<Collider>().enabled = false;
        _CollectProduct.collectables = droppedCollectionList;

        //_FishDropArea.standList.Add(this);
        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);
        }
        workAreaList[0].productStandList.Add(this);
        FishCountInit();
        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    MarketCustomerManager.Instance.collectAreaList_Electroincs.Add(_CollectProduct);
                    MarketCustomerManager.Instance.maxCharacterCount_Electronics += customerCount;
                }
                break;

            case MarketType.Sports:
                {
                    MarketCustomerManager.Instance.collectAreaList_Sports.Add(_CollectProduct);
                    MarketCustomerManager.Instance.maxCharacterCount_Sports += customerCount;
                }
                break;

            case MarketType.Toys:
                {
                    MarketCustomerManager.Instance.collectAreaList_Toys.Add(_CollectProduct);
                    MarketCustomerManager.Instance.maxCharacterCount_Toys += customerCount;
                }
                break;
        }
        if (PlayerPrefs.GetInt(machineName + "firstopen") == 1)
        {
            ManuealGemCreate();
        }
        PlayerPrefs.SetInt(machineName + "firstopen", 1);

        //MarketCustomerManager.Instance.collectAreaList.Add(_CollectProduct);
        //MarketCustomerManager.Instance.maxCharacterCount += customerCount;

        MissionManager.Instance.allStandList.Add(this);
        MissionManager.Instance.StandMission_Start(_CollectProduct.CollectId - 2);

        if (MissionManager.Instance.standMission.gameObject.activeInHierarchy)
        {
            MissionManager.Instance.standMission.MissionUpdatestand(_CollectProduct.CollectId - 2);
        }
        //if (_CollectProduct.CollectId > 2)
        //    {
        //        MissionManager.Instance.standMission.MissionUpdate();
        //    }

        //if (collectIDList[0] >= 2)
        //{
        //    MissionManager.Instance.StandMission_Start(collectIDList[0] - 1);
        //}
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1.5f);
        GetComponent<Collider>().enabled = true;
        StandReActive();
    }
    void FishCountInit()
    {
        //FishManager.Instance.fishCount[1] += fishCountTotal * 4;
    }
    public override void SpecificReset()
    {
        //ResetStand();
    }





    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
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
            foreach (int cltId in collectIDList)
            {
                if (_stackCollect.collectionTrs[i].collectID == cltId && amount > 0)
                {
                    if (collectType == CollectType.All || _stackCollect.collectionTrs[i].collectType == collectType)
                    {
                        droppingCollectionList.Add(_stackCollect.collectionTrs[i]);
                        amount--;
                        break;
                    }
                }
            }
        }


        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            //droppingCollectionList[i].productCollectActive = true;
            droppingCollectionList[i].fishCollectable = droppedCollectionList;

            Collectable deletedCollect = droppingCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
            //Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            droppedCollectionList.Add(droppingCollectionList[i]);
            //yield return null;

            float deltaY = 0;
            deltaY = (droppedCollectionList.Count - 1) / productPosTR.Length;
            Transform targetTR = productPosTR[(droppedCollectionList.Count - 1) % productPosTR.Length];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollectionList[i], i * 0.05f));
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
            }
            //yield return null;
        }
        PlayerPrefs.SetInt(machineName + "col", droppedCollectionList.Count);

        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        _stackCollect.collectActive = true;

        yield return new WaitForSeconds(0.5f);
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
        collectable.productCollectActive = true;
        collectable.transform.parent = dropPosTR;
        if (collectable.gameObject != null)
        {
            //collectable.transform.parent = currentCar.GetComponent<FishCar>().fishPosParent;
            //if (collectable.animator != null)
            //{
            //    collectable.animator.SetTrigger("flutter");
            //}

        }
        if(collectable.GetComponent<TShirt>() != null)
        {
            collectable.GetComponent<TShirt>().HangerOpen();
        }




        MissionManager.Instance.StandMission_Start(_CollectProduct.CollectId - 2);
        workAreaList[0].StnadFullCheck();
        _CollectProduct.ratio = (float)droppedCollectionList.Count / (float)fishCountTotal;

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
    public void ManuealGemCreate()
    {
        StartCoroutine(ManuelGemCreator());
    }
    IEnumerator ManuelGemCreator()
    {
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col"); i++)
        {
            GameObject newProduct = Instantiate(productsPrefab[0].gameObject);
            newProduct.GetComponent<Collectable>().collectActive = false;

            newProduct.GetComponent<Collectable>().fishCollectable = droppedCollectionList;

            droppedCollectionList.Add(newProduct.GetComponent<Collectable>());


            float deltaY = 0;
            Transform targetTR;

            deltaY = (droppedCollectionList.Count - 1) / productPosTR.Length;
            targetTR = productPosTR[(droppedCollectionList.Count - 1) % productPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            newProduct.transform.position = dropPos;
            newProduct.transform.rotation = targetRot;

            fishCountCurrent -= 1;
            fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            //yield return new WaitForSeconds(0.2f);
            newProduct.GetComponent<Collectable>().productCollectActive = true;

            if (newProduct.GetComponent<TShirt>() != null)
            {
                newProduct.GetComponent<TShirt>().HangerOpen();
            }
            yield return null;
        }
        //GetComponent<Collider>().enabled = true;
    }
}
