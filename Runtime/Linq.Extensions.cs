#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System;
using System.Collections.Generic;
using System.Linq;

public static class LinqFunctionalExtensions
{
    /// <summary> Performs an action on each element of the list and returns the list </summary>
    public static List<T> ForEachAndReturn<T>(this List<T> list, Action<T> action)
    {
        list.ForEach(action);
        return list;
    }
    
    /// <summary> Performs an action on each element of the array and returns the array </summary>
    public static T[] ForEachAndReturn<T>(this T[] array, Action<T> action)
    {
        Array.ForEach(array, action);
        return array;
    }
    
    /// <summary> Performs an action on each element of the enumerable and returns the enumerable </summary>
    public static IEnumerable<T> ForEachAndReturn<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        var forEachAndReturn = enumerable.ToList();
        forEachAndReturn.ForEach(action);
        return forEachAndReturn;
    }
}