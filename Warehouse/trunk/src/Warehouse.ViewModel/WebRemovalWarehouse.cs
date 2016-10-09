using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.ViewModel
{
    public class WebRemovalWarehouse : WebWarehouseM
    {
        public int RemovalWarehourseRecordID { get; set; }
        public DateTime RemovalWarehouseTime { get; set; }
        //public int? TwoDimensioncodeID { get; set; }

        public int StateID { get; set; }
    }
}
