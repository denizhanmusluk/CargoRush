//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public enum MoneyType
{
    Money,
    Gem
}
public class BuyButtons : MonoBehaviour
{
    public TextMeshProUGUI costText;
    public Button button;
    public int id;
    [SerializeField] Image moneyImg;
    public MoneyType _moneyType;
    [SerializeField] Sprite moneyIcon, gemIcon;
    public string skinName;
    [SerializeField] Color gemColor, moneyColor;
    private void Start()
    {
        switch (_moneyType)
        {
            case MoneyType.Money:
                {
                    moneyImg.sprite = moneyIcon;
                }
                break;
            case MoneyType.Gem:
                {
                    moneyImg.sprite = gemIcon;
                }
                break;
        }
    }
    public void BuyClick()
    {
        StarPanelManager.Instance.BuyClick(id, _moneyType);

        float time = CoefficientTransformation.FormatSaniye(Globals.speedPlayTime);

        if (id != 0)
        {
            //GameManager.Instance.GameAnalyticsTag(skinName);
            GameManager.Instance.HomaAnalyticsTag(skinName);
        }
        //GameAnalytics.NewDesignEvent(skinName);
        AudioManager.Instance.ButtonSound();
    }
    public void CostTextInit(int costAmount)
    {
        switch (_moneyType)
        {
            case MoneyType.Money:
                {
                    costText.text = costAmount.ToString();
                    if(costAmount >= 1000)
                    {
                        int newValue = costAmount / 1000;
                        costText.text = newValue.ToString() + "K";

                    }

                    //costText.text = CoefficientTransformation.Converter(costAmount);
                    costText.color = moneyColor;
                }
                break;
            case MoneyType.Gem:
                {
                    costText.text = CoefficientTransformation.Converter(costAmount);
                    costText.color = gemColor;
                }
                break;
        }

    }
}
