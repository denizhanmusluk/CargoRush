//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class CharacterUpgradeManager : MonoBehaviour
{
    private static CharacterUpgradeManager _instance = null;
    public static CharacterUpgradeManager Instance => _instance;

    [SerializeField] CharacterUpgradeSettings _characterUpgradeSettings;
    [SerializeField] UpgradeButton button_CharacterSpeedLevel, button_StackCapacityLevel;
    public GameObject characterUpgradePanel;
    public UpgradeAreaCharacter _upgradeAreaCharacter;
    private void Awake()
    {
        _instance = this;
        Globals.magnetRadiusLevel = PlayerPrefs.GetInt("magnetRadiusLevel");
        Globals.characterSpeedLevel = PlayerPrefs.GetInt("characterSpeedLevel");
        Globals.stackCapacityLevel = PlayerPrefs.GetInt("stackCapacityLevel");
    }
    private void Start()
    {
        isEnoughMoney();
        InitButtonValues();
    }
    void InitButtonValues()
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
            button_StackCapacityLevel.ButtonLevel(Globals.stackCapacityLevel);
        }
        else
        {
            button_StackCapacityLevel.FullLevel();
            button_StackCapacityLevel.UpgradeValueFull(_characterUpgradeSettings.stackCapacity[Globals.stackCapacityLevel]);
            button_StackCapacityLevel.ButtonLevel(Globals.stackCapacityLevel);
        }


        if (Globals.characterSpeedLevel < _characterUpgradeSettings.characterSpeed.Length - 1)
        {
            button_CharacterSpeedLevel.TextInit(Globals.characterSpeedLevel, _characterUpgradeSettings.characterSpeedCost[Globals.characterSpeedLevel + 1]);
            button_CharacterSpeedLevel.UpgradeValueTextInit(_characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel], _characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel + 1]);
            button_CharacterSpeedLevel.ButtonLevel(Globals.characterSpeedLevel);

        }
        else
        {
            button_CharacterSpeedLevel.FullLevel();
            button_CharacterSpeedLevel.UpgradeValueFull(_characterUpgradeSettings.characterSpeed[Globals.characterSpeedLevel]);
            button_CharacterSpeedLevel.ButtonLevel(Globals.characterSpeedLevel);
        }
        VibratoManager.Instance.MediumVibration();
    }
    public void MagnetRadiusUpgradeButton()
    {
        if (Globals.magnetRadiusLevel < _characterUpgradeSettings.magnetRadius.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.magnetRadiusCost[Globals.magnetRadiusLevel + 1])
            {
                GameManager.Instance.MoneyUpdate(-_characterUpgradeSettings.magnetRadiusCost[Globals.magnetRadiusLevel + 1]);
                Globals.magnetRadiusLevel++;
                PlayerPrefs.SetInt("magnetRadiusLevel", Globals.magnetRadiusLevel);
                PlayerController.Instance.magnet.MagnetLevelUp();
                //PlayerBehaviour.Instance.playerController.CharacterUpgrade(Globals.holeRadiusLevel);
                isEnoughMoney();
                InitButtonValues();
                PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform,0.8f, 1f, 0.5f, Ease.OutElastic);
                PlayerController.Instance.UpgradeTextSpawn("+Magnet");
            }
        }
    }

    public void MoveSpeedUpgradeButton()
    {
        if (Globals.characterSpeedLevel < _characterUpgradeSettings.characterSpeed.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.characterSpeedCost[Globals.characterSpeedLevel + 1])
            {
                GameManager.Instance.MoneyUpdate(-_characterUpgradeSettings.characterSpeedCost[Globals.characterSpeedLevel + 1]);
                Globals.characterSpeedLevel++;
                PlayerPrefs.SetInt("characterSpeedLevel", Globals.characterSpeedLevel);
                isEnoughMoney();
                InitButtonValues();
                PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                PlayerController.Instance.UpgradeTextSpawn("+Speed");
                
                
                string tag = "Player Movespeed Upgrade " + Globals.characterSpeedLevel.ToString();
                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }
        }
    }
    public void StackCapacityUpgradeButton()
    {
        if (Globals.stackCapacityLevel < _characterUpgradeSettings.stackCapacity.Length - 1)
        {
            if (Globals.moneyAmount >= _characterUpgradeSettings.stackCapacityCost[Globals.stackCapacityLevel + 1])
            {
                GameManager.Instance.MoneyUpdate(-_characterUpgradeSettings.stackCapacityCost[Globals.stackCapacityLevel + 1]);
                Globals.stackCapacityLevel++;
                PlayerPrefs.SetInt("stackCapacityLevel", Globals.stackCapacityLevel);
                isEnoughMoney();
                InitButtonValues();
                PlayerController.Instance.GetComponent<BoingScale>().ScaleEffectTR(PlayerController.Instance.transform, 0.8f, 1f, 0.5f, Ease.OutElastic);
                PlayerController.Instance.UpgradeTextSpawn("+Capacity");
               
                
                string tag = "Player Capacity Upgrade " + Globals.stackCapacityLevel.ToString();
                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag, time);
            }

        }

    }
    public void isEnoughMoney()
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
}
