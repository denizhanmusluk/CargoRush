using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseTicketManager : MonoBehaviour
{
    private static PurchaseTicketManager _instance = null;
    public static PurchaseTicketManager Instance => _instance;
    int ticketAmount;
    int cost;
    Button buyButton;
    private void Awake()
    {
        _instance = this;
    }
    public void TicketBuy(int _ticketAmount, int _cost, Button _buyButton)
    {
        ticketAmount = _ticketAmount;
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted();
    }
    void PayingCompleted()
    {
        buyButton.interactable = true;
        GameManager.Instance.ui.GemUpdate(ticketAmount);
    }

}
