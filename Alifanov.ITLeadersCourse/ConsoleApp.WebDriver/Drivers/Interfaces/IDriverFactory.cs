namespace ConsoleApp.WebDriver.Drivers.Interfaces
{
    using ConsoleApp.WebDriver.Enums;

    public abstract class IDriverFactory
    {
        public abstract IDriver GetDriver(BrowserType driverType);
    }
}
