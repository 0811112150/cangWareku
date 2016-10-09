using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.DomainModel;
using Warehouse.Common;

namespace Warehouse.DAL.Configuration
{
    public class RemovalWarehourseRecordMap : EntityTypeConfiguration<RemovalWarehouseRecord>
    {
        public RemovalWarehourseRecordMap()
        {
            this.HasKey(t => t.RemovalWarehourseRecordID);


            this.ToTable("T_RemovalWarehouseRecord ");
            this.Property(r => r.RemovalWarehourseRecordID).HasColumnName("RemovalWarehourseRecordID");
            this.Property(r => r.WarehouseID).HasColumnName("WarehouseID");
            this.Property(r => r.StateID).HasColumnName("StateID");
            this.Property(r => r.RemovalWarehouseTime).HasColumnName("RemovalWarehouseTime");
            this.Property(r => r.OrderID).HasColumnName("OrderID");

            this.HasOptional(r => r.WarehouseM)
                .WithMany(r => r.RemovalWarehourseRecords)
                .HasForeignKey(r => r.WarehouseID);

            this.HasRequired(r => r.RemovalWarehouseOrder)
                .WithMany(r => r.RemovalWarehouseRecords)
                .HasForeignKey(r => r.OrderID);

        }
    }
}
