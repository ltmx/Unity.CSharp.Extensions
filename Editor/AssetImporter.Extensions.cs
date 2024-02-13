#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

public static class AssetImporterExtensions
{
    // Asset Importer Stuff
    public static void Import(this Texture2D t) => AssetDatabase.ImportAsset(t.GetPath());
    public static void Import<T>(this T t) where T : Object => AssetDatabase.ImportAsset(t.GetPath());
    public static void Import(this AssetImporter t) => AssetDatabase.ImportAsset(t.assetPath);
    public static void ImportAndRefresh(this AssetImporter t) {
        AssetDatabase.ImportAsset(t.assetPath);
        AssetDatabase.Refresh();
    }
}

#endif