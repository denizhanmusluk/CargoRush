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
    public bool sellingWorker = false;
    public void LevelUp()
    {
        int lvl = PlayerPrefs.GetInt(workerLevelName);
        lvl++;
        PlayerPrefs.SetInt(workerLevelName, lvl);

        workerLevel = PlayerPrefs.GetInt(workerLevelName);

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
        DnzEvents.aiWorkerStart += AIStart;
        DnzEvents.aiWorkerStop += AIStop;
        DnzEvents.aiWorkerListReset += ListReset;
        MoveSpeedInit();

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
        AImoveSpeed = aiStackCollect.GetComponent<StackCollectWorker>().characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel] * Globals.workerSpeedFactor;
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
        float speed = 0.75f + 0.05f * Globals.workerMoveSpeedLevel;
        animator.SetFloat("Speed", speed * Globals.workerSpeedFactor);

        animator.SetBool("walk", true);
        Vector3 direction = (targetPos - transform.position).normalized;
        direction.y = 0;
        float RotY = Vector3.SignedAngle(direction, transform.forward, Vector3.up);

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
        aiStackCollect.GetComponent<StackCollectWorker>().collectActive = false;
        isStayHoldActive = false;
        followActive = false;
        following = null;
        following += StopPositionGoEnd;
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
            }

            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                playerStop();
                following = null;
                navMeshAgent.SetDestination(transform.position);
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
            }

            if (!isStayHoldActive)
            {
                isStayHoldActive = true;

                playerStop();
                following = null;
                navMeshAgent.SetDestination(transform.position); 

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
    IEnumerator AiStackCountInit(int i)
    {
        yield return new WaitForSeconds(2f);
        aiStackCollect.GetComponent<StackCollectWorker>().currentCapacity = aiStackCollect.GetComponent<StackCollectWorker>().collectionTrs.Count + fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].fishCountCurrent;


    }
    public void TargetFishAreaSelect()
    {
        fishCollectArea.ShuffleStandList();

        isStayHoldActive = false;

        List<CollectProduct> tempCollectArea = new List<CollectProduct>();
        bool collectTargetCheckActive = true;
        foreach (var env in fishCollectArea.CollectProductList)
        {
            if (env.collectables.Count > 0 && collectTargetCheckActive && env.collectActive)
            {
                for (int i = 0; i < fishCollectArea.standList.Count; i++)
                {
                    foreach (int cltId in fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectIDList)
                    {
                        bool breakActive = false;
                        if ((fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType == CollectType.All || env.collectables[env.collectables.Count - 1].collectType == fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType || fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType2 == CollectType.All || env.collectables[env.collectables.Count - 1].collectType == fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].collectType2) && cltId == env.CollectId && fishCollectArea.standList[fishCollectArea.standList.Count - 1 - i].fishCountCurrent > 0)
                        {
                            StartCoroutine(AiStackCountInit(i));
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
                }
            }


        }

        if (tempCollectArea.Count != 0)
        {
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

            Vector3 targetPos = new Vector3(collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.x + fishCollectOffset.x, collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.y, collectAreaTarget.aiCollectTargetTR[targetCollectPointSelect].position.z + fishCollectOffset.y);
            PlayerMovingDirection(targetPos);

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
            }
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

    public bool NewSameTargetCourierStand()
    {
        bool targetChanged = false;
        for (int i = 0; i < fishCollectArea.standCourierList.Count; i++)
        {
            bool breakActive = false;
            foreach (Collectable clt in aiStackCollect.collectionTrs)
            {
                foreach (int cltId2 in fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i].collectIDList)
                {
                    if ((fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i].collectType == CollectType.All || clt.collectType == fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i].collectType || fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i].collectType2 == CollectType.All || clt.collectType == fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i].collectType2) && clt.collectID == cltId2 && fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i].fishCountCurrent > 0)
                    {

                        targetChanged = true;
                        if (targetStand != fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i])
                        {
                            targetStand = fishCollectArea.standCourierList[fishCollectArea.standCourierList.Count - 1 - i];
                        }
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

        isStayHoldActive = false;

        {
            //targetStand.aiTargetPosListCheck[targetDropPointSelect] = 0;

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


            if (aiStackCollect.collectionTrs.Count > 0)
            {
                following = null;
                following += GoToStandArea;
            }
            else
            {
                isStayHoldActive = false;

                following = null;
                following += StopPositionGo;
            }
        }
    }
    float stepCounter = 0;
    void GoToStandArea()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetStand.aiTargetPosList[targetDropPointSelect].position.x, targetStand.aiTargetPosList[targetDropPointSelect].position.z)) > 0.75f)
        {
            characterStayActive = false;

            PlayerMovingDirection(targetStand.aiTargetPosList[targetDropPointSelect].position);

            if (!targetStand.gameObject.activeInHierarchy)
            {
                TargetFishAreaSelect();
            }

            if (sellingWorker)
            {
                stepCounter += Time.deltaTime;
                if (stepCounter > 1f)
                {
                    stepCounter = 0f;
                    bool trashActive = false;
                    foreach (var clt in aiStackCollect.collectionTrs)
                    {
                        if (clt.collectID == 50)
                        {
                            trashActive = true;
                        }
                    }

                    if (!trashActive)
                    {
                        NewSameTargetCourierStand();
                    }
                    //if (!isStayHoldActive)
                    //{
                    //    aiStackActive = true;
                    //    isStayHoldActive = true;
                    //    playerStop();
                    //}
                }
            }
            navMeshAgent.SetDestination(targetStand.aiTargetPosList[targetDropPointSelect].position);
        }
        else
        {

            if (!characterStayActive)
            {
                characterStayActive = true;
            }

            if (!isStayHoldActive)
            {
                aiStackActive = true;
                isStayHoldActive = true;
                //if (!targetStand.gameObject.activeInHierarchy)
                //{
                //    TargetFishAreaSelect();
                //}
                playerStop();

                if (sellingWorker)
                {
                    targetStand.TargetCourierArrived(this);
                    targetStand.aiTargetPosListCheck[targetDropPointSelect] = 0;
                }
                else
                {
                    targetStand.TargetArrived(this);
                }

                if (sellingWorker)
                {
                    DestroyBoxChack();
                }
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
    void DestroyBoxChack()
    {
        if (aiStackCollect.collectionTrs.Count > 0)
        {
            Collectable dstCol = aiStackCollect.collectionTrs[0];
            bool destroyActive = true;
            for (int i = 0; i < fishCollectArea.standList.Count; i++)
            {
                if (fishCollectArea.standList[i].GetComponent<StandFishCar>() != null)
                {
                    for (int j = 0; j < fishCollectArea.standList[i].GetComponent<StandFishCar>().collectIDList.Length; j++)
                    {
                        if(fishCollectArea.standList[i].GetComponent<StandFishCar>().collectIDList[j] == aiStackCollect.collectionTrs[0].collectID)
                        {
                            destroyActive = false;
                        }
                    }
                }
            }
            if(destroyActive == true)
            {
                if(dstCol.puffEffectPrefab != null)
                {
                    GameObject puffEffect = Instantiate(dstCol.puffEffectPrefab, dstCol.transform.position, dstCol.transform.rotation);
                }
                aiStackCollect.collectionTrs.Remove(dstCol);
                aiStackCollect.CollectedListReset();
                //Destroy(dstCol.gameObject);
                StartCoroutine(BoxScaleDown(dstCol.transform));
            }
        }
    }

    IEnumerator BoxScaleDown(Transform boxTR)
    {
        Vector3 boxFirstScale = boxTR.localScale;
        float counter = 0f;
        float angleValue = 0f;
        while(counter < Mathf.PI)
        {
            counter += 8 * Time.deltaTime;
            angleValue = Mathf.Sin(counter * Mathf.PI);
            angleValue *= 0.4f;
            boxTR.localScale = Vector3.Lerp(boxFirstScale, boxFirstScale * (1 + angleValue), counter);
            yield return null;
        }
        counter = 0f;
        while (counter < Mathf.PI)
        {
            counter += 8 * Time.deltaTime;
            boxTR.localScale = Vector3.Lerp(boxFirstScale, Vector3.zero, counter);
            yield return null;
        }

        Destroy(boxTR.gameObject);
    }
}
