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
	public partial class SpeedChangeBoxTypeUserControl : UserControl
	{
		public SpeedChangeBoxTypeUserControl()
		{
			InitializeComponent();
			BindData();
		}

		private void BindData()
		{
			dgvSpeedChangeBox.Rows.Clear();
			var depBLL = new SpeedChangeBoxTypeBLL();
			var result = depBLL.GetSpeedChangeBoxList();
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			}
			int i = 1;
			foreach (var item in result.Data) {
				dgvSpeedChangeBox.Rows.Add(item.SpeedChangeBoxTypeID, i++, item.SpeedChangeBoxName);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var addForm = new AddSpeedChangeBoxTypeForm();
			addForm.CallBack = BindData;
			addForm.ShowDialog();
		}

		private void dgvSpeedChangeBox_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;

			if (rowIndex == -1) {
				return;
			}

			if (this.dgvSpeedChangeBox.Columns[columnIndex] == this.dgvSpeedChangeBox.Columns["Delete"]) {
				var dialogResult = DlgHelper.ShowConfirmMsgBox("确定要删除吗？");
				if (dialogResult == DialogResult.Yes) {
					var id = (int)dgvSpeedChangeBox.Rows[rowIndex].Cells["SpeedChangeBoxTypeID"].Value;
					var result = new SpeedChangeBoxTypeBLL().DelSpeedChangeBox(id);
					if (result.Code > 0) {
						DlgHelper.ShowAlertMsgBox(result.Msg);
						return;
					}
					BindData();
				}
			}
		}
	}
}
