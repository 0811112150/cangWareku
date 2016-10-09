using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Warehouse.Common;
using System.IO;
using System.Web.Security;
using Warehouse.BLL;

namespace Warehouse.Win
{
	public partial class UserLoginForm : Form
	{
		public UserLoginForm()
		{
			InitializeComponent();
		}

		private void UserLoginForm_Load(object sender, EventArgs e)
		{
			//var user = Membership.CreateUser("adminstrator", "123456");

			//new UserBLL().ResetPassword("123456", "adminstrator");
			LoadRemenberUserNames();
		}

		private void LoadRemenberUserNames()
		{
			var filePath = FileHelper.MakeSureFileExist(SystemInfo.RemenberUserNamesFile);
			using (var reader = new StreamReader(filePath)) {
				var line = reader.ReadLine();
				while (!string.IsNullOrWhiteSpace(line)) {
					cbxUserNameList.Items.Add(line);
					line = reader.ReadLine();
				}
				if (cbxUserNameList.Items.Count > 0) {
					cbxUserNameList.SelectedIndex = 0;
				}
			}
		}

		private void WriteRemberUserName()
		{
			var filePath = FileHelper.MakeSureFileExist(SystemInfo.RemenberUserNamesFile);
			using (var writer = new StreamWriter(filePath, false)) {
				writer.WriteLine(cbxUserNameList.Text);
				int i = 1;
				foreach (string item in cbxUserNameList.Items) {
					if (item != cbxUserNameList.Text) {
						writer.WriteLine(item);
						i++;
						if (i >= 5) {
							break;
						}
					}
				}
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			var userName = cbxUserNameList.Text.Trim();
			var password = txtPassword.Text.Trim();
			if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password)) {
				DlgHelper.ShowAlertMsgBox("请输入用户名或密码");
				return;
			}
            
			if (Membership.ValidateUser(userName, password)) {
				WriteRemberUserName();
				this.Visible = false;
				new MainForm(userName).ShowDialog();
			} else {
				DlgHelper.ShowAlertMsgBox("用户名或密码错误！");
				return;
			}
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(txtPassword.Text)) {
				btnLogin_Click(null, null);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
