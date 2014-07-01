using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMCares.BMS.FDI.Common
{
    public class Log
    {
        private readonly string path = AppDomain.CurrentDomain.BaseDirectory + @"Config\Log4net.config";

        private ILog logger = null;

        public Log()
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
            logger = LogManager.GetLogger("XMCares.BMS.FDI");
        }

        public Log(Type type)
        {
            log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
            logger = LogManager.GetLogger(type);
        }

        public static Log GetLogger(Type type)
        {
            return new Log(type);
        }

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Fatal(string message)
        {
            logger.Fatal(message);
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Warn(string message)
        {
            logger.Warn(message);
        }   
    }
}
