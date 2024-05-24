using UnityEngine;

public static class RenderTextureExtensions
{
    /// <summary> Copies pixel data from the rhs texture into the lhs one </summary>
    /// <param name="destination">The destination Texture </param>
    /// <param name="source"> The source RenderTexture </param>
    public static void CopyFrom(this Texture destination, Texture source) => Graphics.CopyTexture(source, destination);

    /// <summary> Copies pixel data from the lhs texture into the rhs one </summary>
    /// <param name="source"> The source RenderTexture </param>
    /// <param name="destination">The destination Texture </param>
    public static void CopyTo(this Texture source, Texture destination) => Graphics.CopyTexture(source, destination);
    
    /// <summary> Sets the RenderTexture's mipmaps to the specified value</summary>
    public static void SetUseMipMaps(this RenderTexture renderTexture, bool useMips)
    {
        if (useMips == renderTexture.useMipMap) return;
        renderTexture.Release();
        renderTexture.useMipMap = useMips;
        renderTexture.Create();
    }
        
        
}