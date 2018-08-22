using log4net;

namespace DesignWeb_Project.Helpers
{
    internal class MyLogger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MyLogger));

        public static ILog Log
        {
            get { return MyLogger.log; }
        }
    }
}