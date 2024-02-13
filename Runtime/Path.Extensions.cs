#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

using System.IO;
using UnityEditor;
using UnityEngine;

public static class PathExtensions
{
    public static string RemoveAssetNameFromPath(this string path, Object asset) => path.Replace("/" + asset.name + ".asset", "");

    public static string RemoveAssetFolderFromPath(this string path, Object asset) => path.Replace("Assets", "");

    public static string Combine(this string path, string other) => Path.Combine(path, other);
    /// Pings the asset at the desired path

    #if UNITY_EDITOR
    public static void PingPath(this string path, bool select = false) {
        Object asset = AssetDatabase.LoadAssetAtPath<Object>(path);
        if (select) Selection.activeObject = asset;
        EditorGUIUtility.PingObject(asset);
    }
    #endif
}