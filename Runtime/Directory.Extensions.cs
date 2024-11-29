#region Header
// **    Copyright (C) 2024 Nicolas Reinhard, @ltmx. All rights reserved.
// **    Github Profile: https://github.com/ltmx
// **    Repository : https://github.com/ltmx/Unity.Athena
#endregion

using System.IO;

public static class DirectoryExtensions
{
    /// <summary> Creates a directory if it doesn't exist. </summary>
    public static void CreateDirectoryIfVoid(this string path)
    {
        if (path.DirectoryExists() == null)
        {
            path.CreateDirectory();
        }
    }

    /// Returns the directory path if it exists, otherwise returns null.
    /// Used for null checking
    public static string DirectoryExists(this string path) => Directory.Exists(path) ? path : null;

    /// <inheritdoc cref="Directory.CreateDirectory(string)" />
    public static DirectoryInfo CreateDirectory(this string path) => Directory.CreateDirectory(path);
}