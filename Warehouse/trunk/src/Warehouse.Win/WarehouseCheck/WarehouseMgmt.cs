using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.Win.WarehouseCheck;

namespace Warehouse.Win
{
	public partial class WarehouseMgmt : UserControl
	{
		//private PutInWarehouseCheckUserControl putInCheckUserControl;
		//private PutInWarehouseCheckUserControl warehouseCheckUserControl;
		//private RemovalWarehouseCheckUserControl removalCheckUserControl;

		public WarehouseMgmt()
		{
			InitializeComponent();
		}

		private void tsBtnPutInCheck_Click(object sender, EventArgs e)
		{
			var putInCheckUserControl = new PutInWarehouseCheckUserControl(true);
			putInCheckUserControl.Dock = DockStyle.Fill;

			pnlCheckControlContainer.Controls.Clear();
			pnlCheckControlContainer.Controls.Add(putInCheckUserControl);

			tsBtnPutInCheck.Checked = true;
			tsBtnRemovalCheck.Checked = false;
			tsBtnWarehouseCheck.Checked = false;
			btnShowAlarmTable.Checked = false;
		}

		private void tsBtnWarehouseCheck_Click(object sender, EventArgs e)
		{
			var warehouseCheckUserControl = new PutInWarehouseCheckUserControl(false);
			warehouseCheckUserControl.Dock = DockStyle.Fill;

			pnlCheckControlContainer.Controls.Clear();
			pnlCheckControlContainer.Controls.Add(warehouseCheckUserControl);

			tsBtnPutInCheck.Checked = false;
			tsBtnRemovalCheck.Checked = false;
			tsBtnWarehouseCheck.Checked = true;
			btnShowAlarmTable.Checked = false;
		}

		private void tsBtnRemovalCheck_Click(object sender, EventArgs e)
		{
			var removalCheckUserControl = new RemovalWarehouseCheckUserControl();
			removalCheckUserControl.Dock = DockStyle.Fill;

			pnlCheckControlContainer.Controls.Clear();
			pnlCheckControlContainer.Controls.Add(removalCheckUserControl);

			tsBtnPutInCheck.Checked = false;
			tsBtnRemovalCheck.Checked = true;
			tsBtnWarehouseCheck.Checked = false;
			btnShowAlarmTable.Checked = false;
		}

		private void WarehouseMgmt_Load(object sender, EventArgs e)
		{
			tsBtnPutInCheck_Click(null, null);
		}

		private void btnShowAlarmTable_Click(object sender, EventArgs e)
		{
			var alarmUserControl = new AlarmListUserControl();
			alarmUserControl.Dock = DockStyle.Fill;

			pnlCheckControlContainer.Controls.Clear();
			pnlCheckControlContainer.Controls.Add(alarmUserControl);
			tsBtnPutInCheck.Checked = false;
			tsBtnRemovalCheck.Checked = false;
			tsBtnWarehouseCheck.Checked = false;
			btnShowAlarmTable.Checked = true;

		}
	}
}
