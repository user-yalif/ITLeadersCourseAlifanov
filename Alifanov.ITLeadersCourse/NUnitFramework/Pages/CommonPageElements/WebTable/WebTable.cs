namespace NUnitFramework.Pages.CommonPageElements.WebTable
{
    using NUnitFramework.Logging;
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
            Logger.Log.Info("Try to get cell by column name and row value");

            var columnIdex = HeaderRow.GetColumnIndex(columnName);
            var tableRow = GetRow(row => row.HasValue(value));

            return tableRow.GetCell(columnIdex);
        }

        public TableRow GetRow(Func<TableRow, bool> predicate) => TableRows.FirstOrDefault(predicate);

        public List<TableRow> GetNotEmptyTableRows()
        {
            Logger.Log.Info("Try to get non empty table rows");

            List<TableRow> notEmptyTableRows = new List<TableRow>();

            foreach (var row in TableRows)
            {
                if (!string.IsNullOrEmpty(row.GetCell(3).GetText().Trim()))
                {
                    notEmptyTableRows.Add(row);
                }
            }

            return notEmptyTableRows;
        }
    }
}
