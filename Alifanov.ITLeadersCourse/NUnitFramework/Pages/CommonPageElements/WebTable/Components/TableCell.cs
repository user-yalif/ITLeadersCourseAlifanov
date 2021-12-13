namespace NUnitFramework.Pages.CommonPageElements.WebTable.Components
{
    using OpenQA.Selenium;

    public class TableCell
    {
        private IWebElement CellElement { get; set; }

        public TableCell(IWebElement element) => CellElement = element;

        public string GetText() => CellElement.Text;

        public bool HasValue() => !string.IsNullOrEmpty(CellElement.Text);

        public bool HasValue(string value) =>
            CellElement.Text.Trim().Equals(value, System.StringComparison.OrdinalIgnoreCase);

        public IWebElement GetCellValue(By locator) =>
            CellElement.FindElement(locator);
    }
}
