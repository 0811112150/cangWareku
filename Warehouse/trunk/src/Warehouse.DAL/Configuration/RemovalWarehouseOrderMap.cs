using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.DomainModel;
using Warehouse.Common;

namespace Warehouse.DAL.Configuration
{
	public class RemovalWarehouseOrderMap : EntityTypeConfiguration<RemovalWarehouseOrder>
	{
		public RemovalWarehouseOrderMap()
		{
			this.HasKey(t => t.OrderID);
			this.Property(r => r.Staff).HasMaxLength(50);
			this.Property(r => r.DispathPlace).HasMaxLength(50);

			this.ToTable("T_RemovalWarehouseOrder");
			this.Property(r => r.OrderID).HasColumnName("OrderID");
			this.Property(r => r.Staff).HasColumnName("Staff");
			this.Property(r => r.DispathPlace).HasColumnName("DispathPlace");
			this.Property(r => r.StateID).HasColumnName("StateID");
			this.Property(r => r.DispathTime).HasColumnName("DispathTime");
			this.Property(r => r.SpeedChangeBoxName).HasColumnName("SpeedChangeBoxName");
			this.Property(r => r.PlanCount).HasColumnName("PlanCount");

		}
	}
}
