using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.ViewModel
{
    public class WebWarehouseM
    {
        private string _speedChangeBoxName = string.Empty;
        private string _staff = string.Empty;
        private string _dispathPlace = string.Empty;
        private string _barCode = string.Empty;

        public int WarehouseID { get; set; }
        public string BarCode { get { return _barCode; } set { _barCode = value; } }
        public DateTime WarehouseTime { get; set; }
        public string Staff { get { return _staff; } set { _staff = value; } }
        public string DispathPlace { get { return _dispathPlace; } set { _dispathPlace = value; } }
        public DateTime DispathTime { get; set; }

        public string SpeedChangeBoxName { get { return _speedChangeBoxName; } set { _speedChangeBoxName = value; } }
    }
}
