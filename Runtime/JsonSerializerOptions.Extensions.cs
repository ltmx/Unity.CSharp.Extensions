#region Header

// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Athena

#endregion

using System.Text.Json;
using System.Text.Json.Serialization;

public static class JsonSerializerOptionsExtensions
{
    public static JsonSerializerOptions AddConverter<T>(this JsonSerializerOptions options) where T : JsonConverter, new()
    {
        options.Converters.Add(new T());
        return options;
    }
}