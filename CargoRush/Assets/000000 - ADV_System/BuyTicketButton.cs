using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyTicketButton : MonoBehaviour
{
    public Button buyButton;
    public int ticketAmount = 1;
    public int cost = 1;
    public void BuyTickedPurchase_Click()
    {
        PurchaseTicketManager.Instance.TicketBuy(ticketAmount, cost, buyButton);
        buyButton.interactable = false;
    }
}
