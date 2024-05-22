using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketCaseManager : MonoBehaviour
{
    private static MarketCaseManager _instance = null;
    public static MarketCaseManager Instance => _instance;
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
    [SerializeField] Transform exit;
    public Casier _casier;
    public Sprite standSprite;

    private void Awake()
    {
        _instance = this;
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
                DropCollection( collectedNo, _stackCollect);
                //StartCoroutine(SetFishAmount(-collectedNo));
        }
    }

    public void DropCollection( int collectAmount, StackCollect _stackCollect)
    {
        if (collectAmount > 0)
        {
            //VibratoManager.Instance.MediumMultiVibration();
            _stackCollect.collectActive = false;
        }
        StartCoroutine(DropSequantial( collectAmount, _stackCollect));
    }

    IEnumerator DropSequantial(int collectAmount, StackCollect _stackCollect)
    {
        yield return null;

        List<Collectable> droppingCollectionList = new List<Collectable>();

        int amount = collectAmount;
        int loopCount = _stackCollect.collectionTrs.Count;
        for (int i = 0; i < loopCount; i++)
        {
            if ( amount > 0)
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
        StartCoroutine(BoxGo(customerList[0]));
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
        if(other.GetComponent<PlayerController>() != null)
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
        //customer.shoppingBigCart.SetActive(false);
        customer.animator.SetBool("carry", true);

        currentBox.transform.parent = customer.boxPosTR.parent;
        currentBox.GetComponent<Box>().animator.SetTrigger("close");
        CloseProductList();
        Vector3 firstPos = currentBox.transform.position;
        Quaternion firstRot = currentBox.transform.rotation;


        Vector3 targetPos = customer.boxPosTR.position;
        Quaternion targetRot = customer.boxPosTR.rotation;


        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        float counter = 0f;
        while(counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);


            currentBox.transform.position = Vector3.Lerp(firstPos, new Vector3(targetPos.x, targetPos.y + posY, targetPos.z), counter);
            currentBox.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        DropMoney(collectableList);
        customer.canvasProduactTR.gameObject.SetActive(false);
        customer.smileyGO.SetActive(true);
    }
    void CloseProductList()
    {
        foreach(var prct in collectableList)
        {
            prct.gameObject.SetActive(false);
        }
    }
    void ClearProductList()
    {
        foreach (var prct in collectableList)
        {
            Destroy(prct.gameObject);
        }
        collectableList.Clear();
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
            banknot.banknotValue = droppingCollectionList[i].price;
            moneyArea.moneyList.Add(banknot);
            yield return null;
        }
        ClearProductList();

        customerList[0].CustomerGoExit(exit);
        customerList.Remove(customerList[0]);
        AllCustomersMove();
        if (casierWorkerActive)
        {
            _casier._animator.SetBool("pay", false);
        }
    }
}
