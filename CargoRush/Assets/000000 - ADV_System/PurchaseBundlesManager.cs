using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

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
        GameManager.Instance.ui.MoneyUpdate(5000);

        if (bundle1 != null)
        {
            bundle1.CheckPurchased();
        }
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
        GameManager.Instance.ui.MoneyUpdate(5000);
        GameManager.Instance.ui.GemUpdate(20);

        if (bundle2 != null)
        {
            bundle2.CheckPurchased();
        }
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
        GameManager.Instance.ui.GemUpdate(50);

        if (bundle4 != null)
        {
            bundle4.CheckPurchased();
        }
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
        GameManager.Instance.ui.MoneyUpdate(50000);
        GameManager.Instance.ui.GemUpdate(250);

        SkillManager.Instance.PurchaseRepairImmediateActive();


        if (bundle6 != null)
        {
            bundle6.CheckPurchased();
        }
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
        GameManager.Instance.ui.MoneyUpdate(1000);
        GameManager.Instance.ui.GemUpdate(6);

        SkillManager.Instance.PurchaseRepairImmediateActive();


        if (specialOffer != null)
        {
            specialOffer.CheckPurchased();
        }
    }
}
