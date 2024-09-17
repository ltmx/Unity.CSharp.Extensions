#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public static class ColorExtensions
{
    /// <summary>remaps the input color to the MinMax Range</summary>
    /// <seealso cref="math.unlerp(float4, float4, float4)"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Color Unlerp(this Color @in, float2 minMax) => ((@in.AsFloat4() - minMax.x) / (minMax.y - minMax.x)).AsColor();
    
    /// <summary> Converts a Color to a float4 </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float4 AsFloat4(this Color c) => new(c.r, c.g, c.b, c.a);
    
    /// <summary> Converts a float4 to a Color </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Color AsColor(this float4 c) => new(c.x, c.y, c.z, c.w);
}