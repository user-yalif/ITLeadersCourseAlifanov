namespace NUnitFramework.Pages.CommonPageElements.WebTable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NUnitFramework.Pages.CommonPageElements.WebTable.Components;
    using OpenQA.Selenium;

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

        public TableRow GetRow(Func<TableRow, bool> predicate) =>
            TableRows.FirstOrDefault(predicate);

        public List<TableRow> GetNotEmptyTableRows()
        {
            List<TableRow> notEmptyTableRows = new();

            foreach (var row in TableRows)
            {
                if (row.GetCell(3).HasValue())
                {
                    notEmptyTableRows.Add(row);
                }
            }

            return notEmptyTableRows;
        }
    }
}
