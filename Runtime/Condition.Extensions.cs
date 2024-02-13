#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System;

public static class ConditionExtensions {
    
    public static bool And(this bool a, bool b) => a && b;
    public static bool AndNot(this bool a, bool b) => a && !b;
    public static bool Nand(this bool a, bool b) => !a && !b;
    public static bool Or(this bool a, bool b) => a || b;
    public static bool OrNot(this bool a, bool b) => a || b;
    public static bool Nor(this bool a, bool b) => !a || !b;

    public static void IfTrue(this bool condition, Action action) {
        if (condition) action();
    }
    public static void IfTrue<T>(this bool condition, Func<object> action){
        if (condition) action();
    }

    public static void IfFalse(this bool condition, Action action) {
        if (!condition) action();
    }
    
    public static void Select(this bool condition, Action onTrue, Action onFalse) {
        if (condition) onTrue();
        else onFalse();
    }
    
    public static void Select<T>(this bool condition, Action<T> onTrue, Action<T> onFalse, T arg) {
        if (condition) onTrue(arg);
        else onFalse(arg);
    }

    public static U IfTrue<T, U>(this bool condition, Func<T, U> action, T arg) => condition ? action(arg) : default;

    public static U IfFalse<T, U>(this bool condition, Func<T, U> action, T arg) => !condition ? action(arg) : default;

    public static void IfTrue<T>(this bool condition, Action<T> action, T arg) {
        if (condition) action(arg);
    }
    public static void IfFalse<T>(this bool condition, Action<T> action, T arg) {
        if (!condition) action(arg);
    }
    
    public static void flip(this ref bool condition) => condition = !condition;
    
}