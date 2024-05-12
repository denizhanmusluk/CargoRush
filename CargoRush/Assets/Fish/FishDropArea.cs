using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FishDropArea : MonoBehaviour
{
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
    void Start()
    {
        _CollectProduct.collectables = fishCollectable;
        //FishManager.Instance.rubbishDropArea = this;
        //IndicatorManager.Instance._FishDropAreaList.Add(this);
        CollectProductList.Add(_CollectProduct);
        //_CollectProduct._FishDropArea = this;
    }
    IEnumerator GarbageDropping()
    {
        while (true)
        {
            int garbageSelect = Random.Range(0, garbagePrefabs.Length);
            GarbageCreate(garbageSelect);
            yield return new WaitForSeconds(1f);
        }
    }
    public void GarbageCreate(int id)
    {
        Collectable _fishCollect;
        GameObject fsh = Instantiate(garbagePrefabs[id], fishPosTR[posNo % fishPosTR.Length].position, Quaternion.identity);
        fsh.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
        posNo++;

        _fishCollect = fsh.GetComponent<Collectable>();
        _fishCollect.collectActive = true;
        collectableList.Add(_fishCollect);
        _fishCollect.collectableList = collectableList;
        //_fishCollect.fishArea = this;
        //fishCollectable.Add(_fishCollect);
        //_fishCollect.fishCollectable = fishCollectable;
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
