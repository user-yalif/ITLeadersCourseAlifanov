namespace NUnitFramework.Logging
{
    using NUnitFramework.Logging.Imlementations;
    using NUnitFramework.Logging.Interfaces;
    using static NUnitFramework.AppSettings.SettingsConfigurator;

    public class Logger
    {
        private static ILoggerInstance loggerInstance;

        public static ILoggerInstance Log
        {
            get
            {
                return loggerInstance ??= new LoggerFactory()
                    .GetLogger(Settings.Logger)
                    .SetUp();
            }
        }
    }
}
