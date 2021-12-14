namespace NUnitFramework.Pages.AlertsFrameAndWindows.ModalDialogsElements
{
    using NUnitFramework.Logging;
    using OpenQA.Selenium;

    public class SmallModalElement
    {
        private IWebElement SmallModal { get; }

        private IWebElement Header => SmallModal.FindElement(By.CssSelector(".modal-header > .modal-title"));

        private IWebElement Body => SmallModal.FindElement(By.CssSelector(".modal-body"));

        private IWebElement CloseButton => SmallModal.FindElement(By.CssSelector("button#closeSmallModal"));

        public SmallModalElement(IWebDriver driver)
        {
            SmallModal = driver.FindElement(By.CssSelector(".modal-content"));
        }

        public string GetHeader()
        {
            Logger.Log.Info("Try to get Small Modal's header");

            return Header.Text;
        }

        public string GetMessage()
        {
            Logger.Log.Info("Try to get Small Modal's message");

            return Body.Text;
        }

        public ModalDialogsPage CloseModal()
        {
            Logger.Log.Info("Click on Small Modal's Close button");

            CloseButton.Click();

            return new ModalDialogsPage();
        }
    }
}
