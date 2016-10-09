using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.Common;

namespace Warehouse.Win
{
	public class PermissionCheckHelper
	{
		public static bool GetHighUserPermission(string msg)
		{
			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString())
				|| MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())) {
				return true;
			}

			var hasPermission = false;
			var permissionForm = new PermissionCheckForm(msg);
			if (permissionForm.ShowDialog() == DialogResult.OK) {
				hasPermission = permissionForm.IsCorrect;
			} else {
				DlgHelper.ShowAlertMsgBox("没有高级权限！");
			}
			return hasPermission;
		}
	}
}
