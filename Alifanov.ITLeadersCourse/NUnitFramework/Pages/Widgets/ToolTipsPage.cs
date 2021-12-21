using NUnitFramework.Helpers;
using NUnitFramework.Logging;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace NUnitFramework.Pages.Widgets
{
    public class ToolTipsPage : BasePage
    {
        private IWebElement HoverMeToSeeButton => FindElement(By.XPath("//button[@id='toolTipButton']"));

        private IWebElement HoverMeToSeeToolTip => FindElement(By.XPath("//div[@class='tooltip-inner']"));

        public ToolTipsPage MoveToHoverMeToSeeButton()
        {
            Actions actions = new Actions(Driver);

            actions.MoveToElement(HoverMeToSeeButton)
                .Build()
                .Perform();

            return this;
        }

        public string GetTextOfToolTipHoverMeToSeeButton()
        {
            Logger.Log.Info("Get text of Tool Tip from Hover Me To See Button");

            Waiter.WaitUntilElementToBeEnabled(HoverMeToSeeToolTip);

            return HoverMeToSeeToolTip.Text.Trim();
        }
    }
}
