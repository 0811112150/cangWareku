using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.Common;
using Warehouse.DomainModel;

namespace Warehouse.DAL.Configuration
{
    public class DepartmentMap : EntityTypeConfiguration<Department>
    {
        public DepartmentMap()
        {
            this.HasKey(t => t.DepartmentID);

            this.Property(r => r.DepartmentName).HasMaxLength(50);
            this.ToTable("my_aspnet_department");

            this.Property(r => r.DepartmentID).HasColumnName("DepartmentID");
            this.Property(r => r.DepartmentName).HasColumnName("DepartmentName");
        }
    }
}
