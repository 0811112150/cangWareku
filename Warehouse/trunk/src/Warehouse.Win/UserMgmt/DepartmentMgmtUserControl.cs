using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.BLL;

namespace Warehouse.Win
{
	public partial class DepartmentMgmtUserControl : UserControl
	{
		public DepartmentMgmtUserControl()
		{
			InitializeComponent();
			dgvDepartment.AutoGenerateColumns = false;
			BindData();
		}

		private void BindData()
		{
			dgvDepartment.Rows.Clear();
			var depBLL = new DepartmentBLL();
			var result = depBLL.GetAllDepartment();
			int i = 1;
			foreach (var item in result) {
				dgvDepartment.Rows.Add(item.DepartmentID, i++, item.DepartmentName);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;

			if (rowIndex == -1) {
				return;
			}

			if (this.dgvDepartment.Columns[columnIndex] == this.dgvDepartment.Columns["Delete"]) {
				var dialogResult = DlgHelper.ShowConfirmMsgBox("确定要删除吗？");
				if (dialogResult == DialogResult.Yes) {
					var id = (int)dgvDepartment.Rows[rowIndex].Cells["DepartmentID"].Value;
					var result = new DepartmentBLL().DeleteDepartmentByID(id);
					if (result.Code > 0) {
						DlgHelper.ShowAlertMsgBox(result.Msg);
						return;
					}
					BindData();
				}
			} else if (this.dgvDepartment.Columns[columnIndex] == this.dgvDepartment.Columns["Edit"]) {
				var id = (int)dgvDepartment.Rows[rowIndex].Cells["DepartmentID"].Value;
				var name = dgvDepartment.Rows[rowIndex].Cells["DepartmentName"].Value.ToString();

				var departmentForm = new AddDepartmentForm(true, id, name);
				departmentForm.CallBack += BindData;

				departmentForm.ShowDialog();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var addDepartment = new AddDepartmentForm(false);
			addDepartment.CallBack += BindData;

			addDepartment.ShowDialog();
		}
	}
}
