//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
[System.Serializable]
public struct EnvDatas
{
    public List<Environments> environments;

}
public class EnvironmentList : MonoBehaviour
{
    private static EnvironmentList _instance = null;
    public static EnvironmentList Instance => _instance;
    [SerializeField] int L3_firstEnvCount;
    public List<Environments> allEnvironments = new List<Environments>();
    public List<EnvDatas> envDatas;
    public List<int> collectEnvCounters = new List<int>();

    //public List<Environments> L1environments = new List<Environments>();
    //public List<Environments> L2environments = new List<Environments>();
    //public List<Environments> L3environments = new List<Environments>();
    //public List<Environments> L4environments = new List<Environments>();
    //public List<Environments> L5environments = new List<Environments>();
    //public CollectableArrangement _collectableArrangement;
    bool newObjectActive = false;
    //public int[] envListCounter;
    [SerializeField] int plasticOpenLevel;
    [SerializeField] int yarnOpenLevel;
    [SerializeField] int woodOpenLevel;
    [SerializeField] CinemachineVirtualCamera plasticCam, yarnCam, woodCam;
    bool plasticOpenActive = false;
    bool yarnOpenActive = false;
    bool woodOpenActive = false;
    [SerializeField] List<GameObject> plastics;
    [SerializeField] List<GameObject> threads;
    [SerializeField] List<GameObject> woods;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        CollectProgressManager.Instance.totalEnvCount = allEnvironments.Count;
        Globals.envLevel = PlayerPrefs.GetInt("envlevel");
        EnvironmentOpen();
    }
    public void EnvironmentOpen()
    {
        for (int i = 0; i < collectEnvCounters.Count; i++)
        {
            collectEnvCounters[i] = 0;
        }
    
        for (int i = 0; i < Globals.envLevel + 1; i++)
        {
            foreach(var envs in envDatas[i].environments)
            {
                envs.gameObject.SetActive(true);
            }
        }
    }

    public void EnvironmentReset()
    {
        totalCollectedCount = 0;
        maxGarbageCount = 0;
        for (int i = 0; i < collectEnvCounters.Count; i++)
        {
            collectEnvCounters[i] = 0;
        }
        for (int i = 0; i < Globals.envLevel + 1; i++)
        {
            foreach (var envs in envDatas[i].environments)
            {
                envs.gameObject.SetActive(true);
                envs.EnvReset();
            }
        }
        for (int i = 0; i < Globals.envLevel + 1; i++)
        {
            maxGarbageCount += envDatas[i].environments.Count;
        }

        if (plasticOpenActive)
        {
            plasticOpenActive = false;
            StartCoroutine(CamSet(plasticCam, 1));
        }

        if (yarnOpenActive)
        {
            yarnOpenActive = false;
            StartCoroutine(CamSet(yarnCam, 2));
        }

        if (woodOpenActive)
        {
            woodOpenActive = false;
            StartCoroutine(CamSet(woodCam, 3));
        }
        Globals.envLevelUpActive = true;
    }
    [SerializeField] int totalCollectedCount = 0;
    [SerializeField] int maxGarbageCount = 0;
    public void EnvLevelUpCheck()
    {
        totalCollectedCount++;
        CollectProgressManager.Instance.CollectEnvSliderSet(totalCollectedCount, maxGarbageCount);
        if (Globals.envLevelUpActive && totalCollectedCount >= maxGarbageCount && PlayerPrefs.GetInt("envlevel") < envDatas.Count - 1)
        {
            Globals.envLevelUpActive = false;
            Globals.envLevel++;
            PlayerPrefs.SetInt("envlevel", Globals.envLevel);
            Debug.Log("Globals.envLevel  " + Globals.envLevel);
            if(plasticOpenLevel == Globals.envLevel)
            {
                plasticOpenActive = true;
            }

            if (yarnOpenLevel == Globals.envLevel)
            {
                yarnOpenActive = true;
            }

            if (woodOpenLevel == Globals.envLevel)
            {
                woodOpenActive = true;
            }

            string str = "Hole Stage : " + (Globals.envLevel + 1).ToString() + " Unlocked";
            float time = CoefficientTransformation.FormatSaniye(Globals.speedPlayTime);
            //GameAnalytics.NewDesignEvent(str,time);
        }
    }
    IEnumerator CamSet(CinemachineVirtualCamera cam,int i)
    {
        if(i == 1)
        {
            StartCoroutine(PlasticsSeqOpen());
            GameManager.Instance.ui.plasticOpenTextGO.SetActive(true);
        }
        if (i == 2)
        {
            StartCoroutine(ThreadsSeqOpen());
            GameManager.Instance.ui.yarnOpenTextGO.SetActive(true);
        }
        if (i == 3)
        {
            StartCoroutine(WoodsSeqOpen());
            GameManager.Instance.ui.woodOpenTextGO.SetActive(true);
        }
        cam.Priority = 50;
        yield return new WaitForSeconds(4f);
        cam.Priority = 0;

        if (i == 1)
        {
            GameManager.Instance.ui.plasticOpenTextGO.SetActive(false);
        }
        if (i == 2)
        {
            GameManager.Instance.ui.yarnOpenTextGO.SetActive(false);
        }
        if (i == 3)
        {
            GameManager.Instance.ui.woodOpenTextGO.SetActive(false);
        }
    }
    IEnumerator PlasticsSeqOpen()
    {
        foreach(GameObject obj in plastics)
        {
            obj.SetActive(false);
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < plastics.Count; i++)
        {
            plastics[i].SetActive(true);
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator ThreadsSeqOpen()
    {
        foreach (GameObject obj in threads)
        {
            obj.SetActive(false);
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < threads.Count; i++)
        {
            threads[i].SetActive(true);
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator WoodsSeqOpen()
    {
        foreach (GameObject obj in woods)
        {
            obj.SetActive(false);
        }
        yield return new WaitForSeconds(1.5f);
        for (int i = 0; i < woods.Count; i++)
        {
            woods[i].SetActive(true);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
