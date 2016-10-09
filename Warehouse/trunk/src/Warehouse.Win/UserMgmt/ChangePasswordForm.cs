using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.BLL;

namespace Warehouse.Win
{
	public partial class ChangePasswordForm : Form
	{
		private string _userName = "";

		public ChangePasswordForm(string userName)
		{
			InitializeComponent();

			_userName = userName;
		}

		private void txtNotNull_Validating(object sender, CancelEventArgs e)
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

			var result = new UserBLL().ChangePassword(txtOldPassword.Text.Trim(), txtConfirmPassword.Text.Trim(), _userName);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			} else {
				DlgHelper.ShowSuccessBox();
				this.Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
