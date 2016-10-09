using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.BLL;
using Warehouse.ViewModel;
using Warehouse.Common;
using System.IO;

namespace Warehouse.Win
{
	public partial class RemovalUserControl : UserControl
	{
		/// <summary>
		/// 当前入库{0}台
		/// </summary>
		private string _countStatisticStr = "当前出库 {0} 台";
		private string _alreadyPrintCount = "已经扫描 {0} 张二维码";
		private bool _isScanOnefinished = false;
		private int _currentOrderID;
		List<WebPutInWarehouseRecord> barCodeList = new List<WebPutInWarehouseRecord>();

		public RemovalUserControl()
		{
			InitializeComponent();

			InitControls();
		}

		private void InitControls()
		{
			dgvBarCodeList.AutoGenerateColumns = false;
			txtRemovalUserName.Text = MainForm.CurrentUserName;
			var boxTypeDir = new PutInWarehouseBLL().GetSpeedChangeBoxType();
			foreach (var item in boxTypeDir.Data) {
				cbxProductType.Items.Add(item);
				cbxProductType.DisplayMember = "SpeedChangeBoxName";
				cbxProductType.ValueMember = "SpeedChangeBoxTypeID";
			}

			LoadDispatchPlaceList();

			ReadConfigFromFile();

			SetPutinSetEnable(false);
			btnStartRemoval.Enabled = true;
			btnStopRemoval.Enabled = false;
			SetCountStatisticText(0, true);

    //        if (MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString())
    //|| MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString())) {
    //            this.btnRemovalSet.Visible = true;
    //        } else {
    //            this.btnRemovalSet.Visible = false;
    //        }
		}

		private void btnStartRemoval_Click(object sender, EventArgs e)
		{
			if (CheckPutinSetIsCorrect() == false) {
				DlgHelper.ShowAlertMsgBox("出库设置信息错误，请检查设置！", true);
				return;
			}

			var removalOrder = new WebRemovalWarehouseOrder() {
				SpeedChangeBoxName = ((WebSpeedChangeBoxType)cbxProductType.SelectedItem).SpeedChangeBoxName,
				DispathPlace = cbxDispathPlace.Text,
				Staff = txtRemovalUserName.Text,
				PlanCount = int.Parse(txtCountLimit.Text),
			};
			var result = RemovalWarehouseBLL.SaveRemalWarehouseOrder(removalOrder);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			}
			_currentOrderID = result.Data;

			btnRemovalSet.Enabled = false;
			btnStartRemoval.Enabled = false;
			btnStopRemoval.Enabled = true;

			txtBarCode.Text = "";
			SetCountStatisticText(0, true);

			txtBarCode.Focus();
		}

		private void btnRemovalSet_Click(object sender, EventArgs e)
		{
			if (btnRemovalSet.Text == "修改") {
				SetPutinSetEnable(true);
				btnStartRemoval.Enabled = false;
				btnRemovalSet.Text = "确定";
			} else {
                if (!MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString())
        && !MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString()))
                {
                    var isHasPermission = PermissionCheckHelper.GetHighUserPermission("出库设置需要高级权限！");
                    if (isHasPermission == false)
                    {
                        return;
                    }
                }

