using System;

namespace Virtuesky.Ads
{
    [Serializable]
    public class MaxInterstitialUnitId : AdUnitId
    {
        public MaxInterstitialUnitId(string _androidId, string _iosId) : base(_androidId, _iosId)
        {
        }
    }
}