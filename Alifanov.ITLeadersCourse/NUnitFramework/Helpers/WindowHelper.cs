using NUnitFramework.Drivers;
using System.Collections.Generic;

namespace NUnitFramework.Helpers
{
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
