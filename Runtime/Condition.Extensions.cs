#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System;

public static class ConditionExtensions {
    
    // Boolean Logic
    /// <summary> Logical a AND b</summary>
    public static bool And(this bool a, bool b) => a && b;
    /// <summary> Logical a AND NOT b</summary>
    public static bool AndNot(this bool a, bool b) => a && !b;
    /// <summary> Logical NAND (not a and not b</summary>
    public static bool Nand(this bool a, bool b) => !a && !b;
    /// <summary> Logical a OR b</summary>
    public static bool Or(this bool a, bool b) => a || b;
    /// <summary> Logical a OR NOT b </summary>
    public static bool OrNot(this bool a, bool b) => a || !b;
    /// <summary> Logical NOR (not a or not b</summary>
    public static bool Nor(this bool a, bool b) => !a || !b;

    /// <summary> If the condition is true, execute the action </summary>
    public static void IfTrue(this bool condition, Action action) {
        if (condition) action?.Invoke();
    }
    /// <summary> If the condition is true, execute the action </summary>
    public static void IfTrue<T>(this bool condition, Func<object> action){
        if (condition) action?.Invoke();
    }

    /// <summary> If the condition is false, execute the action </summary>
    public static void IfFalse(this bool condition, Action action) {
        if (!condition) action?.Invoke();
    }
    
    /// <summary> Select the action to perform based on the condition </summary>
    public static void Select(this bool condition, Action onTrue, Action onFalse) {
        if (condition) onTrue?.Invoke();
        else onFalse();
    }
    
    /// <summary> Select the action to perform based on the condition </summary>
    public static void Select<T>(this bool condition, Action<T> onTrue, Action<T> onFalse, T arg) {
        if (condition) onTrue?.Invoke(arg);
        else onFalse(arg);
    }

    /// <summary> Perform an action with passed arguments if true</summary>
    public static U IfTrue<T, U>(this bool condition, Func<T, U> action, T arg) => condition ? action(arg) : default;

    /// <summary> Perform an action with passed arguments if false</summary>
    public static U IfFalse<T, U>(this bool condition, Func<T, U> action, T arg) => !condition ? action(arg) : default;

    /// <summary> Perform an action with passed arguments if true</summary>
    public static void IfTrue<T>(this bool condition, Action<T> action, T arg) {
        if (condition) action?.Invoke(arg);
    }
    /// <summary> Perform an action with passed arguments if false</summary>
    public static void IfFalse<T>(this bool condition, Action<T> action, T arg) {
        if (!condition) action?.Invoke(arg);
    }
    
    public static void flip(this ref bool condition) => condition = !condition;
    
    public static void IfNullOrEmpty(this string condition, Action action) {
        if (string.IsNullOrEmpty(condition)) action?.Invoke();
    }
    public static void IfNotNullOrEmpty(this string condition, Action action) {
        if (!string.IsNullOrEmpty(condition)) action?.Invoke();
    }
    
}