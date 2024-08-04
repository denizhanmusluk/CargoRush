using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BuyTicketButton : MonoBehaviour
{
    public Button buyButton;
    public int ticketAmount = 1;
    public float cost = 1;

    public TextMeshProUGUI ticketText;
    public TextMeshProUGUI costText;
    private void OnEnable()
    {
        ticketText.text = ticketAmount.ToString();
        costText.text = "$" + cost.ToString();
    }
    public void BuyTickedPurchase_Click()
    {
        //buyButton.interactable = false;
        PurchaseTicketManager.Instance.TicketBuy(ticketAmount, cost, this);
    }
}
