using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModelButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Button modelSelectButton;
    public Image selectedOutline;
    public Image modelImage;
    public Image grayImage;
    public Image darkImage;
    public Image lockImage;
    public TextMeshProUGUI modelText;
    public BuyButtons buyButton;
    public int shopLevel;
    public int buttonId;
    public bool isFree = false;
    public void SelectClick()
    {
        StarPanelManager.Instance.SelectClick(buttonId);
    }
    public void OpenedCheck()
    {
        if(PlayerPrefs.GetInt("adv" + buyButton.id) == 1 || isFree)
        {
            modelSelectButton.interactable = true;
            modelImage.gameObject.SetActive(true);
            grayImage.gameObject.SetActive(false);
            darkImage.gameObject.SetActive(false);
            modelText.gameObject.SetActive(false);
            lockImage.gameObject.SetActive(false);

            buyButton.gameObject.SetActive(false);
            buyButton.button.interactable = false;
            modelSelectButton.interactable = true;
        }
        else
        {
            modelSelectButton.interactable = false;
            BuyableCheck();
        }

    
    }

    public void Locked()
    {

    }

    void BuyableCheck()
    {
     
        
        if (PlayerPrefs.GetInt("shopindex") >= shopLevel)
        {
            buyButton.gameObject.SetActive(true);
            modelText.gameObject.SetActive(false);
            lockImage.gameObject.SetActive(false);
            darkImage.gameObject.SetActive(false);

            grayImage.gameObject.SetActive(true);

        }
        else
        {
            buyButton.gameObject.SetActive(false);
            modelText.gameObject.SetActive(true);
            lockImage.gameObject.SetActive(false);
            darkImage.gameObject.SetActive(true);

            grayImage.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("shopindex") < shopLevel - 1)
        {
            buyButton.gameObject.SetActive(false);
            modelText.gameObject.SetActive(false);
            lockImage.gameObject.SetActive(true);
            darkImage.gameObject.SetActive(true);

            grayImage.gameObject.SetActive(false);
        }
    }

}
