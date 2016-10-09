using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using Warehouse.Common;

namespace Warehouse.Win
{
	public partial class PermissionCheckForm : Form
	{
		public bool IsCorrect { get; set; }
		public PermissionCheckForm(string msg)
		{
			InitializeComponent();
			IsCorrect = false;
			label3.Text = msg;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var userName = txtUserName.Text.Trim();
			var password = txtPassword.Text.Trim();
			if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password)) {
				DlgHelper.ShowAlertMsgBox("请输入用户名或密码");
				return;
			}

			if (Membership.ValidateUser(userName, password)) {
				var userRoles = Roles.GetRolesForUser(userName);
				if (userRoles.Contains(PermissionEnum.班长.ToString()) || userRoles.Contains(PermissionEnum.系统管理员.ToString())) {
					IsCorrect = true;
					this.DialogResult = DialogResult.OK;
					this.Close();
				} else {
					DlgHelper.ShowAlertMsgBox("用户权限不足！");
				}
			} else {
				DlgHelper.ShowAlertMsgBox("用户名或密码错误！");
			}
		}

		private void PermissionCheckForm_FormClosing(object sender, FormClosingEventArgs e)
		{

		}

		private void PermissionCheckForm_Load(object sender, EventArgs e)
		{
			DlgHelper.AlarmSound();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
	}
}
