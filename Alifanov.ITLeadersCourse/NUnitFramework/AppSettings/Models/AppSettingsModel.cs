namespace NUnitFramework.AppSettings.Models
{
    using NUnitFramework.Enums;

    public class AppSettingsModel
    {
        public string BaseUrl { get; set; }

        public BrowserType Browser { get; set; }

        public LoggerType Logger { get; set; }
    }
}
