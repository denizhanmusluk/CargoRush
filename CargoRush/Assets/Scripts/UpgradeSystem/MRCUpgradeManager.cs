using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using HomaGames.HomaBelly;

public class MRCUpgradeManager : MonoBehaviour
{
    private static MRCUpgradeManager _instance = null;
    public static MRCUpgradeManager Instance => _instance;

    public CharacterUpgradeSettings _characterUpgradeSettings;
    public UpgradeButton button_machineSpeedLevel, button_errorFreqLevel, button_customerEarningLevel, button_customerCooldownLevel, button_repairRunTimeLevel, button_repairSpeedLevel;
    public UpgradeButton button_TrainCapacity, button_TrainSpeed;
    private void Awake()
    {
        _instance = this;

        Globals.machineSpeedLevel = PlayerPrefs.GetInt("machineSpeedLevel" + PlayerPrefs.GetInt("level"));
        Globals.machineErrorFrequencyLevel = PlayerPrefs.GetInt("machineErrorFrequencyLevel" + PlayerPrefs.GetInt("level"));
        Globals.customerEarningLevel = PlayerPrefs.GetInt("customerEarningLevel" + PlayerPrefs.GetInt("level"));
        Globals.customerCooldownLevel = PlayerPrefs.GetInt("customerCooldownLevel" + PlayerPrefs.GetInt("level"));
        Globals.repairRunTimeLevel = PlayerPrefs.GetInt("repairRunTimeLevel" + PlayerPrefs.GetInt("level"));
        Globals.repairSpeedLevel = PlayerPrefs.GetInt("repairSpeedLevel" + PlayerPrefs.GetInt("level"));


        Globals.trainCapacityLevel = PlayerPrefs.GetInt("trainCapacityLevel" + PlayerPrefs.GetInt("level"));
        Globals.trainSpeedLevel = PlayerPrefs.GetInt("trainSpeedLevel" + PlayerPrefs.GetInt("level"));
    }
    private void Start()
    {
        _characterUpgradeSettings = LevelManager.Instance._currnetCharacterUpgradeSettings;
        IsEnoughMoney();
        InitButtonValues();
    }
    public void InitButtonValues()
    {
        if (Globals.machineSpeedLevel < _characterUpgradeSettings.machineSpeed.Length - 1)
        {
            button_machineSpeedLevel.TextInit(Globals.machineSpeedLevel, _characterUpgradeSettings.machineSpeedCost[Globals.machineSpeedLevel + 1]);
            button_machineSpeedLevel.UpgradeValueTextInit(_characterUpgradeSettings.machineSpeed[Globals.machineSpeedLevel], _characterUpgradeSettings.machineSpeed[Globals.machineSpeedLevel + 1]);
            button_machineSpeedLevel.ButtonLevel(Globals.machineSpeedLevel, _characterUpgradeSettings.machineSpeed.Length - 1);
        }
        else
        {
            button_machineSpeedLevel.FullLevel();
            button_machineSpeedLevel.UpgradeValueFull(_characterUpgradeSettings.machineSpeed[Globals.machineSpeedLevel]);
            button_machineSpeedLevel.ButtonLevel(Globals.machineSpeedLevel, _characterUpgradeSettings.machineSpeed.Length - 1);
        }


        if (Globals.machineErrorFrequencyLevel < _characterUpgradeSettings.machineErrorBoxCount.Length - 1)
        {
            button_errorFreqLevel.TextInit(Globals.machineErrorFrequencyLevel, _characterUpgradeSettings.machineSpeedCost[Globals.machineErrorFrequencyLevel + 1]);
            button_errorFreqLevel.UpgradeValueTextInit(_characterUpgradeSettings.machineErrorBoxCount[Globals.machineErrorFrequencyLevel], _characterUpgradeSettings.machineErrorBoxCount[Globals.machineErrorFrequencyLevel + 1]);
            button_errorFreqLevel.ButtonLevel(Globals.machineErrorFrequencyLevel, _characterUpgradeSettings.machineErrorBoxCount.Length - 1);
        }
        else
        {
            button_errorFreqLevel.FullLevel();
            button_errorFreqLevel.UpgradeValueFull(_characterUpgradeSettings.machineErrorBoxCount[Globals.machineErrorFrequencyLevel]);
            button_errorFreqLevel.ButtonLevel(Globals.machineErrorFrequencyLevel, _characterUpgradeSettings.machineErrorBoxCount.Length - 1);
        }


        if (Globals.customerEarningLevel < _characterUpgradeSettings.customerEarning.Length - 1)
        {
            button_customerEarningLevel.TextInit(Globals.customerEarningLevel, _characterUpgradeSettings.customerEarningCost[Globals.customerEarningLevel + 1]);
            button_customerEarningLevel.UpgradeValueTextInit(_characterUpgradeSettings.customerEarning[Globals.customerEarningLevel], _characterUpgradeSettings.customerEarning[Globals.customerEarningLevel + 1]);
            button_customerEarningLevel.ButtonLevel(Globals.customerEarningLevel, _characterUpgradeSettings.customerEarning.Length - 1);
        }
        else
        {
            button_customerEarningLevel.FullLevel();
            button_customerEarningLevel.UpgradeValueFull(_characterUpgradeSettings.customerEarning[Globals.customerEarningLevel]);
            button_customerEarningLevel.ButtonLevel(Globals.customerEarningLevel, _characterUpgradeSettings.customerEarning.Length - 1);
        }



        if (Globals.customerCooldownLevel < _characterUpgradeSettings.customerCooldown.Length - 1)
        {
            button_customerCooldownLevel.TextInit(Globals.customerCooldownLevel, _characterUpgradeSettings.customerCooldownCost[Globals.customerCooldownLevel + 1]);
            button_customerCooldownLevel.UpgradeValueTextInit(_characterUpgradeSettings.customerCooldown[Globals.customerCooldownLevel], _characterUpgradeSettings.customerCooldown[Globals.customerCooldownLevel + 1]);
            button_customerCooldownLevel.ButtonLevel(Globals.customerCooldownLevel, _characterUpgradeSettings.customerCooldown.Length - 1);
        }
        else
        {
            button_customerCooldownLevel.FullLevel();
            button_customerCooldownLevel.UpgradeValueFull(_characterUpgradeSettings.customerCooldown[Globals.customerCooldownLevel]);
            button_customerCooldownLevel.ButtonLevel(Globals.customerCooldownLevel, _characterUpgradeSettings.customerCooldown.Length - 1);
        }



        if (Globals.repairRunTimeLevel < _characterUpgradeSettings.repairRunTime.Length - 1)
        {
            button_repairRunTimeLevel.TextInit(Globals.repairRunTimeLevel, _characterUpgradeSettings.repairRunTimeCost[Globals.repairRunTimeLevel + 1]);
            button_repairRunTimeLevel.UpgradeValueTextInit(_characterUpgradeSettings.repairRunTime[Globals.repairRunTimeLevel], _characterUpgradeSettings.repairRunTime[Globals.repairRunTimeLevel + 1]);
            button_repairRunTimeLevel.ButtonLevel(Globals.repairRunTimeLevel, _characterUpgradeSettings.repairRunTime.Length - 1);
        }
        else
        {
            button_repairRunTimeLevel.FullLevel();
            button_repairRunTimeLevel.UpgradeValueFull(_characterUpgradeSettings.repairRunTime[Globals.repairRunTimeLevel]);
            button_repairRunTimeLevel.ButtonLevel(Globals.repairRunTimeLevel, _characterUpgradeSettings.repairRunTime.Length - 1);
        }



        if (Globals.repairSpeedLevel < _characterUpgradeSettings.repairSpeed.Length - 1)
        {
            button_repairSpeedLevel.TextInit(Globals.repairSpeedLevel, _characterUpgradeSettings.repairSpeedCost[Globals.repairSpeedLevel + 1]);
            button_repairSpeedLevel.UpgradeValueTextInit(_characterUpgradeSettings.repairSpeed[Globals.repairSpeedLevel], _characterUpgradeSettings.repairSpeed[Globals.repairSpeedLevel + 1]);
            button_repairSpeedLevel.ButtonLevel(Globals.repairSpeedLevel, _characterUpgradeSettings.repairSpeed.Length - 1);
        }
        else
        {
            button_repairSpeedLevel.FullLevel();
            button_repairSpeedLevel.UpgradeValueFull(_characterUpgradeSettings.repairSpeed[Globals.repairSpeedLevel]);
            button_repairSpeedLevel.ButtonLevel(Globals.repairSpeedLevel, _characterUpgradeSettings.repairSpeed.Length - 1);
        }


        if (Globals.trainCapacityLevel < _characterUpgradeSettings.trainCapacity.Length - 1)
        {
            button_TrainCapacity.TextInit(Globals.trainCapacityLevel, _characterUpgradeSettings.repairSpeedCost[Globals.trainCapacityLevel + 1]);
            button_TrainCapacity.UpgradeValueTextInit(_characterUpgradeSettings.trainCapacity[Globals.trainCapacityLevel], _characterUpgradeSettings.trainCapacity[Globals.trainCapacityLevel + 1]);
            button_TrainCapacity.ButtonLevel(Globals.trainCapacityLevel, _characterUpgradeSettings.trainCapacity.Length - 1);
        }
        else
        {
            button_TrainCapacity.FullLevel();
            button_TrainCapacity.UpgradeValueFull(_characterUpgradeSettings.trainCapacity[Globals.trainCapacityLevel]);
            button_TrainCapacity.ButtonLevel(Globals.trainCapacityLevel, _characterUpgradeSettings.trainCapacity.Length - 1);
        }

        if (Globals.trainSpeedLevel < _characterUpgradeSettings.trainSpeedFactor.Length - 1)
        {
            button_TrainSpeed.TextInit(Globals.trainSpeedLevel, _characterUpgradeSettings.trainSpeedFactorCost[Globals.trainSpeedLevel + 1]);
            button_TrainSpeed.UpgradeValueTextInit(_characterUpgradeSettings.trainSpeedFactor[Globals.trainSpeedLevel], _characterUpgradeSettings.trainSpeedFactor[Globals.trainSpeedLevel + 1]);
            button_TrainSpeed.ButtonLevel(Globals.trainSpeedLevel, _characterUpgradeSettings.trainSpeedFactor.Length - 1);
        }
        else
        {
            button_TrainSpeed.FullLevel();
            button_TrainSpeed.UpgradeValueFull(_characterUpgradeSettings.trainSpeedFactor[Globals.trainSpeedLevel]);
            button_TrainSpeed.ButtonLevel(Globals.trainSpeedLevel, _characterUpgradeSettings.trainSpeedFactor.Length - 1);
        }
        VibratoManager.Instance.MediumVibration();
    }
    public void IsEnoughMoney()
    {
        if (Globals.machineSpeedLevel < _characterUpgradeSettings.machineSpeed.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.machineSpeedCost[Globals.machineSpeedLevel + 1])
        {
            button_machineSpeedLevel.moneyButton.interactable = true;
        }
        else
        {
            button_machineSpeedLevel.moneyButton.interactable = false;
        }



        if (Globals.machineErrorFrequencyLevel < _characterUpgradeSettings.machineErrorBoxCount.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.machineErrorBoxCount_Cost[Globals.machineErrorFrequencyLevel + 1])
        {
            button_errorFreqLevel.moneyButton.interactable = true;
        }
        else
        {
            button_errorFreqLevel.moneyButton.interactable = false;
        }


        if (Globals.customerEarningLevel < _characterUpgradeSettings.customerEarning.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.customerEarningCost[Globals.customerEarningLevel + 1])
        {
            button_customerEarningLevel.moneyButton.interactable = true;
        }
        else
        {
            button_customerEarningLevel.moneyButton.interactable = false;
        }



        if (Globals.customerCooldownLevel < _characterUpgradeSettings.customerCooldown.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.customerCooldownCost[Globals.customerCooldownLevel + 1])
        {
            button_customerCooldownLevel.moneyButton.interactable = true;
        }
        else
        {
            button_customerCooldownLevel.moneyButton.interactable = false;
        }



        if (Globals.repairRunTimeLevel < _characterUpgradeSettings.repairRunTime.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.repairRunTimeCost[Globals.repairRunTimeLevel + 1])
        {
            button_repairRunTimeLevel.moneyButton.interactable = true;
        }
        else
        {
            button_repairRunTimeLevel.moneyButton.interactable = false;
        }



        if (Globals.repairSpeedLevel < _characterUpgradeSettings.repairSpeed.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.repairSpeedCost[Globals.repairSpeedLevel + 1])
        {
            button_repairSpeedLevel.moneyButton.interactable = true;
        }
        else
        {
            button_repairSpeedLevel.moneyButton.interactable = false;
        }



        if (Globals.trainCapacityLevel < _characterUpgradeSettings.trainCapacity.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.trainCapacityCost[Globals.trainCapacityLevel + 1])
        {
            button_TrainCapacity.moneyButton.interactable = true;
        }
        else
        {
            button_TrainCapacity.moneyButton.interactable = false;
        }

        if (Globals.trainSpeedLevel < _characterUpgradeSettings.trainSpeedFactor.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.trainSpeedFactorCost[Globals.trainSpeedLevel + 1])
        {
            button_TrainSpeed.moneyButton.interactable = true;
        }
        else
        {
            button_TrainSpeed.moneyButton.interactable = false;
        }
    }



