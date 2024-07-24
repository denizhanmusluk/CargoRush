using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyMoneyButton : MonoBehaviour
{
    public Button buyButton;
    public int moneyAmount = 1;
    public int cost = 1;
    public void BuyMoneyPurchase_Click()
    {
        PurchaseMoneyManager.Instance.MoneyBuy(moneyAmount, cost, buyButton);
        buyButton.interactable = false;
    }
}
