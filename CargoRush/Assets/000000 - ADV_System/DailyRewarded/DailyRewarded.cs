using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DailyRewarded : MonoBehaviour
{
    public string dailyRewardedTag;
    public string dailyRewardedName;
    public int maxRewardedCount = 5;
    public int[] moneyRewardedAmounts;
    public TextMeshProUGUI advCountText;
    public Button advButton;
    [SerializeField] GameObject advImage_GO;
    [SerializeField] GameObject free_GO;
    private void OnEnable()
    {
        CheckAndSaveDate();
        RemainingCheck();
    }
    void CheckAndSaveDate()
    {
        System.DateTime date = System.DateTime.Now;
        string tarih = date.ToString("dd/MM/yyyy");

        Debug.Log("kayitliTarih " + PlayerPrefs.GetString("kayitliTarih") + "  " + tarih);

        if (PlayerPrefs.GetString("kayitliTarih") != tarih)
        {
            PlayerPrefs.SetString("kayitliTarih", tarih);
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
    void AdvButtonPassive()
    {
        advButton.interactable = false;
        advCountText.text = (maxRewardedCount - PlayerPrefs.GetInt(dailyRewardedName)).ToString() + "/" + maxRewardedCount.ToString();
    }
    public void ClickADV_Button()
    {
        string adv_name = dailyRewardedTag + "_REWARDED";
        AudioManager.Instance.ButtonSound();
        AdvButtonPassive();

        if (PlayerPrefs.GetInt("firstdailyrewarded") == 0)
        {
            AdvEnd();
        }
        else
        {
            ADVManager.Instance.RewardedStart(AdvEnd, adv_name);
        }
    }
    void AdvEnd()
    {
        PlayerPrefs.SetInt("firstdailyrewarded", 1);
        PlayerPrefs.SetInt(dailyRewardedName, PlayerPrefs.GetInt(dailyRewardedName) + 1);
        advCountText.text = (maxRewardedCount - PlayerPrefs.GetInt(dailyRewardedName)).ToString() + "/" + maxRewardedCount.ToString();
        GameManager.Instance.ui.MoneyCreateDailyRewarded(moneyRewardedAmounts[PlayerPrefs.GetInt("level")], transform.position);
        StartCoroutine(ButtonActivatorDelay());
    }
    IEnumerator ButtonActivatorDelay()
    {
        yield return new WaitForSeconds(2f);
        RemainingCheck();
    }
}
