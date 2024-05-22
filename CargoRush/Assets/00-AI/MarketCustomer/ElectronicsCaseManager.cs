using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElectronicsCaseManager : MonoBehaviour, IMoneyArea
{
    private static ElectronicsCaseManager _instance = null;
    public static ElectronicsCaseManager Instance => _instance;
    [SerializeField] MoneyArea moneyArea;

    public GameObject boxPrefab;
    public Transform boxFristPosTR;
    public List<Transform> productDropPosList;
    public List<Collectable> collectableList;

    public List<Transform> customerWaitPosListTR;
    public List<AIMarketCustomer> customerList;
    GameObject currentBox;
    public bool casierActive = false;
    public bool casierWorkerActive = false;
    public Transform exit;
    public Casier _casier;
    public Sprite standSprite;
    public Transform customerCreateTR;
    Vector3 firstColliderSize;
    public string caseName;

    public List<AIMarketCustomer> extraCustomerList;
    public Transform vipWaitingPosTR;

    public GameObject waitProgressGO;
    public Image waitProgressFill;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        firstColliderSize = moneyArea.GetComponent<BoxCollider>().size;
        StartCoroutine(MoneyCreate());
    }
    public void MoneySave()
    {
        PlayerPrefs.SetInt(caseName + "totalvalue", 0);
        PlayerPrefs.SetInt(caseName + "banknotcount", 0);
    }
    IEnumerator ColliderReset()
    {
        moneyArea.GetComponent<BoxCollider>().size = Vector3.zero;
        vipMoneyDropArea.GetComponent<BoxCollider>().size = Vector3.zero;
        yield return new WaitForSeconds(0.1f);
        moneyArea.GetComponent<BoxCollider>().size = firstColliderSize;
        vipMoneyDropArea.GetComponent<BoxCollider>().size = firstColliderSize;
    }
    public void PayCustomer()
    {
        currentBox = Instantiate(boxPrefab, boxFristPosTR.position, boxFristPosTR.rotation);
        currentBox.transform.parent = boxFristPosTR.parent;
        currentBox.transform.localScale = boxFristPosTR.localScale;
        DropCustomerProduct();
        if (casierWorkerActive)
        {
            _casier._animator.SetBool("pay", true);
        }
    }
    void DropCustomerProduct()
    {
        CollectionChecking(customerList[0].aiStackCollect);
    }
    void AllCustomersMove()
    {
        PlayerPrefs.SetInt("focuscounter", PlayerPrefs.GetInt("focuscounter") + 1);
        foreach (var cstmr in customerList)
        {
            cstmr.CasetargetPosSelect();
        }
    }

    void CollectionChecking(StackCollect _stackCollect)
    {

        int collectedNo = 0;
        foreach (var collects in _stackCollect.collectionTrs)
        {
            {
                collectedNo++;
            }
        }

        _stackCollect.ReverseCollectedList();
        _stackCollect.CollectedListReset();

        if (collectedNo > 0)
        {
            DropCollection(collectedNo, _stackCollect);
            //StartCoroutine(SetFishAmount(-collectedNo));
        }
    }

    public void DropCollection(int collectAmount, StackCollect _stackCollect)
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
            if (amount > 0)
            {
                droppingCollectionList.Add(_stackCollect.collectionTrs[i]);

                amount--;
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
            collectableList.Add(droppingCollectionList[i]);
            yield return new WaitForSeconds(0.2f);
            droppingCollectionList[i].collectActive = false;
            float deltaY = 0;
            deltaY = (collectableList.Count - 1) / productDropPosList.Count;
            Transform targetTR = productDropPosList[(collectableList.Count - 1) % productDropPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.1f, 0);
            StartCoroutine(Drop(targetTR, dropPos, droppingCollectionList[i], i * 0.05f));

            //yield return null;
        }

        if (_stackCollect.collectionTrs.Count == 0)
        {
            //PlayerController.Instance.animator.SetBool("carrying", false);
        }
        yield return new WaitForSeconds(0.5f);
        if (customerList[0].customerLevel == 2)
        {
            StartCoroutine(BoxGo2(customerList[0]));
        }
        else
        {
            StartCoroutine(BoxGo(customerList[0]));
        }
    }
    IEnumerator Drop(Transform dropPosTR, Vector3 dropPos, Collectable collectable, float waitTime)
    {

        //collectable.animator.SetTrigger("stop");
        yield return new WaitForSeconds(waitTime);
        if (collectable.GetComponent<Animator>() != null)
        {
            collectable.GetComponent<Animator>().SetTrigger("close");
        }
        collectable.transform.parent = currentBox.transform;
        Vector3 firstPos = collectable.transform.position;
        Quaternion firstRot = collectable.transform.rotation;
        if (collectable.gameObject != null)
        {
            collectable.CollectSave();
            //collectable.transform.parent = null;
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

        if (collectable.gameObject != null)
        {

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            casierActive = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            casierActive = false;
        }
    }
    IEnumerator BoxGo(AIMarketCustomer customer)
    {
        customer.currentBox = currentBox.transform;
        //customer.shoppingBigCart.SetActive(false);
        customer.animator.SetBool("carry", true);

        currentBox.transform.parent = customer.boxPosTR.parent;
        currentBox.GetComponent<Box>().animator.SetTrigger("close");

        SetSize();

        //CloseProductList();


        yield return new WaitForSeconds(0.5f);
        Vector3 firstPos = currentBox.transform.position;
        Quaternion firstRot = currentBox.transform.rotation;


        Vector3 targetPos = customer.boxPosTR.position;
        Quaternion targetRot = customer.boxPosTR.rotation;


        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            currentBox.transform.position = Vector3.Lerp(firstPos, new Vector3(targetPos.x, targetPos.y + posY, targetPos.z), counter);
            currentBox.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        currentBox.transform.position = targetPos;

        DropMoney(collectableList);
        customer.canvasProduactTR.gameObject.SetActive(false);
        customer.smileyGO.SetActive(true);
    }
    IEnumerator BoxGo2(AIMarketCustomer customer)
    {
        customer.currentBox = currentBox.transform;
        //customer.shoppingBigCart.SetActive(false);
        customer.animator.SetBool("carry", true);

        currentBox.transform.parent = customer.boxPosTR_Inside2.parent;
        currentBox.GetComponent<Box>().animator.SetTrigger("close");
        SetSize();

        //CloseProductList();
        Vector3 firstPos = currentBox.transform.position;
        Quaternion firstRot = currentBox.transform.rotation;


        Vector3 targetPos = customer.boxPosTR_Inside2.position;
        Quaternion targetRot = customer.boxPosTR_Inside2.rotation;


        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            currentBox.transform.position = Vector3.Lerp(firstPos, new Vector3(targetPos.x, targetPos.y + posY, targetPos.z), counter);
            currentBox.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        currentBox.transform.position = targetPos;

        DropMoney(collectableList);
        customer.canvasProduactTR.gameObject.SetActive(false);
        customer.smileyGO.SetActive(true);
    }
    void CloseProductList()
    {
        foreach (var prct in collectableList)
        {
            prct.gameObject.SetActive(false);
        }
    }
    void SetSize()
    {
        foreach (var prct in collectableList)
        {
            prct.transform.localScale *= 0.5f;
        }
    }
    void ClearProductList()
    {
        foreach (var prct in collectableList)
        {
            //Destroy(prct.gameObject);
        }
        collectableList.Clear();
    }
    IEnumerator MoneyCreate()
    {
        int banknotVal = 1;
        if (PlayerPrefs.GetInt(caseName + "banknotcount") > 0)
        {
            banknotVal = 1 + PlayerPrefs.GetInt(caseName + "totalvalue") / PlayerPrefs.GetInt(caseName + "banknotcount");
        }
        for (int i = 0; i < PlayerPrefs.GetInt(caseName + "banknotcount"); i++)
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
            banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = droppingCollectionList[i].price + Globals.extraMoneySkin;
            moneyArea.moneyList.Add(banknot);
            PlayerPrefs.SetInt(caseName + "totalvalue", PlayerPrefs.GetInt(caseName + "totalvalue") + banknot.banknotValue);

            if (MissionManager.Instance.saleMissionList[droppingCollectionList[i].collectID - 2].gameObject.activeInHierarchy)
            {
                MissionManager.Instance.saleMissionList[droppingCollectionList[i].collectID - 2].MissionUpdateSale(droppingCollectionList[i].collectID - 2);
            }

            yield return null;
        }

        if (Globals.doubleIncomeActive)
        {
            moneyListCount = moneyArea.moneyList.Count;
            for (int i = 0; i < droppingCollectionList.Count; i++)
            {
                float deltaY = 0;
                deltaY = (moneyListCount + i) / moneyArea.dropMoneyPosList.Count;
                Transform targetTR = moneyArea.dropMoneyPosList[(moneyListCount + i) % moneyArea.dropMoneyPosList.Count];
                Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
                BanknotMoney banknot = Instantiate(moneyArea.moneyPrefab, moneyArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
                banknot.MovingMoney(moneyArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
                banknot.banknotValue = droppingCollectionList[i].price;
                moneyArea.moneyList.Add(banknot);
                PlayerPrefs.SetInt(caseName + "totalvalue", PlayerPrefs.GetInt(caseName + "totalvalue") + banknot.banknotValue);

                yield return null;
            }
        }
        PlayerPrefs.SetInt(caseName + "banknotcount", moneyArea.moneyList.Count);

        ClearProductList();


        AIBehaviour();

        customerList.Remove(customerList[0]);

        AllCustomersMove();
        if (casierWorkerActive)
        {
            _casier._animator.SetBool("pay", false);
        }
        StartCoroutine(ColliderReset());

    }
    void AIBehaviour()
    {
        List<MarketType> marketTypes = new List<MarketType>();
        if (MarketCustomerManager.Instance.maxCharacterCount_Sports > 0)
        {
            marketTypes.Add(MarketType.Sports);
        }
        if (MarketCustomerManager.Instance.maxCharacterCount_Toys > 0)
        {
            marketTypes.Add(MarketType.Toys);
        }


        int randomselect = Random.Range(0, 100);
        if (randomselect < 2 && marketTypes.Count > 0 && customerList[0].secondShoppingActive && extraCustomerList.Count < 3)
        {
            int typeSelect = Random.Range(0, marketTypes.Count);
            MarketCustomerManager.Instance.CustomerRemoveList(customerList[0], MarketType.Electronics);
            MarketCustomerManager.Instance.ReInit(customerList[0], marketTypes[typeSelect]);


        }
        else
        {

            customerList[0].CustomerGoExit(exit);
        }

    }

    [SerializeField] MoneyArea vipMoneyDropArea;


    public VipCustomer vipCustomer;
    public void VipWaitStart()
    {
        waitProgressGO.SetActive(true);
        StartCoroutine(VipWaiting(300));
        StartCoroutine(DigitalCounter(300));
    }

    IEnumerator VipWaiting(int _time)
    {
        waitProgressFill.fillAmount = 0;
        float counter = 0f;
        float waitTime = _time;
        while (counter < waitTime && !vipCustomer.itsOk)
        {
            counter += (1f / 60f);
            waitProgressFill.fillAmount = counter / waitTime;
            yield return new WaitForSeconds(1f/60f);
        }
        if (vipCustomer.itsOk)
        {
            DropMoneyVip(vipCustomer.aiStackCollect.collectionTrs);
            vipCustomer.smileyGO.SetActive(true);
            vipCounter = 0;
        }
        else
        {
            vipCustomer.emojiAngryGO.SetActive(true);
            vipCustomer.aiStackCollect.DisperseCollected();
        }
        vipCustomer.GoExit();
        waitProgressGO.SetActive(false);

    }
    public int vipCounter;
    IEnumerator DigitalCounter(int _time)
    {
        vipCounter = _time;
        RewardPanel.Instance.vipPanelGO.SetActive(true);
        while (vipCounter > 0)
        {
            int minute = Mathf.FloorToInt(vipCounter / 60);
            int second = Mathf.FloorToInt(vipCounter % 60);

            RewardPanel.Instance.vipCounterText.text = minute.ToString() + ":" + ($"{second}");
            if (minute < 10)
            {
                RewardPanel.Instance.vipCounterText.text = "0" + minute.ToString() + ":" + ($"{second}");

            }
            if (second < 10)
            {
                RewardPanel.Instance.vipCounterText.text = minute.ToString() + ":0" + ($"{second}");
                if (minute < 10)
                {
                    RewardPanel.Instance.vipCounterText.text = "0" + minute.ToString() + ":0" + ($"{second}");

                }
                if (vipCounter <= 3)
                {
                    StartCoroutine(CounterTextColorSet(RewardPanel.Instance.vipCounterText));
                    VibratoManager.Instance.LightVibration();
                }
            }
            vipCounter--;
            yield return new WaitForSeconds(1);
            if (!Globals.holePlatformActive)
            {
                RewardPanel.Instance.vipPanelGO.SetActive(true);
            }
        }

        RewardPanel.Instance.vipCounterText.text = "00:00";
        yield return new WaitForSeconds(0.5f);
        RewardPanel.Instance.vipPanelGO.SetActive(false);

    }
    IEnumerator CounterTextColorSet(TextMeshProUGUI txt)
    {
        float counter = 0f;
        float value = 0f;
        while (counter < 1f)
        {
            counter += Time.deltaTime;
            value = (Mathf.Sin(Mathf.PI * counter));
            //holeTimerBG_Image.color = Color.Lerp(firstColor, targetColor, value);
            txt.color = Color.Lerp(Color.white, Color.red, value);
            yield return null;
        }
        txt.color = Color.white;
    }
    void DropMoneyVip(List<Collectable> droppingCollectionList)
    {
        StartCoroutine(DroppingMoneyVip(droppingCollectionList));
    }
    IEnumerator DroppingMoneyVip(List<Collectable> droppingCollectionList)
    {

        int moneyListCount = vipMoneyDropArea.moneyList.Count;
        for (int i = 0; i < droppingCollectionList.Count; i++)
        {
            float deltaY = 0;
            deltaY = (moneyListCount + i) / vipMoneyDropArea.dropMoneyPosList.Count;
            Transform targetTR = vipMoneyDropArea.dropMoneyPosList[(moneyListCount + i) % vipMoneyDropArea.dropMoneyPosList.Count];
            Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
            BanknotMoney banknot = Instantiate(vipMoneyDropArea.moneyPrefab, vipMoneyDropArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
            banknot.MovingMoney(vipMoneyDropArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
            banknot.banknotValue = (droppingCollectionList[i].price + vipCustomer.extraPrice + Globals.extraMoneySkin);
            vipMoneyDropArea.moneyList.Add(banknot);
            yield return null;
        }
        if (Globals.doubleIncomeActive)
        {
            moneyListCount = moneyArea.moneyList.Count;
            for (int i = 0; i < droppingCollectionList.Count; i++)
            {
                float deltaY = 0;
                deltaY = (moneyListCount + i) / vipMoneyDropArea.dropMoneyPosList.Count;
                Transform targetTR = vipMoneyDropArea.dropMoneyPosList[(moneyListCount + i) % vipMoneyDropArea.dropMoneyPosList.Count];
                Vector3 dropPos = targetTR.position + new Vector3(0, deltaY * 0.2f, 0);
                BanknotMoney banknot = Instantiate(vipMoneyDropArea.moneyPrefab, vipMoneyDropArea.firstMoneyCreatePosTR.position, Quaternion.identity).GetComponent<BanknotMoney>();
                banknot.MovingMoney(vipMoneyDropArea.firstMoneyCreatePosTR.position, dropPos, targetTR);
                banknot.banknotValue = (droppingCollectionList[i].price + vipCustomer.extraPrice);
                vipMoneyDropArea.moneyList.Add(banknot);
                yield return null;
            }
        }

        StartCoroutine(ColliderReset());
    }
}
