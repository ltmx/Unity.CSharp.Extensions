#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

#if UNITY_EDITOR

using UnityEditor;
using UnityEditor.AssetImporters;

public static class ScriptedImporterEditorExtensions
{
    public static SerializedProperty FindProperty(this ScriptedImporterEditor s, string name)
    {
        return s.serializedObject.FindProperty(name);
    }
}


#endif