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
        if(PlayerPrefs.GetInt("isbannerdisable") == 0)
        {
            BannerShow();
        }
        else
        {
            BannerHide();
        }
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


    void BannerShow()
    {
        HomaBelly.Instance.ShowBanner();
    }

    public void BannerHide()
    {
        PlayerPrefs.SetInt("purchasebanneris", 1);
        HomaBelly.Instance.HideBanner();
    }
}
