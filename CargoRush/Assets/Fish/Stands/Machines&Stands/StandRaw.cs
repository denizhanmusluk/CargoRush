using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StandRaw : Stand
{
    [SerializeField] CollectProduct _CollectProduct;

    public Transform[] fishPosTR;
    [SerializeField] int customerCount;

    public Collectable[] rawPrefabs;
    public int maxBandCapacity = 10;
    public int currentBandCount = 0;
    public ProcessMachine processMachine;
    public TextMeshProUGUI bandText;

    public BandStock bandStock;

    public GameObject needPackTape_GO;
    public override void CollectableCountSet()
    {
        PlayerPrefs.SetInt(machineName + "rawcount", currentBandCount);
        bandText.text = (currentBandCount).ToString() + "/" + (maxBandCapacity).ToString();

    }
    public override void SpecificStart()
    {
        bandText.text = (currentBandCount).ToString() + "/" + (maxBandCapacity).ToString();
        _CollectProduct.collectables = droppedCollectionList;

        //_FishDropArea.standList.Add(this);
        //foreach (var wrkArea in workAreaList)
        //{
        //    wrkArea.standList.Add(this);
        //}
        StandReActive();
        FishCountInit();
        ManuealRawCreate();
        //MarketCustomerManager.Instance.collectAreaList.Add(_CollectProduct);
        //MarketCustomerManager.Instance.maxCharacterCount += customerCount;
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
        if (collectAmount > 0 &&  _stackCollect.collectionTrs[0] != null)
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
        PlayerPrefs.SetInt(machineName + "rawcount", currentBandCount);

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
            AudioManager.Instance.StackDropSound();
        }


        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;
        //foreach (var wrkArea in workAreaList)
        //{
        //    wrkArea.ShuffleStandList();
        //    wrkArea.ShuffleCollectProductList();
        //}
        if (PlayerPrefs.GetInt("bandstocktutorial") == 2)
        {
            PlayerPrefs.SetInt("bandstocktutorial", 3);
            TutorialManager.Instance.bandTut_2.SetActive(false);
            TutorialManager.Instance.bandTut_3.SetActive(false);
            IndicatorManager.Instance.IndicaorDeActive();

            TutorialManager.Instance.SkinTutorialStart();

            IndicatorManager.Instance.TutorialStepCompleted();


            //PlayerPrefs.SetInt("skinactive", 1);
            //StoreManager.Instance.storeButton.SetActive(true);
            //TutorialManager.Instance.SkinTutorialStart();

        }
        //if (PlayerPrefs.GetInt("bandstocktutorial") == 4)
        //{
        //    PlayerPrefs.SetInt("bandstocktutorial", 5);
        //    TutorialManager.Instance.bandTut_2.SetActive(false);
        //    TutorialManager.Instance.bandTut_3.SetActive(false);
        //    IndicatorManager.Instance.IndicaorDeActive();
        //}
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

        if (collectable.gameObject != null)
        {
            //collectable.transform.parent = currentCar.GetComponent<FishCar>().fishPosParent;
            //if (collectable.animator != null)
            //{
            //    collectable.animator.SetTrigger("flutter");
            //}

        }

        currentBandCount++;
        fishCountCurrent++;
        bandText.text = (currentBandCount).ToString() + "/" + (maxBandCapacity).ToString();

        if (currentBandCount >= maxBandCapacity)
        {
            currentBandCount = maxBandCapacity;
            processMachine.bandActive = true;
            FullBand();
        }

        droppedCollectionList.Remove(collectable);
        Destroy(collectable.gameObject, 0.1f);
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
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "rawcount"); i++)
        {
            //GameObject newProduct = Instantiate(rawPrefabs[0].gameObject);
            //newProduct.GetComponent<Collectable>().collectActive = false;

            //newProduct.GetComponent<Collectable>().fishCollectable = droppedCollectionList;

            //droppedCollectionList.Add(newProduct.GetComponent<Collectable>());
            currentBandCount++;
            bandText.text = (currentBandCount).ToString() + "/" + (maxBandCapacity).ToString();
            processMachine.bandActive = true;
            FullBand();

            float deltaY = 0;
            Transform targetTR;

            deltaY = (droppedCollectionList.Count - 1) / fishPosTR.Length;
            targetTR = fishPosTR[(droppedCollectionList.Count - 1) % fishPosTR.Length];

            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.01f, 0);
            Quaternion targetRot = targetTR.transform.rotation;

            //newProduct.transform.parent = targetTR.parent;


            //newProduct.transform.position = dropPos;
            //newProduct.transform.rotation = targetRot;
            //fishCountCurrent -= 1;
            //yield return new WaitForSeconds(0.2f);
            //newProduct.GetComponent<Collectable>().productCollectActive = true;
            yield return null;
        }
        bandText.text = (currentBandCount).ToString() + "/" + (maxBandCapacity).ToString();

        if(currentBandCount == 0)
        {
            EmptyBand();
        }
    }

    public void EmptyBand()
    {
        bandStock.ManuelRawCreate();
        needPackTape_GO.SetActive(true);
    }
    public void FullBand()
    {
        needPackTape_GO.SetActive(false);
    }
}
