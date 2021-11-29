﻿namespace NUnitFramework.AppSettings
{
    using System.IO;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using NUnitFramework.AppSettings.Models;

    public static class SettingsConfigurator
    {
        private static readonly string PathToAppSettings = @"AppSettings\Files\appsettings.json";

        private static AppSettingsModel GetAppSettings()
        {
            var settings = File.ReadAllText(PathToAppSettings);

            return JsonSerializer.Deserialize<AppSettingsModel>(settings, new JsonSerializerOptions()
            {
                IgnoreNullValues = true,
                WriteIndented = false,
                Converters = { new JsonStringEnumConverter() }
            });
        }

        public static AppSettingsModel Settings { get; } = GetAppSettings();
    }
}
