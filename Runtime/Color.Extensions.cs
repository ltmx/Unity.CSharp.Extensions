#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

using Unity.Mathematics;
using UnityEngine;

public static class ColorExtensions
{
    /// <summary>remaps the input color to the MinMax Range</summary>
    /// <seealso cref="math.unlerp(float4, float4, float4)"/>
    public static Color unlerp(this Color In, float2 MinMax) => ((In.AsFloat4() - MinMax.x) / (MinMax.y - MinMax.x)).asColor();
    
    /// <summary> Converts a Color to a float4 </summary>
    public static float4 AsFloat4(this Color c) => new(c.r, c.g, c.b, c.a);
    
    /// <summary> Converts a float4 to a Color </summary>
    public static Color asColor(this float4 c) => new(c.x, c.y, c.z, c.w);
}