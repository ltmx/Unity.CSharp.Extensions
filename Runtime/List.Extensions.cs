#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System.Collections.Generic;

public static class ListExtensions
{
    public static void AddTo<T>(this T item, List<T> list) => list.Add(item);

    public static void AddTo<T>(this IEnumerable<T> item, List<T> list) => list.AddRange(item);
}