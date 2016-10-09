using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.Common;
using Warehouse.DomainModel;

namespace Warehouse.DAL
{
    public class PutInWarehouseRecordMap : EntityTypeConfiguration<PutInWarehouseRecord>
    {
        public PutInWarehouseRecordMap()
        {
            this.HasKey(t => t.PutInWarehouseRecordID);
            this.Property(t => t.PutInTime)
                .IsRequired();

            this.Property(r => r.Place)
                .HasMaxLength(100);

            this.ToTable("T_PutInWarehouseRecord");
            this.Property(r => r.PutInWarehouseRecordID).HasColumnName("PutInWarehouseRecordID");
            this.Property(r => r.PutInTime).HasColumnName("PutInTime");
            this.Property(r => r.Place).HasColumnName("Place");
            this.Property(r => r.WarehouseID).HasColumnName("WarehouseID");
            //this.Property(r => r.TwoDimensioncodeID).HasColumnName("TwoDimensioncodeID");
            this.Property(r => r.StateID).HasColumnName("StateID");
            this.Property(r => r.PutInUserName).HasColumnName("PutInUserName");

            this.HasOptional(r => r.WarehouseM)
                .WithMany(r => r.PutInWarehouseRecords)
                .HasForeignKey(r => r.WarehouseID);

            //this.HasOptional(r => r.TwoDimensioncode)
            //    .WithMany(r => r.PutInWarehouseRecords)
            //    .HasForeignKey(r => r.TwoDimensioncodeID);
        }

    }
}
