#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.IO;
using UnityEditor;
using UnityEngine;

public static class PathExtensions
{
    /// <summary> Removes the asset name (asset.extension) from the path </summary>
    public static string RemoveAssetNameFromPath(this string path, Object asset) => path.Replace("/" + asset.name + ".asset", "");
    
    
    /// <summary> Removes the "Assets" folder from the path, useful to access </summary>
    public static string RemoveAssetFolderFromPath(this string path) => path.Replace("Assets", "");
    
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