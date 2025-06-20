using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using HomaGames.HomaBelly;

public class ModelButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Button modelSelectButton;
    public Image selectedOutline;
    public Image selectedTick;
    public Image buyedImg;
    public Image modelImage;
    public Image grayImage;
    public Image darkImage;
    public Image lockImage;
    //public TextMeshProUGUI modelText;
    public BuyButtons buyButton;
    public Button advButton;
    public int shopLevel;
    public int buttonId;
    public bool isFree = false;
    public GameObject selectAndBuyGO;
    public Button selectButton;
    public GameObject unlockNewMapGO;
    public TextMeshProUGUI unlockNewMapText;
    public TextMeshProUGUI advCountText;

    public int totalADV_Count = 3;
    public string skinName;
    public void SelectClick()
    {
        StarPanelManager.Instance.SelectClick(buttonId);
        AudioManager.Instance.ButtonSound();
        if(buttonId == 1 && PlayerPrefs.GetInt("skinfirstselect") == 0)
        {
            PlayerPrefs.SetInt("skinfirstselect", 1);
            IndicatorManager.Instance.TutorialStepCompleted();
            IndicatorManager.Instance.TutorialStepStart(63);
        }
    }
    public void SelectedButtonClick()
    {
        StarPanelManager.Instance.SelectedButtonClick(buttonId);
        StarPanelManager.Instance.StarPAnelActive();
        selectButton.gameObject.SetActive(false);
        if (buttonId == 1 && PlayerPrefs.GetInt("skinfirstselect") == 1)
        {
            PlayerPrefs.SetInt("skinfirstselect", 2);
            IndicatorManager.Instance.TutorialStepCompleted();
        }
    }
    public void OpenedCheck()
    {
        if(PlayerPrefs.GetInt("buyskin" + buyButton.id) == 1 || isFree || PlayerPrefs.GetInt("adv" + buyButton.id) == totalADV_Count  )
        {
            //modelSelectButton.interactable = true;
            modelImage.gameObject.SetActive(true);
            grayImage.gameObject.SetActive(false);
            darkImage.gameObject.SetActive(false);
            //modelText.gameObject.SetActive(false);
            lockImage.gameObject.SetActive(false);
            unlockNewMapGO.gameObject.SetActive(false);

            buyButton.gameObject.SetActive(false);
            advButton.gameObject.SetActive(false);
            buyedImg.gameObject.SetActive(true);
            selectButton.gameObject.SetActive(true);
            buyButton.button.interactable = false;
            advButton.interactable = false;
            //modelSelectButton.interactable = true;
        }
        else
        {
            //modelSelectButton.interactable = false;
            BuyableCheck();
        }

    
    }

    public void Locked()
    {

    }

    void BuyableCheck()
    {
     
        
        if (PlayerPrefs.GetInt("level") >= shopLevel)
        {
            buyButton.gameObject.SetActive(true);
            advButton.gameObject.SetActive(true);
            buyedImg.gameObject.SetActive(false);
            selectButton.gameObject.SetActive(false);
            //modelText.gameObject.SetActive(false);
            lockImage.gameObject.SetActive(false);
            unlockNewMapGO.gameObject.SetActive(false);
            darkImage.gameObject.SetActive(false);

            grayImage.gameObject.SetActive(true);

            advCountText.text = PlayerPrefs.GetInt("adv" + buyButton.id).ToString() + "/" + totalADV_Count.ToString();
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            advButton.gameObject.SetActive(true);
            buyButton.button.interactable = false;
            advButton.interactable = false;
            buyedImg.gameObject.SetActive(false);
            selectButton.gameObject.SetActive(false);
            //modelText.gameObject.SetActive(true);
            lockImage.gameObject.SetActive(true);
            unlockNewMapGO.gameObject.SetActive(true);
            darkImage.gameObject.SetActive(true);

            grayImage.gameObject.SetActive(false);
            //unlockNewMapText.text = "UNLOCK MAP " + (shopLevel + 1).ToString();
        }
    }



    public void ClickADV_Button()
    {
        string adv_name = "Skin_Rewarded";
        ADVManager.Instance.RewardedStart(AdvEnd, adv_name, true);
        AudioManager.Instance.ButtonSound();
    }

    void AdvEnd(bool ticketActive)
    {
        PlayerPrefs.SetInt("adv" + buyButton.id, PlayerPrefs.GetInt("adv" + buyButton.id) + 1);
        advCountText.text = PlayerPrefs.GetInt("adv" + buyButton.id).ToString() + "/" + totalADV_Count.ToString();

        string tag = skinName + PlayerPrefs.GetInt("adv" + buyButton.id).ToString();

        if (ticketActive)
        {
            Analytics.ItemObtained(" Skin_RV", buyButton.id, ItemFlowReason.Progression);
        }
        else
        {
            Analytics.ItemObtained(" Skin_RV", buyButton.id, ItemFlowReason.RewardedVideoAd);
        }

        //GameManager.Instance.HomaAnalyticsTag(tag);

        OpenedCheck();
    }
}
