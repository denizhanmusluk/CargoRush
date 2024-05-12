using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigAquarium : Stand
{
    public List<Transform> whaleList;
    public List<Transform> dolphinList;
    [SerializeField] Transform fishInTR;
    public GameObject cannedFishPrefab;
    public Transform[] fishPosTR;
    public Transform[] cannedFishPosTR;


    public List<Collectable> cannedCollectionList = new List<Collectable>();
    [SerializeField] CollectProduct _CollectProduct;
    //[SerializeField] Animator machineAnimator;
    [SerializeField] CollectProduct _CollectProductRaf;
    bool machineActive = false;
    //public int[] collectIDother;
    [SerializeField] public int whaleCollectID;
    [SerializeField] public int dolphinCollectID;
    public List<FishDropArea> _FishDropAreaOther;
    int fishEatcurrentCount = 0;
    [SerializeField] int fishEatPeriod;
    public Transform indicatorPosTR;
    public override void CollectableCountSet()
    {

    }
    public override void SpecificStart()
    {
        for(int i = 0; i < PlayerPrefs.GetInt("bigfish0"); i++)
        {
            whaleList[i].gameObject.SetActive(true);
        }
        for (int i = 0; i < PlayerPrefs.GetInt("bigfish1"); i++)
        {
            dolphinList[i].gameObject.SetActive(true);
        }
        Globals.bigFishAquariumActive = true;
        _CollectProduct.collectables = cannedCollectionList;
        //StandManager.Instance.standList.Add(this);
        //_FishDropArea.CollectProductList.Add(_CollectProduct);
        //_FishDropArea.standList.Add(this);

        foreach (var fsharea in _FishDropAreaOther)
        {
            fsharea.standList.Add(this);
        }

        StandReActive();
        FishCountInit();
        //_CollectProductRaf.machineActive = true;
        StartCoroutine(CreatorChecking());
    }
    void FishCountInit()
    {
        FishManager.Instance.fishCount[0] += 20;
        FishManager.Instance.fishCount[1] += 20;
        FishManager.Instance.fishCount[2] += 20;
    }
    public override void SpecificReset()
    {
        //ResetStand();
    }
   public bool creatingActive = false;
    void MachineActive()
    {
        foreach (var fish in whaleList)
        {
            fish.GetComponent<Animator>().SetBool("fishshow", true);
        }
        foreach (var fish in dolphinList)
        {
            fish.GetComponent<Animator>().SetBool("fishshow", true);
        }
        //machineAnimator.SetBool("kizak", true);
    }
    void MachineStop()
    {
        foreach (var fish in whaleList)
        {
            fish.GetComponent<Animator>().SetBool("fishshow", false);
        }
        foreach (var fish in dolphinList)
        {
            fish.GetComponent<Animator>().SetBool("fishshow", false);
        }
        //machineAnimator.SetBool("kizak", false);
    }
    IEnumerator CreatorChecking()
    {
        creatingActive = false;
        while (!creatingActive)
        {
            //if (cannedCount < cannedFishPosTR.Length)
            //{
                //yield return new WaitForSeconds(0.1f);
                creatingActive = true;

                StartCoroutine(CannedCreator());
            //}
            if (!creatingActive)
            {
                foreach (var lst in cannedCollectionList)
                {
                    lst.productCollectActive = true;
                }
            }
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void CannedCountSet()
    {
        cannedCount = cannedCollectionList.Count;
    }

    IEnumerator CannedCreator()
    {

        yield return new WaitForSeconds(0.5f);
        if (droppedCollectionList.Count > 0 && whaleList[0].gameObject.activeInHierarchy)
        {
            //MachineActive();
        }

        //float waitTime = 1f;
        while (droppedCollectionList.Count > 0 && whaleList[0].gameObject.activeInHierarchy)
        {
            fishEatcurrentCount++;
            Globals.showActive = true;
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
       if( fishEatcurrentCount > fishEatPeriod)
        {
            fishEatcurrentCount = 0;
            if(PlayerPrefs.GetInt("bigfish1") > 0)
            {
                PlayerPrefs.SetInt("bigfish1", PlayerPrefs.GetInt("bigfish1") - 1);

                foreach( var dolphins in dolphinList)
                {
                    dolphins.gameObject.SetActive(false);

                }


                for (int i = 0; i < PlayerPrefs.GetInt("bigfish1"); i++)
                {
                    dolphinList[i].gameObject.SetActive(true);
                }
            }
        }
        Globals.showActive = false;
        machineActive = false;
        MachineStop();
        yield return new WaitForSeconds(3f);
        cannedCount = cannedCollectionList.Count;
        //if (droppedCollectionList.Count > 0)
        {
            StartCoroutine(CreatorChecking());
        }
    }


    IEnumerator CreateCanned(float waitTime, Collectable fish)
    {
        //foreach (var lst in cannedCollectionList)
        //{
        //    lst.productCollectActive = true;
        //}
        //Vector3 firstPos = fish.transform.position;
        //Quaternion firstRot = fish.transform.rotation;

        //Quaternion targetRot = fishInTR.transform.rotation;
        //Vector3 dropPos = fishInTR.transform.position;


        // go in position
        //float angle = 0f;
        //float posY = 0f;
        //float psoY_Factor = 1f;
        //float counter = 0f;
        //while (counter < 1f)
        //{
        //    counter += 2 * Time.deltaTime;

        //    angle = counter * Mathf.PI;
        //    posY = psoY_Factor * Mathf.Sin(angle);

        //    fish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
        //    fish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

        //    yield return null;
        //}



        // go convert position

        //firstPos = fish.transform.position;
        //counter = 0f;
        //while (counter < 1f)
        //{
        //    counter += Time.deltaTime;
        //    fish.transform.position = Vector3.Lerp(firstPos, converFishtoCannedTR.transform.position, counter);

        //    yield return null;
        //}




        // converting
        //Destroy(fish.gameObject);

        //Vector3 firstScale = fish.transform.localScale;
        //firstPos = fish.transform.position;
        //firstRot = fish.transform.rotation;


        //GameObject icedFish = Instantiate(cannedFishPrefab, firstPos, firstRot);
        //icedFish.GetComponent<Collectable>().collectActive = false;
        //icedFish.GetComponent<Collectable>().fishCollectable = cannedCollectionList;


        //counter = 0f;
        //yield return null;
        //while (counter < 1f)
        //{
        //    counter += Time.deltaTime;
        //    icedFish.transform.position = Vector3.Lerp(firstPos, fishOutTR.transform.position, counter);

        //    yield return null;
        //}
        // converting finish

        //cannedCollectionList.Add(icedFish.GetComponent<Collectable>());

        //yield return null;

        //float deltaY = 0;

        //deltaY = (cannedCollectionList.Count - 1) / cannedFishPosTR.Length;
        //Transform targetTR = cannedFishPosTR[(cannedCollectionList.Count - 1) % cannedFishPosTR.Length];

        //Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        //icedFish.GetComponent<Collectable>().productCollectActive = true;

        //if (productGoActive)
        //{
        StartCoroutine(GoCannedPos(fish.GetComponent<Collectable>(), fishInTR, fishInTR.position));
        //}
        //fish.transform.localScale = firstScale;
        yield return null;
    }
    IEnumerator GoCannedPos(Collectable icedFish, Transform targetTR, Vector3 dropPos)
    {
        MachineActive();
        yield return new WaitForSeconds(1f);
        MachineActive();
        Vector3 firstPos = icedFish.transform.position;
        Quaternion firstRot = icedFish.transform.rotation;

        Quaternion targetRot = targetTR.transform.rotation;
        float angle = 0f;
        float posY = 0f;
        float psoY_Factor = 4f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            dropPos = fishInTR.position;

            angle = counter * Mathf.PI;
            posY = psoY_Factor * Mathf.Sin(angle);

            icedFish.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), counter);
            icedFish.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);

            yield return null;
        }
        icedFish.transform.position = dropPos;
        icedFish.transform.rotation = targetRot;

        Destroy(icedFish.gameObject);
        //yield return new WaitForSeconds(0.2f);
        //icedFish.productCollectActive = true;

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
        }
        StartCoroutine(DropSequantial(collectAmount, _stackCollect));
        Debug.Log("balina");
        IndicatorManager.Instance.IndicaorDeActive();
    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {
        yield return null;

        List<Collectable> droppingCollectionList = new List<Collectable>();
        List<Collectable> droppingWhaleCollectionList = new List<Collectable>();
        List<Collectable> droppingDolphinCollectionList = new List<Collectable>();

        int amount = collectAmount;
        int loopCount = _stackCollect.collectionTrs.Count;
        for (int i = 0; i < loopCount; i++)
        {
            if (amount > 0)
            {
                foreach (var clListId in collectIDList)
                {
                    if (_stackCollect.collectionTrs[i].collectID == clListId)
                    {
                        droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

                        amount--;
                        break;
                    }
                }
            }


            if (_stackCollect.collectionTrs[i].collectID == whaleCollectID)
            {
                droppingWhaleCollectionList.Add(_stackCollect.collectionTrs[i]);
            }


            if (_stackCollect.collectionTrs[i].collectID == dolphinCollectID)
            {
                droppingDolphinCollectionList.Add(_stackCollect.collectionTrs[i]);
            }
        }
        // // // // // // // // // //

        for (int i = 0; i < droppingDolphinCollectionList.Count; i++)
        {
            Collectable deletedCollect = droppingDolphinCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
            //Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < droppingDolphinCollectionList.Count; i++)
        {
            yield return null;
            droppingDolphinCollectionList[i].collectActive = false;

            Transform targetTR = dolphinList[PlayerPrefs.GetInt("bigfish1") - 1];
            Vector3 dropPos = targetTR.position;
            StartCoroutine(DropBig(targetTR, dropPos, droppingDolphinCollectionList[i]));
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
            }
        }
        // // // // // // // // // //



        for (int i = 0; i < droppingWhaleCollectionList.Count; i++)
        {
            Collectable deletedCollect = droppingWhaleCollectionList[i];

            _stackCollect.collectionTrs.Remove(deletedCollect);
            //Destroy(deletedCollect.gameObject,4f);
        }
        for (int i = 0; i < droppingWhaleCollectionList.Count; i++)
        {
            yield return null;
            droppingWhaleCollectionList[i].collectActive = false;
            
            Transform targetTR = whaleList[PlayerPrefs.GetInt("bigfish0") - 1];
            Vector3 dropPos = targetTR.position;
            StartCoroutine(DropBig(targetTR, dropPos, droppingWhaleCollectionList[i]));
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
            }
        }
        // // // // // // // // // //

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
        }
        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
    }
    IEnumerator DropBig(Transform dropPosTR, Vector3 dropPos, Collectable collectable)
    {
        cannedCount++;
        fishCountCurrent++;
        fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();

        collectable.transform.parent = null;

        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        Quaternion targetAngle = dropPosTR.rotation;

        float timeCounter = 0;
        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;

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
        collectable.gameObject.SetActive(false);
        dropPosTR.gameObject.SetActive(true);
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {
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


        if (collectable.GetComponent<FishAquarium>() != null)
        {
            foreach (var pos in fishPosTR)
            {
                collectable.GetComponent<FishAquarium>().posList.Add(pos);
            }
            collectable.GetComponent<FishAquarium>().followActive = true;
            collectable.GetComponent<FishAquarium>().TargetPosSelect();
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