using NUnitFramework.Logging;
using NUnitFramework.Pages.Elements.WebTablesElement;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class WebTablesPage : BasePage
    {
        private IWebElement AddButton => FindElement(By.CssSelector("button#addNewRecordButton"));

        private RegistrationFormPage RegistrationForm => new(Driver);

        public RegistrationFormPage ClickAddButton()
        {
            Logger.Log.Info("Click on Add Button");

            AddButton.Click();

            return RegistrationForm;
        }
    }
}
