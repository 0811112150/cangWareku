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
using Warehouse.Common.CResult;

namespace Warehouse.Win
{
	public partial class AddDepartmentForm : Form
	{
		private bool _isEdit = false;
		private int _departmentID;

		public MethodInvoker CallBack;

		public AddDepartmentForm(bool isEdit, int departmentID = 0, string oldName = "")
		{
			InitializeComponent();
			_isEdit = isEdit;
			_departmentID = departmentID;
			this.txtDepartmentName.Text = oldName;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			var departmentName = txtDepartmentName.Text.Trim();

			if (this.ValidateChildren(ValidationConstraints.Enabled) == false) {
				return;
			}

			CResult<bool> result;
			var bll = new DepartmentBLL();
			if (_isEdit) {
				result = bll.UpdateDepartment(departmentName, _departmentID);
			} else {
				result = bll.AddDepartment(departmentName);
			}

			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			}

			this.Close();

			if (CallBack != null) {
				CallBack();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void txtDepartmentName_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.NotNullCheck((Control)sender, errorProvider1, e);
		}

		private void AddDepartmentForm_Validating(object sender, CancelEventArgs e)
		{
			foreach (Control item in this.Controls) {
				item.Focus();
			}
		}
	}
}
