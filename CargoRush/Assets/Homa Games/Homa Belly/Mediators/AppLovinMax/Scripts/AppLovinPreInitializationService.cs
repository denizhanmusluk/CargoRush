using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomaGames.HomaBelly
{
    public abstract class AppLovinPreInitializationService
    {
        private string _serviceName;
        public string ServiceName => _serviceName;

        protected static readonly List<AppLovinPreInitializationService> _subscribers = new List<AppLovinPreInitializationService>();
        public static List<AppLovinPreInitializationService> Subscribers => _subscribers;

        protected AppLovinPreInitializationService(string serviceName)
        {
            _serviceName = serviceName;
        }
        
        public abstract void BeforeInitialization();

        public abstract Task BeforeBannerLoad(string bannerAdId);

        public abstract Task BeforeInterstitialLoad(string interstitialAdId);

        public abstract Task BeforeRewardedVideoLoad(string rewardedVideoAdId);
    }
}
