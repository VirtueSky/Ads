using System;

namespace Virtuesky.Ads
{
    [Serializable]
    public class MaxAppOpenUnitId : AdUnitId
    {
        public MaxAppOpenUnitId(string _androidId, string _iosId) : base(_androidId, _iosId)
        {
        }

        public MaxAppOpenUnitId() : base("", "")
        {
        }
    }
}