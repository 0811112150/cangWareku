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

namespace Warehouse.Win.WarehouseCheck
{
	public partial class AlarmListUserControl : UserControl
	{
		private AlarmOrderEnum _currentOrderBy = AlarmOrderEnum.AlarmTime;
		private int _firstIndex = 1;
		private bool _ascding = false;

		public AlarmListUserControl()
		{
			InitializeComponent();

			dgvAlarmList.AutoGenerateColumns = false;
			customPageControl.PageChange += PageChange;
		}

		private int PageChange(int pageIndex, int pageSize)
		{
			_firstIndex = (pageIndex - 1) * pageSize + 1;
			int totalCount;

			var result = new AlarmBLL().GetAllAlarm(out totalCount, "", pageIndex, pageSize, _currentOrderBy, _ascding, null, null);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
			}

			dgvAlarmList.DataSource = result.Data;

			return totalCount;
		}
		private void AlarmListUserControl_Load(object sender, EventArgs e)
		{
			customPageControl.MannuleClickGo();
		}

		private void dgvAlarmList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			AlarmOrderEnum orderBy = AlarmOrderEnum.AlarmTime;
			switch (e.ColumnIndex) {
				case 2:
					orderBy = AlarmOrderEnum.AlarmTime;
					break;
				case 3:
					orderBy = AlarmOrderEnum.AlarmType;
					break;
			}
			if (_currentOrderBy == orderBy) {
				_ascding = !_ascding;
			} else {
				_ascding = true;
			}
			_currentOrderBy = orderBy;
			customPageControl.MannuleClickGo();
		}

		private void dgvAlarmList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			int i = _firstIndex;
			foreach (DataGridViewRow row in dgvAlarmList.Rows) {
				row.Cells[1].Value = i++;
			}
		}
	}
}
