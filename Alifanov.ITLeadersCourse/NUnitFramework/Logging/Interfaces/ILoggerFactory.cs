namespace NUnitFramework.Logging.Interfaces
{
    using NUnitFramework.Enums;

    public abstract class ILoggerFactory
    {
        public abstract ILoggerInstance GetLogger(LoggerType logger);
    }
}
