using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.Common;

namespace Warehouse.Win
{
	public partial class SystemMgmtControl : UserControl
	{
		private DepartmentMgmtUserControl department;
		private UserMgmtUserControl userMgmt;
		private SpeedChangeBoxTypeUserControl speedChangeBoxUserControl;

		public SystemMgmtControl()
		{
			InitializeComponent();

		}

		private void tsBtnUserMgmt_Click(object sender, EventArgs e)
		{
			if (userMgmt != null) {
				userMgmt.Dispose();
			}
			userMgmt = new UserMgmtUserControl();
			userMgmt.Dock = DockStyle.Fill;
			pnlControlContainer.Controls.Clear();
			pnlControlContainer.Controls.Add(userMgmt);
			tsBtnUserMgmt.Checked = true;
			tsBtnDepartment.Checked = false;
			tsBtnProductType.Checked = false;
		}

		private void tsBtnDepartment_Click(object sender, EventArgs e)
		{
			if (department != null) {
				department.Dispose();
			}
			department = new DepartmentMgmtUserControl();
			department.Dock = DockStyle.Fill;
			pnlControlContainer.Controls.Clear();
			pnlControlContainer.Controls.Add(department);
			tsBtnUserMgmt.Checked = false;
			tsBtnDepartment.Checked = true;
			tsBtnProductType.Checked = false;
		}

		private void UserfunctionUserControl_Load(object sender, EventArgs e)
		{
			if (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())) {
				tsBtnDepartment.Visible = true;
				tsBtnProductType.Visible = true;
			} else {
				tsBtnProductType.Visible = false;
				tsBtnDepartment.Visible = false;
			}

			tsBtnUserMgmt_Click(null, null);
		}

		private void tsBtnProductType_Click(object sender, EventArgs e)
		{
			if (speedChangeBoxUserControl != null) {
				speedChangeBoxUserControl.Dispose();
			}

			speedChangeBoxUserControl = new SpeedChangeBoxTypeUserControl();
			speedChangeBoxUserControl.Dock = DockStyle.Fill;
			pnlControlContainer.Controls.Clear();
			pnlControlContainer.Controls.Add(speedChangeBoxUserControl);
			tsBtnUserMgmt.Checked = false;
			tsBtnDepartment.Checked = false;
			tsBtnProductType.Checked = true;
		}
	}
}
