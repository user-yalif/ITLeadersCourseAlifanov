namespace NUnitFramework.Drivers.Interfaces
{
    using NUnitFramework.Enums;

    public abstract class IDriverFactory
    {
        public abstract IDriver GetDriver(BrowserType driverType);
    }
}
