#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public static class AssetImporterExtensions
{
	// Asset Importer Stuff
	public static void Import(this Texture2D t) => AssetDatabase.ImportAsset(t.GetPath());
	public static void Import<T>(this T t) where T : Object => AssetDatabase.ImportAsset(t.GetPath());
	public static void Import(this AssetImporter t) => AssetDatabase.ImportAsset(t.assetPath);

	public static void ImportAndRefresh(this AssetImporter t)
	{
		AssetDatabase.ImportAsset(t.assetPath);
		AssetDatabase.Refresh();
	}

}

#endif