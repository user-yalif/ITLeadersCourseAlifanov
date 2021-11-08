namespace ConsoleApp.WebDriver.Helpers
{
    using System.Collections.Generic;
    using ConsoleApp.WebDriver.Drivers;

    public static class WindowHelper
    {
        private static List<string> WindowHandles { get; set; } = new();

        public static string AddWindow()
        {
            var tempHandle = string.Empty;

            foreach (var handle in WebDriverManager.Driver.WindowHandles)
            {
                if (!WindowHandles.Contains(handle))
                {
                    WindowHandles.Add(handle);

                    tempHandle = handle;
                }
            }

            return tempHandle;
        }

        public static void SwitchTo(string windowHandle)
        {
            WebDriverManager.Driver.SwitchTo().Window(windowHandle);
        }

        public static void CloseCurrent()
        {
            var currentWindow = WebDriverManager.Driver.CurrentWindowHandle;

            WebDriverManager.Driver.Close();

            WindowHandles.Remove(currentWindow);
        }

        public static void CloseAllBut(string windowHandle)
        {
            foreach (var handle in WindowHandles)
            {
                if (handle != windowHandle)
                {
                    SwitchTo(handle);
                    WebDriverManager.Driver.Close();
                }
            }

            WindowHandles.RemoveAll(handle => !handle.Equals(windowHandle));

            SwitchTo(windowHandle);
        }
    }
}
