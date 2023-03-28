using System;

namespace Virtuesky.Ads
{
    [Serializable]
    public class MaxRewardedUnitId : AdUnitId
    {
        public MaxRewardedUnitId(string _androidId, string _iosId) : base(_androidId, _iosId)
        {
        }
    }
}