#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using UnityEditor;
using UnityEditor.AssetImporters;

public static class ScriptedImporterEditorExtensions
{
    public static SerializedProperty FindProperty(this ScriptedImporterEditor s, string name)
    {
        return s.serializedObject.FindProperty(name);
    }
}