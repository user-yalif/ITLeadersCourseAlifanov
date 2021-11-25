namespace NUnitFramework.Helpers
{
    using System;
    using OpenQA.Selenium;

    public static class Screenshoter
    {
        private static string ConfigureScreenshotName(string output) =>
            string.Concat(output, @$"\{DateTime.Now:yyyy-MM-dd-HH-mm-ss}{"_Name"}.png");

        public static string TakeScreenshot(IWebDriver driver, string outputPath, string testName)
        {
            var screenshotName = ConfigureScreenshotName(outputPath);

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(screenshotName, ScreenshotImageFormat.Png);

            return screenshotName;
        }
    }
}
