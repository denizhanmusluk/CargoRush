﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using UnityEngine;

// ReSharper disable AccessToStaticMemberViaDerivedType

namespace HomaGames.HomaBelly
{
    public class AppLovinMaxMediator : MediatorBase
    {
        protected override string MediatorPackageName => HomaBellyAppLovinMaxConstants.ID;

        protected override void InternalInitialize()
        {
            if (HomaBellyManifestConfiguration.TryGetString(out var sdkKey, MediatorPackageName , "s_sdk_key") && !string.IsNullOrEmpty(sdkKey))
            {
                foreach (var preInitializationService in AppLovinPreInitializationService.Subscribers)
                {
                    try
                    {
                        HomaGamesLog.Debug($"[Applovin Pre Initialization Service] BeforeInitialization for service: {preInitializationService.ServiceName}");
                        preInitializationService.BeforeInitialization();
                        HomaGamesLog.Debug($"[Applovin Pre Initialization Service] Done for service: {preInitializationService.ServiceName}");
                    }
                    catch (Exception e)
                    {
                        HomaGamesLog.Warning($"[Applovin Pre Initialization Service] Error while executing BeforeInitialization for service: {preInitializationService.ServiceName}. Message: {e.Message}");
                    }
                }
                
                // Initialize AppLovin SDK
                MaxSdkCallbacks.OnSdkInitializedEvent += (MaxSdkBase.SdkConfiguration sdkConfiguration) =>
                {
                    // AppLovin SDK is initialized
                    InvokeOnInitialised();
                };

                MaxSdk.SetSdkKey(sdkKey);
                MaxSdk.InitializeSdk();
            }
            else
            {
                HomaGamesLog.Warning($"[AppLovin Max Mediator] Could not find sdk_key for AppLovin Max");
            }
            
            // Register Ad Revenue Paid Events
            MaxSdkCallbacks.Interstitial.OnAdRevenuePaidEvent += (adUnitId, adInfo)
                => OnMaxAdRevenuePaid(adUnitId, AdType.Interstitial, adInfo);
            MaxSdkCallbacks.Rewarded.OnAdRevenuePaidEvent += (adUnitId, adInfo)
                => OnMaxAdRevenuePaid(adUnitId, AdType.RewardedVideo, adInfo);
            MaxSdkCallbacks.Banner.OnAdRevenuePaidEvent += (adUnitId, adInfo)
                => OnMaxAdRevenuePaid(adUnitId, AdType.Banner, adInfo);
            
            // Banner
            MaxSdkCallbacks.Banner.OnAdClickedEvent += (s, info) => InvokeBannerAdClickedEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Banner.OnAdLoadFailedEvent += (s, info) => InvokeBannerAdLoadFailedEvent(s,(int)info.Code,info.Message);
            MaxSdkCallbacks.Banner.OnAdLoadedEvent += (s,info) => InvokeOnBannerLoadedEvent(GetPlacementId(s,info));

            // Video Ads
            MaxSdkCallbacks.Rewarded.OnAdLoadedEvent += (s,info) => InvokeOnRewardedAdLoadedEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Rewarded.OnAdLoadFailedEvent += (s,error) => InvokeOnRewardedAdFailedEvent(GetPlacementId(s),(int)error.Code,error.Message);
            MaxSdkCallbacks.Rewarded.OnAdDisplayFailedEvent += (s, error, info) => InvokeOnRewardedAdFailedToDisplayEvent(GetPlacementId(s,info),(int)error.Code,error.Message);
            MaxSdkCallbacks.Rewarded.OnAdDisplayedEvent += (s, info) => InvokeOnRewardedAdDisplayedEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Rewarded.OnAdClickedEvent += (s,info) => InvokeOnRewardedAdClickedEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Rewarded.OnAdHiddenEvent += (s, info) => InvokeOnRewardedAdDismissedEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Rewarded.OnAdReceivedRewardEvent += (s, reward, info) => InvokeOnRewardedAdReceivedRewardEvent(GetPlacementId(s,info),new VideoAdReward(reward.Label, reward.Amount));

            // Interstitials
            MaxSdkCallbacks.Interstitial.OnAdClickedEvent +=(s, info) => InvokeOnInterstitialClickedEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Interstitial.OnAdDisplayedEvent += (s, info) => InvokeOnInterstitialShownEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Interstitial.OnAdLoadedEvent += (s, info) => InvokeOnInterstitialLoadedEvent(GetPlacementId(s,info));
            MaxSdkCallbacks.Interstitial.OnAdLoadFailedEvent += (s, error) => InvokeOnInterstitialFailedEvent(GetPlacementId(s),(int)error.Code,error.Message);
            MaxSdkCallbacks.Interstitial.OnAdDisplayFailedEvent += (s, error, info) => InvokeInterstitialFailedToDisplayEvent(GetPlacementId(s,info),(int)error.Code,error.Message);
            MaxSdkCallbacks.Interstitial.OnAdHiddenEvent += (s, info) => InvokeOnInterstitialDismissedEvent(GetPlacementId(s,info));
        }

