namespace NUnitFramework.Logging.Interfaces
{
    public interface ILoggerInstance
    {
        ILoggerInstance SetUpLogger();

        void Info(string message);

        void Info(string message, params object[] args);

        void Worn(string message);

        void Worn(string message, params object[] args);

        void Error(string message);

        void Error(string message, params object[] args);
    }
}
