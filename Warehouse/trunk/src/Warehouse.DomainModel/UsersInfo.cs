using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
    public class UsersInfo
    {
        public int ID { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int? DepartmentID { get; set; }
        public int StateID { get; set; }

        public virtual Department Department { get; set; }
    }
}
