namespace NUnitFramework.AppSettings.Models
{
    using NUnitFramework.Enums;

    public class AppSettingsModel
    {
        public string BaseUrl { get; set; }

        public BrowserType Browser { get; set; }

        public LoggerType Logger { get; set; }

        public PathsModel Paths { get; set; }

        public TestDataModel TestData { get; set; }

        public class PathsModel
        {
            public string ScreenshotsOutput { get; set; }

            public string DownloadsDirectory { get; set; }
        }

        public class TestDataModel
        {
            public string JpegFileToUpload { get; set; }
        }
    }
}
