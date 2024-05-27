using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWorker : MonoBehaviour, IWorkerModelSelect
{
    public event Action following;

    public float AImoveSpeed;
    public NavMeshAgent navMeshAgent;
    public StackCollect aiStackCollect;
    public Animator animator;

    //[SerializeField] Transform fishCollectPoint;
    //[SerializeField] List<Transform> fishDropPointList;

    public bool characterStayActive = false;
    public bool isStayHoldActive = false;
    public bool followActive = false;
    [SerializeField] WorkArea fishCollectArea;
    [SerializeField] Stand targetStand;
    [SerializeField] CollectProduct collectAreaTarget;
    Vector3 firstPos;
    [SerializeField] string workerLevelName;
    int workerLevel = 0;
    [SerializeField] GameObject elArabasi;
    [SerializeField] GameObject forklift;
    public bool aiDropActive = true;
    public bool aiStackActive = false;
    public void LevelUp()
    {
        int lvl = PlayerPrefs.GetInt(workerLevelName);
        lvl++;
        PlayerPrefs.SetInt(workerLevelName, lvl);

        workerLevel = PlayerPrefs.GetInt(workerLevelName);
        //if (currentCar != null)
        //{
        //    currentCar.GetComponent<FishCar>().CarLevelCreate(carLevel);
        //}
        LevelInit();
        if (gameObject.activeInHierarchy)
        {
            aiStackCollect.CollectedListResetLevelUp();
        }
    }
    public void LevelInit()
    {
        workerLevel = PlayerPrefs.GetInt(workerLevelName);
        aiStackCollect.stackLevel = workerLevel;
        if (workerLevel == 1)
        {
            if (elArabasi != null)
            {
                elArabasi.SetActive(true);
            }
        }
        if (workerLevel == 2)
        {
            if (elArabasi != null)
            {
                elArabasi.SetActive(false);
            }

            if (forklift != null)
            {
                forklift.SetActive(true);
            }
            //navMeshAgent.radius = 0.6f;
        }

    }
    private void Awake()
    {
        firstPos = transform.position;
        aiStackCollect.GetComponent<StackCollectWorker>().characterUpgradeSettings = HRUpgradeManager.Instance._characterUpgradeSettings;
        LevelInit();
    }
    public void DropActivator()
    {
        StartCoroutine(DropActivate());
    }
    IEnumerator DropActivate()
    {
        aiDropActive = false;
        yield return new WaitForSeconds(Time.deltaTime * 2);
        aiDropActive = true;
    }
    void Start()
    {
        //WallManager.Instance.allWorker.Add(this);

        DnzEvents.aiWorkerStart += AIStart;
        DnzEvents.aiWorkerStop += AIStop;
        DnzEvents.aiWorkerListReset += ListReset;
        MoveSpeedInit();
        //if (fishCollectArea.fishCollectable.Count > 0)

        //AIStart();

        StartCoroutine(StartFirst());
    }
    IEnumerator StartFirst()
    {
        yield return new WaitForSeconds(1f);
        isStayHoldActive = false;

        following = null;
        following += StopPositionGo;
    }
    public void MoveSpeedInit()
    {
        AImoveSpeed = aiStackCollect.GetComponent<StackCollectWorker>().characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel];
        navMeshAgent.speed = AImoveSpeed;
    }
    public void ListReset()
    {
        aiStackCollect.GetComponent<StackCollectWorker>().collectActive = true;
        foreach (var collection in aiStackCollect.collectionTrs)
        {
            Destroy(collection.gameObject);
        }
        aiStackCollect.collectionTrs.Clear();
    }
    public void PlayerMovingDirection(Vector3 targetPos)
    {
        float speed = 0.5f + 0.05f * Globals.workerMoveSpeedLevel;
        animator.SetFloat("Speed", speed);

        animator.SetBool("walk", true);
        Vector3 direction = (targetPos - transform.position).normalized;
        direction.y = 0;
        float RotY = Vector3.SignedAngle(direction, transform.forward, Vector3.up);
        //float RotY = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

        //animator.speed = 1 + 0.1f * Globals.characterSpeedLevel;
        if (animator != null)
        {
            animator.SetFloat("x", Mathf.Cos((RotY + 90) * Mathf.Deg2Rad));
            animator.SetFloat("y", Mathf.Sin((RotY + 90) * Mathf.Deg2Rad));
        }
    }
    public void playerStop()
    {
        animator.SetBool("walk", false);

        float firstAngleX = Mathf.Cos((transform.localEulerAngles.y + 90) * Mathf.Deg2Rad);
        float firstAngleY = Mathf.Sin((transform.localEulerAngles.y + 90) * Mathf.Deg2Rad);
        LeanTween.value(firstAngleX, 0, 2 * AImoveSpeed / (60)).setOnUpdate((float val) =>
        {
            if (animator != null)
                animator.SetFloat("x", val);
        });
        LeanTween.value(firstAngleY, 0, 2 * AImoveSpeed / (60)).setOnUpdate((float val) =>
        {
            if (animator != null)
                animator.SetFloat("y", val);
        });
    }
    void AIStart()
    {
        followActive = true;
        StartCoroutine(StartDelay());
    }
    public void AIStop()
    {
        //playerStop();
        aiStackCollect.GetComponent<StackCollectWorker>().collectActive = false;
        isStayHoldActive = false;
        followActive = false;
        following = null;
        following += StopPositionGoEnd;
        //navMeshAgent.SetDestination(transform.position);
    }
    void StopPositionGoEnd()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(firstPos.x, firstPos.z)) > 0.1f)
        {
            characterStayActive = false;
            PlayerMovingDirection(firstPos);
            navMeshAgent.SetDestination(firstPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
                //StartCoroutine(RotateTarget());
            }
            //animator.SetBool("Walk", false);

            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                playerStop();
                following = null;
                navMeshAgent.SetDestination(transform.position);
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                //StartCoroutine(StartDelay());
            }
        }
    }
    void StopPositionGo()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(firstPos.x, firstPos.z)) > 0.1f)
        {
            characterStayActive = false;
            PlayerMovingDirection(firstPos);
            navMeshAgent.SetDestination(firstPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
                //StartCoroutine(RotateTarget());
            }
            //animator.SetBool("Walk", false);

            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                playerStop();
                following = null;
                navMeshAgent.SetDestination(transform.position); 
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                //StartCoroutine(StartDelay());
                AIStart();
            }
        }
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        TargetFishAreaSelect();

    }
    int targetCollectId = 0;
    public void TargetFishAreaSelect()
    {
        fishCollectArea.ShuffleStandList();

        //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;

        isStayHoldActive = false;

        List<CollectProduct> tempCollectArea = new List<CollectProduct>();
        bool collectTargetCheckActive = true;
        foreach (var env in fishCollectArea.CollectProductList)
        {
            if (env.collectables.Count > 0 && collectTargetCheckActive)
            {
                for (int i = 0; i < fishCollectArea.standList.Count; i++)
                {
                    foreach (int cltId in fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectIDList)
                    {
                        bool breakActive = false;
                        if ((fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType == CollectType.All || env.collectables[env.collectables.Count - 1].collectType == fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType || fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType2 == CollectType.All || env.collectables[env.collectables.Count - 1].collectType == fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType2) && cltId == env.CollectId && fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].fishCountCurrent > 0)
                        {
                            aiStackCollect.GetComponent<StackCollectWorker>().currentCapacity = fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].fishCountCurrent;
                            tempCollectArea.Add(env);
                            targetStand = fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i];

                            collectTargetCheckActive = false;
                            breakActive = true;
                            break;
                        }
                        if (breakActive)
                        {
                            break;
                        }
                    }
                    //Debug.Log("_targetStand.fishCountCurrent  " + _targetStand.fishCountCurrent);

                }
            }


        }
        //fishCollectArea.ShuffleStandList();
        //fishCollectArea.ShuffleCollectProductList();
        if (tempCollectArea.Count != 0)
        {

            //int randomTargetSelect = UnityEngine.Random.Range(0, tempCollectArea.Count);
            //aiStackCollect.GetComponent<StackCollectWorker>().aiCollectActive = true;

            collectAreaTarget = tempCollectArea[0];
            targetCollectId = collectAreaTarget.CollectId;
            aiStackCollect.GetComponent<StackCollectWorker>().targetId = targetCollectId;
            aiStackCollect.GetComponent<StackCollectWorker>().collectableType = collectAreaTarget.collectableType;
            fishCollectOffset = new Vector2(UnityEngine.Random.Range(-0.5f, 0.5f), UnityEngine.Random.Range(-0.5f, 0.5f));

            collectAreaTarget.aiCollectTargetCheck[targetCollectPointSelect] = 0;

            targetCollectPointSelect = UnityEngine.Random.Range(0, collectAreaTarget.aiCollectTargetTR.Length);
            for (int i = 0; i < 50; i++)
            {
                targetCollectPointSelect = UnityEngine.Random.Range(0, collectAreaTarget.aiCollectTargetTR.Length);
                if (collectAreaTarget.aiCollectTargetCheck[targetCollectPointSelect] != 1)
                {
                    collectAreaTarget.aiCollectTargetCheck[targetCollectPointSelect] = 1;
                    break;
                }
            }
            aiStackCollect.GetComponent<StackCollectWorker>().collectActive = false;
            aiStackActive = false;
            following = null;
            following += GoToFishCollectArea;
        }
        else
        {
            isStayHoldActive = false;

            following = null;
            following += StopPositionGo;
        }
    }
    Vector2 fishCollectOffset;
    int targetCollectPointSelect = 0;
    int targetDropPointSelect = 0;

    void GoToFishCollectArea()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.x + fishCollectOffset.x, collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.z + fishCollectOffset.y)) > 0.25f)
        {
            characterStayActive = false;

            //animator.SetBool("Walk", true);
            Vector3 targetPos = new Vector3(collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.x + fishCollectOffset.x, collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.y, collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.z + fishCollectOffset.y);
            PlayerMovingDirection(targetPos);

            //transform.position = Vector3.MoveTowards(transform.position, targetPlayer.position, Time.deltaTime * moveSpeed);
            if (!collectAreaTarget.gameObject.activeInHierarchy)
            {
                TargetFishAreaSelect();
            }
            navMeshAgent.SetDestination(targetPos);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
                //StartCoroutine(RotateTarget());
            }
            //animator.SetBool("Walk", false);
            if (!isStayHoldActive)
            {
                aiStackActive = true;
                isStayHoldActive = true;
                if (!fishCollectArea.gameObject.activeInHierarchy)
                {
                    TargetFishAreaSelect();
                }
                playerStop();
                aiStackCollect.GetComponent<StackCollectWorker>().collectActive = true;
                fishCollectArea.TargetArrived(this);
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;

                //if (fishCollectArea.fishCollectable.Count > 0)
                //{
                //    fishCollectArea.TargetArrived(this);
                //}
                //else
                //{
                //    AIStop();
                //}
            }
        }
    }


    public bool NewSameTargetStand()
    {
        bool targetChanged = false;
        for (int i = 0; i < fishCollectArea.standList.Count; i++)
        {
            bool breakActive = false;
            foreach (Collectable clt in aiStackCollect.collectionTrs)
            {
                foreach (int cltId2 in fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectIDList)
                {
                    if ((fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType == CollectType.All || clt.collectType == fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType || fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType2 == CollectType.All || clt.collectType == fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType2) && clt.collectID == cltId2 && fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].fishCountCurrent > 0)
                    {
                        targetChanged = true;
                        targetStand = fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i];
                        TargetFishStandSelect();
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

    public void TargetFishStandSelect()
    {
        aiStackCollect.GetComponent<StackCollectWorker>().aiCollectActive = false;
        //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        isStayHoldActive = false;
        //List<Stand> tempDropArea = new List<Stand>();
        //foreach (var env in fishCollectArea.standList)
        //{
        //    if (env.collectID == targetCollectId)
        //    {
        //        tempDropArea.Add(env);
        //    }
        //}

        //if (tempDropArea.Count != 0)
        {
            //int randomTargetSelect = UnityEngine.Random.Range(0, tempDropArea.Count);

            //targetStand = tempDropArea[randomTargetSelect];

            //targetDropPointSelect = UnityEngine.Random.Range(0, targetStand.aiTargetPosList.Length);

            targetStand.aiTargetPosListCheck[targetDropPointSelect] = 0;

            targetDropPointSelect = UnityEngine.Random.Range(0, targetStand.aiTargetPosList.Length);
            for (int i = 0; i < 50; i++)
            {
                targetDropPointSelect = UnityEngine.Random.Range(0, targetStand.aiTargetPosList.Length);
                if (targetStand.aiTargetPosListCheck[targetDropPointSelect] != 1)
                {
                    targetStand.aiTargetPosListCheck[targetDropPointSelect] = 1;
                    break;
                }
            }
            aiStackCollect.GetComponent<StackCollectWorker>().collectActive = false;

            aiStackActive = false;

            following = null;
            following += GoToStandArea;
        }
        //else
        //{
        //    StartCoroutine(StartDelay());
        //}
    }
    void GoToStandArea()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetStand.aiTargetPosList[targetDropPointSelect].position.x, targetStand.aiTargetPosList[targetDropPointSelect].position.z)) > 0.25f)
        {
            characterStayActive = false;

            //animator.SetBool("Walk", true);
            PlayerMovingDirection(targetStand.aiTargetPosList[targetDropPointSelect].position);

            //transform.position = Vector3.MoveTowards(transform.position, targetPlayer.position, Time.deltaTime * moveSpeed);
            if (!targetStand.gameObject.activeInHierarchy)
            {
                TargetFishAreaSelect();
            }
            navMeshAgent.SetDestination(targetStand.aiTargetPosList[targetDropPointSelect].position);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
                //StartCoroutine(RotateTarget());
            }
            //animator.SetBool("Walk", false);

            if (!isStayHoldActive)
            {
                aiStackActive = true;
                isStayHoldActive = true;
                if (!targetStand.gameObject.activeInHierarchy)
                {
                    TargetFishAreaSelect();
                }
                playerStop();

           
                targetStand.TargetArrived(this);
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
            }
        }
    }
    private void Update()
    {
        following?.Invoke();
        if (Input.GetKeyDown(KeyCode.F))
        {
            LevelUp();
        }
    }
    public void UpgradeSkateBoardInit()
    {

    }
}
