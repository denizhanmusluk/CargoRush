using UnityEditor;
using System;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

#if UNITY_IOS
using UnityEditor.Callbacks;
#endif

namespace HomaGames.HomaBelly
{
    /// <summary>
    /// Postprocessor executed upon iOS build. It fetches any
    /// configuration from servers and applies it to the build:
    /// 
    /// - List of SkAdNetwork IDs to be added to Info.plist
    /// </summary>
    public class AppLovinAmazonPostProcessBuild : IPreprocessBuildWithReport
    {
        private static readonly List<string> DynamicLibrariesToEmbed = new List<string>
        {
            "DTBiOSSDK.xcframework"
        };

        public int callbackOrder => 0;

        public void OnPreprocessBuild(BuildReport report)
        {
            AppLovinSettings.Instance.AddApsSkAdNetworkIds = true;
        }
        
#if UNITY_IOS
        [InitializeOnLoadMethod]
        public static void ConfigureMinimumRequirediOSTargetVersion()
        {
            // Minimum target OS version required is 12.5 for Amazon SDK
            if (Version.Parse(PlayerSettings.iOS.targetOSVersionString) < Version.Parse("12.5"))
            {
                PlayerSettings.iOS.targetOSVersionString = "12.5";    
            }
        }
        
        [PostProcessBuild(int.MaxValue)]
        public static void OnPostprocessBuild(BuildTarget buildTarget, string buildPath)
        {
            iOSPlistUtils.AppendAdNetworkIds(buildTarget, buildPath, new string[] {"p78axxw29g.skadnetwork"});
        }
#endif
    }
}
