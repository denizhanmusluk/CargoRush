using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AmazonAds;
using UnityEditor;
using UnityEngine;

namespace HomaGames.HomaBelly
{
    public class AmazonPreInitializationService : AppLovinPreInitializationService
    {
        private readonly Dictionary<string, bool> _interstitialFirstLoadRequested = new Dictionary<string, bool>();
        private readonly Dictionary<string, bool> _rewardedVideoFirstLoadRequested = new Dictionary<string, bool>();
        private bool _initialized = false;
        
        [RuntimeInitializeOnLoadMethod]
        static void Subscribe()
        {
            HomaGamesLog.Debug("[Amazon Pre Initialization Service] Subscribing Service");
            _subscribers.Add(new AmazonPreInitializationService());
        }

        private AmazonPreInitializationService() : base("amazon_ad_network") { }
        
        public override void BeforeInitialization()
        {
        
            string path = "s_android_app_id";
#if UNITY_IOS
            path = "s_ios_app_id";
#endif
            if (HomaBellyManifestConfiguration.TryGetString(out var appId, AppLovinAmazonAdapterConstants.ID, path))
            {
                if (string.IsNullOrEmpty(appId))
                {
                    HomaGamesLog.Warning("[Amazon Pre Initialization Service] Amazon App ID is empty. Skipping initialization...");
                    return;
                }
                
                Amazon.Initialize(appId);
                Amazon.SetAdNetworkInfo(new AdNetworkInfo(DTBAdNetwork.MAX));
            
#if HOMA_DEVELOPMENT
                Amazon.EnableLogging(true);
                Amazon.EnableTesting(true); // Make sure to take this off when going live.
#endif
            
#if UNITY_IOS
                Amazon.SetAPSPublisherExtendedIdFeatureEnabled(true);
#endif
                _initialized = true;
                HomaGamesLog.Debug("[Amazon Pre Initialization Service] Initialized");
            }
            else
            {
                HomaGamesLog.Debug("[Amazon Pre Initialization Service] Could not find Amazon App ID in manifest. Skipping initialization...");
            }
        }
        
        public override async Task BeforeBannerLoad(string bannerAdId)
        {
            string path = "s_android_banner_ad_unit_id";
            #if UNITY_IOS
            path = "s_ios_banner_ad_unit_id";
            #endif

            if (HomaBellyManifestConfiguration.TryGetString(out var bannerId, AppLovinAmazonAdapterConstants.ID, path))
            {
                if (string.IsNullOrEmpty(bannerId))
                {
                    HomaGamesLog.Warning("[Amazon Pre Initialization Service] Amazon Banner Ad Unit ID is empty. Skipping load...");
                    return;
                }
                
                HomaGamesLog.Debug($"[Amazon Pre Initialization Service] Loading banner {bannerAdId}...");
                APSBannerAdRequest bannerAdRequest = new APSBannerAdRequest(320, 50, bannerId);
                AmazonMaxAdResponse amazonMaxAdResponse = await ExecuteAmazonAdRequest(bannerAdRequest);
                if (amazonMaxAdResponse != null)
                {
                    if (amazonMaxAdResponse.AdError != null)
                    {
                        MaxSdk.SetBannerLocalExtraParameter(bannerAdId, "amazon_ad_error", amazonMaxAdResponse.AdError.GetAdError());
                    }
                    else if (amazonMaxAdResponse.AdResponse != null)
                    {
                        MaxSdk.SetBannerLocalExtraParameter(bannerAdId, "amazon_ad_response", amazonMaxAdResponse.AdResponse.GetResponse());
                    }
                }
            }
            else
            {
                HomaGamesLog.Debug("[Amazon Pre Initialization Service] Cannot find banner ad unit id in manifest. Skipping load...");
            }
        }

        public override async Task BeforeInterstitialLoad(string interstitialAdId)
        {            
            // Only execute ad request first time
            if (!ShouldRequestToLoadAdId(_interstitialFirstLoadRequested, interstitialAdId) || !_initialized) return;
            _interstitialFirstLoadRequested.Add(interstitialAdId, true);
            
            string path = "s_android_interstitial_ad_unit_id";
#if UNITY_IOS
            path = "s_ios_interstitial_ad_unit_id";
#endif
            
            if (HomaBellyManifestConfiguration.TryGetString(out var interstitialId, AppLovinAmazonAdapterConstants.ID, path))
            {
                if (string.IsNullOrEmpty(interstitialId))
                {
                    HomaGamesLog.Warning("[Amazon Pre Initialization Service] Amazon Interstitial Ad Unit ID is empty. Skipping load...");
                    return;
                }
                
                HomaGamesLog.Debug($"[Amazon Pre Initialization Service] Loading interstitial {interstitialAdId}...");
                APSVideoAdRequest interstitialAdRequest = new APSVideoAdRequest(320, 480, interstitialId);
                AmazonMaxAdResponse amazonMaxAdResponse = await ExecuteAmazonAdRequest(interstitialAdRequest);
                if (amazonMaxAdResponse != null)
                {
                    if (amazonMaxAdResponse.AdError != null)
                    {
                        MaxSdk.SetInterstitialLocalExtraParameter(interstitialAdId, "amazon_ad_error", amazonMaxAdResponse.AdError.GetAdError());
                    }
                    else if (amazonMaxAdResponse.AdResponse != null)
                    {
                        MaxSdk.SetInterstitialLocalExtraParameter(interstitialAdId, "amazon_ad_response", amazonMaxAdResponse.AdResponse.GetResponse());
                    }
                }
            }
            else
            {
                HomaGamesLog.Debug("[Amazon Pre Initialization Service] Cannot find interstitial ad unit id in manifest. Skipping load...");
            }
        }
        
