namespace ConsoleApp.WebDriver.Pages.Lesson8ComplexActions
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class DroppablePage : BasePage
    {
        private IWebElement DemoFrame => FindElement(By.ClassName("demo-frame"));

        private IWebElement DraggableElement => FindElement(By.Id("draggable"));

        private IWebElement DroppableElement => FindElement(By.Id("droppable"));

        private IWebElement MessageElement => FindElement(By.CssSelector("div#droppable p"));

        public DroppablePage SwitchToDemoFrame()
        {
            Driver.SwitchTo().Frame(DemoFrame);

            return this;
        }

        public DroppablePage DragAndDropDraggableElement()
        {
            new Actions(Driver)
                .DragAndDrop(DraggableElement, DroppableElement)
                .Build()
                .Perform();

            return this;
        }

        public string GetMessage() => MessageElement.Text;

        public DroppablePage SwitchToSelf()
        {
            Driver.SwitchTo().DefaultContent();

            return this;
        }
    }
}
