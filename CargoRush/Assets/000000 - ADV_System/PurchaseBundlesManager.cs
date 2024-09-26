using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using HomaGames.HomaBelly;

public class PurchaseBundlesManager : MonoBehaviour
{
    private static PurchaseBundlesManager _instance = null;
    public static PurchaseBundlesManager Instance => _instance;
    Button buyButton;
    float cost;

    public NoAdsBundles noAdsBundles;
    public NoAdsLimitedBundles noAdsLimitedBundles;

    public Bundle1 bundle1;
    public Bundle2 bundle2;
    public Bundle3 bundle3;
    public Bundle4 bundle4;
    public Bundle5 bundle5;
    public Bundle6 bundle6;
    public SpecialOffer specialOffer;


    //public NoAdsPopUp noAdsPopUp;

    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
    
    }


    public void NoAdsBuy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_NoAds();
    }
    void PayingCompleted_NoAds()
    {
        buyButton.interactable = true;
        ADVManager.Instance.NoAds();
        // // // // //
        if (noAdsBundles != null)
        {
            noAdsBundles.CheckPurchased();
        }

        Analytics.ItemConsumed("NoAds", 0, ItemFlowReason.InAppPurchase);
    }

    public void NoAdsLimitedBuy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_NoAdsLimited();
    }
    void PayingCompleted_NoAdsLimited()
    {
        buyButton.interactable = true;
        ADVManager.Instance.NoAdsLimited();
        // // // // //
        if (noAdsLimitedBundles != null)
        {
            noAdsLimitedBundles.CheckPurchased();
        }
        SaveCurrentDate();
        Analytics.ItemConsumed("1DayNoAds", 0, ItemFlowReason.InAppPurchase);
    }


    void SaveCurrentDate()
    {
        DateTime now = DateTime.Now;
        PlayerPrefs.SetString(DayCycleManager.Instance.SavedDateKey, now.ToString());
    }



    public void Bundle_1_Buy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Bundle_1();
    }
    void PayingCompleted_Bundle_1()
    {
        PlayerPrefs.SetInt("bundle1", 1);
        buyButton.interactable = true;
        ADVManager.Instance.NoAds();
        // // // // //
        GameManager.Instance.MoneyUpdate(5000);
        Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)5000, (float)Globals.moneyAmount, null, "Bundle1", ResourceFlowReason.InAppPurchase);

        if (bundle1 != null)
        {
            bundle1.CheckPurchased();
        }

        Analytics.ItemConsumed("Bundle1", 0, ItemFlowReason.InAppPurchase);
    }


    public void Bundle_2_Buy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Bundle_2();
    }
    void PayingCompleted_Bundle_2()
    {
        PlayerPrefs.SetInt("bundle2", 1);
        buyButton.interactable = true;
        ADVManager.Instance.NoAds();
        // // // // //
        GameManager.Instance.MoneyUpdate(5000);
        GameManager.Instance.GemUpdate(20);

        Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)5000, (float)Globals.moneyAmount, null, "Bundle2", ResourceFlowReason.InAppPurchase);

        if (bundle2 != null)
        {
            bundle2.CheckPurchased();
        }
        Analytics.ItemConsumed("Bundle2", 0, ItemFlowReason.InAppPurchase);
    }
    public void Bundle_3_Buy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Bundle_3();
    }
    void PayingCompleted_Bundle_3()
    {
        PlayerPrefs.SetInt("bundle3", 1);
        buyButton.interactable = true;
        ADVManager.Instance.NoAds();
        // // // // //
        SkillManager.Instance.PurchaseCapacityBoostActive();

        if (bundle3 != null)
        {
            bundle3.CheckPurchased();
        }
        Analytics.ItemConsumed("Bundle3", 0, ItemFlowReason.InAppPurchase);
    }
    public void Bundle_4_Buy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Bundle_4();
    }
    void PayingCompleted_Bundle_4()
    {
        PlayerPrefs.SetInt("bundle4", 1);
        buyButton.interactable = true;
        ADVManager.Instance.NoAds();
        // // // // //

        SkillManager.Instance.PurchaseCapacityBoostActive();
        SkillManager.Instance.PurchaseSpeedBoostActive();
        SkillManager.Instance.PurchaseDoubleIncomeBoostActive();
        GameManager.Instance.GemUpdate(50);

        if (bundle4 != null)
        {
            bundle4.CheckPurchased();
        }
        Analytics.ItemConsumed("Bundle4", 0, ItemFlowReason.InAppPurchase);
    }
    public void Bundle_5_Buy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Bundle_5();
    }
    void PayingCompleted_Bundle_5()
    {
        PlayerPrefs.SetInt("bundle5", 1);
        buyButton.interactable = true;
        ADVManager.Instance.NoAds();
        // // // // //

        SkillManager.Instance.PurchaseCapacityBoostActive();
        SkillManager.Instance.PurchaseSpeedBoostActive();
        SkillManager.Instance.PurchaseDoubleIncomeBoostActive();
        SkillManager.Instance.PurchaseRepairImmediateActive();

        if (bundle5 != null)
        {
            bundle5.CheckPurchased();
        }
        Analytics.ItemConsumed("Bundle5", 0, ItemFlowReason.InAppPurchase);
    }
    public void Bundle_6_Buy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_Bundle_6();
    }
    void PayingCompleted_Bundle_6()
    {
        PlayerPrefs.SetInt("bundle6", 1);
        buyButton.interactable = true;
        ADVManager.Instance.NoAds();
        // // // // //
        GameManager.Instance.MoneyUpdate(50000);
        GameManager.Instance.GemUpdate(250);

        Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)50000, (float)Globals.moneyAmount, null, " Bundle6", ResourceFlowReason.InAppPurchase);

        SkillManager.Instance.PurchaseRepairImmediateActive();


        if (bundle6 != null)
        {
            bundle6.CheckPurchased();
        }
        Analytics.ItemConsumed("Bundle6", 0, ItemFlowReason.InAppPurchase);
    }


    public void SpecialOffer_Buy(float _cost, Button _buyButton)
    {
        cost = _cost;
        buyButton = _buyButton;
        PayingCompleted_SpecialOffer();
    }
    void PayingCompleted_SpecialOffer()
    {
        PlayerPrefs.SetInt("specialoffer", 1);
        buyButton.interactable = true;
        // // // // //
        GameManager.Instance.MoneyUpdate(1000);
        GameManager.Instance.GemUpdate(6);

        Analytics.ResourceFlowEvent(ResourceFlowType.Source, "Money", (float)1000, (float)Globals.moneyAmount, null, " SpecialOffer", ResourceFlowReason.InAppPurchase);

        //SkillManager.Instance.PurchaseRepairImmediateActive();


        if (specialOffer != null)
        {
            specialOffer.CheckPurchased();
        }
        Analytics.ItemConsumed("SpecialOffer", 0, ItemFlowReason.InAppPurchase);
    }
}
