using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Microsoft.Practices.Unity.Configuration;

namespace XMCares.BMS.FDI.Common
{
    public class ConfigHelper
    {
        private static string dbConnStr = string.Empty;
        public static string DbConnStr
        {
            get { return dbConnStr = string.IsNullOrEmpty(dbConnStr) ? ConfigurationManager.ConnectionStrings["DbConnStr"].ToString() : dbConnStr; }
        }

        /// <summary>
        /// Rabbit MQ服务端连接字符串
        /// </summary>
        private static string rmqServiceUrl = string.Empty;
        /// <summary>
        /// Rabbit MQ服务端连接字符串
        /// </summary>
        public static string RmqServiceUrl
        {
            get
            {
                return rmqServiceUrl = string.IsNullOrEmpty(rmqServiceUrl) ? ConfigurationManager.AppSettings["RmqServiceUrl"].ToString() : rmqServiceUrl;
            }
        }

        private static string subQueue = string.Empty;
        public static string SubQueue
        {
            get { return subQueue = string.IsNullOrEmpty(subQueue) ? ConfigurationManager.AppSettings["SubQueue"].ToString() : subQueue; }
        }

        private static string pubQueue = string.Empty;
        public static string PubQueue
        {
            get { return pubQueue = string.IsNullOrEmpty(pubQueue) ? ConfigurationManager.AppSettings["PubQueue"].ToString() : pubQueue; }
        }
    }
}
