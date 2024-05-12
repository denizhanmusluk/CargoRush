using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCreating : MonoBehaviour
{
    [SerializeField] GameObject moneyPrefab;

    //public int moneyNum;
    //public List<GameObject> moneyList;
    public float spawnTime = 0.67f;
    public int maxLimit = 12;
    public int banknotValue = 1;
    [SerializeField] Transform[] moneyInstantiatePoint;
    //[SerializeField] Transform firstInstPoint, firstInstPoint2;
    [SerializeField] MoneyCollect moneyCollecting;
    [SerializeField] public MeshRenderer buildMesh;
    float spawnTurboTime = 0.04f;
   public float firstSpawnTime;
    private void Awake()
    {
        firstSpawnTime = spawnTime;
    }
    void Start()
    {
        Debug.Log("firstSpawnTime " + firstSpawnTime);
        StartCoroutine(SpawnMoney());
    }

    IEnumerator SpawnMoney()
    {
        while (!transform.parent.GetComponent<Build>().troubleActive)
        {
            yield return new WaitForSeconds(spawnTime);

            if (moneyCollecting.moneyNum < maxLimit)
            {
                GameObject material = Instantiate(moneyPrefab, transform.position, Quaternion.Euler(-90,90,0), this.transform);
                material.GetComponent<Banknot>().banknotValue = banknotValue;
                float clothRow = moneyCollecting.moneyNum / moneyInstantiatePoint.Length;
                material.GetComponent<Banknot>().mnyCollect = moneyCollecting;
                Vector3 targetPos = moneyInstantiatePoint[moneyCollecting.moneyNum % moneyInstantiatePoint.Length].position + new Vector3(0, (clothRow / 3), 0);
                material.transform.position = targetPos;
                moneyCollecting.moneyList.Add(material);
                moneyCollecting.moneyNum++;
            }
        }
        yield return null;
        StartCoroutine(SpawnMoney());
    }
    public void spawnSpeed()
    {
        StartCoroutine(spawnSpeedSet());
    }
    IEnumerator spawnSpeedSet()
    {
        spawnTime = spawnTurboTime;
        yield return new WaitForSeconds(5f);
        spawnTime = firstSpawnTime;
    }
}
