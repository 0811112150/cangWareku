using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.ViewModel
{
    public class WebDepartment
    {
        private string _departmentName = string.Empty;

        public string DepartmentName
        {
            get { return _departmentName; }
            set { _departmentName = value; }
        }

        public int DepartmentID { get; set; }

    }
}
