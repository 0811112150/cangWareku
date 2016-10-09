using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
    public class WarehouseM
    {
        public WarehouseM()
        {
            this.RemovalWarehourseRecords = new List<RemovalWarehouseRecord>();
			this.PutInWarehouseRecords = new List<PutInWarehouseRecord>();
        }

        public int WarehouseID { get; set; }

        public string BarCode { get; set; }

        public int? TwoDimensioncodeID { get; set; }

        public DateTime WarehouseTime { get; set; }

        public int StateID { get; set; }
        public string PutInUserName { get; set; }
        public string Place { get; set; }

        public virtual TwoDimensioncode TwoDimensioncode { get; set; }
        public virtual ICollection<RemovalWarehouseRecord> RemovalWarehourseRecords { get; set; }
        public virtual ICollection<PutInWarehouseRecord> PutInWarehouseRecords { get; set; }
    }
}
