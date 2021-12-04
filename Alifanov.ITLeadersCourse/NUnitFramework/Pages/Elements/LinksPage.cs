using NUnitFramework.Logging;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class LinksPage : BasePage
    {
        private IWebElement CreatedLink => FindElement(By.CssSelector("a#created"));

        private IWebElement OutputCreatedLink => FindElement(By.Id("linkResponse"));


        public LinksPage ClickOnCreatedLink()
        {
            Logger.Log.Info("Click on Created Link");

            CreatedLink.Click();

            return this;
        }

        public string GetOutput()
        {
            return OutputCreatedLink.Text;
        }
    }
}
