namespace Warehouse.Win.WarehouseCheck
{
	partial class AlarmListUserControl
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
			this.dgvAlarmList = new System.Windows.Forms.DataGridView();
			this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IndexID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlarmContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlarmTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customPageControl = new Warehouse.Win.CustomPageControl();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAlarmList
			// 
			this.dgvAlarmList.AllowUserToAddRows = false;
			this.dgvAlarmList.AllowUserToDeleteRows = false;
			this.dgvAlarmList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvAlarmList.BackgroundColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAlarmList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAlarmList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlarmList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.IndexID,
            this.AlarmContent,
            this.Operator,
            this.AlarmTime,
            this.AlarmTypeName});
			this.dgvAlarmList.Location = new System.Drawing.Point(3, 3);
			this.dgvAlarmList.Name = "dgvAlarmList";
			this.dgvAlarmList.RowHeadersVisible = false;
			this.dgvAlarmList.RowTemplate.Height = 23;
			this.dgvAlarmList.Size = new System.Drawing.Size(951, 427);
			this.dgvAlarmList.TabIndex = 7;
			this.dgvAlarmList.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlarmList_ColumnHeaderMouseClick);
			this.dgvAlarmList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAlarmList_DataBindingComplete);
			// 
			// OrderID
			// 
			this.OrderID.DataPropertyName = "ID";
			this.OrderID.HeaderText = "ID";
			this.OrderID.Name = "OrderID";
			this.OrderID.Visible = false;
			// 
			// IndexID
			// 
			this.IndexID.HeaderText = "序号";
			this.IndexID.Name = "IndexID";
			// 
			// AlarmContent
			// 
			this.AlarmContent.DataPropertyName = "AlarmContent";
			this.AlarmContent.HeaderText = "报警原因";
			this.AlarmContent.Name = "AlarmContent";
			this.AlarmContent.Width = 300;
			// 
			// Operator
			// 
			this.Operator.DataPropertyName = "Operator";
			this.Operator.HeaderText = "操作员";
			this.Operator.Name = "Operator";
			// 
			// AlarmTime
			// 
			this.AlarmTime.DataPropertyName = "AlarmTime";
			this.AlarmTime.HeaderText = "报警时间";
			this.AlarmTime.Name = "AlarmTime";
			this.AlarmTime.Width = 120;
			// 
			// AlarmTypeName
			// 
			this.AlarmTypeName.DataPropertyName = "AlarmTypeName";
			this.AlarmTypeName.HeaderText = "报警类型";
			this.AlarmTypeName.Name = "AlarmTypeName";
			// 
			// customPageControl
			// 
			this.customPageControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.customPageControl.AutoScroll = true;
			this.customPageControl.Location = new System.Drawing.Point(0, 431);
			this.customPageControl.Name = "customPageControl";
			this.customPageControl.Size = new System.Drawing.Size(951, 55);
			this.customPageControl.TabIndex = 8;
			// 
			// AlarmListUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.Controls.Add(this.customPageControl);
			this.Controls.Add(this.dgvAlarmList);
			this.Name = "AlarmListUserControl";
			this.Size = new System.Drawing.Size(957, 489);
			this.Load += new System.EventHandler(this.AlarmListUserControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAlarmList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAlarmList;
		private CustomPageControl customPageControl;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn IndexID;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlarmContent;
		private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlarmTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlarmTypeName;
	}
}
