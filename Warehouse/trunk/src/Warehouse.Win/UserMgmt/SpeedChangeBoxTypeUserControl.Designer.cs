namespace Warehouse.Win
{
	partial class SpeedChangeBoxTypeUserControl
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvSpeedChangeBox = new System.Windows.Forms.DataGridView();
			this.SpeedChangeBoxTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SpeedChangeBoxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvSpeedChangeBox)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(4, 367);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "添加型号";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvSpeedChangeBox
			// 
			this.dgvSpeedChangeBox.AllowUserToAddRows = false;
			this.dgvSpeedChangeBox.AllowUserToDeleteRows = false;
			this.dgvSpeedChangeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSpeedChangeBox.BackgroundColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSpeedChangeBox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSpeedChangeBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSpeedChangeBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpeedChangeBoxTypeID,
            this.OrderIndex,
            this.SpeedChangeBoxName,
            this.Delete});
			this.dgvSpeedChangeBox.Location = new System.Drawing.Point(3, 7);
			this.dgvSpeedChangeBox.Name = "dgvSpeedChangeBox";
			this.dgvSpeedChangeBox.RowHeadersVisible = false;
			this.dgvSpeedChangeBox.RowTemplate.Height = 23;
			this.dgvSpeedChangeBox.Size = new System.Drawing.Size(603, 346);
			this.dgvSpeedChangeBox.TabIndex = 2;
			this.dgvSpeedChangeBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSpeedChangeBox_CellContentClick);
			// 
			// SpeedChangeBoxTypeID
			// 
			this.SpeedChangeBoxTypeID.DataPropertyName = "SpeedChangeBoxTypeID";
			this.SpeedChangeBoxTypeID.HeaderText = "SpeedChangeBoxTypeID";
			this.SpeedChangeBoxTypeID.Name = "SpeedChangeBoxTypeID";
			this.SpeedChangeBoxTypeID.Visible = false;
			// 
			// OrderIndex
			// 
			this.OrderIndex.HeaderText = "编号";
			this.OrderIndex.Name = "OrderIndex";
			// 
			// SpeedChangeBoxName
			// 
			this.SpeedChangeBoxName.DataPropertyName = "SpeedChangeBoxName";
			this.SpeedChangeBoxName.HeaderText = "型号";
			this.SpeedChangeBoxName.Name = "SpeedChangeBoxName";
			// 
			// Delete
			// 
			this.Delete.HeaderText = "删除";
			this.Delete.Name = "Delete";
			this.Delete.Text = "删除";
			this.Delete.UseColumnTextForLinkValue = true;
			// 
			// SpeedChangeBoxTypeUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvSpeedChangeBox);
			this.Name = "SpeedChangeBoxTypeUserControl";
			this.Size = new System.Drawing.Size(609, 396);
			((System.ComponentModel.ISupportInitialize)(this.dgvSpeedChangeBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dgvSpeedChangeBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeedChangeBoxTypeID;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderIndex;
		private System.Windows.Forms.DataGridViewTextBoxColumn SpeedChangeBoxName;
		private System.Windows.Forms.DataGridViewLinkColumn Delete;

	}
}
