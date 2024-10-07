using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using HomaGames.HomaBelly;

public enum DailyType
{
    Money,
    Ticket
}
public class DailyRewarded : MonoBehaviour
{
    public DailyType _dailyType;
    public string dailyRewardedTag;
    public string dailyRewardedName;
    public int maxRewardedCount = 5;
    public int[] moneyRewardedAmounts;
    public TextMeshProUGUI advCountText;
    public TextMeshProUGUI moneyAmountText;
    public Button advButton;
    [SerializeField] GameObject advImage_GO;
    [SerializeField] GameObject free_GO;
    private void OnEnable()
    {
        switch (_dailyType)
        {
            case DailyType.Money:
                {
                    moneyAmountText.text = "$" + moneyRewardedAmounts[PlayerPrefs.GetInt("level")].ToString();
                }
                break;
            case DailyType.Ticket:
                {

                }
                break;
        }

        CheckAndSaveDate();
        RemainingCheck();
    }
    void CheckAndSaveDate()
    {
        System.DateTime date = System.DateTime.Now;
        string tarih = date.ToString("dd/MM/yyyy");

        //Debug.Log("kayitliTarih " + PlayerPrefs.GetString("kayitliTarih") + "  " + tarih);

        if (PlayerPrefs.GetString("kayitliTarih" + dailyRewardedName) != tarih + dailyRewardedName)
        {
            PlayerPrefs.SetString("kayitliTarih" + dailyRewardedName, tarih + dailyRewardedName);
            PlayerPrefs.SetInt(dailyRewardedName, 0);
        }


        PlayerPrefs.Save();
    }
    void RemainingCheck()
    {
        if(PlayerPrefs.GetInt(dailyRewardedName) < maxRewardedCount)
        {
            AdvButtonActive();
        }
        else
        {
            AdvButtonPassive();
        }
    }
    void AdvButtonActive()
    {
        advButton.interactable = true;
        advCountText.text = (maxRewardedCount - PlayerPrefs.GetInt(dailyRewardedName)).ToString() + "/" + maxRewardedCount.ToString();

        switch (_dailyType)
        {
            case DailyType.Money:
                {
                    if (PlayerPrefs.GetInt("firstdailyrewarded") == 0)
                    {
                        advImage_GO.SetActive(false);
                        free_GO.SetActive(true);
                    }
                    else
                    {
                        advImage_GO.SetActive(true);
                        free_GO.SetActive(false);
                    }
                }
                break;
            case DailyType.Ticket:
                {
                    advImage_GO.SetActive(true);
                    free_GO.SetActive(false);
                }
                break;
        }
  
    }
    void AdvButtonPassive()
    {
        advButton.interactable = false;
        advCountText.text = (maxRewardedCount - PlayerPrefs.GetInt(dailyRewardedName)).ToString() + "/" + maxRewardedCount.ToString();
    }
    public void ClickADV_Button()
    {
        string adv_name = dailyRewardedTag;
        AudioManager.Instance.ButtonSound();
        AdvButtonPassive();


        switch (_dailyType)
        {
            case DailyType.Money:
                {
                    if (PlayerPrefs.GetInt("firstdailyrewarded") == 0)
                    {
                        AdvEnd(true);
                    }
                    else
                    {
                        ADVManager.Instance.RewardedStart(AdvEnd, adv_name,false);
                    }
                }
                break;
            case DailyType.Ticket:
                {
                    ADVManager.Instance.RewardedStart(AdvEnd, adv_name , false);
                }
                break;
        }



    }
    void AdvEnd(bool ticketActive)
    {
        bool rewardedActive = false;
        if (PlayerPrefs.GetInt("firstclickdailyrew") > 0)
        {
            rewardedActive = true;
            if (ticketActive)
            {
                Analytics.ItemObtained(" DailyRewarded", 0, ItemFlowReason.Progression);
                Analytics.ItemConsumed(" DailyRewarded", 0, ItemFlowReason.Progression);
            }
            else
            {
                Analytics.ItemObtained(" DailyRewarded", 0, ItemFlowReason.RewardedVideoAd);
                Analytics.ItemConsumed(" DailyRewarded", 0, ItemFlowReason.RewardedVideoAd);
            }

        }

        PlayerPrefs.SetInt("firstclickdailyrew", 1);

        switch (_dailyType)
        {
            case DailyType.Money:
                {
                    PlayerPrefs.SetInt("firstdailyrewarded", 1);
                    GameManager.Instance.ui.MoneyCreateDailyRewarded(moneyRewardedAmounts[PlayerPrefs.GetInt("level")], transform.position, rewardedActive);

                }
                break;
            case DailyType.Ticket:
                {
                    GameManager.Instance.ui.TicketCreateDailyRewarded(moneyRewardedAmounts[PlayerPrefs.GetInt("level")], transform.position, rewardedActive);

                }
                break;
        }


        PlayerPrefs.SetInt(dailyRewardedName, PlayerPrefs.GetInt(dailyRewardedName) + 1);
        advCountText.text = (maxRewardedCount - PlayerPrefs.GetInt(dailyRewardedName)).ToString() + "/" + maxRewardedCount.ToString();
        StartCoroutine(ButtonActivatorDelay());

        PurchaseManager.Instance.PurchasePanelClose();

    }
    IEnumerator ButtonActivatorDelay()
    {
        yield return new WaitForSeconds(2f);
        RemainingCheck();
    }
}
