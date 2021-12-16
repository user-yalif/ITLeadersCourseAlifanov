namespace NUnitFramework.Pages.CommonPageElements.WebTable.Components
{
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;

    public class TableRow
    {
        private IWebElement TableRowElement { get; set; }

        private IList<TableCell> RowCells =>
            TableRowElement.FindElements(By.XPath(".//div[@role='gridcell']")).Select(cell => new TableCell(cell)).ToList();

        public TableRow(IWebElement element) => TableRowElement = element;

        public bool HasValue(string value) =>
            RowCells.FirstOrDefault(cell => cell.HasValue(value)) != null;

        public TableCell GetCell(int index) => RowCells[index];
    }
}
