using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HomaGames.HomaBelly;
public class PurchaseBoostManager : MonoBehaviour
{
    private static PurchaseBoostManager _instance = null;
    public static PurchaseBoostManager Instance => _instance;
    Button buyButton;
    float cost;


    public BuyCapacity buyCapacity;
    public BuyRepair buyRepair;
    public BuySpeedPurchase buySpeed;
    public BuyDoubleIncome buyDoubleIncome;
    public BuyTrain buyTrain;

    private void Awake()
    {
        _instance = this;
    }

    public void DoubleIncomeBuy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_DoubleIncome();
    }
    void PayingCompleted_DoubleIncome()
    {
        buyButton.interactable = true;
        SkillManager.Instance.PurchaseDoubleIncomeBoostActive();
        if (buyDoubleIncome != null)
        {
            buyDoubleIncome.CheckPurchased();
        }
        Analytics.ItemConsumed("Permanent_DoubleIncome", 0, ItemFlowReason.InAppPurchase);
    }

    public void CapacityBuy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Capacity();
    }
    void PayingCompleted_Capacity()
    {
        buyButton.interactable = true;
        SkillManager.Instance.PurchaseCapacityBoostActive();
        if (buyCapacity != null)
        {
            buyCapacity.CheckPurchased();
        }
        Analytics.ItemConsumed("Permanent_DoubleCapacity", 0, ItemFlowReason.InAppPurchase);
    }

    public void RepairBuy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Repair();
    }
    void PayingCompleted_Repair()
    {
        buyButton.interactable = true;
        SkillManager.Instance.PurchaseRepairImmediateActive();
        if (buyRepair != null)
        {
            buyRepair.CheckPurchased();
        }
        Analytics.ItemConsumed("Permanent_RepairMan", 0, ItemFlowReason.InAppPurchase);
    }
    public void TrainBuy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Train();
    }
    void PayingCompleted_Train()
    {
        buyButton.interactable = true;
        TrainManager.Instance.PurchaseTrainImmediateActive();
        if (buyTrain != null)
        {
            buyTrain.CheckPurchased();
        }
        Analytics.ItemConsumed("Permanent_TrainVagon", 0, ItemFlowReason.InAppPurchase);
    }
    public void SpeedBuy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Speed();
    }
    void PayingCompleted_Speed()
    {
        buyButton.interactable = true;
        SkillManager.Instance.PurchaseSpeedBoostActive();
        if (buySpeed != null)
        {
            buySpeed.CheckPurchased();
        }
        Analytics.ItemConsumed("Permanent_SpeedBoost", 0, ItemFlowReason.InAppPurchase);
    }
}
