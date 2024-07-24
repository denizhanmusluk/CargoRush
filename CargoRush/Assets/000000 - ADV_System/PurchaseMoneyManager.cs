using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseMoneyManager : MonoBehaviour
{
    private static PurchaseMoneyManager _instance = null;
    public static PurchaseMoneyManager Instance => _instance;
    int moneyAmount;
    int cost;
    Button buyButton;
    private void Awake()
    {
        _instance = this;
    }

    public void MoneyBuy(int _moneyAmount, int _cost, Button _buyButton)
    {
        moneyAmount = _moneyAmount;
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted();
    }
    void PayingCompleted()
    {
        buyButton.interactable = true;
        GameManager.Instance.ui.MoneyUpdate(moneyAmount);
    }
}
