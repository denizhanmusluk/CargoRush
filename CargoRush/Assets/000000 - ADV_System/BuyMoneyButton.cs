using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BuyMoneyButton : MonoBehaviour
{
    public int buttonID;
    public Button buyButton;
    public int moneyAmount = 1;
    public float cost = 1;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI costText;
    private void OnEnable()
    {
        moneyText.text = "x" + moneyAmount.ToString();
        costText.text = "$" + cost.ToString();
    }
    public void BuyMoneyPurchase_Click()
    {
        buyButton.interactable = false;
        PurchaseMoneyManager.Instance.MoneyBuy(moneyAmount, cost, buyButton, buttonID);
    }
}
