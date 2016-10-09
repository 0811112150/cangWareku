using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
    public class PutInWarehouseRecord
    {
        public int PutInWarehouseRecordID { get; set; }
        public DateTime PutInTime { get; set; }
        public string Place { get; set; }
        public int? WarehouseID { get; set; }
        //public int? TwoDimensioncodeID { get; set; }
        public int StateID { get; set; }
        public string PutInUserName { get; set; }
        
        public virtual WarehouseM WarehouseM { get; set; }
        //public virtual TwoDimensioncode TwoDimensioncode { get; set; }
    }
}
