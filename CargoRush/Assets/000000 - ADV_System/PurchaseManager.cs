using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseManager : MonoBehaviour
{
    private static PurchaseManager _instance = null;
    public static PurchaseManager Instance => _instance;
    public GameObject purchasePanel_GO;
    public GameObject purchaseButton_GO;

    public GameObject ticketPanel_GO;
    public GameObject moneyPanel_GO;
    public GameObject boosterPanel_GO;
    public GameObject bundlesPanel_GO;


    public GameObject noAdsPopUp_GO;
    public GameObject noAdsLimitedPopUp_GO;
    public GameObject specialOfferPopUp_GO;
    public GameObject speedPopUp_GO;
    public GameObject doubleCapacityPopUp_GO;
    public GameObject doubleIncomePopUp_GO;
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        
    }
    public void PurchasePanelOpen()
    {
        purchasePanel_GO.SetActive(true);
        purchaseButton_GO.SetActive(false);
    }
    public void PurchasePanelClose()
    {
        purchasePanel_GO.SetActive(false);
        purchaseButton_GO.SetActive(true);

    }
    public void BuyBannerDisable()
    {
        ADVManager.Instance.NoAds();
    }
    public void BuyTicket()
    {

    }
    //public void BuySpeedBoost()
    //{
    //    SkillManager.Instance.PurchaseSpeedBoostActive();
    //}
    //public void BuyFullCapacityBoost()
    //{
    //    SkillManager.Instance.PurchaseCapacityBoostActive();
    //}
    //public void BuyDoubleIncomeBoost()
    //{
    //    SkillManager.Instance.PurchaseDoubleIncomeBoostActive();
    //}







    public void OpenTicketPanel()
    {
        ticketPanel_GO.SetActive(true);
        moneyPanel_GO.SetActive(false);
        boosterPanel_GO.SetActive(false);
        bundlesPanel_GO.SetActive(false);
    }

    public void OpenMoneyPanel()
    {
        moneyPanel_GO.SetActive(true);
        ticketPanel_GO.SetActive(false);
        boosterPanel_GO.SetActive(false);
        bundlesPanel_GO.SetActive(false);
    }
    public void OpenBoosterPanel()
    {
        boosterPanel_GO.SetActive(true);
        moneyPanel_GO.SetActive(false);
        ticketPanel_GO.SetActive(false);
        bundlesPanel_GO.SetActive(false);
    }
    public void OpenBundlesPanel()
    {
        bundlesPanel_GO.SetActive(true);
        boosterPanel_GO.SetActive(false);
        moneyPanel_GO.SetActive(false);
        ticketPanel_GO.SetActive(false);
    }


    // // // // // // // // // //

    public void NoAds_PopUp_Open()
    {
        if (PlayerPrefs.GetInt("noadspopupcount") < 3)
        {
            noAdsPopUp_GO.SetActive(true);
            PlayerPrefs.SetInt("noadspopupcount", PlayerPrefs.GetInt("noadspopupcount") + 1);
        }
    }
    public void NoAdsLimited_PopUp_Open()
    {
        noAdsLimitedPopUp_GO.SetActive(true);
    }
    public void SpecialOffer_PopUp_Open()
    {
        specialOfferPopUp_GO.SetActive(true);
    }
    public void Speed_PopUp_Open()
    {
        speedPopUp_GO.SetActive(true);
    }
    public void DoubleIncome_PopUp_Open()
    {
        doubleIncomePopUp_GO.SetActive(true);
    }
    public void DoubleCapacity_PopUp_Open()
    {
        doubleCapacityPopUp_GO.SetActive(true);
    }
}
