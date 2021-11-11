namespace ConsoleApp.WebDriver.AppSettings.Models
{
    using ConsoleApp.WebDriver.Enums;

    public class AppSettingsModel
    {
        public BrowserType BrowserType { get; set; }

        public UrlsModel Urls { get; set; }

        public class UrlsModel
        {
            public string UrlLesson6 { get; set; }

            public string UrlLesson7 { get; set; }
        }
    }
}
