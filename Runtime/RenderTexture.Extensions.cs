using UnityEngine;

public static class RenderTextureExtensions
{
    public static void CopyFrom(this Texture destination, Texture source) => Graphics.CopyTexture(source, destination);
    public static void CopyTo(this Texture source, Texture destination) => Graphics.CopyTexture(source, destination);
    
    public static void SetUseMipMaps(this RenderTexture renderTexture, bool useMips)
    {
        if (useMips == renderTexture.useMipMap) return;
        renderTexture.Release();
        renderTexture.useMipMap = useMips;
        renderTexture.Create();

    }
        
        
}