        protected override bool InternalIsInitialized => MaxSdk.IsInitialized();

        protected override void InternalDestroyBanner(string placementId)
        {
            MaxSdk.DestroyBanner(placementId);
        }

        protected override void InternalHideBanner(string placementId)
        {
            MaxSdk.HideBanner(placementId);
        }

        protected override bool InternalIsInterstitialAvailable(string placementId)
        {
            return MaxSdk.IsInterstitialReady(placementId);
        }

        protected override void InternalSetBannerBackgroundColor(string placement, Color color)
        {
            MaxSdk.SetBannerBackgroundColor(placement,color);
        }

        protected override async void InternalLoadInterstitial(string placement)
        {
            foreach (var preInitializationService in AppLovinPreInitializationService.Subscribers)
            {
                try
                {
                    HomaGamesLog.Debug(
                        $"[Applovin Pre Initialization Service] BeforeInterstitialLoad for service: {preInitializationService.ServiceName}");
                    await preInitializationService.BeforeInterstitialLoad(placement);
                    HomaGamesLog.Debug(
                        $"[Applovin Pre Initialization Service] Done for service: {preInitializationService.ServiceName}");
                }
                catch (Exception e)
                {
                    HomaGamesLog.Warning($"[Applovin Pre Initialization Service] Exception: {e}");
                }
            }
                    
            try        
            {
                MaxSdk.LoadInterstitial(placement);    
            }
            catch (Exception e)
            {
                HomaGamesLog.Warning($"[AppLovin Max Mediator] Exception: {e}");
            }
        }

        protected override int InternalGetBannerHeight(string placement)
        {
            var bannerRect = MaxSdk.GetBannerLayout(placement);
            return DeviceUnitToPixel(bannerRect.height);
        }

        protected override void InternalSetBannerPosition(string placement, BannerPosition bannerPosition)
        {
            MaxSdk.UpdateBannerPosition(placement,GetMaxBannerPosition(bannerPosition));
        }

        private int DeviceUnitToPixel(float dp)
        {
            return Mathf.CeilToInt(dp * MaxSdkUtils.GetScreenDensity());
        }
        
        protected override async void InternalLoadRewardedVideoAd(string placement)
        {
            foreach (var preInitializationService in AppLovinPreInitializationService.Subscribers)
            {
                try
                {
                    HomaGamesLog.Debug($"[Applovin Pre Initialization Service] BeforeRewardedVideoLoad for service: {preInitializationService.ServiceName}");
                    await preInitializationService.BeforeRewardedVideoLoad(placement);
                    HomaGamesLog.Debug($"[Applovin Pre Initialization Service] Done for service: {preInitializationService.ServiceName}");
                }
                catch (Exception e)
                {
                    HomaGamesLog.Warning($"[Applovin Pre Initialization Service] Exception: {e}");
                }
            }

            try
            {
                MaxSdk.LoadRewardedAd(placement);
            }
            catch (Exception e)
            {
                HomaGamesLog.Warning($"[AppLovin Max Mediator] Exception while loading Rewarded Ad: {e}");
            }
        }

        protected override bool InternalIsRewardedVideoAdAvailable(string placementId)
        {
            return MaxSdk.IsRewardedAdReady(placementId);
        }


