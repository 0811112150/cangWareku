using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.ViewModel
{
    public class WebPutInWarehouseRecord : WebWarehouseM
    {
        private string _place = string.Empty;

        public int PutInWarehouseRecordID { get; set; }
        public DateTime PutInTime { get; set; }
        public string Place { get { return _place; } set { _place = value; } }
        public int StateID { get; set; }
        public string PutInUserName { get; set; }
    }
}
