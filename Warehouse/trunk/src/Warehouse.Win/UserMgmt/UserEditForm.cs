using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using System.Web;
using Warehouse.BLL;
using Warehouse.ViewModel;
using Warehouse.Common;

namespace Warehouse.Win
{
	public partial class UserEditForm : Form
	{
		private bool _editOrView = true;
		private int _userID = 0;
		private bool _isSelf = false;

		public MethodInvoker CallBack;

		public UserEditForm(bool editOrView, int userID)
		{
			_editOrView = editOrView;
			
			_userID = userID;

			InitializeComponent();

			if (_editOrView == false) {
				this.Text = "查看信息";
			}

			InitControls();
		}

		public UserEditForm(bool editOrView, string userName)
			: this(editOrView, (int)Membership.GetUser(userName).ProviderUserKey)
		{
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

			var result = new UserBLL().GetUserInfoByUserID(_userID);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			} else {
				var userInfo = result.Data;
				txtAddress.Text = userInfo.Adress;
				txtPhone.Text = userInfo.Phone;
				txtUserName.Text = userInfo.UserName;
				if (userInfo.DepartmentID != null) {
					cbxDepartment.SelectedValue = userInfo.DepartmentID;
				}
				ckBoxIsMonitor.Checked = userInfo.IsMonitor;
				ckBoxIsPutinMan.Checked = userInfo.IsPutinMan;
				ckBoxIsRemovalMan.Checked = userInfo.IsRemovalMan;

				_isSelf = MainForm.CurrentUserName == userInfo.UserName;
			}

			if (_editOrView == false) {
				cbxDepartment.Enabled = false;
				txtAddress.Enabled = false;
				txtPhone.Enabled = false;
				txtUserName.Enabled = false;
				btnConfirm.Visible = false;
				ckBoxIsMonitor.Enabled = false;
				ckBoxIsRemovalMan.Enabled = false;
				ckBoxIsPutinMan.Enabled = false;
			}

			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())) {
				ckBoxIsMonitor.Enabled = false;
				ckBoxIsRemovalMan.Enabled = false;
				ckBoxIsPutinMan.Enabled = false;
			} else if (MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString())) {
				ckBoxIsMonitor.Visible = false;
			}

			if (_isSelf && _editOrView != false) {
				ckBoxIsMonitor.Visible = false;
				ckBoxIsRemovalMan.Visible = false;
				ckBoxIsPutinMan.Visible = false;
				lblPermisson.Visible = false;
			}
		}

		private void UserInfoForm_Load(object sender, EventArgs e)
		{

		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			if (this.ValidateChildren(ValidationConstraints.Enabled) == false) {
				return;
			}

			if (_editOrView == true) {
				var userInfo = new WebUserInfo() {
					ID = _userID,
					UserName = txtUserName.Text.Trim(),
					Adress = txtAddress.Text.Trim(),
					Phone = txtPhone.Text.Trim(),
					IsMonitor = ckBoxIsMonitor.Checked,
					IsRemovalMan = ckBoxIsRemovalMan.Checked,
					IsPutinMan = ckBoxIsPutinMan.Checked,
				};
				var result = new UserBLL().UpdateUser(userInfo);
				if (result.Code > 0) {
					DlgHelper.ShowAlertMsgBox(result.Msg);
					return;
				} else {
					DlgHelper.ShowSuccessBox();
					this.Close();
					if (CallBack != null) {
						CallBack();
					}
				}
			}
		}

		private void txtPhone_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.RegexCheck((Control)sender, errorProvider1, ControlDataCheckHelper.MobilePhoneRegex, e);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
