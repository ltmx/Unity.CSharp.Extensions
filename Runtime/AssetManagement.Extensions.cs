#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

using System;
using System.IO;
using System.Text;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public static class AssetManagementExtensions
{
    public static string ApplicationRootPath => Application.dataPath.Remove(Application.dataPath.Length - 6);
    
    #if UNITY_EDITOR
    
    /// <inheritdoc cref="AssetDatabase.GetAssetPath(UnityEngine.Object)" />
    public static string GetPath<T>(this T o) where T : Object => AssetDatabase.GetAssetPath(o);
    /// <inheritdoc cref="AssetDatabase.LoadAssetAtPath(string, System.Type)" />
    public static T LoadAtPath<T>(string path) where T : Object => AssetDatabase.LoadAssetAtPath<T>(path);
    /// Loads an object from a path relative to the Assets folder
    public static Object LoadAtPath(string path) => AssetDatabase.LoadAssetAtPath<Object>(path);
    
    public static string GetFullPath(this Object asset) => ApplicationRootPath.Combine(AssetDatabase.GetAssetPath(asset));
    public static string GetAssetPathWithoutAssetName(this Object asset) => AssetDatabase.GetAssetPath(asset).RemoveAssetNameFromPath(asset);
    
    /// Replaces an asset at the desired path. If nothing can be found, the asset it simply created
    public static T CreateOrReplaceAsset<T>(this T asset, string path) where T : Object => CreateAssetIfNull(asset, path).CopySerialized(asset);

    /// <inheritdoc cref="AssetDatabase.CreateAsset" />
    public static T CreateAsset<T>(this T asset, string path) where T : Object {
        AssetDatabase.CreateAsset(asset, path);
        return asset;
    }

    /// <inheritdoc cref="EditorUtility.CopySerialized" />
    public static T CopySerialized<T>(this T destination, T source) where T : Object {
        EditorUtility.CopySerialized(source, destination);
        return destination;
    }
    
    
    /// Creates an asset if no asset is found at the desired path
    public static T CreateAssetIfNull<T>(this T asset, string path) where T : Object {
        var existingAsset = LoadAtPath<T>(path);
        return existingAsset != null ? existingAsset : asset.CreateAsset(path);
    }
    
    #endif
    
 



    private static string CreateUniqueFileName(this object obj) => "Script_" + GetFormattedDate() + "_" + math.abs(obj.GetHashCode());
    
    private static string GetFormattedDate() => DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "-" + DateTime.Now.Hour;

    /// Saves a byte array to a file at the desired path
    public static void SaveToFile(this byte[] bytes, string path, string fileName, string extension, bool ping = true)
    {
        path.CreateDirectoryIfVoid();
        
        fileName.IsNullOrEmpty().IfTrue(() => fileName = bytes.CreateUniqueFileName());
        path = Path.Combine(path, fileName) + extension;
        File.WriteAllBytes(path, bytes);
        #if UNITY_EDITOR
            AssetDatabase.Refresh();
            Debug.Log($"Saved script to {path}");
            path.PingPath(ping);
        #endif
    }
    
    /// Saves a string to a file at the desired path
    public static void SaveToFile(this string text, string directory, string fileName, string extension, bool ping = true) => SaveToFile(Encoding.UTF8.GetBytes(text), directory, fileName, extension, ping);
    
    /// Saves a texture to a PNG file at the desired path
    public static void SaveToPNGFile<T>(this T texture, string directory, string fileName, bool ping = true) where T : Texture=> SaveToFile((texture as Texture2D).EncodeToPNG(), directory, fileName, ".png", ping);

    /// Saves a texture to a JPG file at the desired path
    public static void SaveToJPGFile<T>(this T texture, string directory, string fileName, bool ping = true) where T : Texture=> SaveToFile((texture as Texture2D).EncodeToJPG(), directory, fileName, ".jpg", ping);

    
    
    public static Texture2D LoadTexture2D(string path) => LoadResource<Texture2D>(path);

    #if UNITY_EDITOR
        public static T LoadAsset<T>(string path) where T : Object => AssetDatabase.LoadAssetAtPath<T>(path);
    #endif
   
    public static T LoadResource<T>(string path) where T : Object => Resources.Load<T>(path);
}