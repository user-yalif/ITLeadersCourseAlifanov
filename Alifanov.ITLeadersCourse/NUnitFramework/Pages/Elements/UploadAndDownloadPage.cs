namespace NUnitFramework.Pages.Elements
{
    using NUnitFramework.Helpers;
    using NUnitFramework.Logging;
    using NUnitFramework.Utils;
    using OpenQA.Selenium;

    public class UploadAndDownloadPage : BasePage
    {
        private readonly By UploadedFileOutputLocator = By.CssSelector("p#uploadedFilePath");

        private IWebElement DownloadButton => FindElement(By.XPath("//a[@id='downloadButton' and normalize-space()='Download']"));

        private IWebElement UploadButton => FindElement(By.XPath("//input[@id='uploadFile']"));

        private IWebElement UploadedFileOutput => FindElement(UploadedFileOutputLocator);

        public string DownloadFile(string dowloadPath)
        {
            var fileName = DownloadButton.GetAttribute("download");
            var pathToFile = PathUtils.Combine(dowloadPath, fileName);

            Logger.Log.Info("Start {0} file downloading", fileName);

            DownloadButton.Click();

            Waiter.WaitUntilSertainCondition(driver => FileUtils.Exists(pathToFile));

            Logger.Log.Info("Fiel {0} was downloaded", fileName);

            return fileName;
        }

        public UploadAndDownloadPage UploadFile(string pathToFile)
        {
            Logger.Log.Info("Start {0} file uploading", pathToFile);

            UploadButton.SendKeys(pathToFile);

            return this;
        }

        public string GetUploadedFileOutputPath()
        {
            Logger.Log.Info("Try to get uploaded file path");

            Waiter.WaitUntilElementToBePresent(UploadedFileOutputLocator);

            return UploadedFileOutput.Text;
        }
    }
}
