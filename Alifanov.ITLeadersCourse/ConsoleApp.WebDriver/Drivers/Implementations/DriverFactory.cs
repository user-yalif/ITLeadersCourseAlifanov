namespace ConsoleApp.WebDriver.Drivers.Implementations
{
    using System;
    using ConsoleApp.WebDriver.Drivers.Interfaces;
    using ConsoleApp.WebDriver.Enums;

    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(BrowserType driverType)
        {
            switch (driverType)
            {
                case BrowserType.Chrome:
                    return new Chrome();
                case BrowserType.IE:
                    return default;
                default:
                    throw new PlatformNotSupportedException($"{driverType} browser is not supported!");
            }
        }
    }
}
