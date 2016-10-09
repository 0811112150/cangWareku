namespace Warehouse.Win
{
	partial class PutInWarehouseCheckUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPutinRecord = new System.Windows.Forms.DataGridView();
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
            this.RecordID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutInUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintTwoCode = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutinRecord)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPutinRecord
            // 
            this.dgvPutinRecord.AllowUserToAddRows = false;
            this.dgvPutinRecord.AllowUserToDeleteRows = false;
            this.dgvPutinRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPutinRecord.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPutinRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPutinRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPutinRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordID,
            this.IndexID,
            this.BarCode,
            this.PutInUserName,
            this.Place,
            this.PutInTime,
            this.PrintTwoCode});
            this.dgvPutinRecord.Location = new System.Drawing.Point(0, 46);
            this.dgvPutinRecord.Name = "dgvPutinRecord";
            this.dgvPutinRecord.RowHeadersVisible = false;
            this.dgvPutinRecord.RowTemplate.Height = 23;
            this.dgvPutinRecord.Size = new System.Drawing.Size(823, 474);
            this.dgvPutinRecord.TabIndex = 0;
            this.dgvPutinRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPutinRecord_CellContentClick);
            this.dgvPutinRecord.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPutinRecord_ColumnHeaderMouseClick);
            this.dgvPutinRecord.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPutinRecord_DataBindingComplete);
            // 
            // pnlSearch
            // 
            this.pnlSearch.AutoScroll = true;
            this.pnlSearch.BackColor = System.Drawing.Color.Lavender;
            this.pnlSearch.Controls.Add(this.searchEndTime);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.searchStartTime);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.label1);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearchKey);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(823, 40);
            this.pnlSearch.TabIndex = 5;
            // 
            // searchEndTime
            // 
            this.searchEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchEndTime.Location = new System.Drawing.Point(240, 11);
            this.searchEndTime.Name = "searchEndTime";
            this.searchEndTime.Size = new System.Drawing.Size(124, 21);
            this.searchEndTime.TabIndex = 13;
            this.searchEndTime.CloseUp += new System.EventHandler(this.searchEndTime_CloseUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "至";
            // 
            // searchStartTime
            // 
            this.searchStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchStartTime.Location = new System.Drawing.Point(82, 11);
            this.searchStartTime.Name = "searchStartTime";
            this.searchStartTime.Size = new System.Drawing.Size(126, 21);
            this.searchStartTime.TabIndex = 11;
            this.searchStartTime.CloseUp += new System.EventHandler(this.searchStartTime_CloseUp);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "起始时间:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入条形码、入库人、地点";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(755, 7);
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
            this.txtSearchKey.Location = new System.Drawing.Point(551, 10);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(189, 21);
            this.txtSearchKey.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pnlSearch);
            this.panel2.Controls.Add(this.customPageControl);
            this.panel2.Controls.Add(this.dgvPutinRecord);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 584);
            this.panel2.TabIndex = 1;
            // 
            // customPageControl
            // 
            this.customPageControl.AutoScroll = true;
            this.customPageControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customPageControl.Location = new System.Drawing.Point(0, 526);
            this.customPageControl.Name = "customPageControl";
            this.customPageControl.Size = new System.Drawing.Size(823, 58);
            this.customPageControl.TabIndex = 4;
            this.customPageControl.Load += new System.EventHandler(this.customPageControl_Load);
            // 
            // RecordID
            // 
            this.RecordID.DataPropertyName = "WarehouseID";
            this.RecordID.HeaderText = "RecordID";
            this.RecordID.Name = "RecordID";
            this.RecordID.Visible = false;
            // 
            // IndexID
            // 
            this.IndexID.HeaderText = "序号";
            this.IndexID.Name = "IndexID";
            this.IndexID.Width = 70;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "条形码";
            this.BarCode.Name = "BarCode";
            this.BarCode.Width = 170;
            // 
            // PutInUserName
            // 
            this.PutInUserName.DataPropertyName = "PutInUserName";
            this.PutInUserName.HeaderText = "入库人";
            this.PutInUserName.Name = "PutInUserName";
            this.PutInUserName.Width = 120;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "入库地点";
            this.Place.Name = "Place";
            this.Place.Width = 200;
            // 
            // PutInTime
            // 
            this.PutInTime.DataPropertyName = "PutInTime";
            this.PutInTime.HeaderText = "入库时间";
            this.PutInTime.Name = "PutInTime";
            this.PutInTime.Width = 120;
            // 
            // PrintTwoCode
            // 
            this.PrintTwoCode.HeaderText = "打印二维码";
            this.PrintTwoCode.Name = "PrintTwoCode";
            this.PrintTwoCode.Text = "打印";
            this.PrintTwoCode.UseColumnTextForLinkValue = true;
            // 
            // PutInWarehouseCheckUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "PutInWarehouseCheckUserControl";
            this.Size = new System.Drawing.Size(823, 584);
            this.Load += new System.EventHandler(this.WarehouseCheckUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutinRecord)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPutinRecord;
		private CustomPageControl customPageControl;
		private System.Windows.Forms.Panel pnlSearch;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearchKey;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker searchEndTime;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker searchStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutInUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn PutInTime;
        private System.Windows.Forms.DataGridViewLinkColumn PrintTwoCode;

	}
}
