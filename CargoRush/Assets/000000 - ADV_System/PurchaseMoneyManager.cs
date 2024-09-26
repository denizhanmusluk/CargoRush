using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HomaGames.HomaBelly;

public class PurchaseMoneyManager : MonoBehaviour
{
    private static PurchaseMoneyManager _instance = null;
    public static PurchaseMoneyManager Instance => _instance;
    int moneyAmount;
    float cost;
    Button buyButton;
    private void Awake()
    {
        _instance = this;
    }

    public void MoneyBuy(int _moneyAmount, float _cost, Button _buyButton, int buttonID)
    {
        moneyAmount = _moneyAmount;
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted(buttonID);
    }
    void PayingCompleted(int buttonID)
    {
        buyButton.interactable = true;
        GameManager.Instance.MoneyUpdate(moneyAmount);
        Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)5000, (float)Globals.moneyAmount, null, $"MoneyBundle{buttonID}", ResourceFlowReason.InAppPurchase);
        Analytics.ItemConsumed($"MoneyBundle{buttonID}", 0, ItemFlowReason.InAppPurchase);

    }
}
