using Sirenix.OdinInspector;
using UnityEngine;

namespace Virtuesky.Ads
{
    public class AdConfig : ScriptableSettings<AdConfig>
    {
        [SerializeField] private bool autoInit = true;
        [SerializeField] private AdNetWork adNetWork;

        [ShowIf(nameof(adNetWork), AdNetWork.Applovin)] [SerializeField]
        private MaxConfig maxConfig;


        public static bool AutoInit => Instance.autoInit;
        public static AdNetWork AdNetWork => Instance.adNetWork;
        public static MaxConfig MaxConfig => Instance.maxConfig;
    }
}