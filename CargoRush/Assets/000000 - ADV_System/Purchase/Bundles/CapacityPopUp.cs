using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CapacityPopUp : MonoBehaviour
{
    public Button buyButton;
    public GameObject purchasedGO;
    public float cost = 1;
    //public TextMeshProUGUI moneyText;
    public TextMeshProUGUI costText;
    private void Start()
    {

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
        StartCoroutine(CloseDelay());
    }
    IEnumerator CloseDelay()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
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