    public void MachineSpeedUpgrade_Button()
    {
        if (Globals.machineSpeedLevel < _characterUpgradeSettings.machineSpeed.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.machineSpeedCost[Globals.machineSpeedLevel + 1])
            {
                int machineSpeedCost = _characterUpgradeSettings.machineSpeedCost[Globals.machineSpeedLevel + 1];
                GameManager.Instance.MoneyUpdate(-machineSpeedCost);
                Globals.machineSpeedLevel++;
                PlayerPrefs.SetInt("machineSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.machineSpeedLevel);
                IsEnoughMoney();
                InitButtonValues();
     
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " MachineSpeedUpgrade", Globals.machineSpeedLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)machineSpeedCost, (float)Globals.moneyAmount, Globals.machineSpeedLevel.ToString(), "MachineSpeedUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }
    public void MachineErrorFrequencyUpgrade_Button()
    {
        if (Globals.machineErrorFrequencyLevel < _characterUpgradeSettings.machineErrorBoxCount.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.machineErrorBoxCount_Cost[Globals.machineErrorFrequencyLevel + 1])
            {
                int machineErrorFreqCost = _characterUpgradeSettings.machineErrorBoxCount_Cost[Globals.machineErrorFrequencyLevel + 1];
                GameManager.Instance.MoneyUpdate(-machineErrorFreqCost);
                Globals.machineErrorFrequencyLevel++;
                PlayerPrefs.SetInt("machineErrorFrequencyLevel" + PlayerPrefs.GetInt("level"), Globals.machineErrorFrequencyLevel);
                IsEnoughMoney();
                InitButtonValues();

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " MachineDurabilityUpgrade", Globals.machineErrorFrequencyLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)machineErrorFreqCost, (float)Globals.moneyAmount, Globals.machineErrorFrequencyLevel.ToString(), "MachineDurabilityUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }

    public void CustomerEarningUpgrade_Button()
    {
        if (Globals.customerEarningLevel < _characterUpgradeSettings.customerEarning.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.customerEarningCost[Globals.customerEarningLevel + 1])
            {
                int customerEarningCost = _characterUpgradeSettings.customerEarningCost[Globals.customerEarningLevel + 1];
                GameManager.Instance.MoneyUpdate(-customerEarningCost);
                Globals.customerEarningLevel++;
                PlayerPrefs.SetInt("customerEarningLevel" + PlayerPrefs.GetInt("level"), Globals.customerEarningLevel);
                IsEnoughMoney();
                InitButtonValues();

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CustomerEarningUpgrade", Globals.customerEarningLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)customerEarningCost, (float)Globals.moneyAmount, Globals.customerEarningLevel.ToString(), "CustomerEarningUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }
    public void CustomerCooldownUpgrade_Button()
    {
        if (Globals.customerCooldownLevel < _characterUpgradeSettings.customerCooldown.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.customerCooldownCost[Globals.customerCooldownLevel + 1])
            {
                int customerCooldownCost = _characterUpgradeSettings.customerCooldownCost[Globals.customerCooldownLevel + 1];
                GameManager.Instance.MoneyUpdate(-customerCooldownCost);
                Globals.customerCooldownLevel++;
                PlayerPrefs.SetInt("customerCooldownLevel" + PlayerPrefs.GetInt("level"), Globals.customerCooldownLevel);
                IsEnoughMoney();
                InitButtonValues();

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CustomerCooldownUpgrade", Globals.customerCooldownLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)customerCooldownCost, (float)Globals.moneyAmount, Globals.customerCooldownLevel.ToString(), "CustomerCooldownUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }

    public void RepairRunTimeUpgrade_Button()
    {
        if (Globals.repairRunTimeLevel < _characterUpgradeSettings.repairRunTime.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.repairRunTimeCost[Globals.repairRunTimeLevel + 1])
            {
                int customerCooldownCost = _characterUpgradeSettings.repairRunTimeCost[Globals.repairRunTimeLevel + 1];
                GameManager.Instance.MoneyUpdate(-customerCooldownCost);
                Globals.repairRunTimeLevel++;
                PlayerPrefs.SetInt("repairRunTimeLevel" + PlayerPrefs.GetInt("level"), Globals.repairRunTimeLevel);
                IsEnoughMoney();
                InitButtonValues();

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " RepairRunTimeUpgrade", Globals.repairRunTimeLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)customerCooldownCost, (float)Globals.moneyAmount, Globals.repairRunTimeLevel.ToString(), "RepairRunTimeUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }
    public void RepairSpeedUpgrade_Button()
    {
        if (Globals.repairSpeedLevel < _characterUpgradeSettings.repairSpeed.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.repairSpeedCost[Globals.repairSpeedLevel + 1])
            {
                int repairSpeedCost = _characterUpgradeSettings.repairSpeedCost[Globals.repairSpeedLevel + 1];
                GameManager.Instance.MoneyUpdate(-repairSpeedCost);
                Globals.repairSpeedLevel++;
                PlayerPrefs.SetInt("repairSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.repairSpeedLevel);
                IsEnoughMoney();
                InitButtonValues();

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " RepairSpeedUpgrade", Globals.repairSpeedLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)repairSpeedCost, (float)Globals.moneyAmount, Globals.repairSpeedLevel.ToString(), "RepairSpeedUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }
    public void TrainCapacityUpgrade_Button()
    {
        if (Globals.trainCapacityLevel < _characterUpgradeSettings.trainCapacity.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.trainCapacityCost[Globals.trainCapacityLevel + 1])
            {
                int trainCapacityCost = _characterUpgradeSettings.trainCapacityCost[Globals.trainCapacityLevel + 1];
                GameManager.Instance.MoneyUpdate(-trainCapacityCost);
                Globals.trainCapacityLevel++;
                PlayerPrefs.SetInt("trainCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.trainCapacityLevel);
                IsEnoughMoney();
                InitButtonValues();

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " TrainCapacityUpgrade", Globals.trainCapacityLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)trainCapacityCost, (float)Globals.moneyAmount, Globals.trainCapacityLevel.ToString(), "TrainCapacityUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();
                PlayerController.Instance.OpenVagons();
                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }
    public void TrainSpeedUpgrade_Button()
    {
        if (Globals.trainSpeedLevel < _characterUpgradeSettings.trainSpeedFactor.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.trainSpeedFactorCost[Globals.trainSpeedLevel + 1])
            {
                int trainSpeedCost = _characterUpgradeSettings.trainSpeedFactorCost[Globals.trainSpeedLevel + 1];
                GameManager.Instance.MoneyUpdate(-trainSpeedCost);
                Globals.trainSpeedLevel++;
                PlayerPrefs.SetInt("trainSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.trainSpeedLevel);
                IsEnoughMoney();
                InitButtonValues();

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " TrainSpeedUpgrade", Globals.trainSpeedLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)trainSpeedCost, (float)Globals.moneyAmount, Globals.trainSpeedLevel.ToString(), "TrainSpeedUpgrade", ResourceFlowReason.Progression);

                AudioManager.Instance.UpgradeSound();
                PlayerController.Instance.OpenVagons();
                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }


    public void MachineSpeedUpgrade_ADV_Click()
    {
        string adv_name = "MachineSpeedUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(MachineSpeedUpgrade_FREE, adv_name, true);
    }
    public void MachineDurabilityUpgrade_ADV_Click()
    {
        string adv_name = "MachineDurabilityUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(MachineDurabilityUpgrade_FREE, adv_name, true);
    }
    public void CustomerEarningUpgrade_ADV_Click()
    {
        string adv_name = "CustomerEarningUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(CustomerEarningUpgrade_FREE, adv_name, true);
    }
    public void CustomerCooldownUpgrade_ADV_Click()
    {
        string adv_name = "CustomerCooldownUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(CustomerCooldownUpgrade_FREE, adv_name, true);
    }
    public void RepairRunTimeUpgrade_ADV_Click()
    {
        string adv_name = "RepairRunTimeUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(RepairRunTimeUpgrade_FREE, adv_name, true);
    }
    public void RepairSpeedUpgrade_ADV_Click()
    {
        string adv_name = "RepairSpeedUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(RepairSpeedUpgrade_FREE, adv_name, true);
    }

    public void TrainSpeedUpgrade_ADV_Click()
    {
        string adv_name = "TrainSpeedUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(TrainSpeedUpgrade_FREE, adv_name, true);
    }
    public void TrainCapacityUpgrade_ADV_Click()
    {
        string adv_name = "TrainCapacityUpgrade_REWARDED";
        ADVManager.Instance.RewardedStart(TrainCapacityUpgrade_FREE, adv_name, true);
    }
    public void MachineSpeedUpgrade_FREE(bool ticketActive)
    {
        if (Globals.machineSpeedLevel < _characterUpgradeSettings.machineSpeed.Length - 1)
        {
            int machineSpeedCost = _characterUpgradeSettings.machineSpeedCost[Globals.machineSpeedLevel + 1];
            Globals.machineSpeedLevel++;
            PlayerPrefs.SetInt("machineSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.machineSpeedLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " MachineSpeedUpgrade", Globals.machineSpeedLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " MachineSpeedUpgrade", Globals.machineSpeedLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }
    public void MachineDurabilityUpgrade_FREE(bool ticketActive)
    {
        if (Globals.machineErrorFrequencyLevel < _characterUpgradeSettings.machineErrorBoxCount.Length - 1)
        {
            int machineErrorFreqCost = _characterUpgradeSettings.machineErrorBoxCount_Cost[Globals.machineErrorFrequencyLevel + 1];
            Globals.machineErrorFrequencyLevel++;
            PlayerPrefs.SetInt("machineErrorFrequencyLevel" + PlayerPrefs.GetInt("level"), Globals.machineErrorFrequencyLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " MachineDurabilityUpgrade", Globals.machineErrorFrequencyLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " MachineDurabilityUpgrade", Globals.machineErrorFrequencyLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }


    public void CustomerEarningUpgrade_FREE(bool ticketActive)
    {
        if (Globals.customerEarningLevel < _characterUpgradeSettings.customerEarning.Length - 1)
        {
            int customerEarningCost = _characterUpgradeSettings.customerEarningCost[Globals.customerEarningLevel + 1];
            Globals.customerEarningLevel++;
            PlayerPrefs.SetInt("customerEarningLevel" + PlayerPrefs.GetInt("level"), Globals.customerEarningLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CustomerEarningUpgrade", Globals.customerEarningLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CustomerEarningUpgrade", Globals.customerEarningLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }
    public void CustomerCooldownUpgrade_FREE(bool ticketActive)
    {
        if (Globals.customerCooldownLevel < _characterUpgradeSettings.customerCooldown.Length - 1)
        {
            int customerCooldownCost = _characterUpgradeSettings.customerCooldownCost[Globals.customerCooldownLevel + 1];
            Globals.customerCooldownLevel++;
            PlayerPrefs.SetInt("customerCooldownLevel" + PlayerPrefs.GetInt("level"), Globals.customerCooldownLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CustomerCooldownUpgrade", Globals.customerCooldownLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CustomerCooldownUpgrade", Globals.customerCooldownLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }


    public void RepairRunTimeUpgrade_FREE(bool ticketActive)
    {
        if (Globals.repairRunTimeLevel < _characterUpgradeSettings.repairRunTime.Length - 1)
        {
            int customerCooldownCost = _characterUpgradeSettings.repairRunTimeCost[Globals.repairRunTimeLevel + 1];
            Globals.repairRunTimeLevel++;
            PlayerPrefs.SetInt("repairRunTimeLevel" + PlayerPrefs.GetInt("level"), Globals.repairRunTimeLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " RepairRunTimeUpgrade", Globals.repairRunTimeLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " RepairRunTimeUpgrade", Globals.repairRunTimeLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }
    public void RepairSpeedUpgrade_FREE(bool ticketActive)
    {
        if (Globals.repairSpeedLevel < _characterUpgradeSettings.repairSpeed.Length - 1)
        {
            int repairSpeedCost = _characterUpgradeSettings.repairSpeedCost[Globals.repairSpeedLevel + 1];
            Globals.repairSpeedLevel++;
            PlayerPrefs.SetInt("repairSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.repairSpeedLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " RepairSpeedUpgrade", Globals.repairSpeedLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " RepairSpeedUpgrade", Globals.repairSpeedLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }

    public void TrainSpeedUpgrade_FREE(bool ticketActive)
    {
        if (Globals.trainSpeedLevel < _characterUpgradeSettings.trainSpeedFactor.Length - 1)
        {
            int trainSpeedCost = _characterUpgradeSettings.trainSpeedFactorCost[Globals.trainSpeedLevel + 1];
            Globals.trainSpeedLevel++;
            PlayerPrefs.SetInt("trainSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.trainSpeedLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " TrainSpeedUpgrade", Globals.trainSpeedLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " TrainSpeedUpgrade", Globals.trainSpeedLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }

    public void TrainCapacityUpgrade_FREE(bool ticketActive)
    {
        if (Globals.trainCapacityLevel < _characterUpgradeSettings.trainCapacity.Length - 1)
        {
            int trainCapacityCost = _characterUpgradeSettings.trainCapacityCost[Globals.trainCapacityLevel + 1];
            Globals.trainCapacityLevel++;
            PlayerPrefs.SetInt("trainCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.trainCapacityLevel);
            IsEnoughMoney();
            InitButtonValues();

            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " TrainCapacityUpgrade", Globals.trainCapacityLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " TrainCapacityUpgrade", Globals.trainCapacityLevel, ItemFlowReason.RewardedVideoAd);
            }

            AudioManager.Instance.UpgradeSound();

            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }
}
