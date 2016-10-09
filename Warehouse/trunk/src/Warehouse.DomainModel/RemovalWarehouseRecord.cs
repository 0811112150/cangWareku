using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
    public class RemovalWarehouseRecord
    {
        public int RemovalWarehourseRecordID { get; set; }

        public int? WarehouseID { get; set; }

        public int StateID { get; set; }
        public DateTime RemovalWarehouseTime { get; set; }
        public int OrderID { get; set; }

        public virtual WarehouseM WarehouseM { get; set; }
        public virtual RemovalWarehouseOrder RemovalWarehouseOrder { get; set; }
    }
}
