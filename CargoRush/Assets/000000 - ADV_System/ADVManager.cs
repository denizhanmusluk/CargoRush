using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using HomaGames.HomaBelly;
using TMPro;

public class ADVManager : MonoBehaviour
{
    private static ADVManager _instance = null;
    public static ADVManager Instance => _instance;

    public delegate void RW_Function(bool ticketActive);

    public event RW_Function rewardedFunction;
    public event Action interstialFunction;

    public List<RewardedButton> allRewardedButtons = new List<RewardedButton>();



    [SerializeField] GameObject advNotReadyPanel_GO;
    [SerializeField] List<Image> advNotReadyImg_List;
    [SerializeField] TextMeshProUGUI advNotText;
    bool advNotActive;

    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
        //Events.onInitialized += LoadBanner;


        Check_NoAds_Bundle_Active();
    }
    public void Check_NoAds_Bundle_Active()
    {
        if (PlayerPrefs.GetInt("bundlesnoads") == 0 && PlayerPrefs.GetInt("bundlesnoadslimited") == 0)
        {
            if (PlayerPrefs.GetInt("banneractive") == 1)
            {
                StartCoroutine(BannerShowDelay());
            }
        }
        else
        {
            if (PlayerPrefs.GetInt("bundlesnoads") == 1)
            {
                NoAds();
            }
            if (PlayerPrefs.GetInt("bundlesnoadslimited") == 1)
            {
                NoAdsLimited();
            }
        }
    }
    IEnumerator BannerShowDelay()
    {
        yield return new WaitForSeconds(6);
        LoadBanner();
        Events.onBannerAdLoadedEvent += BannerShow;
    }
    private void OnDisable()
    {
        if (PlayerPrefs.GetInt("bundlesnoads") == 0 && PlayerPrefs.GetInt("bundlesnoadslimited") == 0)
        {
            if (PlayerPrefs.GetInt("banneractive") == 1)
            {
                Events.onBannerAdLoadedEvent -= BannerShow;
            }
        }
    }

    public void RewardedStart(RW_Function fnct, string rewardedName, bool activeTicket)
    {
        rewardedFunction = null;

        if (Globals.gemAmount > 0 && activeTicket)
        {
            rewardedFunction += (_tcktAct) => fnct(true);

            GameManager.Instance.GemUpdate(-1);
            rewardedFunction?.Invoke(true);
        }
        else
        {
            if (HomaBelly.Instance.IsRewardedVideoAdAvailable())
            {
                HomaBelly.Instance.ShowRewardedVideoAd(rewardedName);
                Analytics.RewardedAdSuggested(rewardedName);
            }

            rewardedFunction += (_tcktAct) => fnct(false);

            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                StartCoroutine(AdIsNotAnim());
            }
            else
            {
                Events.onRewardedVideoAdRewardedEvent += RewardedEnd;
            }
        }
        AudioManager.Instance.UpgradeSound();
    }
    private void RewardedEnd(VideoAdReward videoAdReward, AdInfo adInfo)
    {
        rewardedFunction?.Invoke(false);
        Events.onRewardedVideoAdRewardedEvent -= RewardedEnd;
        DayCycleManager.Instance.dayCycleCount = 0;
    }

    public void InterstialStart(Action fnct, string rewardedName)
    {
        interstialFunction = null;
        interstialFunction += fnct;
        
        if (HomaBelly.Instance.IsInterstitialAvailable())
        {
            HomaBelly.Instance.ShowInterstitial(rewardedName);
        }


        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            interstialFunction?.Invoke();
        }
        else
        {
            Events.onInterstitialAdClosedEvent += InterstialEnd;
        }
    }
    private void InterstialEnd(AdInfo adInfo)
    {
        interstialFunction?.Invoke();
        Events.onInterstitialAdClosedEvent -= InterstialEnd;
    }


    public void BannerShow(AdInfo adInfo)
    {
        HomaBelly.Instance.ShowBanner();
    }

    public void NoAds()
    {
        PlayerPrefs.SetInt("bundlesnoads", 1);
        HomaBelly.Instance.HideBanner();
    }
    public void NoAdsLimited()
    {
        PlayerPrefs.SetInt("bundlesnoadslimited", 1);
        HomaBelly.Instance.HideBanner();
    }

    public void HideBanner()
    {
        HomaBelly.Instance.HideBanner();
    }


    private const string BannerPlacementId = "YOUR_PLACEMENT_ID";
    private void LoadBanner()
    {
        HomaBelly.Instance.LoadBanner(BannerSize.BANNER, BannerPosition.BOTTOM);
    }
    IEnumerator AdIsNotAnim()
    {
        float advNotDuration = 4f;
        Color transColorText = new Color(1, 1, 1, 0);
        Color transColorImg = new Color(0, 0, 0, 0);

        Color targetColorText = Color.white;
        Color targetColorImg = Color.black;
        advNotActive = false;
        yield return null;
        advNotActive = true;
        advNotReadyPanel_GO.gameObject.SetActive(true);

        float counter = 0f;
        while(counter < 1f && advNotActive)
        {
            counter += 2 * Time.deltaTime;
            advNotText.color = Color.Lerp(transColorText, targetColorText, counter);
            foreach (var img in advNotReadyImg_List)
            {
                img.color = Color.Lerp(transColorImg, targetColorImg, counter);
            }
            yield return null;
        }

        while(counter < advNotDuration && advNotActive)
        {
            counter += Time.deltaTime;

            yield return null;
        }

        counter = 0f;
        while (counter < 1f && advNotActive)
        {
            counter += 2 * Time.deltaTime;
            advNotText.color = Color.Lerp(targetColorText, transColorText, counter);
            foreach (var img in advNotReadyImg_List)
            {
                img.color = Color.Lerp(targetColorImg, transColorImg, counter);
            }
            yield return null;
        }
        if (advNotActive)
        {
            advNotReadyPanel_GO.gameObject.SetActive(false);
        }
    }
}
