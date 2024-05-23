using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Cinemachine;

public class AvailableForPurchase : MonoBehaviour
{
    private static AvailableForPurchase _instance = null;
    public static AvailableForPurchase Instance => _instance;

    public List<GameObject> saleBuilds = new List<GameObject>();
    public CollectableArrangement _requirements;
    public List<BuyBuild> _buyBuild = new List<BuyBuild>();
    [SerializeField] public int _woodCountCurrent = 0, _plasticCountCurrent = 0, _ironCountCurrent = 0;

    GameObject currentSaleBuilds;
    public TextMeshPro controlCenterText;
    [SerializeField] CinemachineVirtualCamera rightCam, leftCam;
    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        for (int i = 0; i < (PlayerPrefs.GetInt("saleLevel") + 1); i++)
        {
            GameObject _saleBuilds =  Instantiate(saleBuilds[i], transform.position, Quaternion.identity);
            if ( i == PlayerPrefs.GetInt("saleLevel"))
            {
                currentSaleBuilds = _saleBuilds;
                //IndicatorManager.Instance.ListSet(_saleBuilds.GetComponent<BuildingManager>()._buyBuilds);
            }
        }
        //SetCollectableList();

        if (PlayerPrefs.GetInt("NextLevelActive") == 1)
        {
            NextLevelActivision();
        }
    }
    public void ListSet()
    {
        //IndicatorManager.Instance.ListSet(currentSaleBuilds.GetComponent<BuildingManager>()._buyBuilds);
    }
    void SetCollectableList()
    {
        //_requirements = LevelManager.Instance.requirementList[Globals.currentLevelIndex];

        for (int i = 0; i < _requirements.Collectables2.Length; i++)
        {
            _requirements.Collectables[i] = _requirements.Collectables2[i];
        }
    }
    public void OpenAreaLevelUp()
    {
        if (PlayerPrefs.GetInt("saleLevel") < saleBuilds.Count - 1)
        {
            PlayerPrefs.SetInt("saleLevel", PlayerPrefs.GetInt("saleLevel") + 1);
            GameObject _saleBuilds = Instantiate(saleBuilds[PlayerPrefs.GetInt("saleLevel")], transform.position, Quaternion.identity);
            currentSaleBuilds = _saleBuilds;
            CameraManager.Instance.PlayerCameraFovSet();
            StartCoroutine(ViewToArea(_saleBuilds.GetComponent<BuildingManager>()));
            //IndicatorManager.Instance.ListSet(_saleBuilds.GetComponent<BuildingManager>()._buyBuilds);
        }
        else
        {
            PlayerPrefs.SetInt("NextLevelActive", 1);
            Debug.Log("Next Level----Next Level----Next Level----Next Level");
            //PlayerPrefs.DeleteAll();
            //GameManager.Instance.ui.NextLevel();
            NextLevelActivision();
            StartCoroutine(ShowArea());
            //PlayerController.Instance._stackCollect.DisperseCollected();
            CollectableList.Instance.ClearAllCollectable();
        }
    }
    public void NextLevelActivision()
    {
        controlCenterText.text = "Next Level";
        //IndicatorManager.Instance.ControlCenterIndActive = true;
        //IndicatorManager.Instance.ShowControlCenter();
    }
    public void RequirementsSets()
    {
        _woodCountCurrent = 0;
        _plasticCountCurrent = 0;
        _ironCountCurrent = 0;

        foreach (var bld in _buyBuild)
        {
            if (bld.woodCountCurrent > 0)
            {
                _woodCountCurrent += bld.woodCountCurrent;
            }

            if (bld.plasticCountCurrent > 0)
            {
                _plasticCountCurrent += bld.plasticCountCurrent;
            }

            if (bld.ironCountCurrent > 0)
            {
                _ironCountCurrent += bld.ironCountCurrent;
            }
        }
        if (_woodCountCurrent <= 0)
        {
            string str = null;
            for (int i = 0; i < _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")].Length; i++)
            {
                char _colID = _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")][i];
                int colID = System.Convert.ToInt32(_colID - '0');
                if (colID == 0)
                {
                    str += "3";
                }
                else
                {
                    str += _colID;
                }
            }
            _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")] = str;
        }


        if (_plasticCountCurrent <= 0)
        {
            string str = null;
            for (int i = 0; i < _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")].Length; i++)
            {
                char _colID = _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")][i];
                int colID = System.Convert.ToInt32(_colID - '0');
                if (colID == 1)
                {
                    str += "3";
                }
                else
                {
                    str += _colID;
                }
            }
            _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")] = str;
        }
        if (_ironCountCurrent <= 0)
        {
            string str = null;
            for (int i = 0; i < _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")].Length; i++)
            {
                char _colID = _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")][i];
                int colID = System.Convert.ToInt32(_colID - '0');
                if (colID == 2)
                {
                    str += "3";
                }
                else
                {
                    str += _colID;
                }
            }
            _requirements.Collectables[PlayerPrefs.GetInt("saleLevel")] = str;
        }
    }



    IEnumerator ViewToArea(BuildingManager buildingManager)
    {
        PlayerController.Instance.PlayerControlDeActive();

        yield return new WaitForSeconds(1f);
         //buildingManager = saleBuilds[PlayerPrefs.GetInt("saleLevel")].GetComponent<BuildingManager>();
        for (int i = 0; i < buildingManager._buyBuilds.Count; i++)
        {
            buildingManager._buyBuilds[i].buyCamera.Priority = (2 + i);
            yield return new WaitForSeconds(1.5f);
        }
        for (int i = 0; i < buildingManager._buyBuilds.Count; i++)
        {
            buildingManager._buyBuilds[i].buyCamera.Priority =0;
        }
        PlayerController.Instance.GameStart();

    }

    IEnumerator ShowArea()
    {
        CinemachineBlendDefinition def = new CinemachineBlendDefinition(CinemachineBlendDefinition.Style.Custom, 2);

        def.m_Time = 2;
        Camera.main.GetComponent<CinemachineBrain>().m_DefaultBlend = def;
        
        rightCam.Priority = 50;
        leftCam.Priority = 0;
        yield return new WaitForSeconds(2f);
        rightCam.Priority = 0;
        leftCam.Priority = 50;
        yield return new WaitForSeconds(2f);
        rightCam.Priority = 0;
        leftCam.Priority = 0;
    }
}