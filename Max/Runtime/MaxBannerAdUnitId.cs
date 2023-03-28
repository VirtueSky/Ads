using System;
using UnityEngine;

namespace Virtuesky.Ads
{
    [Serializable]
    public class MaxBannerAdUnitId : AdUnitId
    {
        [SerializeField] private MaxSdkBase.BannerPosition bannerPos = MaxSdkBase.BannerPosition.BottomCenter;

        public MaxBannerAdUnitId(string _androidId, string _iosId) : base(_androidId, _iosId)
        {
        }
    }
}