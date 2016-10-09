namespace Warehouse.Win
{
	partial class DepartmentMgmtUserControl
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
			this.dgvDepartment = new System.Windows.Forms.DataGridView();
			this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDepartment
			// 
			this.dgvDepartment.AllowUserToAddRows = false;
			this.dgvDepartment.AllowUserToDeleteRows = false;
			this.dgvDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDepartment.BackgroundColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentID,
            this.OrderIndex,
            this.DepartmentName,
            this.Edit,
            this.Delete});
			this.dgvDepartment.Location = new System.Drawing.Point(3, 3);
			this.dgvDepartment.Name = "dgvDepartment";
			this.dgvDepartment.RowHeadersVisible = false;
			this.dgvDepartment.RowTemplate.Height = 23;
			this.dgvDepartment.Size = new System.Drawing.Size(603, 346);
			this.dgvDepartment.TabIndex = 0;
			this.dgvDepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// DepartmentID
			// 
			this.DepartmentID.DataPropertyName = "DepartmentID";
			this.DepartmentID.HeaderText = "DepartmentID";
			this.DepartmentID.Name = "DepartmentID";
			this.DepartmentID.Visible = false;
			// 
			// OrderIndex
			// 
			this.OrderIndex.HeaderText = "编号";
			this.OrderIndex.Name = "OrderIndex";
			// 
			// DepartmentName
			// 
			this.DepartmentName.DataPropertyName = "DepartmentName";
			this.DepartmentName.HeaderText = "名称";
			this.DepartmentName.Name = "DepartmentName";
			// 
			// Edit
			// 
			this.Edit.HeaderText = "修改";
			this.Edit.Name = "Edit";
			this.Edit.Text = "修改";
			this.Edit.UseColumnTextForLinkValue = true;
			// 
			// Delete
			// 
			this.Delete.HeaderText = "删除";
			this.Delete.Name = "Delete";
			this.Delete.Text = "删除";
			this.Delete.UseColumnTextForLinkValue = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(4, 363);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "添加部门";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// DepartmentMgmtUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvDepartment);
			this.Name = "DepartmentMgmtUserControl";
			this.Size = new System.Drawing.Size(609, 396);
			((System.ComponentModel.ISupportInitialize)(this.dgvDepartment)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDepartment;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderIndex;
		private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
		private System.Windows.Forms.DataGridViewLinkColumn Edit;
		private System.Windows.Forms.DataGridViewLinkColumn Delete;
	}
}
