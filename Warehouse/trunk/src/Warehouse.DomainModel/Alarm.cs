using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
	public class Alarm
	{
		public int ID { get; set; }
		public DateTime AlarmTime { get; set; }
		public string AlarmContent { get; set; }
		public int AlarmTypeInt { get; set; }
		public string Operator { get; set; }
	}
}
