using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
	public class TwoDimensioncode
	{
		public TwoDimensioncode()
		{
			this.WarehouseMs = new List<WarehouseM>();
			//this.RemovalWarehourseRecords = new List<RemovalWarehourseRecord>();
			//this.PutInWarehouseRecords = new List<PutInWarehouseRecord>();
		}

		public int TwoDimensioncodeID { get; set; }
		public string TwoDimensionCodeNum { get; set; }
		public int Count { get; set; }
		public int? SpeedChangeBoxTypeID { get; set; }


		public virtual ICollection<WarehouseM> WarehouseMs { get; set; }
		//public virtual ICollection<RemovalWarehourseRecord> RemovalWarehourseRecords { get; set; }
		//public virtual  ICollection<PutInWarehouseRecord> PutInWarehouseRecords { get; set; }
		public virtual SpeedChangeBoxType SpeedChangeBoxType { get; set; }
		public int StateID { get; set; }
	}
}
