using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.DomainModel;

namespace Warehouse.DAL.Configuration
{
	public class AlarmMap : EntityTypeConfiguration<Alarm>
	{
		public AlarmMap()
		{
			this.HasKey(t => t.ID);

			this.Property(r => r.AlarmContent)
				.HasMaxLength(200);

			this.ToTable("t_alarm");
			this.Property(r => r.ID).HasColumnName("ID");
			this.Property(r => r.AlarmTypeInt).HasColumnName("AlarmTypeInt");
			this.Property(r => r.AlarmTime).HasColumnName("AlarmTime");
			this.Property(r => r.AlarmContent).HasColumnName("AlarmContent");
			this.Property(r => r.Operator).HasColumnName("Operator");

		}
	}
}
