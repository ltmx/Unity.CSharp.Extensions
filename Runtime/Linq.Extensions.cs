#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System;
using System.Collections.Generic;
using System.Linq;

public static class LinqFunctionalExtensions
{
    public static List<T> ForEachAndReturn<T>(this List<T> list, Action<T> action)
    {
        list.ForEach(action);
        return list;
    }
    
    public static T[] ForEachAndReturn<T>(this T[] array, Action<T> action)
    {
        Array.ForEach(array, action);
        return array;
    }
    
    public static IEnumerable<T> ForEachAndReturn<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        var forEachAndReturn = enumerable.ToList();
        forEachAndReturn.ForEach(action);
        return forEachAndReturn;
    }
}