#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.Runtime.InteropServices;
using UnityEngine;

public static class Texture2DExtension
{
    public static byte[] GetByteArray32(this Texture2D t) => MemoryMarshal.Cast<Color32, byte>(t.GetPixels32(0)).ToArray();
    // public static byte[] GetRaw(this Texture2D t) => MemoryMarshal.Cast<Color32, byte>(t.GetRawTextureData<Color32>().ToArray()).ToArray();
    
    // Make sure to activate mipmaps
    public static bool CheckTransparencyFromPixelData(this Texture2D t) => t.GetPixelData<Color32>(t.mipmapCount - 1)[0].a is 1 or 0;
    
    // public static bool CheckTransparency(this Texture2D t) => t.GetImporter().DoesSourceTextureHaveAlpha();

    public static byte[] GetByteArray24(this Texture2D t)
    {
        var rgba = t.GetByteArray32(); // maybe incorrect
        var rgb = new byte[rgba.Length / 4 * 3];
        for (int i = 0; i < rgba.Length; i += 4)
        {
            var idx = i / 4 * 3;
            rgb[idx] = rgba[i];
            rgb[idx + 1] = rgba[i + 1];
            rgb[idx + 2] = rgba[i + 2]; 
        }
        return rgb;
    }
    
    // private static Color24[] GetPixels24(this Texture2D t)
    // {
    //     var rgba = t.GetByteArray32(); // maybe incorrect
    //     var colors = new Color24[rgba.Length / 4];
    //     for (int i = 0; i < rgba.Length; i += 4)
    //     {
    //         var idx = i / 4;
    //         colors[idx].r = rgba[i];
    //         colors[idx].g = rgba[i + 1];
    //         colors[idx].b = rgba[i + 2];
    //     }
    //     return colors;
    // }
    
    public static float Aspect(this Texture2D t) => (float) t.width / t.height;
    public static float Aspect2D(this RenderTexture t) => (float) t.width / t.height;
    public static float PixelCount(this Texture2D t) => t.width * t.height;
    public static float PixelCount(this Texture3D t) => t.width * t.height * t.depth;
    public static float PixelCount3D(this RenderTexture t) => t.width * t.height * t.volumeDepth;
    public static float PixelCount2D(this RenderTexture t) => t.width * t.height;

    // To read and write data, we need to set the texture to be readable, and uncompressed
    // public static Texture2D CopySafe(this Texture2D t)
    // {
    //     #if UNITY_EDITOR
    //     var importer = TextureImporterExtensions.GetImporter(t);
    //     var importer = t.GetImporter();
    //     if (importer.crunchedCompression) t.SetCrunchCompression(false);
    //     if (importer.isReadable == false) t.SetReadWriteAndRefresh(true);
    //     #endif
    //     
    //     var copy = new Texture2D(t.width, t.height, t.format, t.mipmapCount > 1);
    //     Graphics.CopyTexture(t, copy);
    //     return copy;
    // }
    
    // Can prevent Bad Format error
    public static Texture2D BlankCopy(this Texture2D t) => new(t.width, t.height, TextureFormat.RGBA32, true);
    
    public static Texture2D SetPixelsChain(this Texture2D t, Color[] colors)
    {
        t.SetPixels(colors);
        return t;
    }

    public static Color[] Px(this Texture2D t) => t.GetPixels();
    public static Color[] Px(this Texture3D t) => t.GetPixels();
    public static void SetPx(this Texture2D t, Color[] colors) => t.SetPixels(colors);
    public static void SetPx(this Texture3D t, Color[] colors) => t.SetPixels(colors);





}