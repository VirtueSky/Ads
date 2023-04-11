#if ENABLE_ADS
#if ENABLE_ANALYTIC
using Firebase.Analytics;
#endif
#if ENABLE_ADJUST
using com.adjust.sdk;
#endif

namespace Virtuesky.Ads
{
    public class RevenueTracking
    {
#if MAX_ENABLE
        public static void OnAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
        {
#if ENABLE_ADJUST
            double revenue = adInfo.Revenue;

            //  Debug.Log("adinfo.Revenue: " + adInfo.Revenue);
            // Ad revenue paid. Use this callback to track user revenue.
            // send ad revenue info to Adjust
            AdjustAdRevenue adRevenue = new AdjustAdRevenue(AdjustConfig.AdjustAdRevenueSourceAppLovinMAX);
            adRevenue.setRevenue(adInfo.Revenue, "USD");
            adRevenue.setAdRevenueNetwork(adInfo.NetworkName);
            adRevenue.setAdRevenuePlacement(adInfo.Placement);
            adRevenue.setAdRevenueUnit(adInfo.AdUnitIdentifier);
            Adjust.trackAdRevenue(adRevenue);
#endif

#if ENABLE_ANALYTIC
                        Parameter[] LTVParameters =
            {
                // Log ad value in micros.
                new Parameter("value", revenue),
                new Parameter("ad_platform", "AppLovin"),
                new Parameter("ad_format", adInfo.AdFormat),
                new Parameter("currency", "USD"),
                new Parameter("ad_unit_name", adInfo.AdUnitIdentifier),
                new Parameter("ad_source", adInfo.NetworkName)
            };

            FirebaseAnalytics.LogEvent("ad_impression", LTVParameters);
#endif
            // Log an event with ad value parameters
        }
#endif
    }
}
#endif