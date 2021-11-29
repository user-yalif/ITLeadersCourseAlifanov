namespace NUnitFramework.Drivers.Implementations
{
    using System;
    using NUnitFramework.Drivers.Interfaces;
    using NUnitFramework.Enums;

    public class DriverFactory : IDriverFactory
    {
        public override IDriver GetDriver(BrowserType browserType)
        {
            return browserType switch
            {
                BrowserType.Chrome => new Chrome(),
                _ => throw new PlatformNotSupportedException($"{browserType} browser is not supported!")
            };
        }
    }
}
