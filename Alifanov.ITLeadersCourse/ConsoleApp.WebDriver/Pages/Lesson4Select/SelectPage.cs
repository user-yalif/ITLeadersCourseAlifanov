namespace ConsoleApp.WebDriver.Pages.Lesson4Select
{
    using System;
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class SelectPage : BasePage
    {
        private IList<IWebElement> GeneralSelectOptions => FindElements(By.XPath("//select[@id='namesList']/option"));

        private IWebElement GeneralSelect => FindElement(By.CssSelector("select#namesList"));

        private IWebElement GroupedSelect => FindElement(By.CssSelector("select#groupedNames"));


        public void SelectNameInGeneralSelect(string name)
        {
            foreach (var element in GeneralSelectOptions)
            {
                if (name.Equals(element.Text, StringComparison.OrdinalIgnoreCase))
                {
                    element.Click();
                }
            }
        }

        public string GetSelectedNameInGeneralSelect()
        {
            return GeneralSelect.Text;
        }

        public void SelectOptionInGeneralSelect(string name)
        {
            var select = new SelectElement(GeneralSelect);

            select.SelectByText(name);
        }

        public string GetSelectedOptionInGeneralSelect()
        {
            return new SelectElement(GeneralSelect).SelectedOption.Text;
        }

        public void SelectOptionInGroupedSelect(string name)
        {
            var select = new SelectElement(GroupedSelect);

            select.SelectByText(name);
        }

        public string GetSelectedOptionInGroupedSelect()
        {
            return new SelectElement(GroupedSelect).SelectedOption.Text;
        }
    }
}
