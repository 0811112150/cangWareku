using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using log4net;

namespace Warehouse.Common
{
	public static class LogHelper
	{
		private static ILog _log;

		static LogHelper()
		{
			var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.config");
			log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(path));
			_log = LogManager.GetLogger("Logging");
		}

		public static void Info(object message)
		{
			if (_log.IsInfoEnabled) {
				_log.Info(message);
			}
		}

		public static void Error(object message)
		{
			if (_log.IsErrorEnabled) {
				_log.Error(message);
			}
		}

		public static void Debug(object message)
		{
			if (_log.IsDebugEnabled) {
				_log.Debug(message);
			}
		}

		public static void Fatal(object message)
		{
			if (_log.IsFatalEnabled) {
				_log.Fatal(message);
			}
		}

		public static void Warn(object message)
		{
			if (_log.IsWarnEnabled) {
				_log.Warn(message);
			}
		}
	}
}
