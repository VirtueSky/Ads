using System;
using UnityEngine;

namespace Virtuesky.Ads
{
    public class AdsManager : MonoBehaviour
    {
        public static AdsManager Instance { get; private set; }
        private static bool isInitialized;
        public static bool IsInitialized => isInitialized;
        private static ApplovinAds applovinAds;

        public static ApplovinAds ApplovinAds
        {
            get
            {
                if (!IsInitialized) return null;
                return applovinAds;
            }
            set { applovinAds = value; }
        }

        private static void SetAdsByNetwork(AdNetWork adNetWork)
        {
            if (!IsInitialized) return;
            switch (adNetWork)
            {
                case AdNetWork.None:

                    break;
                case AdNetWork.Applovin:
                    ApplovinAds = ApplovinAds.Instance;
                    break;
                case AdNetWork.Admod:
                    break;
                default: break;
            }
        }

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
            }
        }

        private void Start()
        {
            if (AdConfig.AutoInit) Initialize();
        }

        public static void Initialize()
        {
            isInitialized = true;
        }
    }
}