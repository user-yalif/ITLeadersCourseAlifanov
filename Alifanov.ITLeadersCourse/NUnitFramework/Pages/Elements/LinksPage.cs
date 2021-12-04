using NUnitFramework.Logging;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class LinksPage : BasePage
    {
        private IWebElement CreatedLink => FindElement(By.CssSelector("a#created"));
        private IWebElement CreatedLinkOutput => FindElement(By.Id("linkResponse"));
        public LinksPage ClickOnCreatedLink()
        {
            Logger.Log.Info("Click on Created Link");

            CreatedLink.Click();

            return this;
        }

        public string GetCreatedLinkOutput()
        {
            Logger.Log.Info("Try to get Created link output");

            return CreatedLinkOutput.Text;
        }
    }
}