				var result = WriteConfigToFile();
				if (result == false) {
					return;
				}
				SetPutinSetEnable(false);
				btnStartRemoval.Enabled = true;
				btnRemovalSet.Text = "修改";
			}

		}

		private void btnStopRemoval_Click(object sender, EventArgs e)
		{
			btnStopRemoval.Enabled = false;
			btnStartRemoval.Enabled = true;
			btnRemovalSet.Enabled = true;
		}

		private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != 13) {
				if (_isScanOnefinished == true) {
					txtBarCode.Text = "";
					_isScanOnefinished = false;
				}
				txtBarCode.Text = txtBarCode.Text + e.KeyChar;
				return;
			}
			if (btnStartRemoval.Enabled == true) {
				DlgHelper.ShowAlertMsgBox("请进行出库设置并点击开始入库后，再开始出库操作！", true);
				txtBarCode.Text = "";
				return;
			}

			_isScanOnefinished = true;

			var twoDimensionCode = txtBarCode.Text;
			var planTotalCount = int.Parse(txtCountLimit.Text.Trim());
			var currentTotalCount = (int)lblCountStatistic.Tag;
			int containCount = 0;

			var saveRemovalResult = RemovalWarehouseBLL.SaveRemalWarehouseInfo(out barCodeList, out containCount, twoDimensionCode, _currentOrderID, ((WebSpeedChangeBoxType)cbxProductType.SelectedItem).SpeedChangeBoxTypeID
				, planTotalCount, currentTotalCount);

			if (saveRemovalResult != RemovalResultEnum.执行成功) {
				if (saveRemovalResult == RemovalResultEnum.变速箱型号不一致) {
					//报警
					new AlarmForm(RemovalResultEnum.变速箱型号不一致.ToString(), AlarmType.出库报警).ShowDialog();
					return;
				} else if (saveRemovalResult == RemovalResultEnum.当前出库数量已经大于设置的出库数量) {
					new AlarmForm(RemovalResultEnum.当前出库数量已经大于设置的出库数量.ToString(), AlarmType.出库报警).ShowDialog();
					var dlgResult = DlgHelper.ShowConfirmMsgBox("是否继续将超出的数量出库？");
					if (dlgResult == DialogResult.Yes) {
						RemovalWarehouseBLL.SaveRemalWarehouseInfo(out barCodeList, out containCount, twoDimensionCode, _currentOrderID, ((WebSpeedChangeBoxType)cbxProductType.SelectedItem).SpeedChangeBoxTypeID
						, planTotalCount, currentTotalCount, true);
					} else {
						return;
					}
				} else {
					DlgHelper.ShowAlertMsgBox(saveRemovalResult.ToString(), true);
					return;
				}
			}
			SetCountStatisticText(containCount, false);
		}

		#region Private Helper
		private bool WriteConfigToFile()
		{
			if (CheckPutinSetIsCorrect() == false) {
				DlgHelper.ShowAlertMsgBox("出库设置信息错误，请检查设置！", true);
				return false;
			}
			;
			var filePath = FileHelper.MakeSureFileExist(SystemInfo.RemovalConfigFile);
			using (var writer = new StreamWriter(filePath, false)) {
				writer.WriteLine(((WebSpeedChangeBoxType)cbxProductType.SelectedItem).SpeedChangeBoxName);
				writer.WriteLine(txtCountLimit.Text);
				writer.WriteLine(cbxDispathPlace.Text);
				return true;
			}
		}

		private void ReadConfigFromFile()
		{
			var filePath = FileHelper.MakeSureFileExist(SystemInfo.RemovalConfigFile);
			using (var reader = new StreamReader(filePath)) {
				var line = reader.ReadLine();
				if (!string.IsNullOrWhiteSpace(line)) {
					foreach (WebSpeedChangeBoxType item in cbxProductType.Items) {
						if (item.SpeedChangeBoxName == line) {
							cbxProductType.SelectedItem = item;
						}
					}
				}
				line = reader.ReadLine();
				if (!string.IsNullOrWhiteSpace(line)) {
					txtCountLimit.Text = line;
				}
				line = reader.ReadLine();
				if (!string.IsNullOrWhiteSpace(line)) {
					cbxDispathPlace.SelectedItem = line;
				}
			}
		}

		private void SetCountStatisticText(int addCount, bool clearCount = false)
		{
			if (clearCount == true) {
				lblCountStatistic.Tag = 0;
				lblAlreadySacnCount.Tag = 0;
			} else {
				if (addCount > 0) {
					lblAlreadySacnCount.Tag = (int)lblAlreadySacnCount.Tag + 1;
				}
				lblCountStatistic.Tag = (int)lblCountStatistic.Tag + addCount;
			}

			//dgvBarCodeList.Rows.Clear();
			dgvBarCodeList.DataSource = barCodeList;
			int i = 1;
			foreach (DataGridViewRow row in dgvBarCodeList.Rows) {
				row.Cells[0].Value = i++;
			}

			lblAlreadySacnCount.Text = string.Format(_alreadyPrintCount, lblAlreadySacnCount.Tag);
			lblCountStatistic.Text = string.Format(_countStatisticStr, lblCountStatistic.Tag);

			var totalCount = (int)lblCountStatistic.Tag;
			if (totalCount > 0 && totalCount >= int.Parse(txtCountLimit.Text.Trim())) {
				DlgHelper.ShowAlertMsgBox("已经达到出库设置的总数量,自动停止出库！", true);
				btnStopRemoval_Click(null, null);
			}
		}

		private void SetPutinSetEnable(bool enabled)
		{
			cbxProductType.Enabled = enabled;
			txtCountLimit.Enabled = enabled;
			cbxDispathPlace.Enabled = enabled;
		}

		private bool CheckPutinSetIsCorrect()
		{
			if (cbxProductType.SelectedIndex < 0
			|| string.IsNullOrWhiteSpace(cbxDispathPlace.Text)
			|| string.IsNullOrWhiteSpace(txtRemovalUserName.Text)) {
				return false;
			}
			try {
				if (int.Parse(txtCountLimit.Text) <= 0) {
					return false;
				}
			} catch (System.Exception ex) {
				return false;
			}

			return true;
		}
		#endregion

		private void txtCountLimit_Validating(object sender, CancelEventArgs e)
		{
			ControlDataCheckHelper.IntCheck((Control)sender, errorProvider1, e);
		}

		public void SetTxtGetFocus()
		{
			this.txtBarCode.Focus();
		}

		private void LoadDispatchPlaceList()
		{
			var filePath = FileHelper.MakeSureFileExist(SystemInfo.DispatchPlaceFile);
			using (var reader = new StreamReader(filePath)) {
				var line = reader.ReadLine();
				while (!string.IsNullOrWhiteSpace(line)) {
					cbxDispathPlace.Items.Add(line);
					line = reader.ReadLine();
				}
				if (cbxDispathPlace.Items.Count > 0) {
					cbxDispathPlace.SelectedIndex = 0;
				}
			}
        }
	}
}
