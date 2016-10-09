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
using Warehouse.Common.CResult;
using Warehouse.ViewModel;

namespace Warehouse.Win
{
    public partial class PutInWarehouseCheckUserControl : UserControl
    {
        private PutInListOrderEnum _currentOrderBy = PutInListOrderEnum.PutInTime;
        private bool _ascding = false;
        private bool _isPutinOrWarehouseCheck = true;
        private int _firstIndex = 1;
        private DateTime _startTime;
        private DateTime _endTime;

        public PutInWarehouseCheckUserControl(bool isPutinOrWarehouseCheck)
        {
            InitializeComponent();
            _isPutinOrWarehouseCheck = isPutinOrWarehouseCheck;
            dgvPutinRecord.AutoGenerateColumns = false;
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

            var warehouseBLL = new PutInWarehouseBLL();
            int totalCount;
            CResult<List<WebPutInWarehouseRecord>> result;
           // if (_isPutinOrWarehouseCheck == true)
           // {
               // dgvPutinRecord.Columns["PrintTwoCode"].Visible = false;
               // result = warehouseBLL.GetPutInWarehouseInfo(out totalCount, txtSearchKey.Text.Trim(), pageIndex, pageSize, _currentOrderBy,
                 //   _ascding, searchStartTime.Value, searchEndTime.Value);
          //  }
          //  else if (_isPutinOrWarehouseCheck == false & (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())))
          //  {
                //if (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString()))
                //{
                  //  result = warehouseBLL.GetWarehouseInfoList(out totalCount, txtSearchKey.Text.Trim(), pageIndex, pageSize, _currentOrderBy, _ascding
                  //  , searchStartTime.Value, searchEndTime.Value);

                    

              //  }
                
           // dgvPutinRecord.DataSource = result.Data;

            // return totalCount;

            //if (_isPutinOrWarehouseCheck == false & (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())))
            if (_isPutinOrWarehouseCheck == false)

             {
             result = warehouseBLL.GetWarehouseInfoList(out totalCount, txtSearchKey.Text.Trim(), pageIndex, pageSize, _currentOrderBy, _ascding
              , searchStartTime.Value, searchEndTime.Value);
             }
             else 
             {
              

                dgvPutinRecord.Columns["PrintTwoCode"].Visible = false;
             result = warehouseBLL.GetPutInWarehouseInfo(out totalCount, txtSearchKey.Text.Trim(), pageIndex, pageSize, _currentOrderBy,
              _ascding, searchStartTime.Value, searchEndTime.Value);

             }

            dgvPutinRecord.DataSource = result.Data;

             return totalCount;

        }

        private void dgvPutinRecord_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PutInListOrderEnum orderBy = PutInListOrderEnum.PutInTime;
            switch (e.ColumnIndex)
            {
                case 2:
                    orderBy = PutInListOrderEnum.BarCode;
                    break;
                case 3:
                    orderBy = PutInListOrderEnum.PutInUserName;
                    break;
                case 4:
                    orderBy = PutInListOrderEnum.Place;
                    break;
                case 5:
                    orderBy = PutInListOrderEnum.PutInTime;
                    break;
            }
            if (_currentOrderBy == orderBy)
            {
                _ascding = !_ascding;
            }
            else
            {
                _ascding = true;
            }
            _currentOrderBy = orderBy;
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

        private void dgvPutinRecord_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int i = _firstIndex;
            foreach (DataGridViewRow row in dgvPutinRecord.Rows)
            {
                row.Cells[1].Value = i++;
            }
        }

        private void dgvPutinRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;

            if (rowIndex == -1)
            {
                return;
            }

            var clickColumn = dgvPutinRecord.Columns[columnIndex];
            var id = (int)dgvPutinRecord.Rows[rowIndex].Cells["RecordID"].Value;

            if (clickColumn == dgvPutinRecord.Columns["PrintTwoCode"])
            {
                var twoCode = new RemovalWarehouseBLL().TwoDimensionCodeByBarID(id);
                if (twoCode.Code > 0)
                {
                    DlgHelper.ShowAlertMsgBox(twoCode.Msg);
                    return;
                }
                var resultPrintStr = ConfigHelper.TwoCodePre + DateTime.Now.ToString() + "^" +twoCode.Data;
                new PutinWarehouse().Print(resultPrintStr);
            }
        }

        private void searchStartTime_CloseUp(object sender, EventArgs e)
        {
            var startTime = searchStartTime.Value;
            var endTime = searchEndTime.Value;
            if (startTime > endTime)
            {
                MessageBox.Show("开始时间不能大于结束时间");
                return;
            }
            _startTime = startTime;

        }

        private void searchEndTime_CloseUp(object sender, EventArgs e)
        {
            var startTime = searchStartTime.Value;
            var endTime = searchEndTime.Value;
            if (startTime > endTime)
            {
                MessageBox.Show("开始时间不能大于结束时间");
            }
            _endTime = endTime;
        }

        private void customPageControl_Load(object sender, EventArgs e)
        {

        }
    }
}
