namespace ConsoleApp.WebDriver.Pages.Lesson7IFrame
{
    using OpenQA.Selenium;

    public class IFramePage : BasePage
    {
        private IWebElement FirstFrameElement => FindElement(By.Id("frame1"));

        private IWebElement IFrameHeader => FindElement(By.Id("pageHeader"));

        public FirstFramePage SwitchToFirstFrame()
        {
            Driver.SwitchTo().Frame(FirstFrameElement);

            return new FirstFramePage();
        }

        public string GetIFrameHeader() => IFrameHeader.Text;

        public IFramePage SwitchToSelf()
        {
            Driver.SwitchTo().DefaultContent();

            return this;
        }
    }
}
