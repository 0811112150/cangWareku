namespace Warehouse.Win
{
	partial class RemovalWarehouseCheckUserControl
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlSearch = new System.Windows.Forms.Panel();
			this.searchEndTime = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.searchStartTime = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearchKey = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.customPageControl = new Warehouse.Win.CustomPageControl();
			this.dgvRemovalOrderRecord = new System.Windows.Forms.DataGridView();
			this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IndexID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SpeedChangeBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BoxCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DispathPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ViewOrderDetail = new System.Windows.Forms.DataGridViewLinkColumn();
			this.pnlSearch.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRemovalOrderRecord)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlSearch
			// 
			this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSearch.AutoScroll = true;
			this.pnlSearch.BackColor = System.Drawing.Color.Lavender;
			this.pnlSearch.Controls.Add(this.searchEndTime);
			this.pnlSearch.Controls.Add(this.label3);
			this.pnlSearch.Controls.Add(this.searchStartTime);
			this.pnlSearch.Controls.Add(this.label2);
			this.pnlSearch.Controls.Add(this.label1);
			this.pnlSearch.Controls.Add(this.btnSearch);
			this.pnlSearch.Controls.Add(this.txtSearchKey);
			this.pnlSearch.Location = new System.Drawing.Point(0, 0);
			this.pnlSearch.Name = "pnlSearch";
			this.pnlSearch.Size = new System.Drawing.Size(857, 53);
			this.pnlSearch.TabIndex = 5;
			// 
			// searchEndTime
			// 
			this.searchEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchEndTime.Location = new System.Drawing.Point(238, 14);
			this.searchEndTime.Name = "searchEndTime";
			this.searchEndTime.Size = new System.Drawing.Size(124, 21);
			this.searchEndTime.TabIndex = 9;
			this.searchEndTime.CloseUp += new System.EventHandler(this.searchEndTime_CloseUp);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(212, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "至";
			// 
			// searchStartTime
			// 
			this.searchStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchStartTime.Location = new System.Drawing.Point(80, 14);
			this.searchStartTime.Name = "searchStartTime";
			this.searchStartTime.Size = new System.Drawing.Size(126, 21);
			this.searchStartTime.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "起始时间:";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(427, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "请输入条形码型号，出库员";
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSearch.Location = new System.Drawing.Point(789, 12);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(52, 23);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "搜索";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearchKey
			// 
			this.txtSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearchKey.Location = new System.Drawing.Point(585, 13);
			this.txtSearchKey.Name = "txtSearchKey";
			this.txtSearchKey.Size = new System.Drawing.Size(189, 21);
			this.txtSearchKey.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.pnlSearch);
			this.panel2.Controls.Add(this.customPageControl);
			this.panel2.Controls.Add(this.dgvRemovalOrderRecord);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(857, 584);
			this.panel2.TabIndex = 1;
			// 
			// customPageControl
			// 
			this.customPageControl.AutoScroll = true;
			this.customPageControl.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.customPageControl.Location = new System.Drawing.Point(0, 533);
			this.customPageControl.Name = "customPageControl";
			this.customPageControl.Size = new System.Drawing.Size(857, 51);
			this.customPageControl.TabIndex = 4;
			// 
			// dgvRemovalOrderRecord
			// 
			this.dgvRemovalOrderRecord.AllowUserToAddRows = false;
			this.dgvRemovalOrderRecord.AllowUserToDeleteRows = false;
			this.dgvRemovalOrderRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRemovalOrderRecord.BackgroundColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRemovalOrderRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvRemovalOrderRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRemovalOrderRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.IndexID,
            this.SpeedChangeBoxName,
            this.BoxCount,
            this.Count,
            this.Staff,
            this.DispathPlace,
            this.DateTime,
            this.ViewOrderDetail});
			this.dgvRemovalOrderRecord.Location = new System.Drawing.Point(0, 54);
			this.dgvRemovalOrderRecord.Name = "dgvRemovalOrderRecord";
			this.dgvRemovalOrderRecord.RowHeadersVisible = false;
			this.dgvRemovalOrderRecord.RowTemplate.Height = 23;
			this.dgvRemovalOrderRecord.Size = new System.Drawing.Size(857, 473);
			this.dgvRemovalOrderRecord.TabIndex = 0;
			this.dgvRemovalOrderRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemovalOrderRecord_CellContentClick);
			this.dgvRemovalOrderRecord.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPutinRecord_ColumnHeaderMouseClick);
			this.dgvRemovalOrderRecord.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRemovalOrderRecord_DataBindingComplete);
			// 
			// OrderID
			// 
			this.OrderID.DataPropertyName = "OrderID";
			this.OrderID.HeaderText = "OrderID";
			this.OrderID.Name = "OrderID";
			this.OrderID.Visible = false;
			// 
			// IndexID
			// 
			this.IndexID.HeaderText = "序号";
			this.IndexID.Name = "IndexID";
			this.IndexID.Width = 60;
			// 
			// SpeedChangeBoxName
			// 
			this.SpeedChangeBoxName.DataPropertyName = "SpeedChangeBoxName";
			this.SpeedChangeBoxName.HeaderText = "型号";
			this.SpeedChangeBoxName.Name = "SpeedChangeBoxName";
			this.SpeedChangeBoxName.Width = 150;
			// 
			// BoxCount
			// 
			this.BoxCount.DataPropertyName = "PlanCount";
			this.BoxCount.HeaderText = "计划数量";
			this.BoxCount.Name = "BoxCount";
			// 
			// Count
			// 
			this.Count.DataPropertyName = "Count";
			this.Count.HeaderText = "实际数量";
			this.Count.Name = "Count";
			// 
			// Staff
			// 
			this.Staff.DataPropertyName = "Staff";
			this.Staff.HeaderText = "出库人";
			this.Staff.Name = "Staff";
			// 
			// DispathPlace
			// 
			this.DispathPlace.DataPropertyName = "DispathPlace";
			this.DispathPlace.HeaderText = "发送地点";
			this.DispathPlace.Name = "DispathPlace";
			this.DispathPlace.Width = 300;
			// 
			// DateTime
			// 
			this.DateTime.DataPropertyName = "DispathTime";
			this.DateTime.HeaderText = "出库时间";
			this.DateTime.Name = "DateTime";
			// 
			// ViewOrderDetail
			// 
			this.ViewOrderDetail.HeaderText = "货单详情";
			this.ViewOrderDetail.Name = "ViewOrderDetail";
			this.ViewOrderDetail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ViewOrderDetail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ViewOrderDetail.Text = "查看";
			this.ViewOrderDetail.UseColumnTextForLinkValue = true;
			// 
			// RemovalWarehouseCheckUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "RemovalWarehouseCheckUserControl";
			this.Size = new System.Drawing.Size(857, 584);
			this.Load += new System.EventHandler(this.WarehouseCheckUserControl_Load);
			this.pnlSearch.ResumeLayout(false);
			this.pnlSearch.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRemovalOrderRecord)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private CustomPageControl customPageControl;
		private System.Windows.Forms.Panel pnlSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearchKey;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvRemovalOrderRecord;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn IndexID;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeedChangeBoxName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BoxCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
		private System.Windows.Forms.DataGridViewTextBoxColumn DispathPlace;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
		private System.Windows.Forms.DataGridViewLinkColumn ViewOrderDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker searchStartTime;
        private System.Windows.Forms.DateTimePicker searchEndTime;

	}
}
