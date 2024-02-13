#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

using System.Text;

public static class StringBuilderExtensions
{
    public static StringBuilder AddLine(this StringBuilder stringBuilder, string line) {
        if (stringBuilder.Length <= 0) return stringBuilder.Append(line);
        stringBuilder.Append('\n');
        return stringBuilder.Append(line);
    }
    
    public static string TrimEnd(this StringBuilder stringBuilder, char c) {
        return stringBuilder.ToString().TrimEnd(c);
    }
}