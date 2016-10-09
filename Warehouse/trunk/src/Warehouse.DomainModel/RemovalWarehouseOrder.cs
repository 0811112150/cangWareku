using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
	public class RemovalWarehouseOrder
	{
		public RemovalWarehouseOrder()
		{
			this.RemovalWarehouseRecords = new List<RemovalWarehouseRecord>();
		}

		public int OrderID { get; set; }
		public string Staff { get; set; }
		public string DispathPlace { get; set; }
		public int StateID { get; set; }
		public DateTime DispathTime { get; set; }
		public string SpeedChangeBoxName { get; set; }
		public int PlanCount { get; set; }

		public virtual ICollection<RemovalWarehouseRecord> RemovalWarehouseRecords { get; set; }
	}
}
