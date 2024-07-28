using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NoAdsPopUp : MonoBehaviour
{
    public Button buyButton;
    public GameObject purchasedGO;
    public float cost = 1;
    //public TextMeshProUGUI moneyText;
    public TextMeshProUGUI costText;
    private void Start()
    {
        //PurchaseBundlesManager.Instance.noAdsPopUp = this;
    }
    private void OnEnable()
    {
        costText.text = "$" + cost.ToString();
        CheckPurchased();
    }
    public void BuyNoAdsBundles_Click()
    {
        buyButton.interactable = false;
        PurchaseBundlesManager.Instance.NoAdsBuy(cost, buyButton);
        StartCoroutine(CloseDelay());
    }
    IEnumerator CloseDelay()
    {
        yield return new WaitForSeconds(0.1f);
        gameObject.SetActive(false);
    }
    public void CheckPurchased()
    {
        if (PlayerPrefs.GetInt("bundlesnoads") == 0)
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
