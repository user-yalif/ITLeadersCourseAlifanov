using NUnitFramework.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace NUnitFramework.Pages.Elements
{
    public class ButtonsPage : BasePage
    {
        private IWebElement DoubleClickMeButton => FindElement(By.CssSelector("button#doubleClickBtn"));

        private IWebElement DoubleClickButtonMessage => FindElement(By.CssSelector("p#doubleClickMessage"));

        public ButtonsPage ClickOnDoubleClickMeButton()
        {
            Logger.Log.Info("Click on Double Click Me button");

            Actions actions = new Actions(Driver);

            actions.DoubleClick(DoubleClickMeButton);
            actions.Build()
                .Perform();

            return this;
        }

        public string GetMessageAfterDoubleClick()
        {
            Logger.Log.Info("Get message after clicking on Double Click Me button");

            return DoubleClickButtonMessage.Text;
        }
<<<<<<< Updated upstream
=======

        public ButtonsPage RightClickOnRightClickMeButton()
        {
            Logger.Log.Info("Click on Right Click Me Button");
            Actions actions = new Actions(Driver);
            actions.ContextClick(RightClickMeButton);
            actions.Build()
                .Perform();

            return this;
        }
        public string GetMessageAfterRightClickMe()
        {
            Logger.Log.Info("Get message after right clicking on Right Click Me button");
            return RightClickMeButtonMessage.Text;
        }
>>>>>>> Stashed changes
    }
}
