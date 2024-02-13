#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena
#endregion

using System.IO;

public static class DirectoryExtensions
{
    /// <summary> Creates a directory if it doesn't exist. </summary>
    public static void CreateDirectoryIfVoid(this string path) => Directory.Exists(path).IfFalse(() => Directory.CreateDirectory(path));
}