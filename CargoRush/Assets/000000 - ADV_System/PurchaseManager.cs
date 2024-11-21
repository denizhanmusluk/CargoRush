using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HomaGames.HomaBelly.IAP;
using TMPro;

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
    public GameObject repairManPopUp_GO;
    public GameObject wagonPopUp_GO;
    public GameObject wagonWithAd_GO;

    public Transform bundleButtonTR;
    public Transform boosterButtonTR;
    public Transform ticketButtonTR;
    public Transform moneyButtonTR;

    Vector3 bundleButtonFirstPos;
    Vector3 boosterButtonFirstPos;
    Vector3 ticketButtonFirstPos;
    Vector3 moneyButtonFirstPos;

    public TextMeshProUGUI wagonDriveTimeTxt;
    private void Awake()
    {
        _instance = this;
    }
    public void ButtonOpen()
    {
        purchaseButton_GO.SetActive(true);
        PlayerPrefs.SetInt("shopbuttonopen", 1);
    }
    private void Start()
    {
        wagonDriveTimeTxt.text=      ConvertSecondToMinSec.Converter(MRCUpgradeManager.Instance._characterUpgradeSettings.trainUsageTime[Globals.trainUsageTimeLevel]) + " Min";
        StartCoroutine(StartDelay());
        if(PlayerPrefs.GetInt("shopbuttonopen") == 1)
        {
            ButtonOpen();
        }

        bundleButtonFirstPos = bundleButtonTR.position;
        boosterButtonFirstPos = boosterButtonTR.position;
        ticketButtonFirstPos = ticketButtonTR.position;
        moneyButtonFirstPos = moneyButtonTR.position;

        if (PlayerPrefs.GetInt("specialOfferCounter") > 0)
        {
            SpecialOfferCounterStart();
        }
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(1);
        HomaStore.Initialize();
    }
    public void PurchasePanelOpen()
    {
        purchasePanel_GO.SetActive(true);
        purchaseButton_GO.SetActive(false);
        AudioManager.Instance.ButtonSound();
        OpenBundlesPanel();
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

        StartCoroutine(ButtonDown(ticketButtonTR, ticketButtonFirstPos));
        StartCoroutine(ButtonUp(boosterButtonTR, boosterButtonFirstPos));
        StartCoroutine(ButtonUp(bundleButtonTR, bundleButtonFirstPos));
        StartCoroutine(ButtonUp(moneyButtonTR, moneyButtonFirstPos));
    }

    public void OpenMoneyPanel()
    {
        moneyPanel_GO.SetActive(true);
        ticketPanel_GO.SetActive(false);
        boosterPanel_GO.SetActive(false);
        bundlesPanel_GO.SetActive(false);

        StartCoroutine(ButtonDown(moneyButtonTR, moneyButtonFirstPos));
        StartCoroutine(ButtonUp(boosterButtonTR, boosterButtonFirstPos));
        StartCoroutine(ButtonUp(ticketButtonTR, ticketButtonFirstPos));
        StartCoroutine(ButtonUp(bundleButtonTR, bundleButtonFirstPos));
    }
    public void OpenBoosterPanel()
    {
        boosterPanel_GO.SetActive(true);
        moneyPanel_GO.SetActive(false);
        ticketPanel_GO.SetActive(false);
        bundlesPanel_GO.SetActive(false);

        StartCoroutine(ButtonDown(boosterButtonTR, boosterButtonFirstPos));
        StartCoroutine(ButtonUp(bundleButtonTR, bundleButtonFirstPos));
        StartCoroutine(ButtonUp(ticketButtonTR, ticketButtonFirstPos));
        StartCoroutine(ButtonUp(moneyButtonTR, moneyButtonFirstPos));
    }
    public void OpenBundlesPanel()
    {
        bundlesPanel_GO.SetActive(true);
        boosterPanel_GO.SetActive(false);
        moneyPanel_GO.SetActive(false);
        ticketPanel_GO.SetActive(false);

        StartCoroutine(ButtonDown(bundleButtonTR, bundleButtonFirstPos));
        StartCoroutine(ButtonUp(boosterButtonTR, boosterButtonFirstPos));
        StartCoroutine(ButtonUp(ticketButtonTR, ticketButtonFirstPos));
        StartCoroutine(ButtonUp(moneyButtonTR, moneyButtonFirstPos));
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

    IEnumerator ButtonUp(Transform buttonTR, Vector3 firstPos)
    {
        float counter = 0;

        while(counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            buttonTR.position = Vector3.Lerp(buttonTR.position, new Vector3(buttonTR.position.x, firstPos.y , buttonTR.position.z), Time.deltaTime * 8);
            yield return null;
        }
    }

    IEnumerator ButtonDown(Transform buttonTR, Vector3 firstPos)
    {
        float counter = 0;

        while (counter < 1f)
        {
            counter += 2 * Time.deltaTime;
            buttonTR.position = Vector3.Lerp(buttonTR.position, new Vector3(buttonTR.position.x, firstPos.y - 60, buttonTR.position.z), Time.deltaTime * 8);
            yield return null;
        }
    }

    int specialOfferCounter = 0;
    public void SpecialOfferCounterStart()
    {
        StartCoroutine(SpecialOfferCounter());
    }
    IEnumerator SpecialOfferCounter()
    {
        specialOfferCounter = PlayerPrefs.GetInt("specialOfferCounter");

        while (specialOfferCounter < 300)
        {
            specialOfferCounter++;
            PlayerPrefs.SetInt("specialOfferCounter", specialOfferCounter);
            if(specialOfferCounter == 300)
            {
                SpecialOffer_PopUp_Open();
            }
            yield return new WaitForSeconds(1);
        }
    }
}
