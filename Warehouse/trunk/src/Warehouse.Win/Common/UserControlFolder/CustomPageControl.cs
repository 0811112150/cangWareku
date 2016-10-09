using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Warehouse.Win
{
	public partial class CustomPageControl : UserControl
	{
		/// <summary>
		///第一个为Pageindex，第二个为Pagesize，第三个问返回值TotalCount
		/// </summary>
		public Func<int, int, int> PageChange;

		private string statisticStr = "共 {0} 条记录，共 {1} 页";
		private int totalCount = 0;
		private int pageSize = 10;
		private int pageIndex = 1;
		private int totalPage = 1;

		public CustomPageControl()
		{
			InitializeComponent();

			InitControls();

			CallPageChange();
		}

		private void InitControls()
		{
			if (totalCount % pageSize == 0) {
				totalPage = totalCount / pageSize;
			} else {
				totalPage = totalCount / pageSize + 1;
			}
			if (totalCount == 0) {
				totalPage = 1;
			}

			cbxPageIndex.Items.Clear();
			for (int i = 1; i <= totalPage; i++) {
				cbxPageIndex.Items.Add(i);
			}
			if (cbxPageIndex.Items.Count < pageIndex) {
				cbxPageIndex.SelectedIndex = cbxPageIndex.Items.Count - 1;
			} else {
				cbxPageIndex.SelectedIndex = pageIndex - 1;
			}

			txtPageSize.Text = pageSize.ToString();
			lblDisplay.Text = string.Format(statisticStr, totalCount, totalPage);
		}

		private void btnPrePage_Click(object sender, EventArgs e)
		{
			pageIndex -= 1;
			CallPageChange();
		}

		private void btnNextPage_Click(object sender, EventArgs e)
		{
			pageIndex += 1;
			CallPageChange();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			MannuleClickGo();
		}

		private void CallPageChange()
		{
			pageSize = int.Parse(txtPageSize.Text);

			if (PageChange != null) {
				totalCount = PageChange(pageIndex, pageSize);
				InitControls();
			}

			SetBtnEnable();
		}

		private void SetBtnEnable()
		{
			if (totalPage == 1) {
				btnFirstPage.Enabled = false;
				btnPrePage.Enabled = false;
				btnNextPage.Enabled = false;
				btnLastPage.Enabled = false;
				return;
			}

			if (pageIndex == 1) {
				btnFirstPage.Enabled = false;
				btnPrePage.Enabled = false;
				btnLastPage.Enabled = true;
				btnNextPage.Enabled = true;
            }
            else if (pageIndex == totalPage)
            {
                btnFirstPage.Enabled = true;
                btnPrePage.Enabled = true;
                btnLastPage.Enabled = false;
                btnNextPage.Enabled = false;
            }
            else {
                btnFirstPage.Enabled = true;
                btnPrePage.Enabled = true;
                btnLastPage.Enabled = true;
                btnNextPage.Enabled = true;
            }
		}

		private void btnFirstPage_Click(object sender, EventArgs e)
		{
			pageIndex = 1;
			CallPageChange();
		}

		private void btnLastPage_Click(object sender, EventArgs e)
		{
			pageIndex = totalPage;
			CallPageChange();
		}

		public void MannuleClickGo()
		{
			pageIndex = cbxPageIndex.SelectedIndex + 1;
			CallPageChange();
		}
	}
}
