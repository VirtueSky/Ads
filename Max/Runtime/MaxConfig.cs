using System;
using UnityEngine;

namespace Virtuesky.Ads
{
    [Serializable]
    public class MaxConfig
    {
        [SerializeField] private bool enable;
        [SerializeField] private string sdkKey;
        [SerializeField] private MaxBannerAdUnitId maxBannerAdUnitId;
        [SerializeField] private MaxInterstitialUnitId maxInterstitialUnitId;
        [SerializeField] private MaxRewardedUnitId maxRewardedUnitId;
        [SerializeField] private MaxAppOpenUnitId maxAppOpenUnitId;
        [SerializeField] private MaxRewardedInterstitialUnitId maxRewardedInterstitialUnitId;

        public bool Enable => enable;
        public string SdkKey => sdkKey;
        public MaxBannerAdUnitId MaxBannerAdUnitId => maxBannerAdUnitId;
        public MaxInterstitialUnitId MaxInterstitialUnitId => maxInterstitialUnitId;
        public MaxRewardedUnitId MaxRewardedUnitId => maxRewardedUnitId;
        public MaxAppOpenUnitId MaxAppOpenUnitId => maxAppOpenUnitId;
        public MaxRewardedInterstitialUnitId MaxRewardedInterstitialUnitId => maxRewardedInterstitialUnitId;
    }
}