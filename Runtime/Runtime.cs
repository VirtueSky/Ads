using UnityEngine;

namespace Virtuesky.Ads
{
    public class Runtime
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void AutoInitialize()
        {
            if (Application.isPlaying)
            {
                var runtimeObject = new GameObject("RuntimeObject") /*{ hideFlags = HideFlags.HideInHierarchy }*/;
                UnityEngine.Object.DontDestroyOnLoad(runtimeObject);
#if ENABLE_ADS
                if (Virtuesky.Ads.AdConfig.AutoInit)
                {
                    runtimeObject.AddComponent<Virtuesky.Ads.AdsManager>();
                }
#endif
            }
        }
    }
}