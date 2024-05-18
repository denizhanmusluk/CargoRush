using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StandFishCar : Stand
{
    [SerializeField] GameObject canvasProductGO, canvasDeliveringGO;
    [SerializeField] Image imageFill;
    [SerializeField] float cooldownTime;
    [SerializeField] MoneyArea moneyArea;

    [SerializeField] Transform carCreateTR, carStandTR, carGoTR;
    [SerializeField] GameObject carPrefab;
    [SerializeField] List<GameObject> carPrefabList = new List<GameObject>();

    GameObject currentCar;
    [SerializeField] string standNameLevel;
    public int[] _fishCountTotal;

    int carLevel = 0;
    [SerializeField] float fishCoun_Factor;

    [SerializeField] int[] productTypeCount;
    [SerializeField] int[] productTypeCountTotal;
    [SerializeField] List<GameObject> productTextGOList;
    [SerializeField] List<TextMeshProUGUI> productTextList;
    void TextInitCheck()
    {
        for (int i = 0; i < productTypeCount.Length; i++)
        {
            productTextList[i].text = (productTypeCountTotal[i] - productTypeCount[i]).ToString() + "/" + (productTypeCountTotal[i]).ToString();

            if (productTypeCount[i] == 0)
            {
                productTextGOList[i].SetActive(false);
            }
            else
            {
                productTextGOList[i].SetActive(true);
            }
        }
    }
    public override void CollectableCountSet()
    {

    }
    private void Awake()
    {
        LevelInit();
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        if (PlayerPrefs.GetInt("firstindactive") == 0)
        {
            PlayerPrefs.SetInt("firstindactive", 1);
            IndicatorManager.Instance.IndicatorTargeterActive();
        }
    }
    public void LevelInit()
    {
        carLevel = PlayerPrefs.GetInt(standNameLevel);
        fishCountTotal = _fishCountTotal[carLevel];
    }
    public void LevelUp()
    {
        int lvl = PlayerPrefs.GetInt(standNameLevel);
        lvl++;
        PlayerPrefs.SetInt(standNameLevel, lvl);

        carLevel = PlayerPrefs.GetInt(standNameLevel);
        if (currentCar != null)
        {
            //currentCar.GetComponent<FishCar>().CarLevelCreate(carLevel);
            ResetStand();

        }
        fishCountCurrent += (_fishCountTotal[carLevel] - fishCountTotal);


        //LevelInit();
        //fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
    }
    public override void SpecificStart()
    {
        //_FishDropArea.standList.Add(this);
        CarCreate();
        FishCountInit();
        foreach (var wrkArea in workAreaList)
        {
            wrkArea.standList.Add(this);
            //wrkArea.CollectProductList.Add(_CollectProducts);
        }
    }
    void FishCountInit()
    {
        //FishManager.Instance.fishCount[0] += (int)(fishCountTotal * fishCoun_Factor);
    }
    public override void SpecificReset()
    {
        ResetStand();
    }



    void CarCreate()
    {
        currentCar = Instantiate(carPrefabList[carLevel], carCreateTR.position, Quaternion.identity);
        currentCar.GetComponent<FishCar>().CarLevelCreate(carLevel);
        currentCar.GetComponent<FishCar>().stand = this;
        currentCar.GetComponent<FishCar>().standPos = carStandTR;
        currentCar.GetComponent<FishCar>().carGoPos = carGoTR;


        productTypeCount = new int[Globals.collectableLevel + 1];
        productTypeCountTotal = new int[Globals.collectableLevel + 1];

        int productCount = fishCountTotal;
        for(int i = 0; i <= Globals.collectableLevel; i++)
        {
            productTypeCount[i] = Random.Range(0, productCount);
            productCount -= productTypeCount[i];
        }
        if(productCount > 0)
        {
            int randomSelect = Random.Range(0, productTypeCount.Length);
            productTypeCount[randomSelect] += productCount;
            productCount -= productTypeCount[randomSelect];
        }
        for (int i = 0; i < productTypeCountTotal.Length; i++)
        {
            productTypeCountTotal[i] = productTypeCount[i];
        }
        TextInitCheck();
    }


    public override void DropCollection(int collectAmount, StackCollect _stackCollect)
    {
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
                    //if (collectType2 == CollectType.All || collectType == CollectType.All || _stackCollect.collectionTrs[i].collectType == collectType || _stackCollect.collectionTrs[i].collectType == collectType2)
                    {
                        bool loopActive = true;
                        for (int j = 0; j < productTypeCount.Length; j++)
                        {
                            if (_stackCollect.collectionTrs[i].collectType == CollectType.Type1 && productTypeCount[0] > 0)
                            {
                                productTypeCount[0]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (_stackCollect.collectionTrs[i].collectType == CollectType.Type2 && productTypeCount[1] > 0)
                            {
                                productTypeCount[1]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (_stackCollect.collectionTrs[i].collectType == CollectType.Type3 && productTypeCount[2] > 0)
                            {
                                productTypeCount[2]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (_stackCollect.collectionTrs[i].collectType == CollectType.Type4 && productTypeCount[3] > 0)
                            {
                                productTypeCount[3]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                            if (_stackCollect.collectionTrs[i].collectType == CollectType.Type5 && productTypeCount[4] > 0)
                            {
                                productTypeCount[4]--;
                                droppingCollection = _stackCollect.collectionTrs[i];
                                i = _stackCollect.collectionTrs.Count;
                                loopActive = false;
                                break;
                            }
                        }
                        if (!loopActive)
                        {
                            break;
                        }
                    }

                }
            }
        }
        if (droppingCollection != null)
        {
            Collectable deletedCollect = droppingCollection;

            _stackCollect.collectionTrs.Remove(deletedCollect);



            droppedCollectionList.Add(droppingCollection);
            PlayerPrefs.SetInt(machineName + "rawcount", droppedCollectionList.Count);

            yield return null;
            droppingCollection.collectActive = false;
            float deltaY = 0;
            deltaY = (droppedCollectionList.Count - 1) / currentCar.GetComponent<FishCar>().fishPosTR.Length;
            Transform targetTR = currentCar.GetComponent<FishCar>().fishPosTR[(droppedCollectionList.Count - 1) % currentCar.GetComponent<FishCar>().fishPosTR.Length];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollection, Time.deltaTime));
            if (_stackCollect.player)
            {
                VibratoManager.Instance.LightVibration();
            }

            fishCountCurrent -= 1;

            //fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
            TextInitCheck();

            if (fishCountCurrent == 0 && !resetActive)
            {
                resetActive = true;
                SpecificReset();
            }
        }


        yield return new WaitForSeconds(0.5f);
        _stackCollect.collectActive = true;

        //yield return null;

        //List<Collectable> droppingCollectionList = new List<Collectable>();

        //int amount = collectAmount;
        //int loopCount = _stackCollect.collectionTrs.Count;
        //for (int i = 0; i < loopCount; i++)
        //{
        //    foreach (var clListId in collectIDList)
        //    {
        //        if (_stackCollect.collectionTrs[i].collectID == clListId && amount > 0)
        //        {
        //            bool loopActive = true;
        //            for (int j = 0; j < productTypeCount.Length; j++)
        //            {
        //                if(_stackCollect.collectionTrs[i].collectType == CollectType.Type1 && productTypeCount[0] > 0)
        //                {
        //                    productTypeCount[0]--;
        //                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);
        //                    amount--;
        //                    loopActive = false;
        //                    break;
        //                }
        //                if (_stackCollect.collectionTrs[i].collectType == CollectType.Type2 && productTypeCount[1] > 0)
        //                {
        //                    productTypeCount[1]--;
        //                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);
        //                    amount--;
        //                    loopActive = false;
        //                    break;
        //                }
        //                if (_stackCollect.collectionTrs[i].collectType == CollectType.Type3 && productTypeCount[2] > 0)
        //                {
        //                    productTypeCount[2]--;
        //                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);
        //                    amount--;
        //                    loopActive = false;
        //                    break;
        //                }
        //                if (_stackCollect.collectionTrs[i].collectType == CollectType.Type4 && productTypeCount[3] > 0)
        //                {
        //                    productTypeCount[3]--;
        //                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);
        //                    amount--;
        //                    loopActive = false;
        //                    break;
        //                }
        //                if (_stackCollect.collectionTrs[i].collectType == CollectType.Type5 && productTypeCount[4] > 0)
        //                {
        //                    productTypeCount[4]--;
        //                    droppingCollectionList.Add(_stackCollect.collectionTrs[i]);
        //                    amount--;
        //                    loopActive = false;
        //                    break;
        //                }
        //            }
        //            if (!loopActive)
        //            {
        //                break;
        //            }
        //        }
        //    }
        //}


        //for (int i = 0; i < droppingCollectionList.Count; i++)
        //{
        //    Collectable deletedCollect = droppingCollectionList[i];

        //    _stackCollect.collectionTrs.Remove(deletedCollect);
        //}
        //for (int i = 0; i < droppingCollectionList.Count; i++)
        //{
        //    droppedCollectionList.Add(droppingCollectionList[i]);

        //    float deltaY = 0;
        //    deltaY = (droppedCollectionList.Count - 1) / currentCar.GetComponent<FishCar>().fishPosTR.Length;
        //    Transform targetTR = currentCar.GetComponent<FishCar>().fishPosTR[(droppedCollectionList.Count - 1) % currentCar.GetComponent<FishCar>().fishPosTR.Length];
        //    Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.3f, 0);
        //    StartCoroutine(Drop(targetTR, dropPos, droppingCollectionList[i], i * 0.05f));
        //    if (_stackCollect.player)
        //    {
        //        VibratoManager.Instance.LightVibration();
        //    }
        //}

        //_stackCollect.collectActive = true;
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


        //Quaternion targetAngle = Quaternion.Euler(dropPosTR.eulerAngles.x, dropPosTR.eulerAngles.y + Random.Range(-30f, 30f), dropPosTR.eulerAngles.z + Random.Range(-30f, 30f));

        while (timeCounter < 1f)
        {
            timeCounter += 4 * Time.deltaTime;

            angle = timeCounter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            if (collectable.gameObject != null)
            {
                collectable.transform.position = Vector3.Lerp(firstPos, new Vector3(dropPos.x, dropPos.y + posY, dropPos.z), timeCounter);
                collectable.transform.rotation = Quaternion.Lerp(firstRot, dropPosTR.rotation, timeCounter);
            }
  
            yield return null;
        }
        collectable.transform.position = dropPos;
        if (collectable.gameObject != null)
        {
            collectable.transform.parent = currentCar.GetComponent<FishCar>().fishPosParent;

        }
    }

    void DropMoney(List<Collectable> droppingCollectionList)
    {
        StartCoroutine(DroppingMoney(droppingCollectionList));
    }
    IEnumerator DroppingMoney(List<Collectable> droppingCollectionList)
    {
        int moneyListCount = moneyArea.moneyList.Count;
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
            Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos);
            banknot.banknotValue = droppingCollectionList[i].price;
            moneyArea.moneyList.Add(banknot);
            yield return null;
        }
        droppedCollectionList.Clear();

    }
    void ResetStand()
    {
        StartCoroutine(ResetDelay());
    }
    IEnumerator ResetDelay()
    {
        //DropMoney();
        StandActive = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(1f);
        DropMoney(droppedCollectionList);

        currentCar.GetComponent<FishCar>().CarGoOut();
        yield return new WaitForSeconds(0.1f);


        canvasDeliveringGO.SetActive(true);
        canvasProductGO.SetActive(false);
        float counter = 0f;
        while(counter < cooldownTime)
        {
            counter += Time.deltaTime;
            imageFill.fillAmount = counter / cooldownTime;
            yield return null;
        }
        imageFill.fillAmount = 1;
        canvasDeliveringGO.SetActive(false);
        canvasProductGO.SetActive(true);
        LevelInit();
        //fishCountText.text = (fishCountTotal - fishCountCurrent).ToString() + "/" + (fishCountTotal).ToString();
        TextInit();
        CarCreate();

        yield return new WaitForSeconds(1f);
        resetActive = false;


    }

}
