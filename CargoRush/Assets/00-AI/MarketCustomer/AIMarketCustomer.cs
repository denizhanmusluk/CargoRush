using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

public class AIMarketCustomer : MonoBehaviour
{
    public MarketType marketType;

    public event Action following;
    public Transform boxPosTR;
    public Transform boxPosTR_Inside1;
    public Transform boxPosTR_Inside2;

    public StackCollect aiStackCollect;

    public NavMeshAgent navMeshAgent;
    public Animator animator;

    public float AImoveSpeed;

    // // // // //
    public List<CollectProduct> collectAreaList;

    public List<CollectProduct> collectAreaTarget;
    public CollectProduct currentTarget;
    [SerializeField] int selectAreaCountTotal;
    public int selectAreaCountCurrent = 0;
    //[SerializeField] int focusChance;



    public bool isStayHoldActive = false;
    int targetCollectId = 0;
    bool characterStayActive = false;
    Vector2 fishCollectOffset;


    [SerializeField] Image _image;
    [SerializeField] TextMeshProUGUI stackText;
    int maxCount = 0;
    public int currentCountStack = 0;
    public Transform canvasProduactTR;
    public GameObject smileyGO;
    public bool moveActive = true;
    public bool shoppingActive = true;


    [SerializeField] GameObject shoppingHandCart;
    //public GameObject shoppingBigCart;
    public int customerLevel = 0;
    public bool secondShoppingActive = true;
    public Transform currentBox;

    public Transform cabineTargetPoint;
    public bool vipActive = false;
    public void ReStart()
    {
        StartCoroutine(RestartDelay());
    }
    IEnumerator RestartDelay()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("ReStart");
        aiStackCollect.collectActive = true;
        paymentActive = true;
        shoppingActive = true;
        secondShoppingActive = false;
        StartCoroutine(StartDelay());

        navMeshAgent.speed = AImoveSpeed;
        selectAreaCountCurrent = 0;
        selectAreaCountTotal = 1;
        for (int i = 0; i < collectAreaList.Count; i++)
        {
            if (!collectAreaList[i].machineActive)
            {
                if (collectAreaList[i].customerCount < 2)
                {
                    collectAreaTarget.Add(collectAreaList[i]);
                    collectAreaList[i].customerCount++;
                    collectAreaList.Remove(collectAreaList[i]);
                    break;
                }
            }
            else
            {
                collectAreaTarget.Add(collectAreaList[i]);
                collectAreaList[i].customerCount++;
                collectAreaList.Remove(collectAreaList[i]);
                break;
            }
        }

