using NUnitFramework.Logging;
using NUnitFramework.Pages.CommonPageElements.WebTable;
using NUnitFramework.Pages.Elements.WebTablesElements;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Elements
{
    public class WebTablesPage : BasePage
    {
        private IWebElement AddButton => FindElement(By.CssSelector("button#addNewRecordButton"));

        private WebTable WebTable => new(FindElement(By.XPath("//div[@class='rt-table' and @role='grid']")));

        private RegistrationFormPage RegistrationForm => new(Driver);

        public RegistrationFormPage ClickAddButton()
        {
            Logger.Log.Info("Click on Add Button");

            AddButton.Click();

            return RegistrationForm;
        }

        public string GetFirstNameByRowValue(string rowValue) =>
            WebTable.GetCellByColumnNameAndRowValue("First Name", rowValue).GetText();

        public string GetLastNameByRowValue(string rowValue) =>
            WebTable.GetCellByColumnNameAndRowValue("Last Name", rowValue).GetText();

        public string GetEmailByRowValue(string rowValue) =>
            WebTable.GetCellByColumnNameAndRowValue("Email", rowValue).GetText();

        public string GetAgeByRowValue(string rowValue) =>
            WebTable.GetCellByColumnNameAndRowValue("Age", rowValue).GetText();

        public string GetSalaryByRowValue(string rowValue) =>
            WebTable.GetCellByColumnNameAndRowValue("Salary", rowValue).GetText();

        public string GetDepartmentByRowValue(string rowValue) =>
            WebTable.GetCellByColumnNameAndRowValue("Department", rowValue).GetText();

        public int GetNotEmptyRowsCount()
        {
            Logger.Log.Info("Getting count of non empty rows");

            return WebTable.GetNotEmptyTableRows().Count;
        }

        public WebTablesPage ClickOnDeleteButtonByRowValue(string rowValue)
        {
            Logger.Log.Info("Click on Row Delete button");

            var actionCell = WebTable.GetCellByColumnNameAndRowValue("Action", rowValue);
            actionCell.GetCellValue(By.XPath(".//span[@title='Delete']")).Click();

            return this;
        }

        public RegistrationFormPage ClickOnEditButtonByRowValue(string rowValue)
        {
            Logger.Log.Info("Click on Row Edit button");

            var actionCell = WebTable.GetCellByColumnNameAndRowValue("Action", rowValue);
            actionCell.GetCellValue(By.XPath(".//span[@title='Edit']")).Click();

            return RegistrationForm;
        }
    }
}
