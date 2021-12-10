using NUnitFramework.Logging;
using NUnitFramework.Pages.CommonPageElements.WebTable;
using NUnitFramework.Pages.Elements.WebTablesElement;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class WebTablesPage : BasePage
    {
        private IWebElement AddButton => FindElement(By.CssSelector("button#addNewRecordButton"));

        private WebTable WebTable => new WebTable(FindElement(By.XPath("//div[@class='rt-table' and @role='grid']")));

        private RegistrationFormPage RegistrationForm => new(Driver);

        public RegistrationFormPage ClickAddButton()
        {
            Logger.Log.Info("Click on Add Button");

            AddButton.Click();

            return RegistrationForm;
        }

        public string GetFirstNameByRowValue(string value) =>
            WebTable.GetCellByColumnNameAndRowValue("First Name", value).GetText();

        public string GetLastNameByRowValue(string email) =>
            WebTable.GetCellByColumnNameAndRowValue("Last Name", email).GetText();
    }
}
