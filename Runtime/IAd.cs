using System;

namespace Virtuesky.Ads
{
    public interface IAd
    {
        AdNetWork NetWork { get; }
        void InitAds();
        bool IsInitialized();

        #region Banner Ads

        void InitBannerAds();
        void LoadBannerAds();
        void ShowBannerAds();
        void HideBannerAds();

        #endregion

        #region Inter Ads

        event Action OnInterstitialAdCompleted;
        void InitInterAds();
        void LoadInterAds();
        bool IsInterAdsReady();
        void ShowInterAds();

        #endregion

        #region Reward Ads

        event Action OnRewardedAdSkipped;
        event Action OnRewardedAdCompleted;
        void InitRewardAds();
        void LoadRewardAds();
        bool IsRewardAdsReady();
        void ShowRewardAds();

        #endregion

        #region Rewarded interstitital ads

        event Action OnRewardedInterstitialAdSkipped;
        event Action OnRewardedInterstitialAdCompleted;
        void InitRewardedInterstitialAds();
        void LoadRewardedInterstitialAds();
        bool IsRewardedInterstitialAdReady();
        void ShowRewardedInterstitialAds();

        #endregion

        #region App Open Ads

        event Action OnAppOpenAdCompleted;
        void InitAppOpenAds();
        void LoadAppOpenAds();
        bool IsAppOpenAdsReady();
        void ShowAppOpenAds();

        #endregion
    }
}