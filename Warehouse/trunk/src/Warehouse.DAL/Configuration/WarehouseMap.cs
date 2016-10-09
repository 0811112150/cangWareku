using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.DomainModel;

namespace Warehouse.DAL.Configuration
{
    public class WarehouseMap : EntityTypeConfiguration<WarehouseM>
    {
        public WarehouseMap()
        {
            this.HasKey(t => t.WarehouseID);
            this.Property(r => r.BarCode).HasMaxLength(50);
            this.Property(r => r.PutInUserName).HasMaxLength(50);
            this.Property(r => r.Place).HasMaxLength(100);

            this.ToTable("T_Warehouse");
            this.Property(r => r.WarehouseID).HasColumnName("WarehouseID");
            this.Property(r => r.BarCode).HasColumnName("BarCode");
            this.Property(r => r.TwoDimensioncodeID).HasColumnName("TwoDimensioncodeID");
            this.Property(r => r.WarehouseTime).HasColumnName("WarehouseTime");
            this.Property(r => r.StateID).HasColumnName("StateID");
            this.Property(r => r.PutInUserName).HasColumnName("PutInUserName");
            this.Property(r => r.Place).HasColumnName("Place");

            this.HasOptional(r => r.TwoDimensioncode)
                .WithMany(t => t.WarehouseMs)
                .HasForeignKey(r => r.TwoDimensioncodeID);

        }
    }
}
