namespace ConsoleApp.WebDriver.Helpers
{
    using ConsoleApp.WebDriver.Drivers;

    public static class AlertHelper
    {
        public static string AcceptAlert()
        {
            var alert = WebDriverManager.Driver.SwitchTo().Alert();

            var alertMessage = alert.Text;
            alert.Accept();

            WebDriverManager.Driver.SwitchTo().DefaultContent();

            return alertMessage;
        }

        public static void DismissAlert()
        {
            WebDriverManager.Driver.SwitchTo().Alert().Dismiss();
            WebDriverManager.Driver.SwitchTo().DefaultContent();
        }
    }
}
