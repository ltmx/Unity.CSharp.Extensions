#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.Text.RegularExpressions;

public static class StringExtensions
{
    /// <summary> Adds a line to the string </summary>
    public static string AddLine(this string stringBuilder, string line) {
        if (stringBuilder.Length <= 0) return stringBuilder.Add(line);
        stringBuilder.Add('\n');
        return stringBuilder.Add(line);
    }

    /// <summary> Adds a string to the string </summary>
    public static string Add(this string s, string characters) {
        s += characters;
        return s;
    }

    /// <summary> Adds a character to the string </summary>
    public static string Add(this string s, char characters) => s + characters;
    
    /// <summary> Removes the specified characters from the string </summary>
    public static string Remove(this string s, string characters) => s.Replace(characters, "");

    /// <summary> Returns true if the string is null or empty </summary>
    public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);

    /// <summary> Returns true if the string contains the value </summary>
    public static bool Lacks(this string s, string value) => s.Contains(value) == false;

    /// <summary> Returns true if the string contains the value </summary>
    public static string Clean(this string text) => Regex.Replace(text, @"(\r\n?|\n)\s*(?=\r\n?|\n)", "\n").TrimExtremities();

    /// <summary> Returns true if the string contains the value </summary>
    public static string TrimExtremities(this string text) => text.TrimStart().TrimEnd();
    
}