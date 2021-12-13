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

        public string GetLastNameByRowValue(string value) =>
            WebTable.GetCellByColumnNameAndRowValue("Last Name", value).GetText();
        public string GetEmailByRowValue(string value) =>
            WebTable.GetCellByColumnNameAndRowValue("Email", value).GetText();

        public string GetAgeByRowValue(string value) =>
            WebTable.GetCellByColumnNameAndRowValue("Age", value).GetText();

        public string GetDepartmentByRowValue(string value) =>
            WebTable.GetCellByColumnNameAndRowValue("Department", value).GetText();

        public int GetNotEmptyRowsCount()
        {
            Logger.Log.Info("Getting count of non empty rows");

            return WebTable.GetNotEmptyTableRows().Count;
        }

        public WebTablesPage ClickOnRowDeleteButtonByEmail(string email)
        {
            Logger.Log.Info("Click on Row Delete button");

            var actionCell = WebTable.GetCellByColumnNameAndRowValue("Action", email);
            actionCell.GetCellValue(By.XPath(".//span[@title='Delete']")).Click();

            return this;
        }
    }
}
