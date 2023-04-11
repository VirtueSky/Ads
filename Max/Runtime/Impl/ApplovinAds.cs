using System;

namespace Virtuesky.Ads
{
    public class ApplovinAds : IAd
    {
        private static ApplovinAds applovinAds;
        public static ApplovinAds Instance => applovinAds ?? (applovinAds = new ApplovinAds());
        public AdNetWork NetWork { get; }

        public void InitAds()
        {
            throw new NotImplementedException();
        }

        public bool IsInitialized()
        {
            throw new NotImplementedException();
        }

        public void InitBannerAds()
        {
            throw new NotImplementedException();
        }

        public void LoadBannerAds()
        {
            throw new NotImplementedException();
        }

        public void ShowBannerAds()
        {
            throw new NotImplementedException();
        }

        public void HideBannerAds()
        {
            throw new NotImplementedException();
        }

        public event Action OnInterstitialAdCompleted;

        public void InitInterAds()
        {
            throw new NotImplementedException();
        }

        public void LoadInterAds()
        {
            throw new NotImplementedException();
        }

        public bool IsInterAdsReady()
        {
            throw new NotImplementedException();
        }

        public void ShowInterAds()
        {
            throw new NotImplementedException();
        }

        public event Action OnRewardedAdSkipped;
        public event Action OnRewardedAdCompleted;

        public void InitRewardAds()
        {
            throw new NotImplementedException();
        }

        public void LoadRewardAds()
        {
            throw new NotImplementedException();
        }

        public bool IsRewardAdsReady()
        {
            throw new NotImplementedException();
        }

        public void ShowRewardAds()
        {
            throw new NotImplementedException();
        }

        public event Action OnRewardedInterstitialAdSkipped;
        public event Action OnRewardedInterstitialAdCompleted;

        public void InitRewardedInterstitialAds()
        {
            throw new NotImplementedException();
        }

        public void LoadRewardedInterstitialAds()
        {
            throw new NotImplementedException();
        }

        public bool IsRewardedInterstitialAdReady()
        {
            throw new NotImplementedException();
        }

        public void ShowRewardedInterstitialAds()
        {
            throw new NotImplementedException();
        }

        public event Action OnAppOpenAdCompleted;

        public void InitAppOpenAds()
        {
            throw new NotImplementedException();
        }

        public void LoadAppOpenAds()
        {
            throw new NotImplementedException();
        }

        public bool IsAppOpenAdsReady()
        {
            throw new NotImplementedException();
        }

        public void ShowAppOpenAds()
        {
            throw new NotImplementedException();
        }
    }
}