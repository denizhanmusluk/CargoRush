using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using HomaGames.HomaBelly;

public class ADVManager : MonoBehaviour
{
    private static ADVManager _instance = null;
    public static ADVManager Instance => _instance;

    public event Action rewardedFunction;
    public event Action interstialFunction;

    public List<RewardedButton> allRewardedButtons = new List<RewardedButton>();
    private void Awake()
    {
        _instance = this;
    }
    private void Start()
    {
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
        BannerShow();
    }
    public void RewardedStart(Action fnct, string rewardedName)
    {
        rewardedFunction = null;
        rewardedFunction += fnct;

        if (Globals.gemAmount > 0)
        {
            GameManager.Instance.ui.GemUpdate(-1);
            rewardedFunction?.Invoke();
        }
        else
        {
            if (HomaBelly.Instance.IsRewardedVideoAdAvailable())
            {
                HomaBelly.Instance.ShowRewardedVideoAd(rewardedName);
            }

            Events.onRewardedVideoAdRewardedEvent += RewardedEnd;
        }
        AudioManager.Instance.UpgradeSound();
    }
    private void RewardedEnd(VideoAdReward videoAdReward, AdInfo adInfo)
    {
        rewardedFunction?.Invoke();
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
        Events.onInterstitialAdClosedEvent += InterstialEnd;
    }
    private void InterstialEnd(AdInfo adInfo)
    {
        interstialFunction?.Invoke();
        Events.onInterstitialAdClosedEvent -= InterstialEnd;
    }


    public void BannerShow()
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
}
