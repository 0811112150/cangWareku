using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using Warehouse.DAL.Configuration;

namespace Warehouse.DAL
{
	public class WarehouseContext : DbContext
	{
		public WarehouseContext()
			: base(DbConnManager.SqlConnection, true)
		{
			Database.SetInitializer<WarehouseContext>(null);
			base.Configuration.ValidateOnSaveEnabled = false;
		}

		public override int SaveChanges()
		{
			if (base.GetValidationErrors().Count() > 0) {
				return 0;
			}

			return base.SaveChanges();
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			RemoveConventions(modelBuilder);

			AddConfigurations(modelBuilder);

			base.OnModelCreating(modelBuilder);
		}

		#region AddConfigurations
		private static void AddConfigurations(DbModelBuilder modelBuilder)
		{
			//数据表Config
			//modelBuilder.Configurations.Add(new MaterialFileMap());
			modelBuilder.Configurations.Add(new WarehouseMap());
			modelBuilder.Configurations.Add(new TwoDimensioncodeMap());
			modelBuilder.Configurations.Add(new SpeedChangeBoxTypeMap());
			modelBuilder.Configurations.Add(new RemovalWarehourseRecordMap());
			modelBuilder.Configurations.Add(new PutInWarehouseRecordMap());
			modelBuilder.Configurations.Add(new RemovalWarehouseOrderMap());
			modelBuilder.Configurations.Add(new DepartmentMap());
			modelBuilder.Configurations.Add(new UsersInfoMap());
			modelBuilder.Configurations.Add(new AlarmMap());
		}
		#endregion

		#region RemoveConventions
		private static void RemoveConventions(DbModelBuilder modelBuilder)
		{
			//移除复数表名的契约
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			//防止黑幕交易 要不然每次都要访问 EdmMetadata这个表
			modelBuilder.Conventions.Remove<IncludeMetadataConvention>();

			//AssociationInverseDiscoveryConvention 
			//寻找导航上互相引用的类的属性，并将它们配置为逆属性的相同的关系。
			//ComplexTypeDiscoveryConvention 
			//寻找有没有主键的类型，并将它们配置为复杂类型。
			//DeclaredPropertyOrderingConvention 
			//确保每个实体的主要关键属性优先于其他属性。
			//ForeignKeyAssociationMultiplicityConvention 
			//配置是必需的还是可选的关系基于为空性外键属性，如果包含在类定义中。
			//IdKeyDiscoveryConvention 
			//查找名为 Id 或 <TypeName> Id 的属性，并将他们配置作为主键。
			//NavigationPropertyNameForeignKeyDiscoveryConvention 
			//使用外键关系，使用 <NavigationProperty> <PrimaryKeyProperty> 模式作为属性的外观。
			//OneToManyCascadeDeleteConvention 
			//交换机上层叠删除，所需的关系。
			//OneToOneConstraintIntroductionConvention 
			//将配置为一个： 一个关系的外键的主键。
			//PluralizingEntitySetNameConvention 
			//配置为多元化的类型名称的实体数据模型中的实体集的名称。
			//PrimaryKeyNameForeignKeyDiscoveryConvention 
			//使用外键关系，使用 <PrimaryKeyProperty> 模式作为属性的外观。
			//PropertyMaxLengthConvention 
			//配置所有的字符串和字节 [] 属性，默认情况下具有最大长度。
			//StoreGeneratedIdentityKeyConvention 
			//配置默认情况下将标识所有整数的主键。
			//TypeNameForeignKeyDiscoveryConvention 
			//使用外键关系，使用 <PrincipalTypeName> <PrimaryKeyProperty> 模式作为属性的外观。
		}
		#endregion
	}
}
