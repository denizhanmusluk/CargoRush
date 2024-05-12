using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StandCEO : Stand
{
    [SerializeField] CollectProduct _CollectProduct;

    public Transform[] productPosTR;
    [SerializeField] int customerCount;
    public CollectType collectTypeMachine;
    public Collectable[] productsPrefab;

    [SerializeField] MoneyArea moneyArea;
    public CEOCharacter cEOCharacter;
    public Transform ceoWaitPos;
    public Transform playerWaitPos;

    public Sprite shoeSprt;
    public Sprite barbieSprt;
    public Image productIMG;
    public TextMeshProUGUI productcountText;
    public void MissionStart(int productID, int productTotalCount, int price)
    {
        PlayerPrefs.SetInt(machineName + "productID", productID);
        PlayerPrefs.SetInt(machineName + "productTotalCount", productTotalCount);
        PlayerPrefs.SetInt(machineName + "price", price);
        StartCoroutine(ValueInitDelay());
        cEOCharacter.GoToPlayer();
    }
    public void MissionCompleted()
    {
        StartCoroutine(DroppingMoney());
    }
    IEnumerator DroppingMoney()
    {
        int moneyListCount = 0;
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "price"); i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos);
            banknot.banknotValue = 1;
            moneyArea.moneyList.Add(banknot);
            yield return null;
        }
    }
    public override void CollectableCountSet()
    {
        //PlayerPrefs.SetInt(machineName + "col", droppedCollectionList.Count);

    }
    IEnumerator ValueInitDelay()
    {
        yield return new WaitForSeconds(0.5f);
        ValueInit();
    }
    void ValueInit()
    {
        collectIDList[0] = PlayerPrefs.GetInt(machineName + "productID");
        fishCountTotal = PlayerPrefs.GetInt(machineName + "productTotalCount");
        fishCountCurrent = PlayerPrefs.GetInt(machineName + "productTotalCount") - PlayerPrefs.GetInt(machineName + "productCurrentCount");

        productcountText.text = fishCountCurrent.ToString();
        if (collectID == 2 || collectID == 3 || collectID == 4)
        {
            marketType = MarketType.Electronics;
        }

        if (collectID == 5 || collectID == 6 || collectID == 7)
        {
            marketType = MarketType.Sports;
        }

        if (collectID == 8 || collectID == 9 || collectID == 10)
        {
            marketType = MarketType.Toys;
        }

        if (collectID == 5)
        {
            productIMG.sprite = shoeSprt;
        }

        if (collectID == 8)
        {
            productIMG.sprite = barbieSprt;
        }
    }
    public override void SpecificStart()
    {
        PlayerController.Instance.standCeo = this;
        if (PlayerPrefs.GetInt(machineName + "productTotalCount") != 0)
        {
            StartCoroutine(ValueInitDelay());
        }
        GetComponent<Collider>().enabled = false;
        //_CollectProduct.collectables = droppedCollectionList;

        //foreach (var wrkArea in workAreaList)
        //{
        //    wrkArea.standList.Add(this);
        //}
        StandReActive();
        FishCountInit();
        //switch (marketType)
        //{
        //    case MarketType.Electronics:
        //        {
        //            MarketCustomerManager.Instance.collectAreaList_Electroincs.Add(_CollectProduct);
        //            MarketCustomerManager.Instance.maxCharacterCount_Electronics += customerCount;
        //        }
        //        break;

        //    case MarketType.Sports:
        //        {
        //            MarketCustomerManager.Instance.collectAreaList_Sports.Add(_CollectProduct);
        //            MarketCustomerManager.Instance.maxCharacterCount_Sports += customerCount;
        //        }
        //        break;

        //    case MarketType.Toys:
        //        {
        //            MarketCustomerManager.Instance.collectAreaList_Toys.Add(_CollectProduct);
        //            MarketCustomerManager.Instance.maxCharacterCount_Toys += customerCount;
        //        }
        //        break;
        //}
        //ManuealGemCreate();
        //MarketCustomerManager.Instance.collectAreaList.Add(_CollectProduct);
        //MarketCustomerManager.Instance.maxCharacterCount += customerCount;
    }
    void FishCountInit()
    {
        FishManager.Instance.fishCount[1] += fishCountTotal * 4;
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
        PlayerPrefs.SetInt(machineName + "productCurrentCount", PlayerPrefs.GetInt(machineName + "productCurrentCount") + 1);

        productcountText.text = (PlayerPrefs.GetInt(machineName + "productTotalCount") - PlayerPrefs.GetInt(machineName + "productCurrentCount")).ToString();

        if (PlayerPrefs.GetInt(machineName + "productCurrentCount") == PlayerPrefs.GetInt(machineName + "productTotalCount"))
        {
            PlayerPrefs.SetInt(machineName + "productTotalCount", 0);
            MissionCompleted();
        }
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
        collectable.productCollectActive = true;
        collectable.transform.parent = dropPosTR;

        collectable.gameObject.SetActive(false);
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
        GetComponent<Collider>().enabled = true;
    }
}