        customerLevel = 2;
        CustomerLevelInit();
        StartCoroutine(FirstBoxReMove());
    }
    IEnumerator FirstBoxReMove()
    {
        currentBox.transform.parent = boxPosTR_Inside1.parent;

        Vector3 firstPos = currentBox.transform.position;
        Quaternion firstRot = currentBox.transform.rotation;


        Vector3 targetPos = boxPosTR_Inside1.position;
        Quaternion targetRot = boxPosTR_Inside1.rotation;

        float angle = 0f;
        float posY = 0f;
        float posY_Factor = 2f;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            angle = counter * Mathf.PI;
            posY = posY_Factor * Mathf.Sin(angle);

            targetPos = boxPosTR_Inside1.position;
            targetRot = boxPosTR_Inside1.rotation;
            currentBox.transform.position = Vector3.Lerp(firstPos, new Vector3(targetPos.x, targetPos.y + posY, targetPos.z), counter);
            currentBox.transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        canvasProduactTR.gameObject.SetActive(true);
    }
    public void Start()
    {
        StartCoroutine(StartDelay());

        navMeshAgent.speed = AImoveSpeed;

        //selectAreaCountTotal = UnityEngine.Random.Range(1, collectAreaList.Count + 1);

        if (collectAreaList.Count >= 2)
        {
            int randomselect = UnityEngine.Random.Range(0, 100);

            if (randomselect > 60)
            {
                selectAreaCountTotal = 2;
            }
            else
            {
                selectAreaCountTotal = 1;
            }
        }
        else
        {
            selectAreaCountTotal = 1;
        }

        if (selectAreaCountTotal > 2)
        {
            selectAreaCountTotal = 2;
        }
        if (selectAreaCountTotal > 1)
        {

            for (int x = 0; x < 2; x++)
            {
                for (int i = 0; i < collectAreaList.Count; i++)
                {
                    if (!collectAreaList[i].machineActive)
                    {
                        if (collectAreaList[i].customerCount < 2)
                        {
                            collectAreaTarget.Add(collectAreaList[i]);
                            collectAreaList[i].customerCount++;
                            collectAreaList.Remove(collectAreaList[i]);
                            break;
                        }
                    }
                    else
                    {
                        collectAreaTarget.Add(collectAreaList[i]);
                        collectAreaList[i].customerCount++;
                        collectAreaList.Remove(collectAreaList[i]);
                        break;
                    }
                }
            }
            selectAreaCountTotal = collectAreaTarget.Count;

        }
        else
        {
            {
                for (int i = 0; i < collectAreaList.Count; i++)
                {
                    if (!collectAreaList[i].machineActive)
                    {
                        if (collectAreaList[i].customerCount < 2)
                        {
                            collectAreaTarget.Add(collectAreaList[i]);
                            collectAreaList[i].customerCount++;
                            collectAreaList.Remove(collectAreaList[i]);
                            break;
                        }
                    }
                    else
                    {
                        collectAreaTarget.Add(collectAreaList[i]);
                        collectAreaList[i].customerCount++;
                        collectAreaList.Remove(collectAreaList[i]);
                        break;
                    }
                }
            }
        }



        customerLevel = selectAreaCountTotal - 1;
        CustomerLevelInit();
    }
    void Randomer()
    {
        List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        System.Random random = new System.Random();

        for (int i = myList.Count - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1); // 0 ile i arasýnda rastgele bir sayý alýr.

            int temp = myList[i];
            myList[i] = myList[j];
            myList[j] = temp;
        }
    }
    void CustomerLevelInit()
    {
        aiStackCollect.stackLevel = customerLevel;
        if (customerLevel == 1)
        {
            shoppingHandCart.SetActive(true);
        }
        if (customerLevel == 2)
        {
            shoppingHandCart.SetActive(true);
            navMeshAgent.radius = 0.6f;
        }
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(2f);
        TargetFishAreaSelect(true, false);

    }
    public void NextTarget()
    {
        currentTarget.aiCollectTargetTR[targetPointSelect].GetComponent<AICollectTarget>().isSelected = false;

        StartCoroutine(SameTargetCheckReset());
        moveActive = true;
        //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        currentCountStack = 0;
        selectAreaCountCurrent++;
        TargetFishAreaSelect(false,false);
    }
    public void TargetFishAreaSelect(bool variableStack,bool sameStand)
    {
        if (collectAreaTarget.Count == 0)
        {
            MarketCustomerManager.Instance.CustomerRemoveList(this, marketType);
            Destroy(gameObject, 0.1f);

            return;
        }
        isStayHoldActive = false;

        if (selectAreaCountTotal > selectAreaCountCurrent)
        {
            currentTarget = collectAreaTarget[selectAreaCountCurrent];
            int stackCount = 1;
           

            if (variableStack && PlayerPrefs.GetInt("tutorialsection1") != 0)
            {
                stackCount = UnityEngine.Random.Range((int)currentTarget.customerMinMax.x, (int)currentTarget.customerMinMax.y);
            }
            maxCount = stackCount;
            _image.sprite = currentTarget.standSprite;
            StackTextInit();
            targetCollectId = currentTarget.CollectId;
            aiStackCollect.GetComponent<StackCollectMarketCustomer>().targetId = targetCollectId;

            if (!sameStand)
            {
                aiStackCollect.GetComponent<StackCollectMarketCustomer>().stackCapacity += stackCount;
            }
            fishCollectOffset = new Vector2(UnityEngine.Random.Range(-0.5f, 0.5f), UnityEngine.Random.Range(-0.5f, 0.5f));

            targetPointSelect = UnityEngine.Random.Range(0, currentTarget.aiCollectTargetTR.Length);

            for (int i = 0; i < currentTarget.aiCollectTargetTR.Length; i++)
            {
                if (!currentTarget.aiCollectTargetTR[i].GetComponent<AICollectTarget>().isSelected)
                {
                    currentTarget.aiCollectTargetTR[i].GetComponent<AICollectTarget>().isSelected = true;
                    targetPointSelect = i;
                    break;
                }
            }
            following = null;
            following += GoToFishCollectArea;
        }
        else
        {
            shoppingActive = false;
            if (marketType == MarketType.Sports)
            {
                int randomselect = UnityEngine.Random.Range(0, 100);
                bool clothesActive = false;
                foreach(var clct in aiStackCollect.collectionTrs)
                {
                    if(clct.collectID == 5 || clct.collectID == 6)
                    {
                        clothesActive = true;
                    }
                }
                if (PlayerPrefs.GetInt("firstcabincustomer") == 0)
                {
                    PlayerPrefs.SetInt("firstcabincustomer", 1);
                    GoCabin(0);
                }
                else
                {
                    int cabineSelect = 0;
                    bool isCabineActive = false;
                    for (int i = 0; i < SportsCaseManager.Instance.standCabins.Count; i++)
                    {
                        if (SportsCaseManager.Instance.standCabins[i].cabineActive && !SportsCaseManager.Instance.standCabins[i].cabineCollectableFull)
                        {
                            if (SportsCaseManager.Instance.standCabins[i].customerCount < 5)
                            {
                                isCabineActive = true;
                                cabineSelect = i;
                            }
                            else
                            {
                                isCabineActive = false;
                            }
                        }
                    }
                    if (randomselect > 85 && clothesActive && isCabineActive)
                    {
                        GoCabin(cabineSelect);
                    }
                    else
                    {
                        CaseWaitListAdd();
                    }
                }
            }
            else
            {
                CaseWaitListAdd();
            }
        }
    }
    public void StackTextInit()
    {
        stackText.text = currentCountStack.ToString() + "/" + maxCount.ToString();

    }
    int targetPointSelect = 0;

    void GoToFishCollectArea()
    {
        if (moveActive && Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(currentTarget.aiCollectTargetTR[targetPointSelect].position.x + fishCollectOffset.x, currentTarget.aiCollectTargetTR[targetPointSelect].position.z + fishCollectOffset.y)) > 0.6f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(currentTarget.aiCollectTargetTR[targetPointSelect].position.x + fishCollectOffset.x, currentTarget.aiCollectTargetTR[targetPointSelect].position.y, currentTarget.aiCollectTargetTR[targetPointSelect].position.z + fishCollectOffset.y);
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);
            if (navMeshAgent.isStopped)
            {
                moveActive = false;
            }
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;
                //TargetFishAreaSelect();
                animator.SetBool("walk", false);
                following = null;
                currentTarget._stand.TargetCustomerArrived(this);

                //fishCollectArea.TargetArrived(this);
                //navMeshAgent.SetDestination(transform.position);
                //navMeshAgent.stoppingDistance
            }
        }
    }
    //public void TaragetCustomerArrivedCurrentStand()
    //{
    //    if (currentTarget != null)
    //    {
    //        currentTarget._stand.TargetCustomerArrived(this);
    //    }
    //}
    Transform caseTargetPos;


    public StandCabin currnetStandCabin;
    public Transform insidePoint;
    public void GoCabinInside(Transform _insidePoint)
    {
        insidePoint = _insidePoint;
        isStayHoldActive = false;
        following = null;
        following += GoingCabinInside;
    }
    void GoingCabinInside()
    {
        if (moveActive && Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(insidePoint.position.x, insidePoint.position.z)) > 0.6f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(insidePoint.position.x, transform.position.y, insidePoint.position.z);
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);
            if (navMeshAgent.isStopped)
            {
                moveActive = false;
            }
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;
                //TargetFishAreaSelect();
                animator.SetBool("walk", false);
                following = null;
                currnetStandCabin.CustomerArrivedInside(this);

                //fishCollectArea.TargetArrived(this);
                //navMeshAgent.SetDestination(transform.position);
                //navMeshAgent.stoppingDistance
            }
        }
    }


    void GoCabin(int cabineSelect)
    {
        //int cabineSelect = 0;
        //for(int i = 0; i < SportsCaseManager.Instance.standCabins.Count; i++)
        //{
        //    if (SportsCaseManager.Instance.standCabins[i].cabineActive && !SportsCaseManager.Instance.standCabins[i].cabineCollectableFull)
        //    {
        //        cabineSelect = i;
        //    }

        //}

        int pointSelect = 0;
        pointSelect = UnityEngine.Random.Range(0, SportsCaseManager.Instance.standCabins[cabineSelect].targetPointList.Count);
        cabineTargetPoint = SportsCaseManager.Instance.standCabins[cabineSelect].targetPointList[pointSelect];
        currnetStandCabin = SportsCaseManager.Instance.standCabins[cabineSelect];
        currnetStandCabin.customerCount++;

        isStayHoldActive = false;
        following = null;
        following += GoToCabinWaitArea;

    }
    void GoToCabinWaitArea()
    {
        if (moveActive && Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(cabineTargetPoint.position.x, cabineTargetPoint.position.z)) > 0.6f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(cabineTargetPoint.position.x, transform.position.y, cabineTargetPoint.position.z);
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);
            if (navMeshAgent.isStopped)
            {
                moveActive = false;
            }
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;
                //TargetFishAreaSelect();
                animator.SetBool("walk", false);
                following = null;
                currnetStandCabin.CustomerArrived(this);

                //fishCollectArea.TargetArrived(this);
                //navMeshAgent.SetDestination(transform.position);
                //navMeshAgent.stoppingDistance
            }
        }
    }

    public void CaseWaitListAdd()
    {
        navMeshAgent.stoppingDistance = 0.15f;
        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    ElectronicsCaseManager.Instance.customerList.Add(this);
                }
                break;

            case MarketType.Sports:
                {
                    SportsCaseManager.Instance.customerList.Add(this);
                }
                break;

            case MarketType.Toys:
                {
                    ToysCaseManager.Instance.customerList.Add(this);
                }
                break;
        }
        CasetargetPosSelect();
    }
    public bool goToPaying = false;
    public void CasetargetPosSelect()
    {
        goToPaying = true;
        switch (marketType)
        {
            case MarketType.Electronics:
                {
                    _image.sprite = ElectronicsCaseManager.Instance.standSprite;
                    caseTargetPos = ElectronicsCaseManager.Instance.customerWaitPosListTR[ElectronicsCaseManager.Instance.customerList.IndexOf(this)];

                }
                break;

            case MarketType.Sports:
                {
                    _image.sprite = SportsCaseManager.Instance.standSprite;
                    caseTargetPos = SportsCaseManager.Instance.customerWaitPosListTR[SportsCaseManager.Instance.customerList.IndexOf(this)];

                }
                break;

            case MarketType.Toys:
                {
                    _image.sprite = ToysCaseManager.Instance.standSprite;
                    caseTargetPos = ToysCaseManager.Instance.customerWaitPosListTR[ToysCaseManager.Instance.customerList.IndexOf(this)];

                }
                break;
        }

        _image.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, _image.GetComponent<RectTransform>().anchoredPosition.y);
        stackText.gameObject.SetActive(false);
        //_image.transform.GetChild(0).gameObject.SetActive(false);
        isStayHoldActive = false;

        following = null;
        following += GoCaseTargetPos;
    }
    void GoCaseTargetPos()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(caseTargetPos.position.x, caseTargetPos.position.z)) > 0.2f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(caseTargetPos.position.x, caseTargetPos.position.y, caseTargetPos.position.z);
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);
            //if (navMeshAgent.isStopped)
            //{
            //    moveActive = false;
            //}
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }
            if (!isStayHoldActive)
            {
                isStayHoldActive = true;
                //TargetFishAreaSelect();
                animator.SetBool("walk", false);
                following = null;
                StartCoroutine(PosRotate(caseTargetPos.rotation));
                switch (marketType)
                {
                    case MarketType.Electronics:
                        {
                            if (ElectronicsCaseManager.Instance.customerList.IndexOf(this) == 0)
                            {
                                StartCoroutine(PaymentElectronics());
                            }
                        }
                        break;

                    case MarketType.Sports:
                        {
                            if (SportsCaseManager.Instance.customerList.IndexOf(this) == 0)
                            {
                                StartCoroutine(PaymentSports());
                            }
                        }
                        break;

                    case MarketType.Toys:
                        {
                            if (ToysCaseManager.Instance.customerList.IndexOf(this) == 0)
                            {
                                StartCoroutine(PaymentToys());
                            }
                        }
                        break;
                }
               
            }
        }
    }
    public bool paymentActive = true;
    IEnumerator PaymentElectronics()
    {
        while (paymentActive)
        {
            if (ElectronicsCaseManager.Instance.casierActive || ElectronicsCaseManager.Instance.casierWorkerActive)
            {
                paymentActive = false;
            }
            yield return null;
        }
        ElectronicsCaseManager.Instance.PayCustomer();
        PlayerPrefs.SetInt("tutorialsection1", 1);
        if (PlayerPrefs.GetInt("tutorialsection2") == 1)
        {
            PlayerPrefs.SetInt("tutorialsection1", 2);
        }
    }

    IEnumerator PaymentSports()
    {
        while (paymentActive)
        {
            if (SportsCaseManager.Instance.casierActive || SportsCaseManager.Instance.casierWorkerActive)
            {
                paymentActive = false;
            }
            yield return null;
        }
        SportsCaseManager.Instance.PayCustomer();
    }

    IEnumerator PaymentToys()
    {
        while (paymentActive)
        {
            if (ToysCaseManager.Instance.casierActive || ToysCaseManager.Instance.casierWorkerActive)
            {
                paymentActive = false;
            }
            yield return null;
        }
        ToysCaseManager.Instance.PayCustomer();
    }
    IEnumerator PosRotate(Quaternion targetRot)
    {
        Quaternion firstRot = transform.rotation;

        float counter = 0f;
        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;

            transform.rotation = Quaternion.Lerp(firstRot, targetRot, counter);
            yield return null;
        }
        transform.rotation = targetRot;
    }
    private void Update()
    {
        following?.Invoke();
        canvasProduactTR.rotation = Quaternion.Euler(canvasProduactTR.eulerAngles.x, 42.038f, canvasProduactTR.eulerAngles.z);
    }
    public void CustomerGoExit(Transform exitPosTR)
    {
        if (customerLevel != 2)
        {
            shoppingHandCart.SetActive(false);
        }
        else
        {
            if (marketType == MarketType.Electronics)
            {
                ElectronicsCaseManager.Instance.extraCustomerList.Remove(this);
            }
            if (marketType == MarketType.Sports)
            {
                SportsCaseManager.Instance.extraCustomerList.Remove(this);
            }
            if (marketType == MarketType.Toys)
            {
                ToysCaseManager.Instance.extraCustomerList.Remove(this);
            }
        }
        MarketCustomerManager.Instance.CustomerRemoveList(this, marketType);

        exitTR = exitPosTR;


        following = null;
        following += GoExitMove;
    }
    Transform exitTR;
    void GoExitMove()
    {

        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(exitTR.position.x, exitTR.position.z)) > 0.2f)
        {
            characterStayActive = false;

            Vector3 targetPos = exitTR.position;
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);

        }
        else
        {
            following = null;

            Destroy(gameObject, 0.1f);
        }



    }
    public void Customer_Staying(int[] collectIDList)
    {
        StartCoroutine(CustomerStaying(collectIDList));
    }
    IEnumerator CustomerStaying(int[] collectIDList)
    {
        int selectAreaCountPre = selectAreaCountCurrent;
        bool newTargetSelected = false;
        yield return new WaitForSeconds(2f);
        bool goOut = false;
        while (!goToPaying && !goOut && selectAreaCountPre == selectAreaCountCurrent && checkActive)
        {
            goOut = true;
            //foreach (var sk in aiCustomer.aiStackCollect.collectionTrs)
            {
                goOut = true;
                foreach (var clListId in collectIDList)
                {
                    if (!goToPaying && aiStackCollect.GetComponent<StackCollectMarketCustomer>().targetId == clListId)
                    {
                        goOut = false;
                        if (!goToPaying && NewSameTargetStand())
                        {
                            newTargetSelected = true;
                            goOut = true;
                        }
                        break;
                    }
                }
                if (newTargetSelected)
                {
                    break;
                }
            }
            yield return null;
        }

        yield return new WaitForSeconds(0.2f);

        if (!goOut || !newTargetSelected)
        {
            if (currentTarget != null)
            {
                currentTarget._stand.TargetCustomerArrived(this);
            }
        }
    }


    public bool NewSameTargetStand()
    {
        List<CollectProduct> collectAreaOtherList = new List<CollectProduct>();
        if(marketType == MarketType.Electronics)
        {
            collectAreaOtherList = MarketCustomerManager.Instance.collectAreaList_Electroincs;
        }
        if (marketType == MarketType.Sports)
        {
            collectAreaOtherList = MarketCustomerManager.Instance.collectAreaList_Sports;

        }
        if (marketType == MarketType.Toys)
        {
            collectAreaOtherList = MarketCustomerManager.Instance.collectAreaList_Toys;

        }

        bool targetChanged = false;
        foreach (var _targetStand in collectAreaOtherList)
        {
            bool breakActive = false;
            //foreach (Collectable clt in aiStackCollect.collectionTrs)
            {
                //foreach (int cltId2 in _targetStand.CollectId)
                {
                    if (!goToPaying && checkActive && aiStackCollect.GetComponent<StackCollectMarketCustomer>().targetId == _targetStand.CollectId && _targetStand.collectables.Count > 0)
                    {
                        currentTarget.aiCollectTargetTR[targetPointSelect].GetComponent<AICollectTarget>().isSelected = false;

                        targetChanged = true;
                        collectAreaTarget[selectAreaCountCurrent] = _targetStand;
                        TargetFishAreaSelect(true,true);
                        breakActive = true;
                        break;
                    }
                }
                if (breakActive)
                {
                    break;
                }
            }
            if (breakActive)
            {
                break;
            }
        }

        return targetChanged;
    }
    bool checkActive = true;
    IEnumerator SameTargetCheckReset()
    {
        checkActive = false;
        yield return new WaitForSeconds(6f);
        checkActive = true;
    }
}
