using System;
using System.Runtime.InteropServices;
using HomaGames.HomaBelly;
using HomaGames.HomaBelly.DataPrivacy;
using UnityEngine;
using UnityEngine.iOS;

namespace HomaGames.AdNetworks.AppLovinFacebookAdapter
{
    internal static class FacebookAppTrackingTransparencyManager
    {
        [RuntimeInitializeOnLoadMethod]
        private static void Init()
        {
            PrivacyInformation.AttAuthorizationStatusChanged += SetAdvertiserTrackingFlag;
            SetAdvertiserTrackingFlag(PrivacyInformation.AttAuthorizationStatus);
        }

        [DllImport("__Internal")]
        // ReSharper disable once InconsistentNaming
        private static extern void FBAdSettingsBridgeSetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled);

        private static void SetAdvertiserTrackingFlag(AttAuthorizationStatus attAuthorizationStatus)
        {
            if (Application.platform != RuntimePlatform.IPhonePlayer)
                return;
            if (!IsAttFlagRequired())
            {
                HomaGamesLog.Debug(
                    $"FacebookAudienceNetwork ATE Flag not required due to iOS version: {Device.systemVersion}");
                return;
            }

            var advertiserTrackingEnabled = attAuthorizationStatus == AttAuthorizationStatus.Authorized;
            HomaGamesLog.Debug($"Setting FacebookAudienceNetwork ATE Flag to: {advertiserTrackingEnabled}");

            FBAdSettingsBridgeSetAdvertiserTrackingEnabled(advertiserTrackingEnabled);
        }

        private static bool IsAttFlagRequired()
        {
            var currentVersion = new Version(Device.systemVersion);
            var ios14 = new Version("14.0");

            // FAN AM confirmed we should inform ATE flag starting with iOS 14.0
            // otherwise FAN will default it to false
            return currentVersion >= ios14;
        }
    }
}