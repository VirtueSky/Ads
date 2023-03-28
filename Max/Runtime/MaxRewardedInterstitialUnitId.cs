using System;

namespace Virtuesky.Ads
{
    [Serializable]
    public class MaxRewardedInterstitialUnitId : AdUnitId
    {
        public MaxRewardedInterstitialUnitId(string _androidId, string _iosId) : base(_androidId, _iosId)
        {
        }
    }
}