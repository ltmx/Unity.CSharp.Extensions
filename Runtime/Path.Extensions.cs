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
    /// <summary> Removes the asset name (asset.extension) from the path </summary>
    public static string RemoveAssetNameFromPath(this string path, Object asset) => path.Replace("/" + asset.name + ".asset", "");

    /// <summary> Removes the "Assets" folder from the path, useful to access </summary>
    public static string RemoveAssetFolderFromPath(this string path, Object asset) => path.Replace("Assets", "");

    /// <inheritdoc cref="Path.Combine(string, string)" />
    public static string Combine(this string path, string other) => Path.Combine(path, other);

#if UNITY_EDITOR
    /// <summary> Pings the asset at the desired path using </summary>
    /// <param name="path">desired path</param>
    /// <param name="select">select target object in unity editor</param>
    /// <seealso cref="EditorGUIUtility.PingObject(Object)" />
    public static void PingPath(this string path, bool select = false)
    {
        var asset = AssetDatabase.LoadAssetAtPath<Object>(path);
        if (select) Selection.activeObject = asset;
        EditorGUIUtility.PingObject(asset);
    }
#endif
}