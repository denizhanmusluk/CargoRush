using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class HRUpgradeManager : MonoBehaviour
{
    private static HRUpgradeManager _instance = null;
    public static HRUpgradeManager Instance => _instance;

    public CharacterUpgradeSettings _characterUpgradeSettings;
    [SerializeField] WorkerUpgradeButton button_Speed, button_Capacity, button_WorkerNo;
    public GameObject workerUpgradePanel;
    public HRWorkerArea _upgradeAreaWorkers;
    public Transform firstCreateTR;
    public GameObject HRWorkerGO;

    public GameObject upgradeButton;
    public GameObject exitTapTutorial_GO;
    private void Awake()
    {
        _instance = this;
        Globals.workerMoveSpeedLevel = PlayerPrefs.GetInt("workerMoveSpeedLevel" + PlayerPrefs.GetInt("level"));
        Globals.workerCapacityLevel = PlayerPrefs.GetInt("workerCapacityLevel" + PlayerPrefs.GetInt("level"));
        Globals.workerNoLevel = PlayerPrefs.GetInt("workerNoLevel" + PlayerPrefs.GetInt("level"));
        Globals.machineLevel = PlayerPrefs.GetInt("machineLevel" + PlayerPrefs.GetInt("level"));

    }
    private void Start()
    {
        _characterUpgradeSettings = LevelManager.Instance._currnetCharacterUpgradeSettings;
        isEnoughMoney();
        InitButtonValues();
    }
    public void InitButtonValues()
    {
        if (Globals.workerMoveSpeedLevel < _characterUpgradeSettings.workerMoveSpeed.Length - 1)
        {
            button_Speed.TextInit(Globals.workerMoveSpeedLevel, _characterUpgradeSettings.workerMoveSpeedCost[Globals.workerMoveSpeedLevel + 1]);
            button_Speed.UpgradeValueTextInit(_characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel], _characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel + 1]);
            button_Speed.ButtonLevel(Globals.workerMoveSpeedLevel);

        }
        else
        {
            button_Speed.FullLevel();
            button_Speed.UpgradeValueFull(_characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel]);
            button_Speed.ButtonLevel(Globals.workerMoveSpeedLevel);
        }


        if (Globals.workerNoLevel < _characterUpgradeSettings.workerNo.Length - 1)
        {
            button_WorkerNo.TextInit(Globals.workerNoLevel, _characterUpgradeSettings.workerNoCost[Globals.workerNoLevel + 1]);
            button_WorkerNo.UpgradeValueTextInit(_characterUpgradeSettings.workerNo[Globals.workerNoLevel], _characterUpgradeSettings.workerNo[Globals.workerNoLevel + 1]);
            button_WorkerNo.ButtonLevel(Globals.workerNoLevel);

        }
        else
        {
            button_WorkerNo.FullLevel();
            button_WorkerNo.UpgradeValueFull(_characterUpgradeSettings.workerNo[Globals.workerNoLevel]);
            button_WorkerNo.ButtonLevel(Globals.workerNoLevel);
        }


        if (Globals.workerCapacityLevel < _characterUpgradeSettings.workerCapacity.Length - 1)
        {
            button_Capacity.TextInit(Globals.workerCapacityLevel, _characterUpgradeSettings.workerCapacityCost[Globals.workerCapacityLevel + 1]);
            button_Capacity.UpgradeValueTextInit(_characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel], _characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel + 1]);
            button_Capacity.ButtonLevel(Globals.workerCapacityLevel);
        }
        else
        {
            button_Capacity.FullLevel();
            button_Capacity.UpgradeValueFull(_characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel]);
            button_Capacity.ButtonLevel(Globals.workerCapacityLevel);
        }
        VibratoManager.Instance.MediumVibration();
    }
    public void WorkerMoveSpeedUpgradeButton()
    {
        if (Globals.workerMoveSpeedLevel < _characterUpgradeSettings.workerMoveSpeed.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.workerMoveSpeedCost[Globals.workerMoveSpeedLevel + 1])
            {
                GameManager.Instance.MoneyUpdate(-_characterUpgradeSettings.workerMoveSpeedCost[Globals.workerMoveSpeedLevel + 1]);
                Globals.workerMoveSpeedLevel++;
                PlayerPrefs.SetInt("workerMoveSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.workerMoveSpeedLevel);
                PlayerController.Instance.magnet.MagnetLevelUp();

                string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerSpeedUpgrade" + Globals.workerMoveSpeedLevel.ToString();
                GameManager.Instance.GameAnalyticsTag(tag);
                
                //PlayerBehaviour.Instance.playerController.CharacterUpgrade(Globals.holeRadiusLevel);
                isEnoughMoney();
                InitButtonValues();
                for (int i = 0; i < PlayerPrefs.GetInt("workerNoLevel" + PlayerPrefs.GetInt("level")); i++)
                {
                    if (_upgradeAreaWorkers.workerList[i].GetComponent<AIWorker>() != null)
                    {
                        _upgradeAreaWorkers.workerList[i].GetComponent<AIWorker>().MoveSpeedInit();
                    }

                    if (_upgradeAreaWorkers.workerList[i].GetComponent<AIGarbageWorker>() != null)
                    {
                        _upgradeAreaWorkers.workerList[i].GetComponent<AIGarbageWorker>().MoveSpeedInit();
                    }
                }
                AudioManager.Instance.UpgradeSound();

                //PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                //PlayerController.Instance.UpgradeTextSpawn("+Magnet");
            }
        }
    }

    public void WorkerCapacityUpgradeButton()
    {
        if (Globals.workerCapacityLevel < _characterUpgradeSettings.workerCapacity.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.workerCapacityCost[Globals.workerCapacityLevel + 1])
            {
                GameManager.Instance.MoneyUpdate(-_characterUpgradeSettings.workerCapacityCost[Globals.workerCapacityLevel + 1]);
                Globals.workerCapacityLevel++;
                PlayerPrefs.SetInt("workerCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.workerCapacityLevel);
                isEnoughMoney();
                InitButtonValues();
                string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerCapacityUpgrade" + Globals.workerCapacityLevel.ToString();
                GameManager.Instance.GameAnalyticsTag(tag);
                //PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                //PlayerController.Instance.UpgradeTextSpawn("+Speed");
                AudioManager.Instance.UpgradeSound();
            }
        }
    }
    public void WorkerNoUpgradeButton()
    {
        if (Globals.workerNoLevel < _characterUpgradeSettings.workerNo.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.workerNoCost[Globals.workerNoLevel + 1])
            {
                int rebuyAmount = 0;

                //if (_upgradeAreaWorkers.workerBuyAreaList[PlayerPrefs.GetInt("workerNoLevel")].gameObject.activeInHierarchy)
                //{
                //    rebuyAmount = _upgradeAreaWorkers.workerBuyAreaList[PlayerPrefs.GetInt("workerNoLevel")].cost - _upgradeAreaWorkers.workerBuyAreaList[PlayerPrefs.GetInt("workerNoLevel")].currentAmount;
                //}

                GameManager.Instance.MoneyUpdate(-_characterUpgradeSettings.workerNoCost[Globals.workerNoLevel + 1] + rebuyAmount);
                Globals.workerNoLevel++;
                PlayerPrefs.SetInt("workerNoLevel" + PlayerPrefs.GetInt("level"), Globals.workerNoLevel);
                isEnoughMoney();
                InitButtonValues();
                WorkerCreate();

                string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-BuyWorker" + Globals.workerNoLevel.ToString() + "-REWARDED";
                GameManager.Instance.GameAnalyticsTag(tag);
                //HRWorkerGO.SetActive(false);

                //PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                //PlayerController.Instance.UpgradeTextSpawn("+Capacity");
                AudioManager.Instance.UpgradeSound();

                if (Globals.workerNoLevel == 1)
                {
                    exitTapTutorial_GO.SetActive(true);
                }
            }

        }

    }
    public void isEnoughMoney()
    {
        if (Globals.workerMoveSpeedLevel < _characterUpgradeSettings.workerMoveSpeed.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.workerMoveSpeedCost[Globals.workerMoveSpeedLevel + 1])
        {
            button_Speed.moneyButton.interactable = true;
        }
        else
        {
            button_Speed.moneyButton.interactable = false;
        }



        if (Globals.workerCapacityLevel < _characterUpgradeSettings.workerCapacity.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.workerCapacityCost[Globals.workerCapacityLevel + 1])
        {
            button_Capacity.moneyButton.interactable = true;
        }
        else
        {
            button_Capacity.moneyButton.interactable = false;
        }


        if (Globals.workerNoLevel < _characterUpgradeSettings.workerNo.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.workerNoCost[Globals.workerNoLevel + 1])
        {
            button_WorkerNo.moneyButton.interactable = true;
        }
        else
        {
            button_WorkerNo.moneyButton.interactable = false;
        }
    }
  
    public void WorkerBuyArea()
    {
        Globals.workerNoLevel++;
        PlayerPrefs.SetInt("workerNoLevel" + PlayerPrefs.GetInt("level"), Globals.workerNoLevel);
        isEnoughMoney();
        InitButtonValues();
        //HRWorkerGO.SetActive(false);
    }
    public void WorkerCreate()
    {
        if (PlayerPrefs.GetInt("workerNoLevel" + PlayerPrefs.GetInt("level")) >= 1)
        {
            for (int i = 0; i < PlayerPrefs.GetInt("workerNoLevel" + PlayerPrefs.GetInt("level")); i++)
            {
                _upgradeAreaWorkers.workerList[i].SetActive(true);
                //_upgradeAreaWorkers.workerBuyAreaList[i].gameObject.SetActive(false);
            }

            //StartCoroutine(WorkerCreateDelay());

        }
    }
    //IEnumerator WorkerCreateDelay()
    //{
    //    _upgradeAreaWorkers.workerList[PlayerPrefs.GetInt("workerNoLevel") - 1].GetComponent<NavMeshAgent>().enabled = false;
    //   yield return null;
    //    _upgradeAreaWorkers.workerList[PlayerPrefs.GetInt("workerNoLevel") - 1].transform.position = firstCreateTR.position;
    //    _upgradeAreaWorkers.workerList[PlayerPrefs.GetInt("workerNoLevel") - 1].GetComponent<NavMeshAgent>().enabled = true;
    //}


    bool opened = false;

    public void CharacterUpgradeOpen()
    {
        if (!opened)
        {
            opened = true;
            workerUpgradePanel.SetActive(true);
            PlayerController.Instance.PlayerControlDeActive();
            upgradeButton.SetActive(false);
            TutorialManager.Instance.clickUpgradeButtonGO.SetActive(false);
            AudioManager.Instance.ButtonSound();
        }
    }
    public void CharacterUpgradeClose()
    {
        if (opened)
        {
            opened = false;
            PlayerController.Instance.PlayerControl_ReActive();
            upgradeButton.SetActive(true);
            exitTapTutorial_GO.SetActive(false);
            IndicatorManager.Instance.KeepCollectTutorial();
        }
    }
    //public void CharacterUpgradeClose()
    //{
    //    if (opened)
    //    {
    //        opened = false;
    //        upgradeOpenActive = false;
    //        PlayerController.Instance.PlayerControl_ReActive();
    //    }

    //}


    public void WorkerMoveSpeedUpgrade_ADV_Click()
    {
        string adv_name = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerSpeedUpgrade" + Globals.workerMoveSpeedLevel.ToString() + "_REWARDED";
        ADVManager.Instance.RewardedStart(WorkerMoveSpeedUpgradeFree, adv_name);

    }
    public void WorkerCapacityUpgrade_ADV_Click()
    {
        string adv_name = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerCapacityUpgrade" + Globals.workerCapacityLevel.ToString() + "_REWARDED";
        ADVManager.Instance.RewardedStart(WorkerCapacityUpgradeFree, adv_name);
    }
    public void WorkerNoUpgrade_ADV_Click()
    {
        string adv_name = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-BuyWorker" + Globals.workerNoLevel.ToString() + "_REWARDED";
        ADVManager.Instance.RewardedStart(WorkerNoUpgradeFree, adv_name);
    }









    public void WorkerMoveSpeedUpgradeFree()
    {
        if (Globals.workerMoveSpeedLevel < _characterUpgradeSettings.workerMoveSpeed.Length - 1)
        {
            Globals.workerMoveSpeedLevel++;
            PlayerPrefs.SetInt("workerMoveSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.workerMoveSpeedLevel);
            PlayerController.Instance.magnet.MagnetLevelUp();

            string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerSpeedUpgrade" + Globals.workerMoveSpeedLevel.ToString() + "-REWARDED";
            GameManager.Instance.GameAnalyticsTag(tag);

            isEnoughMoney();
            InitButtonValues();
            for (int i = 0; i < PlayerPrefs.GetInt("workerNoLevel" + PlayerPrefs.GetInt("level")); i++)
            {
                if (_upgradeAreaWorkers.workerList[i].GetComponent<AIWorker>() != null)
                {
                    _upgradeAreaWorkers.workerList[i].GetComponent<AIWorker>().MoveSpeedInit();
                }

                if (_upgradeAreaWorkers.workerList[i].GetComponent<AIGarbageWorker>() != null)
                {
                    _upgradeAreaWorkers.workerList[i].GetComponent<AIGarbageWorker>().MoveSpeedInit();
                }
            }
        }
    }

    public void WorkerCapacityUpgradeFree()
    {
        if (Globals.workerCapacityLevel < _characterUpgradeSettings.workerCapacity.Length - 1)
        {
                Globals.workerCapacityLevel++;
                PlayerPrefs.SetInt("workerCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.workerCapacityLevel);
                isEnoughMoney();
                InitButtonValues();
                string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerCapacityUpgrade" + Globals.workerCapacityLevel.ToString() + "-REWARDED";
            GameManager.Instance.GameAnalyticsTag(tag);
        }
    }
    public void WorkerNoUpgradeFree()
    {
        if (Globals.workerNoLevel < _characterUpgradeSettings.workerNo.Length - 1)
        {

            int rebuyAmount = 0;
            Globals.workerNoLevel++;
            PlayerPrefs.SetInt("workerNoLevel" + PlayerPrefs.GetInt("level"), Globals.workerNoLevel);
            isEnoughMoney();
            InitButtonValues();
            WorkerCreate();


            string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-BuyWorker" + Globals.workerNoLevel.ToString() + "-REWARDED";
            GameManager.Instance.GameAnalyticsTag(tag);
        }
    }


}
