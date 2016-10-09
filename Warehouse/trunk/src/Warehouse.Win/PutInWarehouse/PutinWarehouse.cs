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
using Smt.Zebra;

namespace Warehouse.Win
{
    public partial class PutinWarehouse : UserControl
    {
        private ZebraPrinter _printer = new ZebraPrinter();
        public string _printerTemplateFile = "GK888T.TXT";
        /// <summary>
        /// 当前入库{0}台
        /// </summary>
        private string _countStatisticStr = "当前入库 {0} 台";
        private string _printOnceCountStr = "当前二维码已经包含 {0} 台";
        private string _alreadyPrintCount = "已经打印 {0} 张二维码";
        private bool _isScanOnefinished = false;
        private List<string> _recentBarcodeList = new List<string>();

        public PutinWarehouse()
        {
            InitializeComponent();

            InitControls();
        }

        private void InitControls()
        {
            lblAlreadyPrintCount.Tag = 0;
            txtPutinUserName.Text = MainForm.CurrentUserName;
            var boxTypeDir = new PutInWarehouseBLL().GetSpeedChangeBoxType();
            foreach (var item in boxTypeDir.Data)
            {
                cbxProductType.Items.Add(item);
                cbxProductType.DisplayMember = "SpeedChangeBoxName";
                cbxProductType.ValueMember = "SpeedChangeBoxTypeID";
            }

            ReadConfigFromFile();

            SetPutinSetEnable(false);
            btnStartPutin.Enabled = true;
            btnStopPutin.Enabled = false;
            SetCountStatisticProp(0);

            if (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString()))
            {
                this.btnPutinSet.Visible = true;

            }
            else if (MainForm.CurrentUserRoles.Contains(PermissionEnum.班长.ToString()))
            {
                this.btnPutinSet.Visible = true;
                //this.txtPutinAddress.Enabled =  false  ;
                this.txtPutinAddress.ReadOnly = true;
            }
            else
            {
                this.btnPutinSet.Visible = false;
            }
        }

        private void btnStartPutin_Click(object sender, EventArgs e)
        {
            //AlarmHelper.StartAlarm();

            if (CheckPutinSetIsCorrect() == false)
            {
                DlgHelper.ShowAlertMsgBox("入库设置信息错误，请检查设置！", true);
                return;
            }

            btnPutinSet.Enabled = false;
            btnStartPutin.Enabled = false;
            btnStopPutin.Enabled = true;

            txtBarCode.Text = "";
            _recentBarcodeList.Clear();
            SetCountStatisticProp(0);

            txtBarCode.Focus();
        }

        private void btnPutinSet_Click(object sender, EventArgs e)
        {
            if (btnPutinSet.Text == "修改")
            {
                SetPutinSetEnable(true);
                btnStartPutin.Enabled = false;
                btnPutinSet.Text = "确定";
            }
            else
            {
                var result = WriteConfigToFile();
                if (result == false)
                {
                    return;
                }
                SetPutinSetEnable(false);
                btnStartPutin.Enabled = true;
                btnPutinSet.Text = "修改";
            }
        }

        private void btnStopPutin_Click(object sender, EventArgs e)
        {
            if (_recentBarcodeList.Count > 0)
            {
                var result = DlgHelper.ShowConfirmMsgBox("是否打印二维码?");
                if (result == DialogResult.Yes)
                {
                    if (_recentBarcodeList.Count != int.Parse(txtPrintCount.Text.Trim()))
                    {
                        if (PermissionCheckHelper.GetHighUserPermission("打印不满数量设置的二维码，需要高级权限"))
                        {
                            var saveResult = PrintTwoDimensioncode();
                            while (saveResult == false)
                            {
                                var dlgResult = MessageBox.Show("入库失败，请检查打印机和服务器状态后重试，点击重试！\n点击取消，需要重新入库这条二维码上的产品！", "重试", MessageBoxButtons.RetryCancel);
                                if (dlgResult == DialogResult.Retry)
                                {
                                    saveResult = PrintTwoDimensioncode();
                                }
                                else
                                {
                                    _recentBarcodeList.Clear();
                                    return;
                                }
                            }
                        }
                        else
                        {
                            int removeCount = _recentBarcodeList.Count;
                            _recentBarcodeList.Clear();
                            SetCountStatisticProp((int)lblCountStatistic.Tag - removeCount);
                            DlgHelper.ShowAlertMsgBox("此货架上的货物没有入库，请重新扫描入库！");
                        }
                    }
                }
                else
                {
                    int removeCount = _recentBarcodeList.Count;
                    _recentBarcodeList.Clear();
                    SetCountStatisticProp((int)lblCountStatistic.Tag - removeCount);
                    DlgHelper.ShowAlertMsgBox("此货架上的货物没有入库，请重新扫描入库！");
                }
            }

            btnStopPutin.Enabled = false;
            btnStartPutin.Enabled = true;
            btnPutinSet.Enabled = true;
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                if (_isScanOnefinished == true)
                {
                    txtBarCode.Text = "";
                    _isScanOnefinished = false;
                }
                txtBarCode.Text = txtBarCode.Text + e.KeyChar;
                return;
            }
            else
            {
                _isScanOnefinished = true;
            }

