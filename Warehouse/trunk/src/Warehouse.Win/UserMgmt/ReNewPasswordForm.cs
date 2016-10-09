using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.BLL;
using System.Web.Security;

namespace Warehouse.Win
{
	public partial class ReNewPasswordForm : Form
	{
		private int _id;

		public ReNewPasswordForm(int id)
		{
			_id = id;

			InitializeComponent();
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
			if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim()) {
				DlgHelper.ShowAlertMsgBox("输入密码不一致，请重新输入！");
				return;
			}

			if (txtConfirmPassword.Text.Trim().Length < 6) {
				DlgHelper.ShowAlertMsgBox("密码长度最少是6位！");
				return;
			}

			var membership = Membership.GetUser(_id);
			if (membership == null) {
				return;
			}
			var result = new UserBLL().ResetPassword(txtConfirmPassword.Text.Trim(), membership.UserName);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
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
