namespace Solid
{
    public class TransferInfoLogger
    {
        private readonly ILogger _logger;
        public TransferInfoLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string logInfo)
        {
            _logger.Log(logInfo);
        }
       
    }

    public interface ILogger
    {
        void Log(string logInfo);
    }

    public class ELKLogger: ILogger
    {
        public void Log(string logStr)
        {
            // send the data to the ELK
        }
    }

    public class LocaleStorageLogger: ILogger
    {
        public void Log(string logStr)
        {
            // send the data to the ELK
        }
    }

    public class MasterLogger : ILogger
    {
        public void Log(string logStr)
        {
            // send the data to the ELK
        }
    }
}
