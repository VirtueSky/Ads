using UnityEditor;
using UnityEngine;

namespace Virtuesky.Ads.Editor
{
    public static class MenuCreator
    {
        [MenuItem("Tools/Virtuesky/Ads %E", false)]
        public static void MenuOpenSettings()
        {
            var adConfig = Virtuesky.Ads.AdConfig.Instance;
            // UnityEditor.EditorGUIUtility.PingObject(adConfig);
            Selection.activeObject = adConfig;
            EditorUtility.FocusProjectWindow();
        }
    }
}