#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.Text;

public static class EncodingExtensions
{
    /// <summary> Converts a string to a byte array using UTF8 encoding </summary>
    /// <seealso cref="Encoding.GetBytes(string)"/>
    public static byte[] ToUTF8Bytes(this string text) => Encoding.UTF8.GetBytes(text);
    
    /// <summary> Converts a byte array to a string using UTF8 encoding </summary>
    /// <seealso cref="Encoding.GetString(byte[])"/>
    public static string ToUTF8String(this byte[] bytes) => Encoding.UTF8.GetString(bytes);
}