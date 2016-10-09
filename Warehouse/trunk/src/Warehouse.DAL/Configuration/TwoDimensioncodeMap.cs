using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.DomainModel;

namespace Warehouse.DAL.Configuration
{
    public class TwoDimensioncodeMap : EntityTypeConfiguration<TwoDimensioncode>
    {
        public TwoDimensioncodeMap()
        {
            this.HasKey(t => t.TwoDimensioncodeID);

            this.Property(r => r.TwoDimensionCodeNum).HasMaxLength(500);

            this.ToTable("T_ TwoDimensionCode");
            this.Property(r => r.TwoDimensioncodeID).HasColumnName("TwoDimensioncodeID");
            this.Property(r => r.TwoDimensionCodeNum).HasColumnName("TwoDimensionCodeNum");
            this.Property(r => r.Count).HasColumnName("Count");
            this.Property(r => r.SpeedChangeBoxTypeID).HasColumnName("SpeedChangeBoxTypeID");
			this.Property(r => r.StateID).HasColumnName("StateID");

            this.HasOptional(r=>r.SpeedChangeBoxType)
                .WithMany(r=>r.TwoDimensioncodes)
                .HasForeignKey(r => r.SpeedChangeBoxTypeID);
        }
    }
}
