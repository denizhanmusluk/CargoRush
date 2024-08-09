using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayCycleManager : MonoBehaviour
{
    private static DayCycleManager _instance = null;
    public static DayCycleManager Instance => _instance;
    public bool IS_Active = true;
    // Start is called before the first frame update
    [SerializeField] int firstInterstialTime = 900;
    [SerializeField] int firstInterstialTimeCounter = 0;

    [SerializeField] int dayCyclePeriod = 180;
    public int dayCycleCount = 0;
    public GameObject dayPanel_GO;
    public GameObject sun;
    public GameObject moon;
    public Image dayFill;

    public string SavedDateKey = "SavedDate";

    private void Awake()
    {
        _instance = this;
        CheckIf24HoursPassed();
    }
    void Start()
    {
        //if (PlayerPrefs.GetInt("bundlesnoads") == 0 && PlayerPrefs.GetInt("bundlesnoadslimited") == 0)
        {
            if (PlayerPrefs.GetInt("firstInterstialTimeCompleted") == 0)
            {
                StartCoroutine(FirstQuarterCounter());
            }
            else
            {
                StartCoroutine(DayCycleCounter());
            }
        }
        StartCoroutine(TimeLapsCheck_24HoursPassed());
        if(PlayerPrefs.GetInt("level") > 0 && Globals.loadingPanelActive)
        {
            if (PlayerPrefs.GetInt("bundlesnoads") == 0 && PlayerPrefs.GetInt("bundlesnoadslimited") == 0)
            {
                PurchaseManager.Instance.NoAdsLimited_PopUp_Open();
            }
        }
    }
    IEnumerator FirstQuarterCounter()
    {
        //FishDropArea.Instance.loadingAreaTextGO.SetActive(true);

        firstInterstialTimeCounter = PlayerPrefs.GetInt("firstInterstialTimeCounter");

        while (firstInterstialTimeCounter < firstInterstialTime)
        {
            firstInterstialTimeCounter++;
            PlayerPrefs.SetInt("firstInterstialTimeCounter", firstInterstialTimeCounter);

            if ( PlayerPrefs.GetInt("banneractive") == 0 && firstInterstialTimeCounter >= 180 && PlayerPrefs.GetInt("bundlesnoads") == 0 && PlayerPrefs.GetInt("bundlesnoadslimited") == 0)
            {
                ADVManager.Instance.BannerShow();
                PlayerPrefs.SetInt("banneractive", 1);
            }

            yield return new WaitForSeconds(1);
        }
        PlayerPrefs.SetInt("firstInterstialTimeCompleted", 1);

        if (PlayerPrefs.GetInt("bundlesnoads") == 0 && PlayerPrefs.GetInt("bundlesnoadslimited") == 0 && IS_Active)
        {
            StartCoroutine(AdvShow());
        }
        else
        {
            DayCycleRestart();
        }
    }
    IEnumerator DayCycleCounter()
    {

        dayPanel_GO.SetActive(true);
        dayCycleCount = PlayerPrefs.GetInt("dayCycleCount");

        while (dayCycleCount < dayCyclePeriod)
        {
            dayCycleCount++;
            PlayerPrefs.SetInt("dayCycleCount", dayCycleCount);
            dayFill.fillAmount = (float)dayCycleCount / (float)dayCyclePeriod;
            if (dayCycleCount < dayCyclePeriod / 2)
            {
                sun.gameObject.SetActive(true);
                moon.gameObject.SetActive(false);
            }
            else
            {
                sun.gameObject.SetActive(false);
                moon.gameObject.SetActive(true);
            }
            yield return new WaitForSeconds(1);
        }
        if (PlayerPrefs.GetInt("bundlesnoads") == 0 && PlayerPrefs.GetInt("bundlesnoadslimited") == 0 && IS_Active)
        {
            StartCoroutine(AdvShow());
        }
        else
        {
            DayCycleRestart();
        }
    }

    IEnumerator AdvShow()
    {
        TutorialManager.Instance.lunch_Break.SetActive(true);
        yield return new WaitForSeconds(3f);
        Fade.Instance.Hide();
        yield return new WaitForSeconds(0.5f);
        ADVManager.Instance.InterstialStart(AdvCompleted, "interstial");
    }
    void AdvCompleted()
    {
        dayCycleCount = 0;
        PlayerPrefs.SetInt("dayCycleCount", dayCycleCount);
        StartCoroutine(DayCycleCounter());
        Fade.Instance.Show();
        if (PlayerPrefs.GetInt("iscount") % 10 == 0)
        {
            PurchaseManager.Instance.NoAds_PopUp_Open();
        }
        PlayerPrefs.SetInt("iscount", PlayerPrefs.GetInt("iscount") + 1);
    }
    void DayCycleRestart()
    {
        dayCycleCount = 0;
        PlayerPrefs.SetInt("dayCycleCount", dayCycleCount);
        StartCoroutine(DayCycleCounter());
    }





    IEnumerator TimeLapsCheck_24HoursPassed()
    {
        while (true)
        {
            CheckIf24HoursPassed();
            yield return new WaitForSeconds(10);
        }
    }
    public void CheckIf24HoursPassed()
    {
        // Kaydedilen tarihi al
        if (PlayerPrefs.HasKey(SavedDateKey))
        {
            string savedDateString = PlayerPrefs.GetString(SavedDateKey);
            DateTime savedDate = DateTime.Parse(savedDateString);

            DateTime currentDate = DateTime.Now;

            TimeSpan timeDifference = currentDate - savedDate;

            if (timeDifference.TotalHours >= 24)
            {
                Debug.Log("24 saat geçti!");
                PlayerPrefs.SetInt("bundlesnoadslimited", 0);
                PlayerPrefs.DeleteKey(SavedDateKey);
                PlayerPrefs.Save();
                ADVManager.Instance.Check_NoAds_Bundle_Active();
            }
            else
            {
                Debug.Log("24 saat geçmedi.");
            }
        }
        else
        {
            Debug.Log("Kayýtlý tarih bulunamadý.");
        }
    }
}
