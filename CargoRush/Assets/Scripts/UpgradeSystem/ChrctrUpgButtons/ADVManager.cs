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
    private void Awake()
    {
        _instance = this;
    }
    public void RewardedStart(Action fnct, string rewardedName)
    {
        rewardedFunction = null;
        rewardedFunction += fnct;


        // kapanacak
        //RewardedEnd();


        //acilacak
        if (HomaBelly.Instance.IsRewardedVideoAdAvailable())
        {
            //// Show ad
            HomaBelly.Instance.ShowRewardedVideoAd(rewardedName);
        }
       
        Events.onRewardedVideoAdRewardedEvent += RewardedEnd;


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




}
