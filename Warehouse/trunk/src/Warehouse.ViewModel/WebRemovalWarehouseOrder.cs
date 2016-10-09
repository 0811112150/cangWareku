using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.ViewModel
{
	public class WebRemovalWarehouseOrder
	{
		private string _staff = string.Empty;
		private string _dispathPlace = string.Empty;
		private IEnumerable<WebRemovalWarehouse> _webRemovalWarehouses = new List<WebRemovalWarehouse>();
		private string _speedChangeBoxName = string.Empty;

		public int OrderID { get; set; }
		public int? Count { get; set; }
		public string Staff { get { return _staff; } set { _staff = value; } }
		public string DispathPlace { get { return _dispathPlace; } set { _dispathPlace = value; } }
		public DateTime DispathTime { get; set; }
		public string SpeedChangeBoxName { get { return _speedChangeBoxName; } set { _speedChangeBoxName = value; } }
		public int PlanCount { get; set; }

		public IEnumerable<WebRemovalWarehouse> WebRemovalWarehouses { get { return _webRemovalWarehouses; } set { _webRemovalWarehouses = value; } }

	}
}
