using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using HomaGames.HomaBelly;

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
    public void RewardedStart(Action fnct)
    {
        rewardedFunction = null;
        rewardedFunction += fnct;


        // kapanacak
        RewardedEnd();


        //acilacak
        //if (HomaBelly.Instance.IsRewardedVideoAdAvailable())
        //{
        //    //// Show ad
        //    HomaBelly.Instance.ShowRewardedVideoAd("rewarded_ad");
        //}
        //HomaBelly.Instance.onRewardedVideoAdRewardedEvent += RewardedEnd;

    }
    private void RewardedEnd()
    {
        rewardedFunction?.Invoke();
    }

    public void InterstialStart(Action fnct)
    {
        interstialFunction = null;
        interstialFunction += fnct;
        InterstialEnd();
    }
    private void InterstialEnd()
    {
        interstialFunction?.Invoke();
    }




}
