using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    private static FishManager _instance = null;
    public static FishManager Instance => _instance;
    public List<Fish> _fishList;
    public GameObject[] fishPrefab;
    public GameObject[] whaleFishPrefab;
    public GameObject[] dolphinFishPrefab;
    public int[] fishCount = new int[4];
    public int[] newFishCount = new int[4];
    public List<WorkArea> _FishDropAreaList = new List<WorkArea>();
    public FishDropArea rubbishDropArea;
    public float firstSize;
    public float lastSize;
    //public GameObject carUpgradeArea;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        //if (PlayerPrefs.GetInt("carup") == 1)
        //{
        //    carUpgradeArea.SetActive(true);
        //}
        StartCoroutine(StartDelay());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1f);
        if(PlayerPrefs.GetInt("firstgarbageCreate") == 0)
        {
            IndicatorManager.Instance.IndicatorTargeterActive();
            PlayerPrefs.SetInt("firstgarbageCreate", 1);
            for(int i = 0; i < 8; i++)
            {
                Fish_Create(11);
            }
        }
        if (PlayerPrefs.GetInt("firstindactive") == 0)
        {
            for (int i = 0; i < 10; i++)
            {
                //Fish_Create(0);
            }
        }
    }
    public void FishCreate()
    {
        for(int i = 0; i < newFishCount.Length; i++)
        {
            newFishCount[i] = (int)((float)fishCount[i] * (1f + (float)(Globals.holeLevel + Globals.holeSpeedLevel + Globals.holeTimeLevel) * 0.05f));
        }
        for (int j = 0; j < fishCount.Length; j++)
        {
            for (int i = 0; i < newFishCount[j]; i++)
            {
                Fish _fish = Instantiate(fishPrefab[j], transform.position, Quaternion.identity).GetComponent<Fish>();
                //Vector3 randomPosition = new Vector3(Random.Range(leftBounding.position.x +10 , rightBounding.position.x -10  ), HoleManager.Instance.fishSurface.position.y, Random.Range(bottomBounding.position.z + 0.5f, topBounding.position.z - 10));
            
                //_fish.transform.position = randomPosition;
                _fish.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
                _fishList.Add(_fish);
            }
        }
        if (Globals.bigFishAquariumActive)
        {
            Debug.Log("big fish active");
            for(int i = 0; i < whaleFishPrefab.Length - PlayerPrefs.GetInt("bigfish0"); i++)
            {
                Fish _fish = Instantiate(whaleFishPrefab[i], transform.position, Quaternion.identity).GetComponent<Fish>();
                //Vector3 randomPosition = new Vector3(Random.Range(leftBounding.position.x + 10, rightBounding.position.x - 10), HoleManager.Instance.fishSurface.position.y, Random.Range(bottomBounding.position.z + 0.5f, topBounding.position.z - 10));

                //_fish.transform.position = randomPosition;
                _fish.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
                _fishList.Add(_fish);
            }
            if (PlayerPrefs.GetInt("bigfish0") > 0)
            {
                for (int i = 0; i < dolphinFishPrefab.Length - PlayerPrefs.GetInt("bigfish1"); i++)
                {
                    Fish _fish = Instantiate(dolphinFishPrefab[i], transform.position, Quaternion.identity).GetComponent<Fish>();
                    //Vector3 randomPosition = new Vector3(Random.Range(leftBounding.position.x + 10, rightBounding.position.x - 10), HoleManager.Instance.fishSurface.position.y, Random.Range(bottomBounding.position.z + 0.5f, topBounding.position.z - 10));

                    //_fish.transform.position = randomPosition;
                    _fish.transform.rotation = Quaternion.Euler(0, Random.Range(-180, 180), 0);
                    _fishList.Add(_fish);
                }
            }
        }
    }
    public void FishesStop()
    {
        foreach(Fish _fish in _fishList)
        {
            _fish.EmptyBottom();
        }
    }
    int fishDropCounter = 0;
    public void Fish_Create(int id)
    {
        rubbishDropArea.GarbageCreate(id);
        //for (int i = 0; i < _FishDropAreaList.Count; i++)
        //{
        //    if (_FishDropAreaList[i].collectLevel == id)
        //    {
        //        _FishDropAreaList[i].FishCreate();
        //    }
        //}
    }
    public void GemCreate()
    {
        rubbishDropArea.GemCreating2();
    }

    //public void BigFish_Create(int level , int bigFishID)
    //{
    //    for (int i = 0; i < _FishDropAreaList.Count; i++)
    //    {
    //        if (_FishDropAreaList[i].collectLevel == level)
    //        {
    //            _FishDropAreaList[i].BigFishCreate(bigFishID);
    //        }
    //    }
    //}
}
