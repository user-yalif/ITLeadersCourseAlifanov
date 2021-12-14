namespace NUnitFramework.Tests.AlertsFrameAndWindows
{
    using NUnit.Framework;
    using NUnitFramework.Navigation.LeftPanel;

    public class ModalDialogsTests : BaseTest
    {
        [Test]
        [TestCase("Small Modal", "This is a small modal.")]
        public void SmallModalTest(string expectedHeader, string expectedMessage)
        {
            var smallModal = LeftPanel.AlertsFrameAndWindows.ModalDialogs()
                .ClickOnSmallModalButton();

            var actualHeader = smallModal.GetHeader();
            var actualMessage = smallModal.GetMessage();

            smallModal.CloseModal();

            Assert.Multiple(() =>
            {
                Assert.That(actualHeader, Is.EqualTo(expectedHeader), "Wrong headers");
                Assert.That(actualMessage, Does.Contain(expectedMessage), "Wrong messages");
            });
        }
    }
}
