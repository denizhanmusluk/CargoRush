//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WorkArea : MonoBehaviour
{
    public GameObject[] fishPrefabs;
    public Transform[] fishPosTR;
    public List<Collectable> fishCollectable;
    int posNo = 0;
    public bool targetActive = true;
    public int requirementCount = 0;
    public int collectLevel;
    [SerializeField] CollectProduct _CollectProduct;
    public List<Stand> standList;
    public List<Stand> standCourierList;
    public List<CollectProduct> CollectProductList;
    public List<int> CollectProductID = new List<int>();

    public List<Stand> productStandList = new List<Stand>();
    public Stand machineStand;

    void Start()
    {
        //_CollectProduct.collectables = fishCollectable;
        //FishManager.Instance._FishDropAreaList.Add(this);
        //IndicatorManager.Instance._FishDropAreaList.Add(this);
        //CollectProductList.Add(_CollectProduct);
        //_CollectProduct._FishDropArea = this;
        //StandManager.Instance.fishDropAreaList.Add(this);
    }

    public void FishCreate()
    {
        Collectable _fishCollect;
        GameObject fsh = Instantiate(fishPrefabs[0], fishPosTR[posNo % fishPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        posNo++;

        _fishCollect = fsh.GetComponent<Collectable>();
        //_fishCollect.animator.SetTrigger("flutter");

        _fishCollect.fishArea = this;
        fishCollectable.Add(_fishCollect);
        _fishCollect.fishCollectable = fishCollectable;
    }



    public void TargetArrived(AIWorker aiWorker)
    {
        StartCoroutine(Staying(aiWorker));
    }
    IEnumerator Staying(AIWorker character)
    {
        //character.aiPopUp.OpenOperationPopUp(5);
        yield return new WaitForSeconds(Random.Range(2.5f, 3f));
        //character.aiPopUp.ClosedAllPopUp();
        //ShuffleList();

        if (character.followActive)
        {
            character.TargetFishStandSelect();
        }
        //yield return new WaitForSeconds(1f);

        //targetActive = true;
    }


    private System.Random rng = new System.Random();

    public void Shuffle<T>(List<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
    public void ShuffleStandList()
    {
        List<Stand> sortedList = standList.OrderBy(x => (x.fishCountTotal - x.fishCountCurrent)).ToList();
        standList = sortedList;
        Shuffle(CollectProductList);

        int index = 0;
        for(int i = 0; i < standList.Count; i++)
        {
            bool breakActive = false;

            foreach (int cltId in standList[i].collectIDList)
            {


                for (int j = 0; j < CollectProductList.Count;j++)
                {
                    if (cltId == CollectProductList[j].CollectId)
                    {
                        index = j;
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
        Shuffle2(CollectProductList, index);
        //List<CollectProduct> sortedList2 = CollectProductList.OrderByDescending(x => (x.collectables.Count)).ToList();
        //CollectProductList = sortedList2;
        //Shuffle(standList);
    }
    public void ShuffleCollectProductList()
    {
        Shuffle(CollectProductList);
        List<CollectProduct> sortedList = CollectProductList.OrderByDescending(x => (x.collectables.Count)).ToList();
        CollectProductList = sortedList;
    }
    public void Shuffle2<T>(List<T> list, int index)
    {
        T value = list[0];
        list[0] = list[index];
        list[index] = value;
    }
    [SerializeField] string productName;
    public void StnadFullCheck()
    {
        bool isFull = true;

        foreach(var stnds in productStandList)
        {
            if(stnds.fishCountCurrent != 0)
            {
                isFull = false;
            }
        }
        if(machineStand.cannedCount < machineStand.productCountTotal)
        {
            isFull = false;
        }

        if (isFull)
        {
            float time = CoefficientTransformation.FormatSaniye(Globals.speedPlayTime);
            string productTag = productName + "Full";
            //GameAnalytics.NewDesignEvent(productTag, time);
        }
    }
}