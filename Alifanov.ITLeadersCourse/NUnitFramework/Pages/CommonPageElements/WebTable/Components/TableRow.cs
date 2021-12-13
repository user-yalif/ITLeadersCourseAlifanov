namespace NUnitFramework.Pages.CommonPageElements.WebTable.Components
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;

    public class TableRow
    {
        private IWebElement RowElement { get; set; }

        private IList<TableCell> RowCells =>
            RowElement.FindElements(By.XPath(".//div[@role='gridcell']")).Select(cell => new TableCell(cell)).ToList();

        public TableRow(IWebElement element) => RowElement = element;

        public bool HasValue(string value) =>
            RowCells.FirstOrDefault(cell => cell.HasValue(value)) != null;

        public TableCell GetCell(int index) => RowCells[index];
    }
}
