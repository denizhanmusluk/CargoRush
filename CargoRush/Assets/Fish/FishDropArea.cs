using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public struct productType
{
    public List<Collectable> productList;
}

public class FishDropArea : MonoBehaviour
{
    private static FishDropArea _instance = null;
    public static FishDropArea Instance => _instance;
    public float createPeriod = 1f;
    public float reactiveRate = 1f;

    public GameObject[] garbagePrefabs;
    public Transform[] fishPosTR;
    public Transform[] gemPosTR;
    public List<Collectable> fishCollectable;
    int posNo = 0;
    int gemPosNo = 0;
    public bool targetActive = true;
    public int requirementCount = 0;
    public int collectLevel;
    [SerializeField] CollectProduct _CollectProduct;
    public List<Stand> standList;
    public List<CollectProduct> CollectProductList;
    [SerializeField] BigAquarium bigAquarium;
    public List<Collectable> collectableList;

    public GameObject gemCollectable;

    public Transform createPos, forceDirPos;
    public List<Transform> createPosList = new List<Transform>();

    public int totalProductCapacity = 50;

   public List<productType> proType = new List<productType>();

    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        _CollectProduct.collectables = fishCollectable;
        //FishManager.Instance.rubbishDropArea = this;
        //IndicatorManager.Instance._FishDropAreaList.Add(this);
        CollectProductList.Add(_CollectProduct);
        //_CollectProduct._FishDropArea = this;
        StartCoroutine(GarbageDropping());
    }
    IEnumerator GarbageDropping()
    {
        while (true)
        {
            //int garbageSelect = Random.Range(0, garbagePrefabs.Length);

            while (totalProductCapacity <= collectableList.Count)
            {
                while ((float)totalProductCapacity * reactiveRate + 1 < collectableList.Count)
                {
                    yield return new WaitForSeconds(1f);

                }

                yield return new WaitForSeconds(1f);
            }

            int garbageSelect = LeastIdCheck();
            GarbageCreate(garbageSelect);
            yield return new WaitForSeconds(createPeriod);
        }
    }
    int LeastIdCheck()
    {
        int minId = 0;
        int count = 0;
        if (collectableList.Count > 0)
        {
            count = proType[0].productList.Count;
            for (int i = 0; i <= Globals.collectableLevel; i++)
            {
                if (proType[i].productList.Count < count)
                {
                    count = proType[i].productList.Count;
                    minId = i;
                }
            }
        }
        return minId;
    }
    public void GarbageCreate(int id)
    {
        int createPosSelect = Random.Range(0, createPosList.Count);
        Collectable _fishCollect;
        GameObject fsh = Instantiate(garbagePrefabs[id], createPosList[createPosSelect].position, Quaternion.identity);
        //GameObject fsh = Instantiate(garbagePrefabs[id], fishPosTR[posNo % fishPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        posNo++;

        _fishCollect = fsh.GetComponent<Collectable>();
        _fishCollect.collectActive = true;
        collectableList.Add(_fishCollect);
        _fishCollect.collectableList = collectableList;

        proType[id].productList.Add(_fishCollect);

        if (fsh.GetComponent<Collector>() != null)
        {
            //Vector3 forceDir = (forceDirPos.position - createPos.position).normalized;
            Vector3 forceDir = (-createPosList[createPosSelect].up).normalized;
            fsh.GetComponent<Collector>().FirstPush(forceDir);
        }
    }
    public void GemCreating()
    {
        GameObject fsh = Instantiate(gemCollectable, gemPosTR[gemPosNo % gemPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, 0, 0);
        gemPosNo++;
    }
    public void BigFishCreate(int fishID)
    {
        Collectable _fishCollect;
        GameObject fsh = Instantiate(garbagePrefabs[fishID], fishPosTR[posNo % fishPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        posNo++;

        _fishCollect = fsh.GetComponent<Collectable>();

        //_fishCollect.fishArea = this;
        fishCollectable.Add(_fishCollect);
        _fishCollect.fishCollectable = fishCollectable;

        if(_fishCollect.GetComponent<BigFish>() != null)
        {
            _fishCollect.GetComponent<BigFish>().bigAquarium = bigAquarium;
        }
    }

    public void TargetArrived(AIWorker aiWorker)
    {
        StartCoroutine(Staying(aiWorker));
    }
    IEnumerator Staying(AIWorker character)
    {
        //character.aiPopUp.OpenOperationPopUp(5);
        yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        //character.aiPopUp.ClosedAllPopUp();

        if (character.followActive)
        {
            character.TargetFishStandSelect();
        }
        yield return new WaitForSeconds(1f);

        //targetActive = true;
    }

    public void ShuffleList()
    {
        List<Stand> sortedList = standList.OrderBy(x => (x.fishCountCurrent)).ToList();
        standList = sortedList;
        //Shuffle(standList);
    }
}
