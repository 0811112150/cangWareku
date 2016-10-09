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
	public partial class RemovalWarehouseCheckUserControl : UserControl
	{
		private int _firstIndex = 1;
		private WarehouseOrderOrderEnum currentOrderBy = WarehouseOrderOrderEnum.DispathTime;
		private bool ascding = false;
		private DateTime _startTime;
		private DateTime _endTime;

		public RemovalWarehouseCheckUserControl()
		{
			InitializeComponent();
			dgvRemovalOrderRecord.AutoGenerateColumns = false;
			customPageControl.PageChange += PageChange;
			//searchStartTime.Value = System.DateTime.Now;
			//searchEndTime.Value = System.DateTime.Now.AddDays(1);
            searchStartTime.Value = System.DateTime.Now.AddDays(-1);
            searchEndTime.Value = System.DateTime.Now;
			_startTime = searchStartTime.Value;
			_endTime = searchEndTime.Value;
		}

		private int PageChange(int pageIndex, int pageSize)
		{
			_firstIndex = (pageIndex - 1) * pageSize + 1;

			var warehouseBLL = new RemovalWarehouseBLL();
			int totalCount;
			var result = warehouseBLL.GetRemovalWarehouseOrderList(out totalCount, txtSearchKey.Text.Trim(), pageIndex, pageSize,
				currentOrderBy, ascding, searchStartTime.Value, searchEndTime.Value);
			dgvRemovalOrderRecord.DataSource = result.Data;

			return totalCount;
		}

		private void dgvPutinRecord_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			WarehouseOrderOrderEnum orderBy = WarehouseOrderOrderEnum.DispathTime;
			switch (e.ColumnIndex) {
				case 3:
					orderBy = WarehouseOrderOrderEnum.Staff;
					break;
				case 4:
					orderBy = WarehouseOrderOrderEnum.DispathPlace;
					break;
				case 5:
					orderBy = WarehouseOrderOrderEnum.DispathTime;
					break;
			}
			if (currentOrderBy == orderBy) {
				ascding = !ascding;
			} else {
				ascding = true;
			}
			currentOrderBy = orderBy;
			customPageControl.MannuleClickGo();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			customPageControl.MannuleClickGo();
		}

		private void WarehouseCheckUserControl_Load(object sender, EventArgs e)
		{
			customPageControl.MannuleClickGo();
		}

		private void dgvRemovalOrderRecord_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			int i = _firstIndex;
			foreach (DataGridViewRow row in dgvRemovalOrderRecord.Rows) {
				row.Cells[1].Value = i++;
			}
		}

		private void dgvRemovalOrderRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int columnIndex = e.ColumnIndex;
			int rowIndex = e.RowIndex;

			if (rowIndex == -1) {
				return;
			}

			var clickColumn = dgvRemovalOrderRecord.Columns[columnIndex];
			var id = (int)dgvRemovalOrderRecord.Rows[rowIndex].Cells["OrderID"].Value;
			if (clickColumn == this.dgvRemovalOrderRecord.Columns["ViewOrderDetail"]) {
				var orderDetailForm = new OrderDetailForm(id);
				orderDetailForm.ShowDialog();
			}
		}

		private void searchStartTime_CloseUp(object sender, EventArgs e)
		{
			var startTime = searchStartTime.Value;
			var endTime = searchEndTime.Value;
			if (startTime > endTime) {
				MessageBox.Show("开始时间不能大于结束时间");
				return;
			}
			_startTime = startTime;
		}

		private void searchEndTime_CloseUp(object sender, EventArgs e)
		{
			var startTime = searchStartTime.Value;
			var endTime = searchEndTime.Value;
			if (startTime > endTime) {
				MessageBox.Show("开始时间不能大于结束时间");
			}
			_endTime = endTime;
		}
	}
}
