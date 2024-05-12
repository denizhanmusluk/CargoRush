//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HoleUpgradeManager : MonoBehaviour
{
    private static HoleUpgradeManager _instance = null;
    public static HoleUpgradeManager Instance => _instance;

    public HoleUpgradeSettings _holeUpgradeSettings;
    [SerializeField] UpgradeButton button_HoleRadiusUpgrade, button_HoleSpeedUpgrade, button_HoleTimeUpgrade;

    int maxLevel = 0;
    int minLevel = 0;
    int deltaLevel = 2;
    private void Awake()
    {
        _instance = this;
        //Globals.holeRadiusLevel = PlayerPrefs.GetInt("holeRadiusLevel");
        //Globals.holeLevel = PlayerPrefs.GetInt("holeLevel");
        //Globals.holeSpeedLevel = PlayerPrefs.GetInt("holeSpeedLevel");
        //Globals.holeTimeLevel = PlayerPrefs.GetInt("holeTimeLevel");
        ////Globals.holeRadiusLevel = Globals.holeLevel / 3;

        //Globals.holeRadiusLevel = _holeUpgradeSettings.holeCollectLevel[Globals.holeLevel];
        //CameraManager.Instance.HoleCameraFovSet();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            HoleRadiusUpgradeButton();
            HoleSpeedUpgradeButton();
            HoleTimeUpgradeButton();
        }
    }
    private void OnEnable()
    {
        //Globals.holeLevel = PlayerPrefs.GetInt("holeLevel");
        //Globals.holeSpeedLevel = PlayerPrefs.GetInt("holeSpeedLevel");
        //Globals.holeTimeLevel = PlayerPrefs.GetInt("holeTimeLevel");

        //Globals.holeRadiusLevel = _holeUpgradeSettings.holeCollectLevel[Globals.holeLevel];
        //CameraManager.Instance.HoleCameraFovSet();
    }
    private void Start()
    {
        _holeUpgradeSettings = LevelManager.Instance._holeUpgradeSettings;

        Globals.holeLevel = PlayerPrefs.GetInt("holeLevel" + Globals.currentLevelIndex.ToString());
        Globals.holeSpeedLevel = PlayerPrefs.GetInt("holeSpeedLevel" + Globals.currentLevelIndex.ToString());
        Globals.holeTimeLevel = PlayerPrefs.GetInt("holeTimeLevel" + Globals.currentLevelIndex.ToString());

        Globals.holeRadiusLevel = _holeUpgradeSettings.holeCollectLevel[Globals.holeLevel];
        CameraManager.Instance.HoleCameraFovSet();



        isEnoughMoney();
        InitButtonValues();
    }
    void InitButtonValues()
    {
        if (Globals.holeLevel < _holeUpgradeSettings.holeRadius.Length - 1)
        {
            button_HoleRadiusUpgrade.TextInit(Globals.holeLevel, _holeUpgradeSettings.holeRadiusCost[Globals.holeLevel + 1]);
            button_HoleRadiusUpgrade.UpgradeValueTextInit(_holeUpgradeSettings.holeRadius[Globals.holeLevel], _holeUpgradeSettings.holeRadius[Globals.holeLevel + 1]);
            button_HoleRadiusUpgrade.ButtonLevel(Globals.holeLevel);
        }
        else
        {
            button_HoleRadiusUpgrade.FullLevel();
            button_HoleRadiusUpgrade.UpgradeValueFull(_holeUpgradeSettings.holeRadius[Globals.holeLevel]);
            button_HoleRadiusUpgrade.ButtonLevel(Globals.holeLevel);
        }


        if (Globals.holeTimeLevel < _holeUpgradeSettings.holeTime.Length - 1)
        {
            button_HoleTimeUpgrade.TextInit(Globals.holeTimeLevel, _holeUpgradeSettings.holeTimeCost[Globals.holeTimeLevel + 1]);
            button_HoleTimeUpgrade.UpgradeValueTextInit(_holeUpgradeSettings.holeTime[Globals.holeTimeLevel], _holeUpgradeSettings.holeTime[Globals.holeTimeLevel + 1]);
            button_HoleTimeUpgrade.ButtonLevel(Globals.holeTimeLevel);
        }
        else
        {
            button_HoleTimeUpgrade.FullLevel();
            button_HoleTimeUpgrade.UpgradeValueFull(_holeUpgradeSettings.holeTime[Globals.holeTimeLevel]);
            button_HoleTimeUpgrade.ButtonLevel(Globals.holeTimeLevel);
        }


        if (Globals.holeSpeedLevel < _holeUpgradeSettings.holeSpeed.Length - 1)
        {
            button_HoleSpeedUpgrade.TextInit(Globals.holeSpeedLevel, _holeUpgradeSettings.holeSpeedCost[Globals.holeSpeedLevel + 1] );
            button_HoleSpeedUpgrade.UpgradeValueTextInit(_holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel], _holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel + 1]);
            button_HoleSpeedUpgrade.ButtonLevel(Globals.holeSpeedLevel);

        }
        else
        {
            button_HoleSpeedUpgrade.FullLevel();
            button_HoleSpeedUpgrade.UpgradeValueFull(_holeUpgradeSettings.holeSpeed[Globals.holeSpeedLevel]);
            button_HoleSpeedUpgrade.ButtonLevel(Globals.holeSpeedLevel);
        }
        VibratoManager.Instance.MediumVibration();
    }
    public void HoleRadiusUpgradeButton()
    {
        if (Globals.holeLevel < _holeUpgradeSettings.holeRadius.Length - 1)
        {
            if (Globals.moneyAmount >= _holeUpgradeSettings.holeRadiusCost[Globals.holeLevel + 1])
            {
                GameManager.Instance.MoneyUpdate(-_holeUpgradeSettings.holeRadiusCost[Globals.holeLevel + 1]);
            
                Globals.holeLevel++;
                Globals.holeRadiusLevel = _holeUpgradeSettings.holeCollectLevel[Globals.holeLevel];

                PlayerPrefs.SetInt("holeLevel" + Globals.currentLevelIndex.ToString(), Globals.holeLevel);
                HoleManager.Instance.HoleLevelUp();
                isEnoughMoney();
                InitButtonValues();
              
                
                string tag = "Hole Size Upgrade " + Globals.holeLevel.ToString();
                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }
        }
    }

    public void HoleSpeedUpgradeButton()
    {
        if (Globals.holeSpeedLevel < _holeUpgradeSettings.holeSpeed.Length - 1)
        {
            if (Globals.moneyAmount >= _holeUpgradeSettings.holeSpeedCost[Globals.holeSpeedLevel + 1] )
            {
                GameManager.Instance.MoneyUpdate(-_holeUpgradeSettings.holeSpeedCost[Globals.holeSpeedLevel + 1]);
                Globals.holeSpeedLevel++;
                PlayerPrefs.SetInt("holeSpeedLevel" + Globals.currentLevelIndex.ToString(), Globals.holeSpeedLevel);
                isEnoughMoney();
                InitButtonValues();
              
                
                string tag = "Hole Speed Upgrade " + Globals.holeSpeedLevel.ToString();
                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }
        }
    }
    public void HoleTimeUpgradeButton()
    {
        if (Globals.holeTimeLevel < _holeUpgradeSettings.holeTime.Length - 1)
        {
            if (Globals.moneyAmount >= _holeUpgradeSettings.holeTimeCost[Globals.holeTimeLevel + 1] )
            {
                GameManager.Instance.MoneyUpdate(-_holeUpgradeSettings.holeTimeCost[Globals.holeTimeLevel + 1]);
                Globals.holeTimeLevel++;
                PlayerPrefs.SetInt("holeTimeLevel" + Globals.currentLevelIndex.ToString(), Globals.holeTimeLevel);
                HoleManager.Instance.HoleTimeUp();

                isEnoughMoney();
                InitButtonValues();
                HoleManager.Instance._holeTimer.Initial();
                
                
                string tag = "Hole Time Upgrade " + Globals.holeTimeLevel.ToString();
                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }

        }

    }
    public void isEnoughMoney()
    {
        if (Globals.holeLevel < _holeUpgradeSettings.holeRadius.Length - 1 && Globals.moneyAmount >= _holeUpgradeSettings.holeRadiusCost[Globals.holeLevel + 1])
        {
            button_HoleRadiusUpgrade.GetComponent<Button>().interactable = true;
        }
        else
        {
            button_HoleRadiusUpgrade.GetComponent<Button>().interactable = false;
        }


        if (Globals.holeTimeLevel < _holeUpgradeSettings.holeTime.Length - 1 && Globals.moneyAmount >= _holeUpgradeSettings.holeTimeCost[Globals.holeTimeLevel + 1] )
        {
            button_HoleTimeUpgrade.GetComponent<Button>().interactable = true;
        }
        else
        {
            button_HoleTimeUpgrade.GetComponent<Button>().interactable = false;
        }

        if (Globals.holeSpeedLevel < _holeUpgradeSettings.holeSpeed.Length - 1 && Globals.moneyAmount >= _holeUpgradeSettings.holeSpeedCost[Globals.holeSpeedLevel + 1] )
        {
            button_HoleSpeedUpgrade.GetComponent<Button>().interactable = true;
        }
        else
        {
            button_HoleSpeedUpgrade.GetComponent<Button>().interactable = false;
        }
        CheckMaxLevel();
        CheckButtons();
    }
    void CheckMaxLevel()
    {
        if(maxLevel < Globals.holeLevel)
        {
            maxLevel = Globals.holeLevel;
        }
        if (maxLevel < Globals.holeTimeLevel)
        {
            maxLevel = Globals.holeTimeLevel;
        }
        if (maxLevel < Globals.holeSpeedLevel)
        {
            maxLevel = Globals.holeSpeedLevel;
        }

        minLevel = 10;
        if (minLevel > Globals.holeLevel)
        {
            minLevel = Globals.holeLevel;
        }
        if (minLevel > Globals.holeTimeLevel)
        {
            minLevel = Globals.holeTimeLevel;
        }
        if (minLevel > Globals.holeSpeedLevel)
        {
            minLevel = Globals.holeSpeedLevel;
        }
    }

    void CheckButtons()
    {
        if(Globals.holeLevel < maxLevel - deltaLevel)
        {
            if (Globals.moneyAmount >= _holeUpgradeSettings.holeRadiusCost[Globals.holeLevel + 1])
            {
                if (!button_HoleRadiusUpgrade.tutorialGO.activeInHierarchy)
                {
                    button_HoleRadiusUpgrade.tutorialGO.SetActive(true);
                }
            }
            else
            {
                button_HoleRadiusUpgrade.tutorialGO.SetActive(false);
            }
        }
        else
        {
            button_HoleRadiusUpgrade.tutorialGO.SetActive(false);

            //if(Globals.holeLevel == maxLevel && maxLevel - minLevel > deltaLevel)
            //{
            //    button_HoleRadiusUpgrade.GetComponent<Button>().interactable = false;
            //}
        }



        if (Globals.holeSpeedLevel < maxLevel - deltaLevel)
        {
            if (Globals.moneyAmount >= _holeUpgradeSettings.holeSpeedCost[Globals.holeSpeedLevel + 1])
            {
                if (!button_HoleSpeedUpgrade.tutorialGO.activeInHierarchy)
                {
                    button_HoleSpeedUpgrade.tutorialGO.SetActive(true);
                }
            }
            else
            {
                button_HoleSpeedUpgrade.tutorialGO.SetActive(false);
            }
        }
        else
        {
            button_HoleSpeedUpgrade.tutorialGO.SetActive(false);

            //if (Globals.holeSpeedLevel == maxLevel && maxLevel - minLevel > deltaLevel)
            //{
            //    button_HoleSpeedUpgrade.GetComponent<Button>().interactable = false;
            //}
        }


        if (Globals.holeTimeLevel < maxLevel - deltaLevel)
        {
            if (Globals.moneyAmount >= _holeUpgradeSettings.holeTimeCost[Globals.holeTimeLevel + 1])
            {
                if (!button_HoleTimeUpgrade.tutorialGO.activeInHierarchy)
                {
                    button_HoleTimeUpgrade.tutorialGO.SetActive(true);
                }
            }
            else
            {
                button_HoleTimeUpgrade.tutorialGO.SetActive(false);
            }
        }
        else
        {
            button_HoleTimeUpgrade.tutorialGO.SetActive(false);

            //if (Globals.holeTimeLevel == maxLevel && maxLevel - minLevel > deltaLevel)
            //{
            //    button_HoleTimeUpgrade.GetComponent<Button>().interactable = false;
            //}
        }

    }
}