            if (btnStartPutin.Enabled == true)
            {
                DlgHelper.ShowAlertMsgBox("请进行入库设置并点击开始入库后，再开始入库操作！", true);
                txtBarCode.Text = "";
                return;
            }
            var barCode = txtBarCode.Text.Trim();

            if (barCode.Length != 17)
            {
                DlgHelper.ShowAlertMsgBox("条形码长度有误！", true);
                return;
            }

            Console.Beep(5000, 1000);

            if (_recentBarcodeList.Contains(barCode))
            {
                //DlgHelper.ShowAlertMsgBox("产品编号重复！", true);
                return;
            }

            var isNumCorrect = PutInWarehouseBLL.IsSpeedChangeTypeNumRight(barCode, ((WebSpeedChangeBoxType)cbxProductType.SelectedItem).SpeedChangeBoxName);
            if (isNumCorrect == false)
            {
                DlgHelper.ShowAlertMsgBox("产品型号和当前设置的型号不一致!", true);
                return;
            }

            if ((int)lblCountStatistic.Tag >= int.Parse(txtCountLimit.Text.Trim()))
            {
                DlgHelper.ShowAlertMsgBox("已达到数量限制，不能入库！", true);
                return;
            }

            var numCheckResult = PutInWarehouseBLL.IsCurrentPutInInfoRight(barCode);
            if (numCheckResult == PutInResultEnum.仓库已经存在此货物)
            {
                DlgHelper.ShowAlertMsgBox(numCheckResult.ToString(), true);
                return;
            }
            else if (numCheckResult == PutInResultEnum.重复入库)
            {
                if (!PermissionCheckHelper.GetHighUserPermission("重复入库,需要高级权限！"))
                {
                    return;
                }
            }

            _recentBarcodeList.Add(txtBarCode.Text.Trim());

            if (_recentBarcodeList.Count == int.Parse(txtPrintCount.Text))
            {
                var saveResult = PrintTwoDimensioncode();
                if (!saveResult)
                {
                    DlgHelper.AlarmSound();
                    while (saveResult == false)
                    {
                        var dlgResult = MessageBox.Show("入库失败，请检查打印机和服务器状态后重试，点击重试！\n点击取消，需要重新入库这条二维码上的产品！", "重试", MessageBoxButtons.RetryCancel);
                        if (dlgResult == DialogResult.Retry)
                        {
                            saveResult = PrintTwoDimensioncode();
                        }
                        else
                        {
                            _recentBarcodeList.Clear();
                            return;
                        }
                    }
                }
            }

