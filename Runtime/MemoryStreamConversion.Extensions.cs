#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.IO;

public static class MemoryStreamConversionExtensions
{
    /// <summary> Converts a byte array to a MemoryStream </summary>
    public static MemoryStream ToMemoryStream(this byte[] bytes) => new(bytes);
    
    /// <summary> Converts a string to a MemoryStream </summary>
    public static MemoryStream ToMemoryStream(this string text) => text.ToUTF8Bytes().ToMemoryStream();
}