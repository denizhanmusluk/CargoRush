//using GameAnalyticsSDK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MissionPanel : MonoBehaviour
{
    public MoneyType moneyType;
    public Button moneyButton;
    public Image missionRateSlider;
    public TextMeshProUGUI missionNameText;
    public TextMeshProUGUI missionRateText;
    public TextMeshProUGUI priceText;
    public int missionCurrentCount;
    public int price;
    public string missionName;
    public bool mission_Active = false;
    public bool missionProduct_Active = false;
    public int maxCount;
    public int currentCount = 0;
    public Sprite moneyIcon, gemIcon;
    public Image moneyImg;
    public GameObject tickGO;
    public string missionTag;

    public void MissionStart(int _currentCount, int _maxCount , int _price)
    {
        tickGO.SetActive(false);
        moneyButton.gameObject.SetActive(true);

        PlayerPrefs.SetInt(missionName + "missionactive", 1);
        currentCount = _currentCount;
        PlayerPrefs.SetInt(missionName + "count", currentCount);
        PlayerPrefs.SetInt(missionName + "maxcount", _maxCount);
        PlayerPrefs.SetInt(missionName + "missionprice", _price);

        maxCount = _maxCount;
        MissionManager.Instance.activeMissionCount++;
        mission_Active = true;
        price = _price;

        if (moneyType == MoneyType.Money)
        {
            priceText.text = "$" + price.ToString();
            moneyImg.sprite = moneyIcon;
        }
        else
        {
            priceText.text = price.ToString();
            moneyImg.sprite = gemIcon;
        }
        moneyButton.interactable = false;
        missionRateSlider.fillAmount = (float)currentCount / (float)maxCount;

        MissionManager.Instance.OpenPanelButton();


        if (currentCount == maxCount)
        {
            MissionComplete();
        }
    }
    public void MissionUpdate()
    {
        if (mission_Active && currentCount < maxCount)
        {
            currentCount++;
            PlayerPrefs.SetInt(missionName + "count", currentCount);

            missionRateSlider.fillAmount = ((float)currentCount / (float)maxCount);

            if (currentCount == maxCount)
            {
                MissionComplete();
            }
        }
    }
    public void MissionUpdatestand(int collectId)
    {
        if (mission_Active && collectId == PlayerPrefs.GetInt(missionName))
        {
            int openedStandCount = 0;

            foreach(var stnd in MissionManager.Instance.allStandList)
            {
                if(stnd.GetComponent<StandFishTezgah>()._CollectProduct.CollectId - 2 == PlayerPrefs.GetInt(missionName))
                {
                    openedStandCount++;


                }
            }
            currentCount++;
            PlayerPrefs.SetInt(missionName + "count", openedStandCount);

            missionRateSlider.fillAmount = ((float)openedStandCount / (float)maxCount);

            if (openedStandCount == maxCount)
            {
                MissionComplete();

                string tag = "";

                if (collectId == 0) { tag = "All phone stands unlocked"; }
                if (collectId == 1) { tag = "All laptop stands unlocked"; }
                if (collectId == 2) { tag = "All headphone stands unlocked"; }
                if (collectId == 3) { tag = "All shoe stands unlocked"; }
                if (collectId == 4) { tag = "All baseball bat stands unlocked"; }
                if (collectId == 5) { tag = "All tshirt stands unlocked"; }
                if (collectId == 6) { tag = "All baby doll stands unlocked"; }
                if (collectId == 7) { tag = "All teddy bear stands unlocked"; }
                if (collectId == 8) { tag = "All toy car stands unlocked"; }

                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }
        }
    }
    private void MissionComplete()
    {
        MissionManager.Instance.startParticleGO.SetActive(true);
        PlayerPrefs.SetInt(missionName, PlayerPrefs.GetInt(missionName) + 1);
        moneyButton.interactable = true;
        missionRateSlider.fillAmount = 1;

        StartCoroutine(MissionCompleteDelay());
        
    }
    IEnumerator MissionCompleteDelay()
    {

        PlayerPrefs.SetInt(missionName + "missionactive", 0);
        PlayerPrefs.SetInt(missionName + "count", 0);
        mission_Active = false;

        MissionManager.Instance.activeMissionCount--;

        moneyButton.interactable = false;

        if (!MissionManager.Instance.missionOpenPanelActive)
        {
            yield return new WaitForSeconds(1f);
            MissionManager.Instance.completeMission.SetActive(true);
            MissionManager.Instance.missionAnimator.SetTrigger("shake");

            MissionManager.Instance.buttonClick += ButtonClick;
        }
        else
        {
            ButtonClick();
        }
        //MissionManager.Instance.MissionOpen();
        //yield return new WaitForSeconds(1f);
        //ButtonClick();
    }
    public void ButtonClick()
    {
        MissionManager.Instance.buttonClick -= ButtonClick;
        //PlayerPrefs.SetInt(missionName + "missionactive", 0);
        //PlayerPrefs.SetInt(missionName + "count", 0);
        //mission_Active = false;

        //MissionManager.Instance.activeMissionCount--;

        //moneyButton.interactable = false;
        StartCoroutine(MissionEndClosePanel());
        StartCoroutine(ButtonDelay());



  

    }
    IEnumerator ButtonDelay()
    {
        yield return new WaitForSeconds(1f);
        tickGO.SetActive(true);
        if (moneyType == MoneyType.Money)
        {
            MissionManager.Instance.MoneyCreate(price, moneyButton.transform);
        }
        else
        {
            GameManager.Instance.ui.GemCreate(price, moneyButton.transform);
        }
        MissionManager.Instance.completeMission.SetActive(false);
        yield return new WaitForSeconds(1f);
        moneyButton.gameObject.SetActive(false);
    }
    IEnumerator MissionEndClosePanel()
    {
        while (MissionManager.Instance.missionOpenPanelActive)
        {
            yield return null;
        }
        float counter = 0f;
        while(counter < 1f)
        {
            counter += 4 * Time.deltaTime;
            transform.localScale = Vector3.Lerp(Vector3.one, new Vector3(1, 0, 1), counter);
            yield return null;
        }

        transform.localScale = Vector3.one;
        gameObject.SetActive(false);
        if (MissionManager.Instance.activeMissionCount == 0)
        {
            MissionManager.Instance.MissionClose();
            yield return new WaitForSeconds(0.5f);
            MissionManager.Instance.panelOpenButton.gameObject.SetActive(false);
        }
    }



    public void MissionStartProduce(int _currentCount, int _maxCount, int _price, int productId)
    {
        tickGO.SetActive(false);
        moneyButton.gameObject.SetActive(true);

        PlayerPrefs.SetInt(missionName + productId.ToString() + "missionactive", 1);
        currentCount = _currentCount;
        PlayerPrefs.SetInt(missionName + productId.ToString() + "count", currentCount);
        PlayerPrefs.SetInt(missionName + productId.ToString() + "maxcount", _maxCount);
        PlayerPrefs.SetInt(missionName + productId.ToString() + "missionprice", _price);

        maxCount = _maxCount;
        MissionManager.Instance.activeMissionCount++;
        MissionManager.Instance.activeProductMissionCount++;
        mission_Active = true;
        price = _price;

        if (moneyType == MoneyType.Money)
        {
            priceText.text = "$" + price.ToString();
            moneyImg.sprite = moneyIcon;
        }
        else
        {
            priceText.text = price.ToString();
            moneyImg.sprite = gemIcon;
        }
        moneyButton.interactable = false;
        missionRateSlider.fillAmount = 0;

        MissionManager.Instance.OpenPanelButton();


        if (currentCount == maxCount)
        {
            MissionCompleteProduce(productId);
        }
    }
    public void MissionUpdateProduce(int productId)
    {
        if (mission_Active && currentCount < maxCount)
        {
            currentCount++;
            PlayerPrefs.SetInt(missionName + productId.ToString() + "count", currentCount);

            missionRateSlider.fillAmount = ((float)currentCount / (float)maxCount);

            if (currentCount == maxCount)
            {
                MissionCompleteProduce(productId);

                string tag = "";

                if (productId == 0) { tag = "Produce " + maxCount.ToString() + "Phone"; }
                if (productId == 1) { tag = "Produce " + maxCount.ToString() + "Laptop"; }
                if (productId == 2) { tag = "Produce " + maxCount.ToString() + "Headphone"; }
                if (productId == 3) { tag = "Produce " + maxCount.ToString() + "Shoe"; }
                if (productId == 4) { tag = "Produce " + maxCount.ToString() + "BaseballBat"; }
                if (productId == 5) { tag = "Produce " + maxCount.ToString() + "Tshirt"; }
                if (productId == 6) { tag = "Produce " + maxCount.ToString() + "BabyDoll"; }
                if (productId == 7) { tag = "Produce " + maxCount.ToString() + "TeddyBear"; }
                if (productId == 8) { tag = "Produce " + maxCount.ToString() + "ToyCar"; }

                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }
        }
    }
    private void MissionCompleteProduce(int productId)
    {
        MissionManager.Instance.startParticleGO.SetActive(true);
        PlayerPrefs.SetInt(missionName + productId.ToString(), PlayerPrefs.GetInt(missionName + productId.ToString()) + 1);
        moneyButton.interactable = true;
        missionRateSlider.fillAmount = 1;

        MissionManager.Instance.activeProductMissionCount--;
        StartCoroutine(MissionCompleteDelay());

    }














    public void MissionStartSale(int _currentCount, int _maxCount, int _price, int productId)
    {
        tickGO.SetActive(false);
        moneyButton.gameObject.SetActive(true);

        PlayerPrefs.SetInt(missionName + productId.ToString() + "missionactive", 1);
        currentCount = _currentCount;
        PlayerPrefs.SetInt(missionName + productId.ToString() + "count", currentCount);
        PlayerPrefs.SetInt(missionName + productId.ToString() + "maxcount", _maxCount);
        PlayerPrefs.SetInt(missionName + productId.ToString() + "missionprice", _price);

        maxCount = _maxCount;
        MissionManager.Instance.activeMissionCount++;
        MissionManager.Instance.activeSaleMissionCount++;
        mission_Active = true;
        price = _price;

        if (moneyType == MoneyType.Money)
        {
            priceText.text = "$" + price.ToString();
            moneyImg.sprite = moneyIcon;
        }
        else
        {
            priceText.text = price.ToString();
            moneyImg.sprite = gemIcon;
        }
        moneyButton.interactable = false;
        missionRateSlider.fillAmount = 0;

        MissionManager.Instance.OpenPanelButton();


        if (currentCount == maxCount)
        {
            MissionCompleteSale(productId);
        }
    }
    public void MissionUpdateSale(int productId)
    {
        if (mission_Active && currentCount < maxCount)
        {
            currentCount++;
            PlayerPrefs.SetInt(missionName + productId.ToString() + "count", currentCount);

            missionRateSlider.fillAmount = ((float)currentCount / (float)maxCount);

            if (currentCount == maxCount)
            {
                MissionCompleteSale(productId);

                string tag = "";

                if (productId == 0) { tag = "Sell " + maxCount.ToString() + "Phone"; }
                if (productId == 1) { tag = "Sell " + maxCount.ToString() + "Laptop"; }
                if (productId == 2) { tag = "Sell " + maxCount.ToString() + "Headphone"; }
                if (productId == 3) { tag = "Sell " + maxCount.ToString() + "Shoe"; }
                if (productId == 4) { tag = "Sell " + maxCount.ToString() + "BaseballBat"; }
                if (productId == 5) { tag = "Sell " + maxCount.ToString() + "Tshirt"; }
                if (productId == 6) { tag = "Sell " + maxCount.ToString() + "BabyDoll"; }
                if (productId == 7) { tag = "Sell " + maxCount.ToString() + "TeddyBear"; }
                if (productId == 8) { tag = "Sell " + maxCount.ToString() + "ToyCar"; }


                float time = CoefficientTransformation.FormatSaniye(Globals.playTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }
        }
    }
    private void MissionCompleteSale(int productId)
    {
        MissionManager.Instance.startParticleGO.SetActive(true);
        PlayerPrefs.SetInt(missionName + productId.ToString(), PlayerPrefs.GetInt(missionName + productId.ToString()) + 1);
        moneyButton.interactable = true;
        missionRateSlider.fillAmount = 1;

        MissionManager.Instance.activeSaleMissionCount--;
        StartCoroutine(MissionCompleteDelay());

    }





    //public void MissionStartStand(int _currentCount, int _maxCount, int _price, int productId)
    //{
    //    PlayerPrefs.SetInt(missionName + productId.ToString() + "missionactive", 1);
    //    currentCount = _currentCount;
    //    PlayerPrefs.SetInt(missionName + productId.ToString() + "count", currentCount);
    //    PlayerPrefs.SetInt(missionName + productId.ToString() + "maxcount", _maxCount);
    //    PlayerPrefs.SetInt(missionName + productId.ToString() + "missionprice", _price);

    //    maxCount = _maxCount;
    //    MissionManager.Instance.activeMissionCount++;
    //    MissionManager.Instance.activeStandMissionCount++;
    //    mission_Active = true;
    //    price = _price;

    //    if (moneyType == MoneyType.Money)
    //    {
    //        priceText.text = "$" + price.ToString();
    //        moneyImg.sprite = moneyIcon;
    //    }
    //    else
    //    {
    //        priceText.text = price.ToString();
    //        moneyImg.sprite = gemIcon;
    //    }
    //    moneyButton.interactable = false;
    //    missionRateSlider.fillAmount = 0;
    //    MissionManager.Instance.panelOpenButton.gameObject.SetActive(true);

    //    if (currentCount == maxCount)
    //    {
    //        MissionCompleteStand(productId);
    //    }
    //}


    //public void MissionUpdateStand(int productId)
    //{
    //    if (mission_Active && currentCount < maxCount)
    //    {
    //        currentCount++;
    //        PlayerPrefs.SetInt(missionName + productId.ToString() + "count", currentCount);

    //        missionRateSlider.fillAmount = ((float)currentCount / (float)maxCount);


    //        if (currentCount == maxCount)
    //        {
    //            MissionCompleteStand(productId);
    //        }
    //    }
    //}



    //private void MissionCompleteStand(int productId)
    //{
    //    MissionManager.Instance.startParticleGO.SetActive(true);
    //    PlayerPrefs.SetInt(missionName + productId.ToString(), PlayerPrefs.GetInt(missionName + productId.ToString()) + 1);
    //    moneyButton.interactable = true;
    //    missionRateSlider.fillAmount = 1;

    //    MissionManager.Instance.activeStandMissionCount--;
    //    StartCoroutine(MissionCompleteDelay());

    //}
}