            SetCountStatisticProp((int)lblCountStatistic.Tag + 1);
        }

        private bool PrintTwoDimensioncode()
        {
            //string printStr = string.Join("?", _recentBarcodeList);
            string printStr = string.Join("?", _recentBarcodeList) + "?" + Guid.NewGuid().ToString();
            var resultPrintStr = ConfigHelper.TwoCodePre + DateTime.Now.ToString() + "^" + cbxProductType.Text + "~" + printStr;


            //var resultPrintStr ="变速箱二维码"+DateTime .Now.ToString()+"~"+printStr;
            //var resultPrintStr ="512班二维码"+DateTime.Now.ToString()+"~"+printStr;
            //var resultPrintStr ="513班二维码"+DateTime.Now.ToString()+"~"+printStr;
            //var resultPrintStr ="525班二维码"+DateTime.Now.ToString()+"~"+printStr;
            var printResult = Print(resultPrintStr);
            if (printResult)
            {
                var result = PutInWarehouseBLL.SavePutInWarehouseInfo(_recentBarcodeList, printStr, ((WebSpeedChangeBoxType)cbxProductType.SelectedItem).SpeedChangeBoxTypeID, txtPutinUserName.Text.Trim(), txtPutinAddress.Text.Trim());
                if (result.Code > 0)
                {
                    DlgHelper.ShowAlertMsgBox(result.Msg + "\n此条二维码作废，请处理！", true);
                    //lblAlreadyPrintCount.Text = string.Format(_alreadyPrintCount, -1 + int.Parse(lblAlreadyPrintCount.Text));
                    SetTwoCodePrintCount(-1);

                    return false;
                }
                else
                {
                    _recentBarcodeList.Clear();
                    SetTwoCodePrintCount(1);
                    return true;
                }
            }
            else
            {
                DlgHelper.ShowAlertMsgBox("二维码打印失败，请检查打印机！", true);
                return false;
            }
        }

        public bool Print(string resultPrintStr)
        {
            return _printer.PrintLabEx(_printerTemplateFile, resultPrintStr, ConfigHelper.PrinterName);
        }

        #region Private Helper
        private bool WriteConfigToFile()
        {
            if (CheckPutinSetIsCorrect() == false)
            {
                DlgHelper.ShowAlertMsgBox("入库设置信息错误，请检查设置！");
                return false;
            }
            ;
            var filePath = FileHelper.MakeSureFileExist(SystemInfo.PutinConfigFile);
            using (var writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(((WebSpeedChangeBoxType)cbxProductType.SelectedItem).SpeedChangeBoxName);
                writer.WriteLine(txtPrintCount.Text);
                writer.WriteLine(txtCountLimit.Text);
                writer.WriteLine(txtPutinAddress.Text);
                return true;
            }

        }

        private void ReadConfigFromFile()
        {
            var filePath = FileHelper.MakeSureFileExist(SystemInfo.PutinConfigFile);
            using (var reader = new StreamReader(filePath))
            {
                var line = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    foreach (WebSpeedChangeBoxType item in cbxProductType.Items)
                    {
                        if (item.SpeedChangeBoxName == line)
                        {
                            cbxProductType.SelectedItem = item;
                        }
                    }
                }
                line = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    txtPrintCount.Text = line;
                }
                line = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    txtCountLimit.Text = line;
                }
                line = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    txtPutinAddress.Text = line;
                }

            }
        }

        private void SetCountStatisticProp(int count)
        {
            lblCountStatistic.Tag = count;
            if (count > 0)
            {
                //lblAlreadyPrintCount.Text = string.Format(_alreadyPrintCount, count / int.Parse(txtPrintCount.Text));
                //if (manualAdd == true)
                //{
                //    lblAlreadyPrintCount.Text = string.Format(_alreadyPrintCount, 1 + int.Parse(txtPrintCount.Text));
                //}
                //else {
                //    lblAlreadyPrintCount.Text = string.Format(_alreadyPrintCount, -1 + int.Parse(txtPrintCount.Text));
                //}
            }
            else
            {
                lblAlreadyPrintCount.Text = string.Format(_alreadyPrintCount, 0);
            }
            lblCountStatistic.Text = string.Format(_countStatisticStr, count);
            lblPrintCountStatistic.Text = string.Format(_printOnceCountStr, _recentBarcodeList.Count);

            dgvBarCodeList.Rows.Clear();
            int i = 1;
            foreach (var item in _recentBarcodeList)
            {
                dgvBarCodeList.Rows.Add(i++, item);
            }

            if (count > 0 && count == int.Parse(txtCountLimit.Text.Trim()))
            {
                DlgHelper.ShowAlertMsgBox("已经达到入库设置的总数量,自动停止入库！");
                btnStopPutin_Click(null, null);
            }
        }

        private void SetPutinSetEnable(bool enabled)
        {
            cbxProductType.Enabled = enabled;
            txtCountLimit.Enabled = enabled;
            if (MainForm.CurrentUserRoles.Contains(PermissionEnum.系统管理员.ToString()))
            {
                txtPutinAddress.Enabled = enabled;
            }

            txtPrintCount.Enabled = enabled;
        }


        private bool CheckPutinSetIsCorrect()
        {
            if (cbxProductType.SelectedIndex < 0
            || string.IsNullOrWhiteSpace(txtPutinAddress.Text)
            || string.IsNullOrWhiteSpace(txtPutinUserName.Text))
            {
                return false;
            }
            try
            {
                if (int.Parse(txtPrintCount.Text) <= 0 || int.Parse(txtCountLimit.Text) <= 0)
                {
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return true;
        }
        #endregion

        private void txtPrintCount_Validating(object sender, CancelEventArgs e)
        {
            ControlDataCheckHelper.IntCheck((Control)sender, errorProvider1, e);
        }

        public void SetTxtGetFocus()
        {
            this.txtBarCode.Focus();
        }

        private void btnMannualPrint_Click(object sender, EventArgs e)
        {
            if (!PermissionCheckHelper.GetHighUserPermission("强制打印,需要高级权限！"))
            {
                return;
            }
            
            
            if (_recentBarcodeList.Count == 0)
            {
                return;
            }
            var saveResult = PrintTwoDimensioncode();
            if (!saveResult)
            {
                DlgHelper.AlarmSound();
                while (saveResult == false)
                {
                    var dlgResult = MessageBox.Show("入库失败，请检查打印机和服务器状态后重试，点击重试！\n点击取消，需要重新入库这条二维码上的产品！", "重试", MessageBoxButtons.RetryCancel);
                    if (dlgResult == DialogResult.Retry)
                    {
                        saveResult = PrintTwoDimensioncode();
                    }
                    else
                    {
                        _recentBarcodeList.Clear();
                        return;
                    }
                }
            }
        }

        private void SetTwoCodePrintCount(int addcount)
        {
            lblAlreadyPrintCount.Tag = (int)lblAlreadyPrintCount.Tag + addcount;
            lblAlreadyPrintCount.Text = string.Format(_alreadyPrintCount, (int)lblAlreadyPrintCount.Tag);
            SetCountStatisticProp((int)lblCountStatistic.Tag);
        }

        private void PutinWarehouse_Load(object sender, EventArgs e)
        {

        }
    }
}
