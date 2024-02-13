#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System;
using System.Collections.Generic;

public static class IEnumerableExtensions
{
    public static void ForEach<T>(this IEnumerable<T> array, Action<T> action) {
        foreach (var item in array) {
            action(item);  
        }
    }
}