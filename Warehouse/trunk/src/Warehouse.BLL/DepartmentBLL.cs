using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Warehouse.Common;
using Warehouse.DAL;
using Warehouse.DomainModel;
using Warehouse.ViewModel;
using Warehouse.Common.CResult;
using System.Linq.Expressions;
using Warehouse.Common.Extension;
using System.Web.Security;
using System.Data;

namespace Warehouse.BLL
{
	public class DepartmentBLL
	{
		private List<Department> _department = new List<Department>();

		/// <summary>
		/// 添加部门
		/// </summary>
		/// <param name="departmentName">部门名称</param>
		/// <returns></returns>
		public CResult<bool> AddDepartment(string departmentName)
		{
			if (string.IsNullOrWhiteSpace(departmentName)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {
				var repository = RepositoryIoc.GetDepartmentRepository(db);
				var department = repository.FirstOrDefault(r => r.DepartmentName == departmentName);
				if (department == null) {
					department = new Department();
					department.DepartmentName = departmentName;
					repository.Insert(department);
					if (db.SaveChanges() > 0) {
						_department.Add(department);
						return new CResult<bool>(true);
					} else {
						return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
					}

				}
				return new CResult<bool>(false, ErrorCode.DepartmentHasExist);
			}
		}

		/// <summary>
		/// 修改部门
		/// </summary>
		/// <param name="departmentName"></param>
		/// <param name="departmentID"></param>
		/// <returns></returns>
		public CResult<bool> UpdateDepartment(string departmentName, int departmentID)
		{
			if (string.IsNullOrWhiteSpace(departmentName)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {
				var repository = RepositoryIoc.GetDepartmentRepository(db);
				var department = repository.FirstOrDefault(r => r.DepartmentID == departmentID);
				if (department == null) {
					return new CResult<bool>(false, ErrorCode.DepartmentHasNoExist);
				}
				department.DepartmentName = departmentName;
				if (repository.Update(department) == EntityState.Modified) {
					if (db.SaveChanges() > 0) {
						return new CResult<bool>(true);
					} else {
						return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
					}
				} else {
					return new CResult<bool>(true);
				}

			}
		}

		/// <summary>
		/// 获取部门列表
		/// </summary>
		/// <returns></returns>
		public List<WebDepartment> GetAllDepartment()
		{
			using (var db = new WarehouseContext()) {
				List<Department> departments;
				if (_department == null || _department.Count() == 0) {
					departments = RepositoryIoc.GetDepartmentRepository(db).Get().ToList();
				} else {
					departments = _department;
				}
				var result = new List<WebDepartment>();
				foreach (var item in departments) {
					result.Add(new WebDepartment() {
						DepartmentID = item.DepartmentID,
						DepartmentName = item.DepartmentName
					});
				}
				return result;
			}
		}


		/// <summary>
		/// 根据ID删除部门
		/// </summary>
		/// <param name="departmentID">部门ID</param>
		/// <returns></returns>
		public CResult<bool> DeleteDepartmentByID(int departmentID)
		{
			using (var db = new WarehouseContext()) {
				var repository = RepositoryIoc.GetDepartmentRepository(db);
				var department = repository.FirstOrDefault(r => r.DepartmentID == departmentID);
				if (department == null) {
					return new CResult<bool>(false, ErrorCode.DepartmentHasNoExist);
				}
				if (RepositoryIoc.GetUsersInfoRepository(db).Count(r => r.DepartmentID == departmentID) > 0) {
					return new CResult<bool>(false, ErrorCode.DepartmentHasUser);
				}
				repository.Delete(department);
				if (db.SaveChanges() > 0) {
					return new CResult<bool>(true);
				} else {
					return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
				}
			}
		}
	}
}
