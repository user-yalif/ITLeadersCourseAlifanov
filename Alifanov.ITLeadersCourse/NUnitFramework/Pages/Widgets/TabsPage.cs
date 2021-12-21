using NUnitFramework.Helpers;
using NUnitFramework.Logging;
using NUnitFramework.Pages.CommonPageElements.Tabs;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Widgets
{
    public class TabsPage : BasePage
    {
        private Tabs TabsRowElement => new(FindElement(By.XPath("//nav[@class='nav nav-tabs']")));

        private IWebElement OriginTabText => FindElement(By.CssSelector("div[id='demo-tabpane-origin']>p"));

        private IWebElement UseTabText => FindElement(By.CssSelector("div[id='demo-tabpane-use']>p"));

        private IWebElement WhatTabText => FindElement(By.CssSelector("div[id='demo-tabpane-what']>p"));

        public TabsPage ClickOnTab(string tabName)
        {
            Logger.Log.Info("Click on Tab");

            TabsRowElement.ClickOnTab(tabName);

            return this;
        }

        public string GetOriginTabText()
        {
            Logger.Log.Info("Get text of the Origin Tab");

            Waiter.WaitUntilElementToBeEnabled(OriginTabText);
            return OriginTabText.Text.Trim();
        }

        public string GetUSeTabText()
        {
            Logger.Log.Info("Get text of the Use Tab");

            Waiter.WaitUntilElementToBeEnabled(UseTabText);
            return UseTabText.Text.Trim();
        }

        public string GetWhatTabText()
        {
            Logger.Log.Info("Get text of the What Tab");

            Waiter.WaitUntilElementToBeEnabled(WhatTabText);
            return WhatTabText.Text.Trim();
        }
    }
}
