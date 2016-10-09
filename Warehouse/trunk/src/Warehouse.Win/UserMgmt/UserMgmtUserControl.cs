using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.BLL;
using Warehouse.Common;

namespace Warehouse.Win
{
	public partial class UserMgmtUserControl : UserControl
	{
		public UserMgmtUserControl()
		{
			InitializeComponent();

			dgvUserList.AutoGenerateColumns = false;
			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())) {
				btnAdd.Text = "添加班长";
				dgvUserList.Columns["IsPutinMan"].Visible = false;
				dgvUserList.Columns["IsRemovalMan"].Visible = false;
			}

			BindData();
		}

		private void BindData()
		{
			var result = new UserBLL().GetUserInfoListByDepartment(MainForm.CurrentUserName);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			}

			dgvUserList.DataSource = result.Data;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var addUser = new UserAddForm();
			addUser.CallBack += BindData;
			addUser.ShowDialog();
		}

		private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;

			if (rowIndex == -1) {
				return;
			}

			var clickColumn = dgvUserList.Columns[columnIndex];
			var id = (int)dgvUserList.Rows[rowIndex].Cells["ID"].Value;

			if (clickColumn == dgvUserList.Columns["Delete"]) {
				var dialogResult = DlgHelper.ShowConfirmMsgBox("确定要删除吗？");
				if (dialogResult == DialogResult.Yes) {
					var result = new UserBLL().DeleteUserByID(id);
					if (result.Code > 0) {
						DlgHelper.ShowAlertMsgBox(result.Msg);
						return;
					}
					BindData();
				}
			} else if (clickColumn == this.dgvUserList.Columns["Edit"]) {
				var departmentForm = new UserEditForm(true, id);
				departmentForm.CallBack += BindData;

				departmentForm.ShowDialog();
			} else if (clickColumn == dgvUserList.Columns["IsMonitor"]) {
				var checkBox = (DataGridViewCheckBoxCell)dgvUserList.Rows[rowIndex].Cells[columnIndex];
				bool value = (bool)checkBox.EditingCellFormattedValue;
			} else if (clickColumn == dgvUserList.Columns["IsPutinMan"]) {
				var checkBox = (DataGridViewCheckBoxCell)dgvUserList.Rows[rowIndex].Cells[columnIndex];
				bool value = (bool)checkBox.EditingCellFormattedValue;
			} else if (clickColumn == dgvUserList.Columns["IsRemovalMan"]) {
				var checkBox = (DataGridViewCheckBoxCell)dgvUserList.Rows[rowIndex].Cells[columnIndex];
				bool value = (bool)checkBox.EditingCellFormattedValue;
			} else if (clickColumn == dgvUserList.Columns["ReSetPassword"]) {
				new ReNewPasswordForm(id).ShowDialog();
			}
		}
	}
}
