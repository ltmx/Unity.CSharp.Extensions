#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System.Text;

public static class EncodingExtensions
{
    public static byte[] ToUTF8Bytes(this string text) => Encoding.UTF8.GetBytes(text);
    public static string ToUTF8String(this byte[] bytes) => Encoding.UTF8.GetString(bytes);
}