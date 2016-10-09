using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using Warehouse.DomainModel;
using System.ComponentModel.DataAnnotations;

namespace Warehouse.DAL.Configuration
{
	public class UsersInfoMap : EntityTypeConfiguration<UsersInfo>
	{
		public UsersInfoMap()
		{
			this.HasKey(t => t.ID);

			this.Property(t => t.ID)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

			this.Property(r => r.Adress).HasMaxLength(100);
			this.Property(r => r.Phone).HasMaxLength(11);

			this.ToTable("my_aspnet_usersinfo");
			this.Property(r => r.Adress).HasColumnName("Adress");
			this.Property(r => r.ID).HasColumnName("ID");
			this.Property(r => r.Phone).HasColumnName("Phone");
			this.Property(r => r.StateID).HasColumnName("StateID");

			this.HasOptional(r => r.Department)
				.WithMany(r => r.UsersInfos)
				.HasForeignKey(r => r.DepartmentID);
		}
	}
}
