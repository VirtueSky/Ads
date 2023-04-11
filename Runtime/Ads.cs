using System;

namespace Virtuesky.Ads
{
    public abstract class Ads : IAd
    {
        public abstract AdNetWork NetWork { get; }
        public abstract void InitAds();
        public abstract bool IsInitialized();
        public abstract void InitBannerAds();
        public abstract void LoadBannerAds();
        public abstract void ShowBannerAds();
        public abstract void HideBannerAds();
        public abstract event Action OnInterstitialAdCompleted;
        public abstract void InitInterAds();
        public abstract void LoadInterAds();
        public abstract bool IsInterAdsReady();
        public abstract void ShowInterAds();
        public abstract event Action OnRewardedAdSkipped;
        public abstract event Action OnRewardedAdCompleted;
        public abstract void InitRewardAds();
        public abstract void LoadRewardAds();
        public abstract bool IsRewardAdsReady();
        public abstract void ShowRewardAds();
        public abstract event Action OnRewardedInterstitialAdSkipped;
        public abstract event Action OnRewardedInterstitialAdCompleted;
        public abstract void InitRewardedInterstitialAds();
        public abstract void LoadRewardedInterstitialAds();
        public abstract bool IsRewardedInterstitialAdReady();
        public abstract void ShowRewardedInterstitialAds();
        public abstract event Action OnAppOpenAdCompleted;
        public abstract void InitAppOpenAds();
        public abstract void LoadAppOpenAds();
        public abstract bool IsAppOpenAdsReady();
        public abstract void ShowAppOpenAds();
    }
}