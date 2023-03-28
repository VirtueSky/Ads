using System;
using UnityEngine;

namespace Virtuesky.Ads
{
    [Serializable]
    public abstract class AdUnitId
    {
        [SerializeField] protected string androidId;
        [SerializeField] protected string iosId;

        public virtual string Id
        {
            get
            {
#if UNITY_ANDROID
                return androidId;
#elif UNITY_IOS
                return iosId;
#else
                return string.Empty;
#endif
            }
        }

        public virtual string IosId => iosId;
        public virtual string AndroidId => androidId;

        public AdUnitId(string _androidId, string _iosId)
        {
            this.androidId = _androidId;
            this.iosId = _iosId;
        }
    }
}