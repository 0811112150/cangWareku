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
using System.Collections;

namespace Warehouse.BLL
{
	public class UserBLL
	{
		public CResult<bool> AddUser(WebUserInfo webUser)
		{
			if (string.IsNullOrWhiteSpace(webUser.UserName)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {

				MembershipCreateStatus status;
				var user = Membership.CreateUser(webUser.UserName, webUser.PassWord, null, null, null, true, out status);
				var roles = new List<string>();
				if (webUser.IsMonitor) {
					roles.Add(PermissionEnum.班长.ToString());
				}
				if (webUser.IsPutinMan) {
					roles.Add(PermissionEnum.入库员.ToString());
				}
				if (webUser.IsRemovalMan) {
					roles.Add(PermissionEnum.出库员.ToString());
				}

				if (status == MembershipCreateStatus.Success) {
					if (roles.Count() > 0) {
						Roles.AddUserToRoles(user.UserName, roles.ToArray());
					}
					var userInfo = new UsersInfo();
					userInfo.ID = (int)user.ProviderUserKey;
					userInfo.Adress = webUser.Adress;
					userInfo.DepartmentID = webUser.DepartmentID;
					userInfo.StateID = (int)RecordState.Show;
					userInfo.Phone = webUser.Phone;
					RepositoryIoc.GetUsersInfoRepository(db).Insert(userInfo);
					if (db.SaveChanges() > 0) {
						return new CResult<bool>(true);
					} else {
						return new CResult<bool>(false, ErrorCode.AddUserInfoFailed);
					}
				} else {
					//Membership.DeleteUser(user.UserName, true);
					return new CResult<bool>(false, 1, status.ToString());
				}
			}
		}

		public CResult<List<WebUserInfo>> GetUserInfoListByDepartment(string userName)
		{
			using (var db = new WarehouseContext()) {

				MembershipUserCollection users = Membership.GetAllUsers();
				var userInfoRepository = RepositoryIoc.GetUsersInfoRepository(db);
				var role = Roles.GetRolesForUser(userName);
				var currentUser = Membership.GetUser(userName);
				var currentUserInfo = userInfoRepository.FirstOrDefault(r => r.ID == (int)currentUser.ProviderUserKey);
				if (currentUserInfo == null) {
					return new CResult<List<WebUserInfo>>(new List<WebUserInfo>(), ErrorCode.UserInfoNoExist);
				}

				var currentDepartmentID = currentUserInfo.DepartmentID;
				var userInfos = new List<WebUserInfo>();

				foreach (MembershipUser item in users) {
					var userID = (int)item.ProviderUserKey;
					var info = userInfoRepository.FirstOrDefault(r => r.ID == userID && r.StateID == (int)RecordState.Show, CommonHelper.GetPropName<UsersInfo>(r => r.Department));
					if (info == null) {
						continue;
					}
					var currentRoles = Roles.GetRolesForUser(item.UserName);
					if ((role.Contains(PermissionEnum.系统管理员.ToString()) && currentRoles.Contains(PermissionEnum.班长.ToString()))
						|| (info.DepartmentID == currentDepartmentID && !currentRoles.Contains(PermissionEnum.班长.ToString()) && !currentRoles.Contains(PermissionEnum.系统管理员.ToString()))) {
						userInfos.Add(new WebUserInfo() {
							ID = userID,
							UserName = (item.UserName),
							Phone = info.Phone,
							DepartmentID = info.DepartmentID,
							DepartmentName = info.Department.DepartmentName,
							Adress = info.Adress,
							IsMonitor = currentRoles.Contains(PermissionEnum.班长.ToString()),
							IsRemovalMan = currentRoles.Contains(PermissionEnum.出库员.ToString()),
							IsPutinMan = currentRoles.Contains(PermissionEnum.入库员.ToString()),
						});
					}
				}
				return new CResult<List<WebUserInfo>>(userInfos);
			}
		}

		public CResult<WebUserInfo> GetUserInfoByUserName(string userName)
		{
			if (string.IsNullOrWhiteSpace(userName)) {
				return new CResult<WebUserInfo>(new WebUserInfo(), ErrorCode.ParameterError);
			}

			using (var db = new WarehouseContext()) {
				var user = Membership.GetUser(userName);
				var userInfo = RepositoryIoc.GetUsersInfoRepository(db).FirstOrDefault(r => r.StateID == (int)RecordState.Show
					&& r.ID == (int)user.ProviderUserKey, CommonHelper.GetPropName<UsersInfo>(r => r.Department));
				if (userInfo == null) {
					return new CResult<WebUserInfo>(new WebUserInfo(), ErrorCode.UserInfoNoExist);
				}

				var webUserInfo = ConverToWebUser(user, userInfo);

				return new CResult<WebUserInfo>(webUserInfo);
			}
		}

		public CResult<WebUserInfo> GetUserInfoByUserID(int userID)
		{
			if (userID <= 0) {
				return new CResult<WebUserInfo>(new WebUserInfo(), ErrorCode.ParameterError);
			}

			using (var db = new WarehouseContext()) {
				var user = Membership.GetUser(userID);
				var userInfo = RepositoryIoc.GetUsersInfoRepository(db).FirstOrDefault(r => r.StateID == (int)RecordState.Show
					&& r.ID == (int)user.ProviderUserKey, CommonHelper.GetPropName<UsersInfo>(r => r.Department));
				if (userInfo == null) {
					return new CResult<WebUserInfo>(new WebUserInfo(), ErrorCode.UserInfoNoExist);
				}

				var webUserInfo = ConverToWebUser(user, userInfo);

				return new CResult<WebUserInfo>(webUserInfo);
			}
		}

		private static WebUserInfo ConverToWebUser(MembershipUser user, UsersInfo userInfo)
		{
			var webUserInfo = new WebUserInfo();
			var currentRoles = Roles.GetRolesForUser(user.UserName);
			webUserInfo.Adress = userInfo.Adress;
			if (userInfo.Department != null) {
				webUserInfo.DepartmentName = userInfo.Department.DepartmentName;
			}
			webUserInfo.Phone = userInfo.Phone;
			webUserInfo.UserName = user.UserName;
			webUserInfo.ID = (int)user.ProviderUserKey;
			webUserInfo.DepartmentID = userInfo.DepartmentID;
			webUserInfo.IsMonitor = currentRoles.Contains(PermissionEnum.班长.ToString());
			webUserInfo.IsPutinMan = currentRoles.Contains(PermissionEnum.入库员.ToString());
			webUserInfo.IsRemovalMan = currentRoles.Contains(PermissionEnum.出库员.ToString());
			return webUserInfo;
		}

		public CResult<bool> DeleteUserByID(int userID)
		{
			if (userID <= 0) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {
				var user = Membership.GetUser(userID);
				if (user == null) {
					return new CResult<bool>(false, ErrorCode.UserNoExist);
				}
				user.IsApproved = false;
				Membership.UpdateUser(user);

				var repository = RepositoryIoc.GetUsersInfoRepository(db);
				var info = repository.FirstOrDefault(r => r.ID == (int)user.ProviderUserKey);
				if (info.StateID == (int)RecordState.Delete) {
					return new CResult<bool>(false, ErrorCode.UserHasDeleted);
				}
				info.StateID = (int)RecordState.Delete;
				if (repository.Update(info) == EntityState.Modified) {
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

		public CResult<bool> UpdateUser(WebUserInfo webUser)
		{
			if (string.IsNullOrWhiteSpace(webUser.UserName)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {
				var user = Membership.GetUser(webUser.UserName);
				if (user == null) {
					return new CResult<bool>(false, ErrorCode.UserNoExist);
				}

				var roles = new List<string>();
				var hasAddRoles = Roles.GetRolesForUser(webUser.UserName);
				if (webUser.IsMonitor) {
					roles.Add(PermissionEnum.班长.ToString());
				}
				if (webUser.IsPutinMan) {
					roles.Add(PermissionEnum.入库员.ToString());
				}
				if (webUser.IsRemovalMan) {
					roles.Add(PermissionEnum.出库员.ToString());
				}
				var hasExistRoles = hasAddRoles.Intersect(roles);
				var toDelRoles = hasAddRoles.Except(hasExistRoles);
				var toAddRoles = roles.Except(hasExistRoles);
				if (toDelRoles.Count() > 0) {
					Roles.RemoveUserFromRoles(webUser.UserName, toDelRoles.ToArray());
				}
				if (toAddRoles.Count() > 0) {
					Roles.AddUserToRoles(webUser.UserName, toAddRoles.ToArray());
				}

				var userID = (int)user.ProviderUserKey;
				var repository = RepositoryIoc.GetUsersInfoRepository(db);
				var userInfo = repository.FirstOrDefault(r => r.ID == userID);
				if (userInfo == null) {
					return new CResult<bool>(false, ErrorCode.UserNoExist);
				}
				userInfo.Phone = webUser.Phone;
				userInfo.Adress = webUser.Adress;
				if (repository.Update(userInfo) == EntityState.Modified) {
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

		public CResult<bool> ResetPassword(string newPassword, string userName)
		{
			if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(userName)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var user = Membership.GetUser(userName);
			if (user == null) {
				return new CResult<bool>(false, ErrorCode.UserNoExist);
			}

			var resetPassword = user.ResetPassword();
			var flag = user.ChangePassword(resetPassword, newPassword);
			if (flag) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.SaveDbChangesFailed);
			}
		}

		public CResult<bool> ChangePassword(string oldPassword, string newPassword, string userName)
		{
			if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(userName)) {
				return new CResult<bool>(false, ErrorCode.ParameterError);
			}
			var user = Membership.GetUser(userName);
			if (user == null) {
				return new CResult<bool>(false, ErrorCode.UserNoExist);
			}
			var flag = user.ChangePassword(oldPassword, newPassword);

			if (flag) {
				return new CResult<bool>(true);
			} else {
				return new CResult<bool>(false, ErrorCode.ChangePasswordFailed);
			}
		}

		public static CResult<int> GetDepartmentIDByUserName(string userName)
		{
			if (string.IsNullOrWhiteSpace(userName)) {
				return new CResult<int>(-1, ErrorCode.ParameterError);
			}
			using (var db = new WarehouseContext()) {
				var user = Membership.GetUser(userName);
				var id = (int)user.ProviderUserKey;
				var userInfo = RepositoryIoc.GetUsersInfoRepository(db).FirstOrDefault(r => r.ID == id);
				if (userInfo == null) {
					return new CResult<int>(-1, ErrorCode.UserInfoNoExist);
				}
				return new CResult<int>(userInfo.DepartmentID.Value);
			}
		}
	}
}
