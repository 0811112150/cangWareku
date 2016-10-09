namespace Warehouse.Win
{
	partial class OrderDetailForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailForm));
			this.dgvRemovalOrderDetailRecord = new System.Windows.Forms.DataGridView();
			this.IndexID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SpeedChangeBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DispathPlace = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvRemovalOrderDetailRecord)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRemovalOrderDetailRecord
			// 
			this.dgvRemovalOrderDetailRecord.AllowUserToAddRows = false;
			this.dgvRemovalOrderDetailRecord.AllowUserToDeleteRows = false;
			this.dgvRemovalOrderDetailRecord.BackgroundColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRemovalOrderDetailRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvRemovalOrderDetailRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRemovalOrderDetailRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexID,
            this.BarCode,
            this.SpeedChangeBoxName,
            this.Staff,
            this.DispathPlace,
            this.DateTime});
			this.dgvRemovalOrderDetailRecord.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRemovalOrderDetailRecord.Location = new System.Drawing.Point(0, 0);
			this.dgvRemovalOrderDetailRecord.Name = "dgvRemovalOrderDetailRecord";
			this.dgvRemovalOrderDetailRecord.RowHeadersVisible = false;
			this.dgvRemovalOrderDetailRecord.RowTemplate.Height = 23;
			this.dgvRemovalOrderDetailRecord.Size = new System.Drawing.Size(754, 565);
			this.dgvRemovalOrderDetailRecord.TabIndex = 1;
			this.dgvRemovalOrderDetailRecord.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRemovalOrderDetailRecord_DataBindingComplete);
			// 
			// IndexID
			// 
			this.IndexID.HeaderText = "序号";
			this.IndexID.Name = "IndexID";
			// 
			// BarCode
			// 
			this.BarCode.DataPropertyName = "BarCode";
			this.BarCode.HeaderText = "条形码";
			this.BarCode.Name = "BarCode";
			// 
			// SpeedChangeBoxName
			// 
			this.SpeedChangeBoxName.DataPropertyName = "SpeedChangeBoxName";
			this.SpeedChangeBoxName.HeaderText = "型号";
			this.SpeedChangeBoxName.Name = "SpeedChangeBoxName";
			this.SpeedChangeBoxName.Width = 150;
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
			this.DateTime.DataPropertyName = "RemovalWarehouseTime";
			this.DateTime.HeaderText = "出库时间";
			this.DateTime.Name = "DateTime";
			// 
			// OrderDetailForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 565);
			this.Controls.Add(this.dgvRemovalOrderDetailRecord);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OrderDetailForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "查看货单详情";
			this.Load += new System.EventHandler(this.OrderDetailForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRemovalOrderDetailRecord)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRemovalOrderDetailRecord;
		private System.Windows.Forms.DataGridViewTextBoxColumn IndexID;
		private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeedChangeBoxName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
		private System.Windows.Forms.DataGridViewTextBoxColumn DispathPlace;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;

	}
}