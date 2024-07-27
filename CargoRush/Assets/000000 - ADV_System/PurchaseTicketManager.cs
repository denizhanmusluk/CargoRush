using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchaseTicketManager : MonoBehaviour
{
    private static PurchaseTicketManager _instance = null;
    public static PurchaseTicketManager Instance => _instance;
    int ticketAmount;
    float cost;
   [SerializeField] BuyTicketButton buyTicketButton;
    private void Awake()
    {
        _instance = this;
    }
    public void TicketBuy(int _ticketAmount, float _cost, BuyTicketButton _buyTicketButton)
    {
        ticketAmount = _ticketAmount;
        cost = _cost;
        buyTicketButton = _buyTicketButton;
        PayingCompleted();
    }
    void PayingCompleted()
    {
        buyTicketButton.buyButton.interactable = true;
        GameManager.Instance.ui.GemUpdate(ticketAmount);
    }

}
