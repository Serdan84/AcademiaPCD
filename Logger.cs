using NLog;

namespace AppAcademiaPcd
{
    class Logger
    {
        private static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        static void Execute(string[] args)
        {
            logger.Debug("Hello World!", args);
        }
    }
}
