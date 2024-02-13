#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

using System.Text.RegularExpressions;

public static class StringExtensions
{
    public static string AddLine(this string stringBuilder, string line) {
        if (stringBuilder.Length <= 0) return stringBuilder.Add(line);
        stringBuilder.Add('\n');
        return stringBuilder.Add(line);
    }

    public static string Add(this string s, string characters) {
        s += characters;
        return s;
    }
    public static string Add(this string s, char characters) {
        return s + characters;
    }
    
    public static bool IsNullOrEmpty(this string s) => string.IsNullOrEmpty(s);
    
    public static string Clean(this string text)
    {
        text = Regex.Replace(text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
        return text;
    }
    
}