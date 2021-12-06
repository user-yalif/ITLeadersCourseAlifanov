using NUnitFramework.Logging;

namespace NUnitFramework.Pages.Elements.LinksElements
{
    public class NewHomePage : BasePage
    {
        public string GetUrl()
        {
            Logger.Log.Info("Get New Home page url");

            return Driver.Url;
        }
    }
}
