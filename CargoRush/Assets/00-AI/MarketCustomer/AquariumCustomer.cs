using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

public class AquariumCustomer : MonoBehaviour
{
    public event Action following;
    public Transform boxPosTR;

    public StackCollect aiStackCollect;

    public NavMeshAgent navMeshAgent;
    public Animator animator;

    public float AImoveSpeed;

    // // // // //
    public List<CollectProduct> collectAreaList_1;
    public List<CollectProduct> collectAreaList_2;

    [SerializeField] List<CollectProduct> collectAreaTarget;
    [SerializeField] CollectProduct currentTarget;
    [SerializeField] int selectAreaCountTotal;
    [SerializeField] int selectAreaCountCurrent = 0;




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
    public GameObject shoppingBigCart;
    int customerLevel = 0;
    private void Start()
    {
        StartCoroutine(StartDelay());
        navMeshAgent.speed = AImoveSpeed;

        if(collectAreaList_2.Count == 0)
        {
            selectAreaCountTotal = 1;
        }
        else
        {
            selectAreaCountTotal = 2;
        }

        if (selectAreaCountTotal > 2)
        {
            selectAreaCountTotal = 2;
        }
        if (selectAreaCountTotal > 1)
        {
            int selectIndex = UnityEngine.Random.Range(0, collectAreaList_1.Count);
            collectAreaTarget.Add(collectAreaList_1[selectIndex]);
            collectAreaList_1[selectIndex].customerCount++;

            int selectIndex2 = UnityEngine.Random.Range(0, collectAreaList_2.Count);
            collectAreaTarget.Add(collectAreaList_2[selectIndex2]);
            collectAreaList_2[selectIndex2].customerCount++;

            //for (int i = 0; i < collectAreaList_1.Count; i++)
            //{
            //    collectAreaTarget.Add(collectAreaList_1[i]);
            //    collectAreaList_1[i].customerCount++;
            //    break;
            //}
            //for (int i = 0; i < collectAreaList_2.Count; i++)
            //{
            //    collectAreaTarget.Add(collectAreaList_2[i]);
            //    collectAreaList_2[i].customerCount++;
            //    break;
            //}
        }
        else
        {
            int selectIndex = UnityEngine.Random.Range(0, collectAreaList_1.Count);
            collectAreaTarget.Add(collectAreaList_1[selectIndex]);
            collectAreaList_1[selectIndex].customerCount++;

            //for (int i = 0; i < collectAreaList_1.Count; i++)
            //{
            //    collectAreaTarget.Add(collectAreaList_1[i]);
            //    collectAreaList_1[i].customerCount++;
            //    break;
            //}
        }
    }

    //void Start()
    //{
    //    StartCoroutine(StartDelay());

    //    navMeshAgent.speed = AImoveSpeed;

    //    selectAreaCountTotal = UnityEngine.Random.Range(1, collectAreaList.Count + 1);
    //    if (selectAreaCountTotal > 2)
    //    {
    //        selectAreaCountTotal = 2;
    //    }
    //    if (selectAreaCountTotal > 1)
    //    {
    //        int focusChance = UnityEngine.Random.Range(0, 10);
    //        if (focusChance < 4)
    //        {
    //            if (!collectAreaList[0].machineActive)
    //            {
    //                if (collectAreaList[0].customerCount < 2)
    //                {
    //                    collectAreaTarget.Add(collectAreaList[0]);
    //                    collectAreaList[0].customerCount++;
    //                }
    //                else
    //                {
    //                    for (int i = 1; i < collectAreaList.Count; i++)
    //                    {
    //                        if (collectAreaList[i].machineActive)
    //                        {
    //                            collectAreaTarget.Add(collectAreaList[i]);
    //                            collectAreaList[i].customerCount++;
    //                            break;
    //                        }

    //                    }
    //                    selectAreaCountTotal = collectAreaTarget.Count;
    //                }
    //            }
    //            else
    //            {
    //                collectAreaTarget.Add(collectAreaList[0]);
    //            }


    //            if (collectAreaList[0].aliveFishActive)
    //            {
    //                int otherStandIndex = UnityEngine.Random.Range(1, collectAreaList.Count);

