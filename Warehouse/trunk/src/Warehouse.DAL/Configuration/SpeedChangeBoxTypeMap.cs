using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.DomainModel;

namespace Warehouse.DAL.Configuration
{
    public class SpeedChangeBoxTypeMap : EntityTypeConfiguration<SpeedChangeBoxType>
    {
        public SpeedChangeBoxTypeMap()
        {
            this.HasKey(t => t.SpeedChangeBoxTypeID);
            this.Property(r => r.SpeedChangeBoxName).HasMaxLength(50);

            this.ToTable("T_SpeedChangeBoxType");
            this.Property(r => r.SpeedChangeBoxTypeID).HasColumnName("SpeedChangeBoxTypeID");
            this.Property(r => r.SpeedChangeBoxName).HasColumnName("SpeedChangeBoxName");

        }

    }
}