        public override async Task BeforeRewardedVideoLoad(string rewardedVideoAdId)
        {
            // Only execute ad request first time
            if (!ShouldRequestToLoadAdId(_rewardedVideoFirstLoadRequested, rewardedVideoAdId) || !_initialized) return;
            _rewardedVideoFirstLoadRequested.Add(rewardedVideoAdId, true);

            string path = "s_android_rewarded_video_ad_unit_id";
#if UNITY_IOS
            path = "s_ios_rewarded_video_ad_unit_id";
#endif
            
            if (HomaBellyManifestConfiguration.TryGetString(out var rewardedVideoId, AppLovinAmazonAdapterConstants.ID, path))
            {
                if (string.IsNullOrEmpty(rewardedVideoId))
                {
                    HomaGamesLog.Warning("[Amazon Pre Initialization Service] Amazon Rewarded Video Ad Unit ID is empty. Skipping load...");
                    return;
                }
                
                HomaGamesLog.Debug($"[Amazon Pre Initialization Service] Loading rewarded video {rewardedVideoAdId}...");
                APSVideoAdRequest rewardedVideoAdRequest = new APSVideoAdRequest(320, 480, rewardedVideoId);
                AmazonMaxAdResponse amazonMaxAdResponse = await ExecuteAmazonAdRequest(rewardedVideoAdRequest);
                if (amazonMaxAdResponse != null)
                {
                    if (amazonMaxAdResponse.AdError != null)
                    {
                        MaxSdk.SetRewardedAdLocalExtraParameter(rewardedVideoAdId, "amazon_ad_error", amazonMaxAdResponse.AdError.GetAdError());
                    }
                    else if (amazonMaxAdResponse.AdResponse != null)
                    {
                        MaxSdk.SetRewardedAdLocalExtraParameter(rewardedVideoAdId, "amazon_ad_response", amazonMaxAdResponse.AdResponse.GetResponse());
                    }
                }
            }
            else
            {
                HomaGamesLog.Debug("[Amazon Pre Initialization Service] Cannot find rewarded video ad unit id in manifest. Skipping load...");
            }
        }

        /// <summary>
        /// Determines if a given AdID has already been requested to load. Amazon Ad Network
        /// requires to load ads only the very first time.
        /// </summary>
        /// <param name="targetDictionary"></param>
        /// <param name="adId"></param>
        /// <returns></returns>
        private bool ShouldRequestToLoadAdId(Dictionary<string, bool> targetDictionary, string adId)
        {
            if (targetDictionary.TryGetValue(adId, out bool alreadyRequested))
            {
                return false;
            }

            return true;
        }
        
        private class AmazonMaxAdResponse
        {
            public AmazonAds.AdError AdError;
            public AmazonAds.AdResponse AdResponse;
        }

        private async Task<AmazonMaxAdResponse> ExecuteAmazonAdRequest(AdRequest adRequest)
        {
            HomaGamesLog.Debug($"[Amazon Pre Initialization Service] Executing AdRequest: {adRequest.GetType()}");
            
            TaskCompletionSource<AmazonMaxAdResponse> taskCompletionSource = new TaskCompletionSource<AmazonMaxAdResponse>();
            AmazonMaxAdResponse amazonMaxAdResponse = new AmazonMaxAdResponse();
            
            adRequest.onFailedWithError += (adError) =>
            {
                HomaGamesLog.Debug($"[Amazon Pre Initialization Service] Ad load error: {adError.GetMessage()}");
                amazonMaxAdResponse.AdError = adError;
                taskCompletionSource.SetResult(amazonMaxAdResponse);
            };
            adRequest.onSuccess += (adResponse) =>
            {
                
                HomaGamesLog.Debug("[Amazon Pre Initialization Service] Ad load succeed");
                amazonMaxAdResponse.AdResponse = adResponse;
                taskCompletionSource.SetResult(amazonMaxAdResponse);
            };

            adRequest.LoadAd();
            
            return await taskCompletionSource.Task;
        }
    }
}
