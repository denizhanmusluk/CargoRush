using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandFishTezgah : Stand, IMoneyArea
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
    public void MoneySave()
    {
        PlayerPrefs.SetInt(standNameLevel + "banknotcount", 0);
    }
    public override void CollectableCountSet()
    {
        PlayerPrefs.SetInt(machineName + "col" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);
        _CollectProduct.ratio = (float)droppedCollectionList.Count / (float)fishCountTotal;
    }
    public override void SpecificStart()
    {
        //GetComponent<Collider>().enabled = false;
        _CollectProduct.collectables = droppedCollectionList;


        FishCountInit();
       
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
        //fishCountCurrent = fishCountTotal;
        //FishManager.Instance.fishCount[1] += fishCountTotal * 4;
    }
    public override void SpecificReset()
    {
        firstColliderOffset = moneyArea.GetComponent<BoxCollider>().center;

        //ResetStand();
    }





    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
        if (collectAmount > 0 && fishCountCurrent > 0 && _stackCollect.collectionTrs[0] != null)
        {
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
        PlayerPrefs.SetInt(machineName + "col" + PlayerPrefs.GetInt("level"), droppedCollectionList.Count);

        yield return null;
        droppingCollection.collectActive = false;
        float deltaY = 0;
        deltaY = (droppedCollectionList.Count - 1) / productPosTR.Length;
        Transform targetTR = productPosTR[(droppedCollectionList.Count - 1) % productPosTR.Length];
        Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 1.25f, 0);
        StartCoroutine(Drop(targetTR, dropPos, droppingCollection, Time.deltaTime));
        if (_stackCollect.player)
        {
            VibratoManager.Instance.LightVibration();
        }

        _stackCollect.collectActive = true;
    }

    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {
        collectable.fishCollectable = droppedCollectionList;
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
        for (int i = 0; i < PlayerPrefs.GetInt(machineName + "col" + PlayerPrefs.GetInt("level")); i++)
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




    [SerializeField] MoneyArea moneyArea;
    Vector3 firstColliderOffset;
    [SerializeField] string standNameLevel;

    public void DropMoney(Collectable droppingCollection)
    {
        StartCoroutine(DroppingMoney(droppingCollection));
    }

    IEnumerator DroppingMoney(Collectable droppingCollection)
    {
        int stepNo = 0;

        float moneyFactor = 1f;
  
        int moneyListCount = moneyArea.moneyList.Count;
        float totalMoney = 0;
        //for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            totalMoney += droppingCollection.price / 3;
        }

        totalMoney /= 2;
        totalMoney = (int)((float)totalMoney * moneyFactor);
        if (Globals.doubleIncomeActive)
        {
            totalMoney = (int)((float)totalMoney * 2f);
        }
        totalMoney = ((float)totalMoney * Globals.extraMoneySkin);
        for (int i = 0; i < (int)totalMoney; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = 2;
            moneyArea.moneyList.Add(banknot);

            stepNo++;
            if (stepNo % 5 == 0)
            {
                yield return null;
            }
        }

        //droppedCollectionList.Clear();
        PlayerPrefs.SetInt(standNameLevel + "banknotcount", PlayerPrefs.GetInt(standNameLevel + "banknotcount") + (int)totalMoney);

        yield return new WaitForSeconds(0.1f);
        StartCoroutine(ColliderReset());

    }
    IEnumerator ColliderReset()
    {
        Vector3 beginOffset = new Vector3(firstColliderOffset.x, -20, firstColliderOffset.z);
        moneyArea.GetComponent<BoxCollider>().center = beginOffset;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            moneyArea.GetComponent<BoxCollider>().center = Vector3.Lerp(beginOffset, firstColliderOffset, counter);
            yield return null;
        }
        moneyArea.GetComponent<BoxCollider>().center = firstColliderOffset;
    }

    IEnumerator MoneyCreate()
    {
        int banknotVal = 2;
        for (int i = 0; i < PlayerPrefs.GetInt(standNameLevel + "banknotcount"); i++)
        {
            float deltaY = 0;
            deltaY = (i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = banknotVal;
            moneyArea.moneyList.Add(banknot);
            yield return null;
        }
        yield return null;
    }
}
