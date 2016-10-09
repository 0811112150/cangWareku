using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.ViewModel
{
	public class WebAlarm
	{
		private string _alarmContent = string.Empty;
		private string _operator = string.Empty;

		public string Operator { get { return _operator; } set { _operator = value; } }

		public string AlarmContent { get { return _alarmContent; } set { _alarmContent = value; } }

		public int ID { get; set; }
		public DateTime AlarmTime { get; set; }
		public int AlarmTypeInt { get; set; }
		public string AlarmTypeName { get; set; }

	}
}
