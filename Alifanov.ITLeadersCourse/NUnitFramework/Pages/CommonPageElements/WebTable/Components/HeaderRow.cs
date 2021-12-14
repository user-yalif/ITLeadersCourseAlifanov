namespace NUnitFramework.Pages.CommonPageElements.WebTable.Components
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;

    public class HeaderRow
    {
        private IWebElement HeaderRowElement { get; set; }

        private IList<TableCell> HeaderCells =>
            HeaderRowElement.FindElements(By.XPath(".//div[@role='columnheader']")).Select(cell => new TableCell(cell)).ToList();

        private IList<string> ColumnsNames =>
            HeaderCells.Select(cell => cell.GetText()).ToList();

        public HeaderRow(IWebElement element) => HeaderRowElement = element;

        public int GetColumnIndex(string columnName) => ColumnsNames.IndexOf(columnName);
    }
}
