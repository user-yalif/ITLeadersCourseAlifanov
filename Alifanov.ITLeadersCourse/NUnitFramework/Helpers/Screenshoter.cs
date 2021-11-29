namespace NUnitFramework.Helpers
{
    using System;
    using System.IO;
    using OpenQA.Selenium;

    public static class Screenshoter
    {
        private static string GetScreenshotName(string fileName) =>
            @$"{DateTime.Now:yyyy-MM-dd_HH-mm-ss}{"_" + fileName}.png";

        public static string TakeScreenshot(IWebDriver driver, string outputPath, string testName)
        {
            var screenshotName = GetScreenshotName(testName);
            var pathToSave = Path.Combine(outputPath, screenshotName);

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(pathToSave, ScreenshotImageFormat.Png);

            return screenshotName;
        }
    }
}
