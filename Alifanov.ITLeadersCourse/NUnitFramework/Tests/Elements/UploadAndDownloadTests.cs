namespace NUnitFramework.Tests.Elements
{
    using NUnit.Framework;
    using NUnitFramework.Navigation.LeftPanel;
    using NUnitFramework.Utils;
    using System.IO;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public class UploadAndDownloadTests : BaseTest
    {
        [Test]
        public void DownloadFileTest()
        {
            var fileName = LeftPanel.Elements.UploadAndDowload()
                .DownloadFile(DownloadDirectory);

            var pathToFile = PathUtils.Combine(DownloadDirectory, fileName);
            FileInfo fileInfo = new(pathToFile);

            Assert.Multiple(() => 
            {
                Assert.That(fileInfo.Length, Is.EqualTo(4096), "Wrong file size");
                Assert.That(fileInfo.Name, Is.EqualTo(fileName), "Wrong file name");
                Assert.That(fileInfo.FullName, Is.EqualTo(pathToFile), "Wrong path to file");
            });
        }

        [Test]
        public void UploadFileTest()
        {
            var pathToFile = PathUtils.ConfigurePathToBaseDirectory(Settings.TestData.JpegFileToUpload);

            var uploadedFilePath = LeftPanel.Elements.UploadAndDowload()
                .UploadFile(pathToFile)
                .GetUploadedFileOutputPath();

            Assert.That(uploadedFilePath, Is.EqualTo(@"C:\fakepath\sampleFile.jpeg"), "Wrong uploaded path");
        }
    }
}
