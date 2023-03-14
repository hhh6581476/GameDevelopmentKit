using ToolbarExtension;
using UnityEngine;

namespace Game.Editor
{
    sealed class ExcelExporterToolBar
    {
        private static readonly GUIContent s_ExportButtonGUIConent = new GUIContent("ExportExcel", "Export All Excel!");

        [Toolbar(OnGUISide.Right, 99)]
        private static void OnToolbarGUI()
        {
            if (GUILayout.Button(s_ExportButtonGUIConent))
            {
                ToolEditor.ExcelExporter();
            }
        }
    }
}
