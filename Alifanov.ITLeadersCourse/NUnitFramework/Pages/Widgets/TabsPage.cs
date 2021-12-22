using NUnitFramework.Logging;
using NUnitFramework.Pages.CommonPageElements.Tabs;
using OpenQA.Selenium;

namespace NUnitFramework.Pages.Widgets
{
    public class TabsPage : BasePage
    {
        private Tabs TabsRowElement => new(FindElement(By.XPath("//nav[@class='nav nav-tabs']")));

        private IWebElement OriginTabText => FindElement(By.CssSelector("div[id='demo-tabpane-origin']"));

        private IWebElement UseTabText => FindElement(By.CssSelector("div[id='demo-tabpane-use']"));

        private IWebElement WhatTabText => FindElement(By.CssSelector("div[id='demo-tabpane-what']"));

        public TabsPage ClickOnTab(string tabName)
        {
            Logger.Log.Info("Click on Tab");

            TabsRowElement.ClickOnTab(tabName);

            return this;
        }

        public string GetOriginTabText()
        {
            Logger.Log.Info("Get text of the Origin Tab");

            return OriginTabText.Text.Trim();
        }

        public string GetUseTabText()
        {
            Logger.Log.Info("Get text of the Use Tab");

            return UseTabText.Text.Trim();
        }

        public string GetWhatTabText()
        {
            Logger.Log.Info("Get text of the What Tab");

            return WhatTabText.Text.Trim();
        }

        public bool IsTabDisabled(string tabName)
        {
            return TabsRowElement.IsTabDisabled(tabName);
        }
    }
}
