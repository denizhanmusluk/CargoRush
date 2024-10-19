//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using HomaGames.HomaBelly;
public class CharacterUpgradeManager : MonoBehaviour
{
    private static CharacterUpgradeManager _instance = null;
    public static CharacterUpgradeManager Instance => _instance;

    public CharacterUpgradeSettings _characterUpgradeSettings;
    public UpgradeButton button_CharacterSpeedLevel, button_StackCapacityLevel;
    public GameObject characterUpgradePanel;
    public UpgradeAreaCharacter _upgradeAreaCharacter;
    private void Awake()
    {
        _instance = this;
        Globals.magnetRadiusLevel = PlayerPrefs.GetInt("magnetRadiusLevel" + PlayerPrefs.GetInt("level"));
        Globals.characterSpeedLevel = PlayerPrefs.GetInt("characterSpeedLevel" + PlayerPrefs.GetInt("level"));
        Globals.stackCapacityLevel = PlayerPrefs.GetInt("stackCapacityLevel" + PlayerPrefs.GetInt("level"));
    }
    private void Start()
    {
        _characterUpgradeSettings = LevelManager.Instance._currnetCharacterUpgradeSettings;
        IsEnoughMoney();
        InitButtonValues();
    }
    public void InitButtonValues()
    {
        //if (Globals.magnetRadiusLevel < _characterUpgradeSettings.magnetRadius.Length - 1)
        //{
        //    button_MagnetRadiusLevel.TextInit(Globals.magnetRadiusLevel, _characterUpgradeSettings.magnetRadiusCost[Globals.magnetRadiusLevel + 1]);
        //    button_MagnetRadiusLevel.UpgradeValueTextInit(_characterUpgradeSettings.magnetRadius[Globals.magnetRadiusLevel], _characterUpgradeSettings.magnetRadius[Globals.magnetRadiusLevel + 1]);
        //}
        //else
        //{
        //    button_MagnetRadiusLevel.FullLevel();
        //    button_MagnetRadiusLevel.UpgradeValueFull(_characterUpgradeSettings.magnetRadius[Globals.magnetRadiusLevel]);
        //}


        if (Globals.stackCapacityLevel < _characterUpgradeSettings.stackCapacity.Length - 1)
        {
            button_StackCapacityLevel.TextInit(Globals.stackCapacityLevel, _characterUpgradeSettings.stackCapacityCost[Globals.stackCapacityLevel + 1]);
            button_StackCapacityLevel.UpgradeValueTextInit(_characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel], _characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel + 1]);
            button_StackCapacityLevel.ButtonLevel(Globals.stackCapacityLevel, _characterUpgradeSettings.stackCapacity.Length - 1);
        }
        else
        {
            button_StackCapacityLevel.FullLevel();
            button_StackCapacityLevel.UpgradeValueFull(_characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel]);
            button_StackCapacityLevel.ButtonLevel(Globals.stackCapacityLevel , _characterUpgradeSettings.stackCapacity.Length - 1);
        }


        if (Globals.characterSpeedLevel < _characterUpgradeSettings.characterSpeed.Length - 1)
        {
            button_CharacterSpeedLevel.TextInit(Globals.characterSpeedLevel, _characterUpgradeSettings.characterSpeedCost[Globals.characterSpeedLevel + 1]);
            button_CharacterSpeedLevel.UpgradeValueTextInit(_characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel], _characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel + 1]);
            button_CharacterSpeedLevel.ButtonLevel(Globals.characterSpeedLevel, _characterUpgradeSettings.characterSpeed.Length - 1);

        }
        else
        {
            button_CharacterSpeedLevel.FullLevel();
            button_CharacterSpeedLevel.UpgradeValueFull(_characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel]);
            button_CharacterSpeedLevel.ButtonLevel(Globals.characterSpeedLevel, _characterUpgradeSettings.characterSpeed.Length - 1);
        }
        VibratoManager.Instance.MediumVibration();
    }
    //public void MagnetRadiusUpgradeButton()
    //{
    //    if (Globals.magnetRadiusLevel < _characterUpgradeSettings.magnetRadius.Length - 1)
    //    {
    //        if (Globals.moneyAmount >= _characterUpgradeSettings.magnetRadiusCost[Globals.magnetRadiusLevel + 1])
    //        {
    //            GameManager.Instance.MoneyUpdate(-_characterUpgradeSettings.magnetRadiusCost[Globals.magnetRadiusLevel + 1]);
    //            Globals.magnetRadiusLevel++;
    //            PlayerPrefs.SetInt("magnetRadiusLevel", Globals.magnetRadiusLevel);
    //            PlayerController.Instance.magnet.MagnetLevelUp();
    //            //PlayerBehaviour.Instance.playerController.CharacterUpgrade(Globals.holeRadiusLevel);
    //            isEnoughMoney();
    //            InitButtonValues();
    //            PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform,0.8f, 1f, 0.5f, Ease.OutElastic);
    //            PlayerController.Instance.UpgradeTextSpawn("+Magnet");
    //        }
    //    }
    //}

    public void MoveSpeedUpgradeButton()
    {
        if (Globals.characterSpeedLevel < _characterUpgradeSettings.characterSpeed.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.characterSpeedCost[Globals.characterSpeedLevel + 1])
            {
                int characterMoveSpeedCost = _characterUpgradeSettings.characterSpeedCost[Globals.characterSpeedLevel + 1];
                GameManager.Instance.MoneyUpdate(-characterMoveSpeedCost);
                Globals.characterSpeedLevel++;
                PlayerPrefs.SetInt("characterSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.characterSpeedLevel);
                IsEnoughMoney();
                InitButtonValues();
                PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                PlayerController.Instance.UpgradeTextSpawn("+Speed");


                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CharacterSpeedUpgrade", Globals.characterSpeedLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)characterMoveSpeedCost, (float)Globals.moneyAmount, Globals.characterSpeedLevel.ToString(), "CharacterSpeedUpgrade", ResourceFlowReason.Progression);


                AudioManager.Instance.UpgradeSound();

                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }
        }
    }
    public void StackCapacityUpgradeButton()
    {
        if (Globals.stackCapacityLevel < _characterUpgradeSettings.stackCapacity.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.stackCapacityCost[Globals.stackCapacityLevel + 1])
            {
                int characterStackCapacityCost = _characterUpgradeSettings.stackCapacityCost[Globals.stackCapacityLevel + 1];
                GameManager.Instance.MoneyUpdate(-characterStackCapacityCost);
                Globals.stackCapacityLevel++;
                PlayerPrefs.SetInt("stackCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.stackCapacityLevel);
                IsEnoughMoney();
                InitButtonValues();
                PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                PlayerController.Instance.UpgradeTextSpawn("+Capacity");

                //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-CharacterCapacityUpgrade" + Globals.stackCapacityLevel.ToString();
                //GameManager.Instance.GameAnalyticsTag(tag);


                //GameManager.Instance.HomaAnalyticsTag("CharacterCapacityUpgrade");

                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CharacterCapacityUpgrade", Globals.stackCapacityLevel, ItemFlowReason.Progression);
                Analytics.ResourceFlowEvent(ResourceFlowType.Sink, "Money", (float)characterStackCapacityCost, (float)Globals.moneyAmount, Globals.stackCapacityLevel.ToString(), "CharacterCapacityUpgrade", ResourceFlowReason.Progression);

                float time = CoefficientTransformation.FormatSaniye(Globals.speedPlayTime);
                //GameAnalytics.NewDesignEvent(tag, time);
                AudioManager.Instance.UpgradeSound();
                if (QuestManager.Instance.upgradeQuest != null)
                {
                    QuestManager.Instance.upgradeQuest.QuestUpdate(1);
                }
            }

        }

    }
    public void IsEnoughMoney()
    {
        //if (Globals.magnetRadiusLevel < _characterUpgradeSettings.magnetRadius.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.magnetRadiusCost[Globals.magnetRadiusLevel + 1])
        //{
        //    button_MagnetRadiusLevel.moneyButton.interactable = true;
        //}
        //else
        //{
        //    button_MagnetRadiusLevel.moneyButton.interactable = false;
        //}


        if (Globals.stackCapacityLevel < _characterUpgradeSettings.stackCapacity.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.stackCapacityCost[Globals.stackCapacityLevel + 1])
        {
            button_StackCapacityLevel.moneyButton.interactable = true;
        }
        else
        {
            button_StackCapacityLevel.moneyButton.interactable = false;
        }

        if (Globals.characterSpeedLevel < _characterUpgradeSettings.characterSpeed.Length - 1 && Globals.moneyAmount >= _characterUpgradeSettings.characterSpeedCost[Globals.characterSpeedLevel + 1])
        {
            button_CharacterSpeedLevel.moneyButton.interactable = true;
        }
        else
        {
            button_CharacterSpeedLevel.moneyButton.interactable = false;
        }
    }
    public void CharacterUpgradeClose()
    {
        _upgradeAreaCharacter.CharacterUpgradeClose();
    }


    public void MoveSpeedUpgrade_ADV_Click()
    {
        string adv_name = "CharacterSpeedUpgradeREWARDED";
        ADVManager.Instance.RewardedStart(MoveSpeedUpgradeFree, adv_name , true);
    }
    public void StackCapacityUpgrade_ADV_Click()
    {
        string adv_name = "CharacterCapacityUpgradeREWARDED";
        ADVManager.Instance.RewardedStart(StackCapacityUpgradeFree, adv_name , true);
    }
    public void MoveSpeedUpgradeFree(bool ticketActive)
    {
        if (Globals.characterSpeedLevel < _characterUpgradeSettings.characterSpeed.Length - 1)
        {
            
                Globals.characterSpeedLevel++;
                PlayerPrefs.SetInt("characterSpeedLevel" + PlayerPrefs.GetInt("level"), Globals.characterSpeedLevel);
                IsEnoughMoney();
                InitButtonValues();
                PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                PlayerController.Instance.UpgradeTextSpawn("+Speed");

            //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-CharacterSpeedUpgrade" + Globals.characterSpeedLevel.ToString() + "-REWARDED";
            //GameManager.Instance.GameAnalyticsTag(tag);


            //GameManager.Instance.HomaAnalyticsTag("CharacterSpeedUpgrade");
            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CharacterSpeedUpgrade", Globals.characterSpeedLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CharacterSpeedUpgrade", Globals.characterSpeedLevel, ItemFlowReason.RewardedVideoAd);
            }


            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }
   public void StackCapacityUpgradeFree(bool ticketActive)
    {
        if (Globals.stackCapacityLevel < _characterUpgradeSettings.stackCapacity.Length - 1)
        {
            Globals.stackCapacityLevel++;
            PlayerPrefs.SetInt("stackCapacityLevel" + PlayerPrefs.GetInt("level"), Globals.stackCapacityLevel);
            IsEnoughMoney();
            InitButtonValues();
            PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
            PlayerController.Instance.UpgradeTextSpawn("+Capacity");

            //string tag = "M" + (PlayerPrefs.GetInt("level") + 1).ToString() + "-CharacterCapacityUpgrade" + Globals.stackCapacityLevel.ToString() + "-REWARDED";
            //GameManager.Instance.GameAnalyticsTag(tag);


            //GameManager.Instance.HomaAnalyticsTag("CharacterCapacityUpgrade");
            if (ticketActive)
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CharacterCapacityUpgrade", Globals.stackCapacityLevel, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemUpgraded(ItemUpgradeType.Upgrade, "Zone " + (PlayerPrefs.GetInt("level") + 1) + " CharacterCapacityUpgrade", Globals.stackCapacityLevel, ItemFlowReason.RewardedVideoAd);
            }


            if (QuestManager.Instance.upgradeQuest != null)
            {
                QuestManager.Instance.upgradeQuest.QuestUpdate(1);
            }
        }
    }
}
