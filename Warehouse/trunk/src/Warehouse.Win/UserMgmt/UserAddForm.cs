using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using Warehouse.BLL;
using Warehouse.ViewModel;
using Warehouse.Common;

namespace Warehouse.Win
{
	public partial class UserAddForm : Form
	{
		public MethodInvoker CallBack;

		public UserAddForm()
		{
			InitializeComponent();

			InitControls();

			//添加班长
			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())) {
				ckBoxIsMonitor.Checked = true;
				ckBoxIsMonitor.Enabled = false;
				ckBoxIsRemovalMan.Checked = true;
				ckBoxIsRemovalMan.Enabled = false;
				ckBoxIsPutinMan.Checked = true;
				ckBoxIsPutinMan.Enabled = false;
			} else {
				//添加普通操作员
				ckBoxIsMonitor.Visible = false;
				ckBoxIsMonitor.Checked = false;
				var result = UserBLL.GetDepartmentIDByUserName(MainForm.CurrentUserName);
				cbxDepartment.Enabled = false;
				if (result.Code == 0) {
					var departmentID = result.Data;
					cbxDepartment.SelectedValue = departmentID;

				} else {
					MessageBox.Show("此用户部门不存在");
				}

			}
		}

		private void InitControls()
		{
			var departments = new DepartmentBLL().GetAllDepartment();
			cbxDepartment.DataSource = departments;
			cbxDepartment.ValueMember = "DepartmentID";
			cbxDepartment.DisplayMember = "DepartmentName";
			if (cbxDepartment.Items.Count > 0) {
				cbxDepartment.SelectedIndex = 0;
			}
		}

		private void UserAddForm_Validating(object sender, CancelEventArgs e)
		{
			foreach (Control item in this.Controls) {
				item.Focus();
			}
		}

		private void txtUserName_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.NotNullCheck((Control)sender, errorProvider1, e);
		}

		private void txtPassword_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.NotNullCheck((Control)sender, errorProvider1, e);
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren(ValidationConstraints.Enabled) == false) {
				return;
			}
			if (txtConfirmPassword.Text != txtPassword.Text) {
				DlgHelper.ShowAlertMsgBox("输入密码不一致，请重新输入！");
				return;
			}

			if (txtConfirmPassword.Text.Trim().Length < 6) {
				DlgHelper.ShowAlertMsgBox("密码长度最少是6位！");
				return;
			}

			if (cbxDepartment.SelectedValue == null) {
				DlgHelper.ShowAlertMsgBox("请选择部门！");
				return;
			}

			var userInfo = new WebUserInfo() {
				DepartmentID = (int)cbxDepartment.SelectedValue,
				Adress = txtAddress.Text.Trim(),
				ConfirmPassWord = txtConfirmPassword.Text.Trim(),
				PassWord = txtPassword.Text.Trim(),
				Phone = txtPhone.Text.Trim(),
				UserName = txtUserName.Text.Trim(),
				IsMonitor = ckBoxIsMonitor.Checked,
				IsPutinMan = ckBoxIsPutinMan.Checked,
				IsRemovalMan = ckBoxIsRemovalMan.Checked,
			};

			var result = new UserBLL().AddUser(userInfo);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			} else {
				DlgHelper.ShowAlertMsgBox("创建用户成功！");
				this.Close();
			}

			if (CallBack != null) {
				CallBack();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.NotNullCheck((Control)sender, errorProvider1, e);
		}

		private void txtPhone_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.RegexCheck((Control)sender, errorProvider1, ControlDataCheckHelper.MobilePhoneRegex, e);
		}
	}
}
