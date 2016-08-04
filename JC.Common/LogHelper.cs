using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using log4net;

namespace JC.Common
{
    public class LogHelper
    {
        /// <summary>  
        /// lock对象  
        /// </summary>  
        private static object lockLog = new object();

        private static ILog _log;
        /// <summary>  
        /// 记录Log信息  
        /// </summary>  
        public static ILog ToLog
        {
            get
            {
                if (_log == null)
                {
                    lock (lockLog)
                    {
                        log4net.Config.XmlConfigurator.Configure();
                        _log = log4net.LogManager.GetLogger("log4NetTest");
                    }
                }
                return _log;
            }
        }

        /// <summary>  
        /// 记录Error日志  
        /// </summary>  
        /// <param name="msg"></param>  
        public static void Error(string msg)
        {
            LogHelper.ToLog.Error("【"+DateTime.Now.ToString()+ "】" + msg +"\r\n"+"---------------------------------------------\r\n");
        }
        /// <summary>  
        /// 记录Warn日志  
        /// </summary>  
        /// <param name="msg"></param>  
        public static void Warn(string msg)
        {
            LogHelper.ToLog.Warn("【" + DateTime.Now.ToString() + "】" + msg + "\r\n" + "---------------------------------------------\r\n");
        }
        /// <summary>  
        /// 记录Info日志  
        /// </summary>  
        /// <param name="msg"></param>  
        public static void Info(string msg)
        {
            LogHelper.ToLog.Info("【" + DateTime.Now.ToString() + "】" + msg + "\r\n" + "---------------------------------------------\r\n");
        }
        /// <summary>  
        /// 记录Debug日志  
        /// </summary>  
        /// <param name="msg"></param>  
        public static void Debug(string msg)
        {
            LogHelper.ToLog.Debug("【" + DateTime.Now.ToString() + "】" + msg + "\r\n" + "---------------------------------------------\r\n");
        }

    }
}