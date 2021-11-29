namespace NUnitFramework.Tests.Elements
{
    using NUnit.Framework;
    using NUnitFramework.Navigation.LeftPanel;

    public class DynamicPropertiesTests : BaseTest
    {
        [Test]
        [TestCase(true)]
        public void WaitButtonToBeEnabled(bool expectedResult)
        {
            var dynamicPropertiesPage = LeftPanel.Elements.DynamicProperties();

            var isButtonEnabled = dynamicPropertiesPage.IsEnableAfterButtonEnabled();

            Assert.That(isButtonEnabled, Is.EqualTo(expectedResult), "Button should be enabled");
        }
    }
}
