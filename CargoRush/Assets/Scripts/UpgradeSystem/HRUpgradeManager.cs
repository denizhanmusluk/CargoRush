using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using HomaGames.HomaBelly;

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
        IsEnoughMoney();
        InitButtonValues();

        if (PlayerPrefs.GetInt("upgradebuttonopen") == 1)
        {
            upgradeButton.SetActive(true);
        }

    }
    public void InitButtonValues()
    {
        if (Globals.workerMoveSpeedLevel < _characterUpgradeSettings.workerMoveSpeed.Length - 1)
        {
            button_Speed.TextInit(Globals.workerMoveSpeedLevel, _characterUpgradeSettings.workerMoveSpeedCost[Globals.workerMoveSpeedLevel + 1]);
            button_Speed.UpgradeValueTextInit(_characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel], _characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel + 1]);
            button_Speed.ButtonLevel(Globals.workerMoveSpeedLevel, _characterUpgradeSettings.workerMoveSpeed.Length - 1);

        }
        else
        {
            button_Speed.FullLevel();
            button_Speed.UpgradeValueFull(_characterUpgradeSettings.workerMoveSpeed[Globals.workerMoveSpeedLevel]);
            button_Speed.ButtonLevel(Globals.workerMoveSpeedLevel, _characterUpgradeSettings.workerMoveSpeed.Length - 1);
        }


        if (Globals.workerNoLevel < _characterUpgradeSettings.workerNo.Length - 1)
        {
            button_WorkerNo.TextInit(Globals.workerNoLevel, _characterUpgradeSettings.workerNoCost[Globals.workerNoLevel + 1]);
            button_WorkerNo.UpgradeValueTextInit(_characterUpgradeSettings.workerNo[Globals.workerNoLevel], _characterUpgradeSettings.workerNo[Globals.workerNoLevel + 1]);
            button_WorkerNo.ButtonLevel(Globals.workerNoLevel, _characterUpgradeSettings.workerNo.Length - 1);

        }
        else
        {
            button_WorkerNo.FullLevel();
            button_WorkerNo.UpgradeValueFull(_characterUpgradeSettings.workerNo[Globals.workerNoLevel]);
            button_WorkerNo.ButtonLevel(Globals.workerNoLevel, _characterUpgradeSettings.workerNo.Length - 1);
        }


        if (Globals.workerCapacityLevel < _characterUpgradeSettings.workerCapacity.Length - 1)
        {
            button_Capacity.TextInit(Globals.workerCapacityLevel, _characterUpgradeSettings.workerCapacityCost[Globals.workerCapacityLevel + 1]);
            button_Capacity.UpgradeValueTextInit(_characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel], _characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel + 1]);
            button_Capacity.ButtonLevel(Globals.workerCapacityLevel, _characterUpgradeSettings.workerCapacity.Length - 1);
        }
        else
        {
            button_Capacity.FullLevel();
            button_Capacity.UpgradeValueFull(_characterUpgradeSettings.workerCapacity[Globals.workerCapacityLevel]);
            button_Capacity.ButtonLevel(Globals.workerCapacityLevel, _characterUpgradeSettings.workerCapacity.Length - 1);
        }
        VibratoManager.Instance.MediumVibration();
    }
    public void WorkerMoveSpeedUpgradeButton()
    {
        if (Globals.workerMoveSpeedLevel < _characterUpgradeSettings.workerMoveSpeed.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.workerMoveSpeedCost[Globals.workerMoveSpeedLevel + 1])
            {
                int workerMoveSpeedCost = _characterUpgradeSettings.workerMoveSpeedCost[Globals.workerMoveSpeedLevel + 1];
                GameManager.Instance.MoneyUpdate(-workerMoveSpeedCost);
                Globals.workerMoveSpeedLevel++;
                PlayerPrefs.SetInt("workerMoveSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.workerMoveSpeedLevel);
                PlayerController.Instance.magnet.MagnetLevelUp();

                //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerSpeedUpgrade" + Globals.workerMoveSpeedLevel.ToString();
                //GameManager.Instance.GameAnalyticsTag(tag);

                //GameManager.Instance.HomaAnalyticsTag("CharacterCapacityUpgrade");

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " WorkerSpeedUpgrade", Globals.workerMoveSpeedLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)workerMoveSpeedCost, (float)Globals.moneyAmount, Globals.workerMoveSpeedLevel.ToString(), "WorkerSpeedUpgrade", ResourceFlowReason.Progression);


                //PlayerBehaviour.Instance.playerController.CharacterUpgrade(Globals.holeRadiusLevel);
                IsEnoughMoney();
                InitButtonValues();

                AllWorkerMoveSpeedInit();

                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
                //PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                //PlayerController.Instance.UpgradeTextSpawn("+Magnet");
            }
        }
    }
    public void AllWorkerMoveSpeedInit()
    {
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

    public void WorkerCapacityUpgradeButton()
    {
        if (Globals.workerCapacityLevel < _characterUpgradeSettings.workerCapacity.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.workerCapacityCost[Globals.workerCapacityLevel + 1])
            {
                int workerCapacityCost = _characterUpgradeSettings.workerCapacityCost[Globals.workerCapacityLevel + 1];
                GameManager.Instance.MoneyUpdate(-workerCapacityCost);
                Globals.workerCapacityLevel++;
                PlayerPrefs.SetInt("workerCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.workerCapacityLevel);
                IsEnoughMoney();
                InitButtonValues();
                //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerCapacityUpgrade" + Globals.workerCapacityLevel.ToString();
                //GameManager.Instance.GameAnalyticsTag(tag);


                //GameManager.Instance.HomaAnalyticsTag("WorkerCapacityUpgrade");
                int levelId = (PlayerPrefs.GetInt("level") + 1);
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + levelId.ToString() + " WorkerCapacityUpgrade", Globals.workerCapacityLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)workerCapacityCost, (float)Globals.moneyAmount, Globals.workerCapacityLevel.ToString(), "WorkerCapacityUpgrade", ResourceFlowReason.Progression);


                //PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                //PlayerController.Instance.UpgradeTextSpawn("+Speed");
                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }
    public void WorkerNoUpgradeButton()
    {
        if (Globals.workerNoLevel < _characterUpgradeSettings.workerNo.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.workerNoCost[Globals.workerNoLevel + 1])
            {
                if (Globals.workerNoLevel == 0)
                {
                    IndicatorManager.Instance.TutorialStepCompleted();
                }
                PlayerPrefs.SetInt("upgradetutorial", 1);

                if (PlayerPrefs.GetInt("upgradeadvbutton") == 0)
                {
                    PlayerPrefs.SetInt("upgradeadvbutton", 1);
                }
                int rebuyAmount = 0;

                //if (_upgradeAreaWorkers.workerBuyAreaList[PlayerPrefs.GetInt("workerNoLevel")].gameObject.activeInHierarchy)
                //{
                //    rebuyAmount = _upgradeAreaWorkers.workerBuyAreaList[PlayerPrefs.GetInt("workerNoLevel")].cost - _upgradeAreaWorkers.workerBuyAreaList[PlayerPrefs.GetInt("workerNoLevel")].currentAmount;
                //}
                int workerCost = _characterUpgradeSettings.workerNoCost[Globals.workerNoLevel + 1];
                GameManager.Instance.MoneyUpdate(-workerCost);
                Globals.workerNoLevel++;
                PlayerPrefs.SetInt("workerNoLevel" + PlayerPrefs.GetInt("level"), Globals.workerNoLevel);
                IsEnoughMoney();
                InitButtonValues();
                CharacterUpgradeManager.Instance.InitButtonValues();
                WorkerCreate();

                //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-BuyWorker" + Globals.workerNoLevel.ToString() + "-REWARDED";
                //GameManager.Instance.GameAnalyticsTag(tag);


                //GameManager.Instance.HomaAnalyticsTag("BuyWorker");

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " BuyWorker", Globals.workerNoLevel, ItemFlowReason.Progression);
                Analytics.ItemObtained(" BuyWorker", Globals.workerNoLevel, ItemFlowReason.Progression);

                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)workerCost, (float)Globals.moneyAmount, Globals.workerNoLevel.ToString(), "BuyWorker", ResourceFlowReason.Progression);

                //HRWorkerGO.SetActive(false);

                //PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                //PlayerController.Instance.UpgradeTextSpawn("+Capacity");
                AudioManager.Instance.UpgradeSound();

                if (Globals.workerNoLevel == 1 && PlayerPrefs.GetInt("level") == 0)
                {
                    exitTapTutorial_GO.SetActive(true);
                }

                if (QuestManager.Instance.buyWorkerQuest != null)
                {
                    QuestManager.Instance.buyWorkerQuest.QuestUpdate(1);
                }
            }

        }

    }
    public void IsEnoughMoney()
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
        IsEnoughMoney();
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

        if(PlayerPrefs.GetInt("firstclickupgradebutton") == 0)
        {
            PlayerPrefs.SetInt("firstclickupgradebutton", 1);
            IndicatorManager.Instance.TutorialStepCompleted();
            IndicatorManager.Instance.TutorialStepStart(22);
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
            //IndicatorManager.Instance.KeepCollectTutorial();


            StartCoroutine(AdvButtonActivator());
        }
    }
    IEnumerator AdvButtonActivator()
    {
        yield return new WaitForSeconds(1f);
        if (PlayerPrefs.GetInt("upgradeadvbutton") == 1)
        {
            PlayerPrefs.SetInt("upgradeadvbutton", 2);
            button_Speed.ADVButtonOpen();
            button_Capacity.ADVButtonOpen();
            button_WorkerNo.ADVButtonOpen();
            CharacterUpgradeManager.Instance.button_CharacterSpeedLevel.ADVButtonOpen();
            CharacterUpgradeManager.Instance.button_StackCapacityLevel.ADVButtonOpen();

            MRCUpgradeManager.Instance.button_machineSpeedLevel.ADVButtonOpen();
            MRCUpgradeManager.Instance.button_errorFreqLevel.ADVButtonOpen();
            MRCUpgradeManager.Instance.button_customerEarningLevel.ADVButtonOpen();
            MRCUpgradeManager.Instance.button_customerCooldownLevel.ADVButtonOpen();
            MRCUpgradeManager.Instance.button_repairRunTimeLevel.ADVButtonOpen();
            MRCUpgradeManager.Instance.button_repairSpeedLevel.ADVButtonOpen();
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
        string adv_name = "WorkerSpeedUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(WorkerMoveSpeedUpgradeFree, adv_name, true);

    }
    public void WorkerCapacityUpgrade_ADV_Click()
    {
        string adv_name = "WorkerCapacityUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(WorkerCapacityUpgradeFree, adv_name, true);
    }
    public void WorkerNoUpgrade_ADV_Click()
    {
        string adv_name = "BuyWorker_REWARDED";
        ADVManager.Instance.RewardedStart(WorkerNoUpgradeFree, adv_name, true);
    }









    public void WorkerMoveSpeedUpgradeFree(bool ticketActive)
    {
        if (Globals.workerMoveSpeedLevel < _characterUpgradeSettings.workerMoveSpeed.Length - 1)
        {
            Globals.workerMoveSpeedLevel++;
            PlayerPrefs.SetInt("workerMoveSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.workerMoveSpeedLevel);
            PlayerController.Instance.magnet.MagnetLevelUp();

            //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerSpeedUpgrade" + Globals.workerMoveSpeedLevel.ToString() + "-REWARDED";
            //GameManager.Instance.GameAnalyticsTag(tag);


            //GameManager.Instance.HomaAnalyticsTag("WorkerSpeedUpgrade");


            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " WorkerSpeedUpgrade", Globals.workerMoveSpeedLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " WorkerSpeedUpgrade", Globals.workerMoveSpeedLevel, ItemFlowReason.RewardedVideoAd);
            }


            IsEnoughMoney();
            InitButtonValues();
            AllWorkerMoveSpeedInit();


            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }

    public void WorkerCapacityUpgradeFree(bool ticketActive)
    {
        if (Globals.workerCapacityLevel < _characterUpgradeSettings.workerCapacity.Length - 1)
        {
                Globals.workerCapacityLevel++;
                PlayerPrefs.SetInt("workerCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.workerCapacityLevel);
                IsEnoughMoney();
                InitButtonValues();
            //    string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-WorkerCapacityUpgrade" + Globals.workerCapacityLevel.ToString() + "-REWARDED";
            //GameManager.Instance.GameAnalyticsTag(tag);


            //GameManager.Instance.HomaAnalyticsTag("WorkerCapacityUpgrade");

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " WorkerCapacityUpgrade", Globals.workerCapacityLevel, ItemFlowReason.Progression);

            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " WorkerCapacityUpgrade", Globals.workerCapacityLevel, ItemFlowReason.RewardedVideoAd);

            }

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }
    public void WorkerNoUpgradeFree(bool ticketActive)
    {
        if (Globals.workerNoLevel < _characterUpgradeSettings.workerNo.Length - 1)
        {
            int rebuyAmount = 0;
            Globals.workerNoLevel++;
            PlayerPrefs.SetInt("workerNoLevel" + PlayerPrefs.GetInt("level"), Globals.workerNoLevel);
            IsEnoughMoney();
            InitButtonValues();
            WorkerCreate();

            //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-BuyWorker" + Globals.workerNoLevel.ToString() + "-REWARDED";
            //GameManager.Instance.GameAnalyticsTag(tag);

            //GameManager.Instance.HomaAnalyticsTag("BuyWorker");


            string _tag = " BuyWorker";
            if (ticketActive)
            {
                Analytics.ItemObtained(_tag, Globals.workerNoLevel, ItemFlowReason.Progression);
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + _tag, Globals.workerNoLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemObtained(_tag, Globals.workerNoLevel, ItemFlowReason.RewardedVideoAd);
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + _tag, Globals.workerNoLevel, ItemFlowReason.RewardedVideoAd);

            }


            if (QuestManager.Instance.buyWorkerQuest != null)
            {
                QuestManager.Instance.buyWorkerQuest.QuestUpdate(1);
            }
        }
    }



    public void UpgradeButtonOpener()
    {
        PlayerPrefs.SetInt("upgradebuttonopen", 1);
        upgradeButton.SetActive(true);
        if (PlayerPrefs.GetInt("upgradeclicktutorial") == 0)
        {
            PlayerPrefs.SetInt("upgradeclicktutorial", 1);
            TutorialManager.Instance.clickUpgradeButtonGO.SetActive(true);
            PlayerController.Instance.PlayerControlDeActive();

            IndicatorManager.Instance.TutorialStepStart(21);
            UpgradePanel.Instance.OpenWorkerUpgradePanel();
        }
    }
}
