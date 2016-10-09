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
	public partial class OrderDetailForm : Form
	{
		private int _orderID = 0;
		public OrderDetailForm(int orderID)
		{
			this._orderID = orderID;

			InitializeComponent();
		}

		private void OrderDetailForm_Load(object sender, EventArgs e)
		{
			int totalCount = 0;
			var result = new RemovalWarehouseBLL().GetRemovalWarehouseInfoListByOrderID(_orderID, out totalCount, "", 1, -1);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			}
			dgvRemovalOrderDetailRecord.AutoGenerateColumns = false;
			dgvRemovalOrderDetailRecord.DataSource = result.Data;
		}

		private void dgvRemovalOrderDetailRecord_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			int i = 1;
			foreach (DataGridViewRow row in dgvRemovalOrderDetailRecord.Rows) {
				row.Cells[0].Value = i++;
			}
		}
	}
}
