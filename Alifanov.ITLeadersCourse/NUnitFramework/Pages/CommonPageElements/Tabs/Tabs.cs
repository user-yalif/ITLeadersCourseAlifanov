using System;
using System.Collections.Generic;
using System.Linq;
using NUnitFramework.Helpers;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.CommonPageElements.Tabs
{
    public class Tabs
    {
        private IWebElement TabsRow { get; set; }

        private IList<IWebElement> TabsList => TabsRow.FindElements(By.XPath(".//a[@role='tab']"));

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

                Waiter.WaitUntilElementsAttributeValueContains(tabElement, "class", "active");

                var tabId = tabElement.GetAttribute("id").Split("-");
                var tabContent = TabsRow.FindElement(By.XPath($"./following-sibling::div/div[@id='{tabId.First()}-tabpane-{tabId.Last()}']"));

                Waiter.WaitUntilElementsAttributeValueContains(tabContent, "class", "active");
                Waiter.WaitUntilCertainCondition(driver => tabContent.FindElements(By.XPath("./*")).Count != 0);
            }
        }

        public bool IsTabDisabled(string tabName)
        {
            var tabElement = TabsList.FirstOrDefault(tab => tabName.Equals(tab.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            return tabElement.GetAttribute("class").Contains("disabled");
        }
    }
}
