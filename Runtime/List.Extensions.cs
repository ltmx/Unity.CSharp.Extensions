#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System.Collections.Generic;

public static class ListExtensions
{
    /// <summary> Adds self item to the target list </summary>
    public static void AddTo<T>(this T item, List<T> list) => list.Add(item);

    /// <summary> Adds self ienumerable to the target list </summary>
    public static void AddTo<T>(this IEnumerable<T> item, List<T> list) => list.AddRange(item);
    
    /// <summary> Creates a new list from a single item </summary>
    public static List<T> ToItemList<T>(this T item) where T : struct => new() { item };
    /// <summary> Creates a new list of strings from a single string </summary>
    public static List<string> ToItemList(this string item) => new() { item };
}