using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using MySql.Web.Security;
using Warehouse.Common;

namespace Warehouse.Win
{
	public partial class MainForm : Form
	{
		public static string CurrentUserName { get; private set; }
		public static string[] CurrentUserRoles { get; private set; }

		private PutinWarehouse _putinWarehousePage;
		private WarehouseMgmt _warehouseMgmtUserControl;
		private RemovalUserControl _removalUserControl;
		private SystemMgmtControl _userfunctionUserControl;

		public MainForm(string userName)
		{
			InitializeComponent();
			CurrentUserName = userName;
			CurrentUserRoles = Roles.GetRolesForUser(CurrentUserName);

			lblCurrentUser.Text = string.Format("欢迎您！ {0} ", CurrentUserName);
		}

		private void SetOtherMenuUnCheck(ToolStripButton checkControl)
		{
			foreach (ToolStripItem control in toolStrip1.Items) {
				if (control is ToolStripButton) {
					ToolStripButton item = (ToolStripButton)control;
					if (item == checkControl) {
						item.Checked = true;
					} else {
						item.Checked = false;
					}
				}
			}
		}

		private void tSbtnPutIn_Click(object sender, EventArgs e)
		{
			if (_putinWarehousePage == null) {
				_putinWarehousePage = new PutinWarehouse();
				_putinWarehousePage.Dock = DockStyle.Fill;
			}
			this.pnlMain.Controls.Clear();
			this.pnlMain.Controls.Add(_putinWarehousePage);
			SetOtherMenuUnCheck(tSbtnPutIn);

			_putinWarehousePage.SetTxtGetFocus();
		}

		private void tsBtnWarehouseCheck_Click(object sender, EventArgs e)
		{
			_warehouseMgmtUserControl = new WarehouseMgmt();
			_warehouseMgmtUserControl.Dock = DockStyle.Fill;

			this.pnlMain.Controls.Clear();
			this.pnlMain.Controls.Add(_warehouseMgmtUserControl);
			SetOtherMenuUnCheck(tsBtnWarehouseCheck);
		}

		private void tsBtnRemoval_Click(object sender, EventArgs e)
		{
			if (_removalUserControl == null) {
				_removalUserControl = new RemovalUserControl();
				_removalUserControl.Dock = DockStyle.Fill;
			}
			this.pnlMain.Controls.Clear();
			this.pnlMain.Controls.Add(_removalUserControl);
			SetOtherMenuUnCheck(tsBtnRemoval);

			_removalUserControl.SetTxtGetFocus();
		}

		private void txtUserMgmt_Click(object sender, EventArgs e)
		{
			_userfunctionUserControl = new SystemMgmtControl();
			_userfunctionUserControl.Dock = DockStyle.Fill;

			this.pnlMain.Controls.Clear();
			this.pnlMain.Controls.Add(_userfunctionUserControl);
			SetOtherMenuUnCheck(tsBtnUserMgmt);
		}

		private void tsBtnPersonalInfo_Click(object sender, EventArgs e)
		{

		}

		private void tsmIViewPersonInfo_Click(object sender, EventArgs e)
		{
			new UserEditForm(false, MainForm.CurrentUserName).ShowDialog();
		}

		private void tsmIEditPersonInfo_Click(object sender, EventArgs e)
		{
			new UserEditForm(true, MainForm.CurrentUserName).ShowDialog();
		}

		private void tsmIChangePassword_Click(object sender, EventArgs e)
		{
			new ChangePasswordForm(CurrentUserName).ShowDialog();
		}

		private void btnLoginOut_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason != CloseReason.ApplicationExitCall) {
				e.Cancel = true;
				Application.Exit();
				return;
			}
			var result = DlgHelper.ShowConfirmMsgBox("是否要退出系统？", false);
			if (result != DialogResult.Yes) {
				e.Cancel = true;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//lblCompanyInfo.Left = (this.Width - lblCompanyInfo.Width) / 2;

			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString())
				|| MainForm.CurrentUserRoles.Contains(PermissionEnum.入库员.ToString())
				|| MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())
				) {
				tSbtnPutIn.Visible = true;
			} else {
				tSbtnPutIn.Visible = false;
			}
			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString())
				|| MainForm.CurrentUserRoles.Contains(PermissionEnum.出库员.ToString())
				|| MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())
				) {
				tsBtnRemoval.Visible = true;
			} else {
				tsBtnRemoval.Visible = false;
			}
			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString())
				|| MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())
				|| MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())
				) {
				tsBtnUserMgmt.Visible = true;
			} else {
				tsBtnUserMgmt.Visible = false;
			}
			lblCurrentUser.Focus();
		}

		private void btnChangeUser_Click(object sender, EventArgs e)
		{
			var result = DlgHelper.ShowConfirmMsgBox("是否切换用户？");
			if (result == DialogResult.Yes) {
				this.Dispose();
				new UserLoginForm().ShowDialog();
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			new AboutUsForm().ShowDialog();
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			//lblCompanyInfo.Left = (this.Width - lblCompanyInfo.Width) / 2;
		}
	}
}
