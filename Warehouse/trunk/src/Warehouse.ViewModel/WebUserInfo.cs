using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Warehouse.ViewModel
{
	public class WebUserInfo
	{
		private string _phone = string.Empty;
		private string _adress = string.Empty;
		private string _userName = string.Empty;
		private string _passWord = string.Empty;
		private string _confirmPassWord = string.Empty;
		private string _departmentName = string.Empty;

		public string ConfirmPassWord { get { return _confirmPassWord; } set { _confirmPassWord = value; } }
		public string PassWord { get { return _passWord; } set { _passWord = value; } }
		public string UserName { get { return _userName; } set { _userName = value; } }
		public int? DepartmentID { get; set; }
		public int ID { get; set; }
		public string Phone { get { return _phone; } set { _phone = value; } }
		public string Adress { get { return _adress; } set { _adress = value; } }
		public string DepartmentName { get { return _departmentName; } set { _departmentName = value; } }
		public bool IsMonitor { get; set; }
		public bool IsPutinMan { get; set; }
		public bool IsRemovalMan { get; set; }
	}
}
