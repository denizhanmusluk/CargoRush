using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HomaGames.HomaBelly;

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
    public void TicketBuy(int _ticketAmount, float _cost, BuyTicketButton _buyTicketButton, int buttonID)
    {
        ticketAmount = _ticketAmount;
        cost = _cost;
        buyTicketButton = _buyTicketButton;
        PayingCompleted(buttonID);
    }
    void PayingCompleted(int buttonID)
    {
        //buyTicketButton.buyButton.interactable = true;
        GameManager.Instance.GemUpdate(ticketAmount);
        Analytics.ItemConsumed($"TicketBundle{buttonID}", 0, ItemFlowReason.InAppPurchase);
    }

}
