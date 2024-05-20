using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FishCar : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform fishPosParent;
    public Transform[] fishPosTR;
    [SerializeField] NavMeshAgent navmeshAgent;
    public Stand stand;
    public Transform standPos;
    public Transform carGoPos;
    bool arrived = false;
    [SerializeField] GameObject[] carLevelsGO;
    private void Start()
    {
        navmeshAgent.SetDestination(standPos.position);
    }
    private void Update()
    {
        if (Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(standPos.position.x, standPos.position.z)) < 0.5f && arrived == false)
        {
            arrived = true;
            navmeshAgent.enabled = false;
            StartCoroutine(SetRot());
            if (stand.GetComponent<AquariumCar>() != null)
            {
                stand.GetComponent<AquariumCar>()._CollectProduct.collectActive = true;
            }
        }
    }
    IEnumerator SetRot()
    {
        navmeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.NoObstacleAvoidance;
        Vector3 firstPos = transform.position;
        Vector3 targetPos = new Vector3(standPos.position.x, transform.position.y, standPos.position.z);
        Quaternion firstRot = transform.rotation;
        float counter = 0f;
        while (counter < 1f)
        {
            counter += 3 * Time.deltaTime;

            transform.position = Vector3.Lerp(firstPos, targetPos, counter);
            transform.rotation = Quaternion.Lerp(firstRot, standPos.rotation, counter);
            yield return null;
        }

        transform.position = targetPos;
        transform.rotation = standPos.rotation;
        navmeshAgent.enabled = true;
        navmeshAgent.SetDestination(transform.position);
        stand.StandReActive();
    }
    public void CarGoOut()
    {
        navmeshAgent.enabled = true;
        navmeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        navmeshAgent.SetDestination(carGoPos.position);
        Destroy(gameObject, 4f);

        if (PlayerPrefs.GetInt("tutorialseq1") == 0)
        {
            PlayerPrefs.SetInt("tutorialseq1", 1);
            ShopManager.Instance.buyOthersGO.SetActive(true);
        }

    }
    public void CarLevelCreate(int level)
    {
        foreach (var car in carLevelsGO)
        {
            car.SetActive(false);
        }
        carLevelsGO[level].SetActive(true);
    }
}
