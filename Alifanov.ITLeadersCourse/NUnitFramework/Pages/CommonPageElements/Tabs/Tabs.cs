using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFramework.Pages.CommonPageElements.Tabs
{
    public class Tabs
    {
        private IWebElement TabsRow { get; set; }

        private IList<IWebElement> TabsList => TabsRow.FindElements(By.XPath("//a[@role='tab']"));

        public Tabs(IWebElement element)
        {
            TabsRow = element;
        }

        public void ClickOnTab(string tabName)
        {
            var tabElement = TabsList.FirstOrDefault(tab => tabName.Equals(tab.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            var isSelected = tabElement.GetAttribute("class").Contains("active");
            var isDisabled = tabElement.GetAttribute("class").Contains("disabled");

            if (!isSelected && !isDisabled)
            {
                tabElement.Click();
            }
        }
    }
}
