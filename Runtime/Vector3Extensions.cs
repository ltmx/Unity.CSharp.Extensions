#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;

public static class Vector3Extensions
{
    public static Vector4 ToVector4(this Vector3 v) => new(v.x, v.y, v.z, 1);
    
    public static float4 ToFloat4(this float3 v) => new(v, 1);

    public static List<Vector4> ToVector4List(this IEnumerable<Vector3> list) => list.Select(ToVector4).ToList();

    public static List<float4> ToFloat4List(this IEnumerable<float3> list) => list.Select(ToFloat4).ToList();
}