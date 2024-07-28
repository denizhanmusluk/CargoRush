using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BuyCapacity : MonoBehaviour
{
    public Button buyButton;
    public GameObject purchasedGO;
    public float cost = 1;
    //public TextMeshProUGUI moneyText;
    public TextMeshProUGUI costText;
    private void Start()
    {
        PurchaseBoostManager.Instance.buyCapacity = this;
    }
    private void OnEnable()
    {
        //moneyText.text = "x" + moneyAmount.ToString();
        costText.text = "$" + cost.ToString();
        CheckPurchased();
    }
    public void BuyCapacityPurchase_Click()
    {
        PurchaseBoostManager.Instance.CapacityBuy(cost, buyButton);
        buyButton.interactable = false;
    }
    public void CheckPurchased()
    {
        if (PlayerPrefs.GetInt("purchasecapacityboost") == 0)
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