    //                for (int i = 0; i < 10; i++)
    //                {
    //                    otherStandIndex = UnityEngine.Random.Range(1, collectAreaList.Count);
    //                    if (!collectAreaList[otherStandIndex].machineActive)
    //                    {
    //                        if (collectAreaList[otherStandIndex].customerCount < 2)
    //                        {
    //                            collectAreaTarget.Add(collectAreaList[otherStandIndex]);
    //                            collectAreaList[otherStandIndex].customerCount++;
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            //selectAreaCountTotal = collectAreaTarget.Count;
    //                        }

    //                    }
    //                    else
    //                    {
    //                        collectAreaTarget.Add(collectAreaList[otherStandIndex]);
    //                        collectAreaList[otherStandIndex].customerCount++;
    //                        break;
    //                    }
    //                }
    //                selectAreaCountTotal = collectAreaTarget.Count;

    //                //collectAreaTarget.Add(collectAreaList[otherStandIndex]);



    //            }
    //            else
    //            {
    //                for (int i = 1; i < collectAreaList.Count; i++)
    //                {
    //                    if (collectAreaList[i].aliveFishActive)
    //                    {
    //                        collectAreaTarget.Add(collectAreaList[i]);
    //                    }
    //                }
    //            }
    //        }
    //        else
    //        {
    //            for (int i = 0; i < collectAreaList.Count; i++)
    //            {
    //                if (collectAreaList[i].aliveFishActive)
    //                {
    //                    collectAreaTarget.Add(collectAreaList[i]);
    //                    break;
    //                }
    //            }
    //            for (int i = 0; i < collectAreaList.Count; i++)
    //            {
    //                if (!collectAreaList[0].machineActive)
    //                {
    //                    if (collectAreaList[0].customerCount < 2)
    //                    {
    //                        collectAreaTarget.Add(collectAreaList[i]);
    //                        collectAreaList[i].customerCount++;
    //                        break;
    //                    }
    //                }
    //            }

    //            selectAreaCountTotal = collectAreaTarget.Count;

    //            //System.Random random = new System.Random();

    //            //for (int i = collectAreaList.Count - 1; i >= 1; i--)
    //            //{
    //            //    int j = random.Next(i + 1); // 0 ile i arasýnda rastgele bir sayý alýr.

    //            //    var temp = collectAreaList[i];
    //            //    collectAreaList[i] = collectAreaList[j];
    //            //    collectAreaList[j] = temp;
    //            //}


    //            for (int i = 0; i < selectAreaCountTotal; i++)
    //            {
    //                collectAreaTarget.Add(collectAreaList[i]);
    //                collectAreaList[i].customerCount++;
    //            }
    //        }

    //    }
    //    else
    //    {
    //        int focusChance = UnityEngine.Random.Range(0, 10);
    //        if (focusChance < 4)
    //        {

    //            if (collectAreaList[0].machineActive)
    //            {
    //                collectAreaTarget.Add(collectAreaList[0]);
    //                collectAreaList[0].customerCount++;
    //            }
    //            else
    //            {
    //                if (collectAreaList[0].customerCount < 2)
    //                {
    //                    collectAreaTarget.Add(collectAreaList[0]);
    //                    collectAreaList[0].customerCount++;
    //                }
    //                else
    //                {
    //                    for (int i = 1; i < collectAreaList.Count; i++)
    //                    {
    //                        if (collectAreaList[i].aliveFishActive)
    //                        {
    //                            collectAreaTarget.Add(collectAreaList[i]);
    //                            collectAreaList[i].customerCount++;
    //                            break;
    //                        }

    //                    }
    //                }
    //            }

    //        }
    //        else
    //        {
    //            for (int i = 0; i < collectAreaList.Count; i++)
    //            {
    //                if (collectAreaList[i].machineActive)
    //                {
    //                    collectAreaTarget.Add(collectAreaList[i]);
    //                    collectAreaList[i].customerCount++;
    //                    break;
    //                }

    //            }

    //            selectAreaCountTotal = collectAreaTarget.Count;
    //        }


