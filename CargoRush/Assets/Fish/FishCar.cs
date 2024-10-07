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
    public Car _car;
    public GameObject vipCanvasGo;
    public Animator vehicleAnim;
    private void Start()
    {
        navmeshAgent.SetDestination(standPos.position);
        if(_car != null)
        {
            _car.WheelActivator(true);
        }
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
                //stand.GetComponent<AquariumCar>()._CollectProduct.collectActive = true;
            }
        }
        VipCanvasSetRot();
    }
    private void VipCanvasSetRot()
    {
        Quaternion cameraRot = Camera.main.transform.rotation;
        vipCanvasGo.transform.rotation = Quaternion.Euler(cameraRot.eulerAngles.x, cameraRot.eulerAngles.y, cameraRot.eulerAngles.z);
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
            counter += Time.deltaTime;

            transform.position = Vector3.Lerp(firstPos, targetPos, counter);
            transform.rotation = Quaternion.Lerp(firstRot, standPos.rotation, counter);
            yield return null;
        }

        transform.position = targetPos;
        transform.rotation = standPos.rotation;
        navmeshAgent.enabled = true;
        navmeshAgent.SetDestination(transform.position);
        stand.StandReActive();
        if (_car != null)
        {
            _car.WheelActivator(false);
        }

        if(vehicleAnim != null)
        {
            vehicleAnim.SetBool("openactive", true);
        }
    }
    public void CarGoOut()
    {

        StartCoroutine(CarGoOurDelay());
    }

    IEnumerator CarGoOurDelay()
    {
        if (vehicleAnim != null)
        {
            vehicleAnim.SetBool("openactive", false);
        }
        yield return new WaitForSeconds(1f);
        if (_car != null)
        {
            _car.WheelActivator(true);
        }
        navmeshAgent.enabled = true;
        navmeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.MedQualityObstacleAvoidance;
        navmeshAgent.SetDestination(carGoPos.position);
        Destroy(gameObject, 4f);
        if (PlayerPrefs.GetInt("tutorialseq1") == 0)
        {
            ShopManager.Instance.buyOthersGO.SetActive(true);
            if (PlayerPrefs.GetInt("againcollect") == 0)
            {
                PlayerPrefs.SetInt("tutorialcompleted", 1);
                TutorialManager.Instance.TutorialCompletedCheck();
            }
        }
        //if (PlayerPrefs.GetInt("tutorialseq1") == 0)
        //{
        //    PlayerPrefs.SetInt("tutorialseq1", 1);
        //    ShopManager.Instance.buyOthersGO.SetActive(true);
        //    if (PlayerPrefs.GetInt("againcollect") == 0)
        //    {
        //        PlayerPrefs.SetInt("tutorialcompleted", 1);
        //        TutorialManager.Instance.TutorialCompletedCheck();

        //        PlayerPrefs.SetInt("againcollect", 1);
        //        Transform indTr = IndicatorManager.Instance.targeterActiveList[0].transform;
        //        float distance;
        //        Collectable currentCollectable;
        //        if (FishDropArea.Instance.collectableList.Count != 0)
        //        {
        //            Transform crusherTR = FishDropArea.Instance.mineCrusher.transform;
        //            currentCollectable = FishDropArea.Instance.collectableList[0];
        //            distance = Vector3.Distance(currentCollectable.transform.position, crusherTR.position);
        //            for (int i = 0; i < FishDropArea.Instance.collectableList.Count; i++)
        //            {
        //                if (Vector3.Distance(FishDropArea.Instance.collectableList[i].transform.position, crusherTR.position) < distance)
        //                {
        //                    currentCollectable = FishDropArea.Instance.collectableList[i];
        //                    distance = Vector3.Distance(currentCollectable.transform.position, crusherTR.position);
        //                }
        //            }
        //            indTr.position = new Vector3(currentCollectable.transform.position.x, indTr.position.y, currentCollectable.transform.position.z);
        //            IndicatorManager.Instance.IndicatorTargeterActive();
        //        }

        //    }
        //}
    }
    //public void CarLevelCreate(int level)
    //{
    //    foreach (var car in carLevelsGO)
    //    {
    //        car.SetActive(false);
    //    }
    //    carLevelsGO[level].SetActive(true);
    //}
}
