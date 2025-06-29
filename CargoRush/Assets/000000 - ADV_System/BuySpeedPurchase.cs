using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BuySpeedPurchase : MonoBehaviour
{
    public Button buyButton;
    public GameObject purchasedGO;
    public float cost = 1;
    //public TextMeshProUGUI moneyText;
    public TextMeshProUGUI costText;
    private void Start()
    {
        PurchaseBoostManager.Instance.buySpeed = this;
    }
    private void OnEnable()
    {
        //moneyText.text = "x" + moneyAmount.ToString();
        costText.text = "$" + cost.ToString();
        CheckPurchased();
    }
    public void BuySpeedPurchase_Click()
    {
        PurchaseBoostManager.Instance.SpeedBuy(cost, buyButton);
        buyButton.interactable = false;
    }
    public void CheckPurchased()
    {
        if (PlayerPrefs.GetInt("purchasespeedboost") == 0)
        {
            buyButton.gameObject.SetActive(true);
            purchasedGO.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(false);
            purchasedGO.gameObject.SetActive(true);
        }
    }
}