        private MaxSdkBase.BannerPosition GetMaxBannerPosition(BannerPosition position)
        {
            //No point in leaving the switch statement until new BannerPositions are added...
            return position == BannerPosition.TOP
                ? MaxSdkBase.BannerPosition.TopCenter
                : MaxSdkBase.BannerPosition.BottomCenter;
        }

        protected override async void InternalLoadBanner(BannerSize size, BannerPosition position, string placementId,
            UnityEngine.Color backgroundColor)
        {
            foreach (var preInitializationService in AppLovinPreInitializationService.Subscribers)
            {
                try
                {
                    HomaGamesLog.Debug(
                        $"[Applovin Pre Initialization Service] BeforeBannerLoad for service: {preInitializationService.ServiceName}");
                    await preInitializationService.BeforeBannerLoad(placementId);
                    HomaGamesLog.Debug(
                        $"[Applovin Pre Initialization Service] Done for service: {preInitializationService.ServiceName}");
                }
                catch (Exception e)
                {
                    HomaGamesLog.Warning($"[Applovin Pre Initialization Service] Exception: {e}");
                }
            }
                 
            try
            {
                MaxSdk.CreateBanner(placementId, GetMaxBannerPosition(position));
                MaxSdk.SetBannerExtraParameter(placementId, "adaptive_banner", "true");

                // If background color is WHITE with ALPHA to 0f, do not set it so it
                // will be fully transparent (no background at all)
                if (backgroundColor != new Color(1f, 1f, 1f, 0f))
                {
                    MaxSdk.SetBannerBackgroundColor(placementId, backgroundColor);
                }  
            }            
            catch (Exception e)
            {
                HomaGamesLog.Warning($"[Applovin Pre Initialization Service] Exception: {e}");
            }
        }

        public override void OnApplicationPause(bool pause)
        {
            // NO-OP
        }

        public override void SetUserIsAboveRequiredAge(bool consent)
        {
            MaxSdk.SetIsAgeRestrictedUser(!consent);
        }

        public override void SetTermsAndConditionsAcceptance(bool consent)
        {
            // NO-OP
        }

        public override void SetAnalyticsTrackingConsentGranted(bool consent)
        {
            // NO-OP
        }

        public override void SetTailoredAdsConsentGranted(bool consent)
        {
            MaxSdk.SetHasUserConsent(consent);
        }

        protected override void InternalShowBanner(string placementId)
        {
            MaxSdk.ShowBanner(placementId);
        }

        protected override void InternalShowInterstitial(string placementId)
        {
            MaxSdk.ShowInterstitial(placementId);
        }

        protected override void InternalShowRewardedVideoAd(string placementId)
        {
            MaxSdk.ShowRewardedAd(placementId);
        }

        public override void ValidateIntegration()
        {
            // Show Mediation Debugger
            MaxSdk.ShowMediationDebugger();
        }

        #region Private helpers

        /// <summary>
        /// Callback invoked for ULRD
        /// </summary>
        /// <param name="adUnitId"></param>
        /// <param name="adType"></param>
        /// <param name="adInfo"></param>
        private void OnMaxAdRevenuePaid(string adUnitId, AdType adType, MaxSdkBase.AdInfo adInfo)
        {
            AdRevenueData data = new AdRevenueData
            {
                AdUnitId = adUnitId,
                AdPlatform = "AppLovin",
                Currency = "USD"
            };

            if (adInfo.Revenue == -1)
            {
                data.Revenue = 0;
                data.Precision = "error";
            }
            else
            {
                data.Revenue = Convert.ToDouble(adInfo.Revenue, CultureInfo.InvariantCulture);
                data.Precision = adInfo.RevenuePrecision;
            }

            data.AdUnitId = adInfo.AdUnitIdentifier;
            data.NetworkName = adInfo.NetworkName;
            data.AdPlacamentName = adInfo.Placement;

            InvokeOnAdRevenuePaidEvent(adUnitId,adType,data);
        }

        #endregion

        private string GetPlacementId(string message, MaxSdkBase.AdInfo adInfo = null)
        {
            if (adInfo != null && !string.IsNullOrEmpty(adInfo.AdUnitIdentifier))
                return adInfo.AdUnitIdentifier;
            return message;
        }
    }
}