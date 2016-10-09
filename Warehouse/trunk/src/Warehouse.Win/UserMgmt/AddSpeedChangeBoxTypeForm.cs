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
	public partial class AddSpeedChangeBoxTypeForm : Form
	{
		public MethodInvoker CallBack;

		public AddSpeedChangeBoxTypeForm()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtProductName.Text.Trim())) {
				DlgHelper.ShowAlertMsgBox("请填写产品型号！");
				return;
			}

			var result = new SpeedChangeBoxTypeBLL().AddSpeedChangeBoxType(txtProductName.Text.Trim());

			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
				return;
			}

			if (CallBack != null) {
				CallBack();
			}

			this.Dispose();
		}
	}
}
