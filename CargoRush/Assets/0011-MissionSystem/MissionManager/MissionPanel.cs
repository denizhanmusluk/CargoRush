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
    public string missionNameString;

    public GameObject completeText_GO;
    public void MissionStart(int _currentCount, int _maxCount , int _price, string _missionName)
    {
        missionNameString = _missionName;
        tickGO.SetActive(false);
        moneyButton.gameObject.SetActive(true);

        PlayerPrefs.SetInt(missionName + "missionactive" + PlayerPrefs.GetInt("level"), 1);
        currentCount = _currentCount;
        PlayerPrefs.SetInt(missionName + "count" + PlayerPrefs.GetInt("level"), currentCount);
        PlayerPrefs.SetInt(missionName + "maxcount" + PlayerPrefs.GetInt("level"), _maxCount);
        PlayerPrefs.SetInt(missionName + "missionprice" + PlayerPrefs.GetInt("level"), _price);

        maxCount = _maxCount;
        MissionManager.Instance.activeMissionCount++;
        mission_Active = true;
        price = _price;

        if (moneyType == MoneyType.Money)
        {
            priceText.text = price.ToString();
            moneyImg.sprite = moneyIcon;
            if(price == 0)
            {
                priceText.gameObject.SetActive(false);
                moneyImg.gameObject.SetActive(false);
            }
            else
            {
                priceText.gameObject.SetActive(true);
                moneyImg.gameObject.SetActive(true);
            }
        }
        else
        {
            priceText.text = price.ToString();
            moneyImg.sprite = gemIcon;
            if (price == 0)
            {
                priceText.gameObject.SetActive(false);
                moneyImg.gameObject.SetActive(false);
            }
            else
            {
                priceText.gameObject.SetActive(true);
                moneyImg.gameObject.SetActive(true);
            }
        }
        moneyButton.interactable = false;
        missionRateSlider.fillAmount = (float)currentCount / (float)maxCount;



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
            PlayerPrefs.SetInt(missionName + "count" + PlayerPrefs.GetInt("level"), currentCount);

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

                float time = CoefficientTransformation.FormatSaniye(Globals.speedPlayTime);
                //GameAnalytics.NewDesignEvent(tag,time);
            }
        }
    }
    private void MissionComplete()
    {
        //MissionManager.Instance.OpenPanelButton();

        MissionManager.Instance.startParticleGO.SetActive(true);
        PlayerPrefs.SetInt(missionName + PlayerPrefs.GetInt("level"), PlayerPrefs.GetInt(missionName + PlayerPrefs.GetInt("level")) + 1);
        moneyButton.interactable = true;
        missionRateSlider.fillAmount = 1;

        StartCoroutine(MissionCompleteDelay());
        
        if(PlayerPrefs.GetInt("firstmissioncompleted") == 0)
        {
            PlayerPrefs.SetInt("firstmissioncompleted", 1);
            MissionManager.Instance.tapTutorialGO.SetActive(true);
        }
        //MissionManager.Instance.MissionCompPopUpOpen(missionNameString);
    }
    IEnumerator MissionCompleteDelay()
    {
        if (PlayerPrefs.GetInt("missionbuttonopen") == 1)
        {
            MissionManager.Instance.tapTutorialGO.SetActive(false);
        }

        PlayerPrefs.SetInt(missionName + "missionactive" + PlayerPrefs.GetInt("level"), 0);
        PlayerPrefs.SetInt(missionName + "count" + PlayerPrefs.GetInt("level"), 0);
        //mission_Active = false;

        MissionManager.Instance.activeMissionCount--;

        moneyButton.interactable = false;

        if (!MissionManager.Instance.missionOpenPanelActive)
        {
            yield return new WaitForSeconds(1f);
            MissionManager.Instance.completeMission.SetActive(true);
            MissionManager.Instance.missionAnimator.SetTrigger("shake");
            ButtonAutoOpen();
            //MissionManager.Instance.buttonClick += ButtonClick;
        }
        else
        {
            ButtonClick();
        }
        //MissionManager.Instance.MissionOpen();
        //yield return new WaitForSeconds(1f);
        //ButtonClick();
    }
    void ButtonAutoOpen()
    {
        StartCoroutine(ButtonDelay());
        StartCoroutine(MissionEndClosePanel_Auto());

    }
    IEnumerator MissionEndClosePanel_Auto()
    {
        MissionManager.Instance.panelOpenButton.gameObject.SetActive(false);
        transform.parent = MissionManager.Instance.missionListParentTR;
        transform.localScale = Vector3.one;
        MissionManager.Instance.missionAnimatorSingleOpener.SetBool("openactive", true);
        yield return new WaitForSeconds(4f);
        float counter = 0f;
        //while (counter < 1f)
        //{
        //    counter += 4 * Time.deltaTime;
        //    transform.localScale = Vector3.Lerp(Vector3.one, new Vector3(1, 0, 1), counter);
        //    yield return null;
        //}
        mission_Active = false;
        //transform.localScale = Vector3.one;
        //if (MissionManager.Instance.activeMissionCount == 0)
        //{
        //    MissionManager.Instance.MissionClose();
        //    yield return new WaitForSeconds(0.5f);
        //    MissionManager.Instance.panelOpenButton.gameObject.SetActive(false);
        //}
        MissionManager.Instance.missionAnimatorSingleOpener.SetBool("openactive", false);
        yield return new WaitForSeconds(1f);

        transform.parent = MissionManager.Instance.missionListTR;
        transform.localScale = Vector3.one;
        MissionManager.Instance.panelOpenButton.gameObject.SetActive(true);
        completeText_GO.gameObject.SetActive(false);
        gameObject.SetActive(false);
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
            if (price > 0)
            {
                MissionManager.Instance.MoneyCreate(price, moneyButton.transform);
            }
        }
        else
        {
            //GameManager.Instance.ui.GemCreate(price, moneyButton.transform);
        }
        MissionManager.Instance.completeMission.SetActive(false);
        yield return new WaitForSeconds(1f);
        moneyButton.gameObject.SetActive(false);
        completeText_GO.gameObject.SetActive(true);


        yield return new WaitForSeconds(4f);

        MissionManager.Instance.OpenPanelButton();
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
        mission_Active = false;
        transform.localScale = Vector3.one;
        if (MissionManager.Instance.activeMissionCount == 0)
        {
            MissionManager.Instance.MissionClose();
            yield return new WaitForSeconds(0.5f);
            MissionManager.Instance.panelOpenButton.gameObject.SetActive(false);
        }
        completeText_GO.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
