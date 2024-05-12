using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;
public class AISushiCustomer : MonoBehaviour
{
    public event Action following;

    [SerializeField] Transform canvasProduactTR;
    public NavMeshAgent navMeshAgent;
    public Animator animator;
    public float AImoveSpeed;
    public CollectProduct targetCollect;
    [SerializeField] Image _image;
    [SerializeField] Image _imageBG;

    int maxCount = 0;
    [SerializeField] TextMeshProUGUI stackText;
    public int currentCountStack = 0;
    int targetCollectId = 0;
    public bool moveActive = true;
    bool characterStayActive = false;
    public bool isStayHoldActive = false;

    public Transform paymentPoint;
    public Transform exitPoint;


    public List<Collectable> collectableList;

    public GameObject smileyGO;
    void Start()
    {
        exitPoint = SushiCustomerManager.Instance.transform;
        paymentPoint = SushiCaseManager.Instance.paymentPoint;
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(2f);
        TargetFishAreaSelect();

    }
    public void TargetFishAreaSelect()
    {
        int stackCount = UnityEngine.Random.Range((int)targetCollect.customerMinMax.x, (int)targetCollect.customerMinMax.y);
        maxCount = stackCount;
        _image.sprite = targetCollect.standSprite;
        StackTextInit();
        targetCollectId = targetCollect.CollectId;


        following = null;
        following += GoToFishCollectArea;
    }

    public void StackTextInit()
    {
        stackText.text = currentCountStack.ToString() + "/" + maxCount.ToString();

    }

    void GoToFishCollectArea()
    {
        if (moveActive && Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetCollect.aiCollectTargetTR[0].position.x , targetCollect.aiCollectTargetTR[0].position.z)) > 0.25f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(targetCollect.aiCollectTargetTR[0].position.x, targetCollect.aiCollectTargetTR[0].position.y, targetCollect.aiCollectTargetTR[0].position.z);
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
                targetCollect._stand.fishCountTotal = maxCount;
                targetCollect._stand.fishCountCurrent = maxCount;
                isStayHoldActive = true;
                animator.SetBool("walk", false);
                following = null;
                StartCoroutine(SitDown());
        
            }
        }
    }

    IEnumerator SitDown()
    {
        navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.LowQualityObstacleAvoidance;

        animator.SetTrigger("sit");
        Vector3 firstPos = transform.position;
        Quaternion firstRot = transform.rotation;

        float counter = 0f;
        while(counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            transform.position = Vector3.Lerp(firstPos, targetCollect.aiCollectTargetTR[0].position, counter);
            transform.rotation = Quaternion.Lerp(firstRot, targetCollect.aiCollectTargetTR[0].rotation, counter);
            yield return null;
        }
        StartCoroutine(EatSushi());

    }

    private void Update()
    {
        following?.Invoke();
        canvasProduactTR.rotation = Quaternion.Euler(canvasProduactTR.eulerAngles.x, -14.812f, canvasProduactTR.eulerAngles.z);
    }

    IEnumerator EatSushi()
    {
        isStayHoldActive = false;
        yield return new WaitForSeconds(1f);
        for(int i = 0; i< maxCount; i++)
        {
            while(targetCollect.collectables.Count == 0)
            {
                transform.position = targetCollect.aiCollectTargetTR[0].position;
                transform.rotation = targetCollect.aiCollectTargetTR[0].rotation;
                yield return null;
            }

            transform.position = targetCollect.aiCollectTargetTR[0].position;
            transform.rotation = targetCollect.aiCollectTargetTR[0].rotation;
            Collectable clt = targetCollect.collectables[targetCollect.collectables.Count - 1];

            //clt.animator.SetTrigger("eat");
            animator.SetTrigger("eat");

            yield return new WaitForSeconds(2f);
            currentCountStack++;
            StackTextInit();
            collectableList.Add(clt);
            targetCollect.collectables.Remove(clt);
            clt.transform.parent = transform;
            //clt.gameObject.SetActive(false);
        }
        _imageBG.color = new Color(0, 0, 0, 0);
        _image.sprite = SushiCaseManager.Instance.standSprite;
        _image.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, _image.GetComponent<RectTransform>().anchoredPosition.y);
        _image.transform.GetChild(0).gameObject.SetActive(false);

        navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;

        following = null;
        following += GoToPaymentPoint;
    }


    void GoToPaymentPoint()
    {
        if (moveActive && Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(paymentPoint.position.x, paymentPoint.position.z)) > 0.25f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(paymentPoint.position.x, paymentPoint.position.y, paymentPoint.position.z);
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
                animator.SetBool("walk", false);
                following = null;
                //////
                SushiCaseManager.Instance.PayCustomer(this);
                targetCollect.isFull = false;


                canvasProduactTR.gameObject.SetActive(false);
                smileyGO.SetActive(true);

            }
        }
    }
    public void GoExit()
    {
        SushiCustomerManager.Instance.CustomerRemoveList(this);

        isStayHoldActive = false;
        following = null;
        following += GoToExitMove;
    }
    void GoToExitMove()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(exitPoint.position.x, exitPoint.position.z)) > 0.25f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(exitPoint.position.x, exitPoint.position.y, exitPoint.position.z);
            animator.SetBool("walk", true);
            navMeshAgent.SetDestination(targetPos);
          
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
                animator.SetBool("walk", false);
                following = null;
                //////
                Destroy(gameObject);
            }
        }
    }
}
