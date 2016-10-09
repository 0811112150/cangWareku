using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Warehouse.Common
{
	public class ConfigHelper
	{
		public static string AlarmFileName { get { return GetStringValue("AlarmFileName"); } }

		public static string PrinterName { get { return GetStringValue("PrinterName"); } }
        
		public static string SerialPortName { get { return GetStringValue("SerialPortName"); } }

        public static string TwoCodePre { get { return GetStringValue("TwoCodePre"); } }

		static bool GetBoolValue(string settingName)
		{
			if (string.IsNullOrEmpty(ConfigurationManager.AppSettings[settingName])) {
				return false;
			}
			try {
				return Convert.ToBoolean(ConfigurationManager.AppSettings[settingName]);
			} catch (Exception) {
				return false;
			}
		}

		static string GetStringValue(string settingName)
		{
			if (string.IsNullOrEmpty(ConfigurationManager.AppSettings[settingName])) {
				return string.Empty;
			}
			try {
				return ConfigurationManager.AppSettings[settingName].ToString();
			} catch (Exception) {
				return string.Empty;
			}
		}
	}
}
