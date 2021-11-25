namespace NUnitFramework.Navigation.LeftPanel.Groups
{
    using System;
    using NUnitFramework.Drivers;
    using NUnitFramework.Logging;
    using NUnitFramework.Navigation.LeftPanel.Interfaces;
    using NUnitFramework.Pages;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public class BaseGroup : ILeftPanelGroup
    {
        private static string BaseUrl => Settings.BaseUrl;

        public T NavigateTo<T>(string path) where T : BasePage, new()
        {
            var url = new UriBuilder(BaseUrl)
            {
                Path = path
            }.Uri.AbsoluteUri;

            Logger.Log.Info($"Redirected to {url}");
            WebDriverManager.Driver.Navigate().GoToUrl(url);

            return new T();
        }
    }
}
