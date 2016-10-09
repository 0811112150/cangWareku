using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.DomainModel
{
    public class SpeedChangeBoxType
    {
        public SpeedChangeBoxType()
        {
            this.TwoDimensioncodes = new List<TwoDimensioncode>();
        }

        public int SpeedChangeBoxTypeID { get; set; }

        public string SpeedChangeBoxName { get; set; }

        public virtual ICollection<TwoDimensioncode> TwoDimensioncodes { get; set; }
    }
}
