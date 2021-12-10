namespace NUnitFramework.Pages.CommonPageElements.WebTable
{
    using NUnitFramework.Pages.CommonPageElements.WebTable.Components;
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WebTable
    {
        private IWebElement WebTableElement { get; set; }

        private HeaderRow HeaderRow =>
            new(WebTableElement.FindElement(By.XPath(".//div[@class='rt-thead -header']")));

        private IList<TableRow> TableRows =>
            WebTableElement.FindElements(By.XPath(".//div[@class='rt-tbody']//div[@role='row']")).Select(row => new TableRow(row)).ToList();

        public WebTable(IWebElement element) => WebTableElement = element;

        public TableCell GetCellByColumnNameAndRowValue(string columnName, string value)
        {
            var columnIdex = HeaderRow.GetColumnIndex(columnName);
            var tableRow = GetRow(row => row.HasValue(value));

            return tableRow.GetCell(columnIdex);
        }

        public TableRow GetRow(Func<TableRow, bool> predicate) => TableRows.FirstOrDefault(predicate);
    }
}