    //        //    int selectStand =  UnityEngine.Random.Range(0, collectAreaList.Count);
    //        //if (!collectAreaList[selectStand].machineActive)
    //        //{
    //        //    for (int i = 1; i < collectAreaList.Count; i++)
    //        //    {
    //        //        if (collectAreaList[i].aliveFishActive)
    //        //        {
    //        //            collectAreaTarget.Add(collectAreaList[i]);
    //        //            collectAreaList[i].customerCount++;
    //        //            break;
    //        //        }

    //        //    }
    //        //}
    //        //else
    //        //{
    //        //    collectAreaTarget.Add(collectAreaList[selectStand]);
    //        //}
    //    }


    //    customerLevel = selectAreaCountTotal - 1;
    //    CustomerLevelInit();
    //}
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
            shoppingBigCart.SetActive(true);
            //shoppingHandCart.SetActive(true);
        }
        if (customerLevel == 2)
        {
            //shoppingHandCart.SetActive(false);
            shoppingBigCart.SetActive(true);
            navMeshAgent.radius = 0.6f;
        }
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(2f);
        TargetFishAreaSelect();

    }
    public void NextTarget()
    {
        moveActive = true;
        navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        currentCountStack = 0;
        selectAreaCountCurrent++;
        TargetFishAreaSelect();
    }
    public void TargetFishAreaSelect()
    {
        isStayHoldActive = false;


        if (selectAreaCountTotal > selectAreaCountCurrent)
        {
            currentTarget = collectAreaTarget[selectAreaCountCurrent];
            int stackCount = UnityEngine.Random.Range((int)currentTarget.customerMinMax.x, (int)currentTarget.customerMinMax.y);
            maxCount = stackCount;
            _image.sprite = currentTarget.standSprite;
            StackTextInit();
            targetCollectId = currentTarget.CollectId;
            aiStackCollect.GetComponent<StackCollectAquarium>().targetId = targetCollectId;

            aiStackCollect.GetComponent<StackCollectAquarium>().stackCapacity += stackCount;

            fishCollectOffset = new Vector2(UnityEngine.Random.Range(-0.5f, 0.5f), UnityEngine.Random.Range(-0.5f, 0.5f));

            targetPointSelect = UnityEngine.Random.Range(0, currentTarget.aiCollectTargetTR.Length);
            following = null;
            following += GoToFishCollectArea;
        }
        else
        {
            shoppingActive = false;
            CaseWaitListAdd();
            Debug.Log("  " + transform.name);
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

                //fishCollectArea.TargetArrived(this);
                //navMeshAgent.SetDestination(transform.position);
                //navMeshAgent.stoppingDistance
            }
        }
    }
    Transform caseTargetPos;
    void CaseWaitListAdd()
    {
        navMeshAgent.stoppingDistance = 0.15f;
        AquariumCaseManager.Instance.customerList.Add(this);
        CasetargetPosSelect();
    }
    public void CasetargetPosSelect()
    {
        _image.sprite = AquariumCaseManager.Instance.standSprite;
        _image.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, _image.GetComponent<RectTransform>().anchoredPosition.y);
        _image.transform.GetChild(0).gameObject.SetActive(false);
        isStayHoldActive = false;

        caseTargetPos = AquariumCaseManager.Instance.customerWaitPosListTR[AquariumCaseManager.Instance.customerList.IndexOf(this)];
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
                if (AquariumCaseManager.Instance.customerList.IndexOf(this) == 0)
                {
                    StartCoroutine(Payment());
                }
            }
        }
    }
    public bool paymentActive = true;
    IEnumerator Payment()
    {
        while (paymentActive)
        {
            if (AquariumCaseManager.Instance.casierActive || AquariumCaseManager.Instance.casierWorkerActive)
            {
                paymentActive = false;
            }
            yield return null;
        }
        AquariumCaseManager.Instance.PayCustomer();
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
        canvasProduactTR.rotation = Quaternion.Euler(canvasProduactTR.eulerAngles.x, -14.812f, canvasProduactTR.eulerAngles.z);
    }
    public void CustomerGoExit(Transform exitPosTR)
    {
        AquariumCustomerManager.Instance.CustomerRemoveList(this);

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
}
