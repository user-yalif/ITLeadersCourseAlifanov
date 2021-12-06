﻿using NUnitFramework.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace NUnitFramework.Pages.Elements
{
    public class ButtonsPage : BasePage
    {
        private IWebElement DoubleClickMeButton => FindElement(By.CssSelector("button#doubleClickBtn"));

        private IWebElement DoubleClickButtonMessage => FindElement(By.CssSelector("p#doubleClickMessage"));

        private IWebElement ClickMeButton => FindElement(By.XPath("//button[normalize-space()='Click Me']"));

        private IWebElement ClickMeButtonMessage => FindElement(By.CssSelector("p#dynamicClickMessage"));

        private IWebElement RightClickMeButton => FindElement(By.CssSelector("button#rightClickBtn"));

        private IWebElement RightClickMeButtonMessage => FindElement(By.CssSelector("p#rightClickMessage"));


        public ButtonsPage ClickOnDoubleClickMeButton()
        {
            Logger.Log.Info("Click on Double Click Me button");

            Actions actions = new Actions(Driver);

            actions.DoubleClick(DoubleClickMeButton);
            actions.Build()
                .Perform();

            return this;
        }

        public string GetDoubleClickMeButtonMessage()
        {
            Logger.Log.Info("Try to get Double Click Me button message");

            return DoubleClickButtonMessage.Text;
        }

        public ButtonsPage RightClickOnRightClickMeButton()
        {
            Logger.Log.Info("Click on Right Click Me Button");

            Actions actions = new Actions(Driver);

            actions.ContextClick(RightClickMeButton);
            actions.Build()
                .Perform();

            return this;
        }

        public string GetRightClickMeButtonMessage()
        {
            Logger.Log.Info("Try to get Right Click Me button message");

            return RightClickMeButtonMessage.Text;
        }

        public ButtonsPage ClickOnClickMeButton()
        {
            Logger.Log.Info("Click on Click Me Button");

            ClickMeButton.Click();

            return this;
        }

        public string GetMessageAfterClickOnClickMeButton()
        {
            Logger.Log.Info("Try to get Click Me button message");

            return ClickMeButtonMessage.Text;
        }
    }
}
