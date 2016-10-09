using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.BLL;
using Warehouse.ViewModel;
using Warehouse.Common;

namespace Warehouse.Win
{
	public partial class AlarmForm : Form
	{
		public AlarmForm(string alarmContent, AlarmType alarmType)
		{
			InitializeComponent();

			richTextBoxAlarmContent.Text = alarmContent;
			var alarm = new WebAlarm() {
				AlarmContent = alarmContent,
				AlarmTypeInt = (int)alarmType,
				Operator = MainForm.CurrentUserName,
			};
			var result = new AlarmBLL().AddAlarm(alarm);
			if (result.Code > 0) {
				DlgHelper.ShowAlertMsgBox(result.Msg);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AlarmForm_Load(object sender, EventArgs e)
		{
			var width = richTextBoxAlarmContent.Width;
			var formmWidth = this.Width;
			richTextBoxAlarmContent.Left = (formmWidth - width) / 2;
			AlarmHelper.StartAlarm();
		}

		private void AlarmForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			AlarmHelper.StopAlarm();
		}
	}
}
