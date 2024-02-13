#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System.IO;

public static class MemoryStreamConversionExtensions
{
    public static MemoryStream ToMemoryStream(this byte[] bytes) => new(bytes);
    public static MemoryStream ToMemoryStream(this string text) => text.ToUTF8Bytes().ToMemoryStream();
}