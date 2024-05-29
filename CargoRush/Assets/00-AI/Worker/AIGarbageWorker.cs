using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIGarbageWorker : MonoBehaviour, IWorkerModelSelect
{
    public event Action following;

    public float AImoveSpeed;
    public NavMeshAgent navMeshAgent;
    public StackCollect aiStackCollect;
    public Animator animator;


    public bool characterStayActive = false;
    public bool isStayHoldActive = false;
    public bool followActive = false;
    [SerializeField] FishDropArea fishDropArea;
    [SerializeField] CollectProduct collectAreaTarget;
    Vector3 firstPos;
    [SerializeField] string workerLevelName;
    int workerLevel = 0;
    [SerializeField] GameObject elArabasi;
    [SerializeField] GameObject forklift;
    public bool aiDropActive = true;


    public CollisionController collisionController;

    [SerializeField] Collectable currentCollectable;
    [SerializeField] Stand targetStand;
    public Board _board;
    public List<GameObject> modelList = new List<GameObject>();
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
        yield return new WaitForSeconds(0.1f);
        aiDropActive = true;
    }
    void Start()
    {

        DnzEvents.aiWorkerStart += AIStart;
        DnzEvents.aiWorkerStop += AIStop;
        DnzEvents.aiWorkerListReset += ListReset;
        MoveSpeedInit();
        StartCoroutine(StartFirst());


        //AIStart();
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
        float speed = 0.75f + 0.05f * Globals.workerMoveSpeedLevel;
        animator.SetFloat("Speed", speed);
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
        Debug.Log("start ai");
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
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;
                StartCoroutine(StartDelay());
            }
        }
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        TargetGarbageSelect();

    }
    int targetCollectId = 0;
    public void TargetGarbageSelect()
    {
        //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        float distance;
        isStayHoldActive = false;
        if (fishDropArea.collectableList.Count != 0)
        {
            currentCollectable = fishDropArea.collectableList[0];
            distance = Vector3.Distance(currentCollectable.transform.position, transform.position);
            for (int i = 0; i < fishDropArea.collectableList.Count; i++)
            {
                if(Vector3.Distance(fishDropArea.collectableList[i].transform.position, transform.position) < distance)
                {
                    currentCollectable = fishDropArea.collectableList[i];
                    distance = Vector3.Distance(currentCollectable.transform.position, transform.position);
                }
            }

            following = null;
            following += GoToCollect;
        }
        else
        {
            if (aiStackCollect.collectionTrs.Count > 0)
            {
                CrusherPosSelect();
            }
            else
            {
                isStayHoldActive = false;

                following = null;
                following += StopPositionGo;
            }
        }
    }
    void GoToCollect()
    {
        if(currentCollectable == null || currentCollectable.grindActive)
        {
            isStayHoldActive = false;

            following = null;
            following += StopPositionGo;
            return;
        }
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(currentCollectable.transform.position.x, currentCollectable.transform.position.z)) > 1f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(currentCollectable.transform.position.x, transform.position.y, currentCollectable.transform.position.z);
            PlayerMovingDirection(targetPos);
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

                playerStop();
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;

                if (collisionController.stackCollect.collectionTrs.Count < aiStackCollect.GetComponent<StackCollectWorker>().baseStackCapacity + collisionController._characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel])
                {
                    TargetGarbageSelect();
                }
                else
                {

                    if (aiStackCollect.collectionTrs.Count > 0)
                    {
                        CrusherPosSelect();
                    }
                    else
                    {
                        isStayHoldActive = false;

                        following = null;
                        following += StopPositionGo;
                    }
                }
            }
        }
    }
    void CrusherPosSelect()
    {
        targetCollectPointSelect = UnityEngine.Random.Range(0, targetStand.aiTargetPosList.Length);
        isStayHoldActive = false;

        following = null;
        following += GoToCrusher;
    }
    void GoToCrusher()
    {
        if (Vector3.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(targetStand.aiTargetPosList[targetCollectPointSelect].position.x , targetStand.aiTargetPosList[targetCollectPointSelect].position.z)) > 0.25f)
        {
            characterStayActive = false;

            Vector3 targetPos = new Vector3(targetStand.aiTargetPosList[targetCollectPointSelect].position.x, transform.position.y, targetStand.aiTargetPosList[targetCollectPointSelect].position.z);
            PlayerMovingDirection(targetPos);

   
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
                StartCoroutine(Staying());
                playerStop();
                //navMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.HighQualityObstacleAvoidance;


            }
        }
    }
    IEnumerator Staying()
    {
        yield return new WaitForSeconds(1f);
        TargetGarbageSelect();
    }
    Vector2 fishCollectOffset;
    int targetCollectPointSelect = 0;
    int targetDropPointSelect = 0;




    private void Update()
    {
        following?.Invoke();
    }
    public void UpgradeSkateBoardInit()
    {
        foreach (var mdl in modelList)
        {
            mdl.SetActive(false);
        }
        _board = null;
        modelList[PlayerPrefs.GetInt("modelselect")].SetActive(true);
        if (modelList[PlayerPrefs.GetInt("modelselect")].GetComponent<Board>() != null)
            _board = modelList[PlayerPrefs.GetInt("modelselect")].GetComponent<Board>();
        //StartCoroutine(AnimationSet());
    }
}
