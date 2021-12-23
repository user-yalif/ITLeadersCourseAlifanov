using NUnitFramework.Helpers;
using NUnitFramework.Logging;
using NUnitFramework.Pages.Elements.LinksElements;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class LinksPage : BasePage
    {
        private readonly By CreatedLinkOutputLocator = By.CssSelector("p#linkResponse");

        private IWebElement CreatedLink => FindElement(By.CssSelector("a#created"));

        private IWebElement CreatedLinkOutput => FindElement(CreatedLinkOutputLocator);

        private IWebElement HomeLink => FindElement(By.Id("simpleLink"));

        public NewHomePage ClickOnHomeLink()
        {
            Logger.Log.Info("Click on Home Link");

            HomeLink.Click();

            return new NewHomePage();
        }

        public LinksPage ClickOnCreatedLink()
        {
            Logger.Log.Info("Click on Created Link");

            CreatedLink.Click();

            return this;
        }

        public string GetCreatedLinkOutput()
        {
            Logger.Log.Info("Try to get Created link output");

            Waiter.WaitUntilElementToBePresent(CreatedLinkOutputLocator);

            return CreatedLinkOutput.Text;
        }
    }
}
