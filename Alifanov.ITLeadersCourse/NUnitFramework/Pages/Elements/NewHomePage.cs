using NUnitFramework.Logging;

namespace NUnitFramework.Pages.Elements
{
    public class NewHomePage : BasePage
    {
        public string GetUrl()
        {
            Logger.Log.Info("Click on Home Link");
            return Driver.Url;
        }
    }
}
