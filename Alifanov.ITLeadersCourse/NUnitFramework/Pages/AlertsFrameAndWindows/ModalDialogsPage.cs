namespace NUnitFramework.Pages.AlertsFrameAndWindows
{
    using NUnitFramework.Logging;
    using NUnitFramework.Pages.AlertsFrameAndWindows.ModalDialogsElements;
    using OpenQA.Selenium;

    public class ModalDialogsPage : BasePage
    {
        private IWebElement SmallModalButton => FindElement(By.CssSelector("button#showSmallModal"));

        private SmallModalElement SmallModal => new(Driver);

        public SmallModalElement ClickOnSmallModalButton()
        {
            Logger.Log.Info("Click on Small Modal Button");

            SmallModalButton.Click();

            return SmallModal;
        }
    }
}
