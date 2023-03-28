using UnityEditor;
using UnityEngine;

namespace Virtuesky.Ads.Editor
{
    public class MaxSettingWindow : EditorWindow
    {
        private UnityEditor.Editor _editor;

        private void OnGUI()
        {
            if (_editor == null) _editor = UnityEditor.Editor.CreateEditor(AdConfig.Instance);

            if (_editor == null)
            {
                EditorGUILayout.HelpBox("Coundn't create the settings resources editor.", MessageType.Error);
                return;
            }

            // SettingsEditor.callFromEditorWindow = true;
            //
            // _editor.DrawHeader();
            // _scrollPosition = EditorGUILayout.BeginScrollView(_scrollPosition);
            // EditorGUILayout.BeginVertical(new GUIStyle {padding = new RectOffset(6, 3, 3, 3)});
            // _editor.OnInspectorGUI();
            // EditorGUILayout.EndVertical();
            // EditorGUILayout.EndScrollView();
            // SettingsEditor.callFromEditorWindow = false;
        }
    }
}