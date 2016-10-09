namespace Warehouse.Win
{
	partial class UserMgmtUserControl
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
			this.dgvUserList = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsPutinMan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IsRemovalMan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ReSetPassword = new System.Windows.Forms.DataGridViewLinkColumn();
			this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
			this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvUserList
			// 
			this.dgvUserList.AllowUserToAddRows = false;
			this.dgvUserList.AllowUserToDeleteRows = false;
			this.dgvUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvUserList.BackgroundColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.DepartmentName,
            this.Phone,
            this.Adress,
            this.IsPutinMan,
            this.IsRemovalMan,
            this.ReSetPassword,
            this.Edit,
            this.Delete});
			this.dgvUserList.Location = new System.Drawing.Point(0, 3);
			this.dgvUserList.Name = "dgvUserList";
			this.dgvUserList.RowHeadersVisible = false;
			this.dgvUserList.RowTemplate.Height = 23;
			this.dgvUserList.Size = new System.Drawing.Size(805, 446);
			this.dgvUserList.TabIndex = 0;
			this.dgvUserList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellContentClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(-1, 461);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "添加用户";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.Visible = false;
			// 
			// UserName
			// 
			this.UserName.DataPropertyName = "UserName";
			this.UserName.HeaderText = "姓名";
			this.UserName.Name = "UserName";
			// 
			// DepartmentName
			// 
			this.DepartmentName.DataPropertyName = "DepartmentName";
			this.DepartmentName.HeaderText = "部门";
			this.DepartmentName.Name = "DepartmentName";
			// 
			// Phone
			// 
			this.Phone.DataPropertyName = "Phone";
			this.Phone.HeaderText = "手机";
			this.Phone.Name = "Phone";
			// 
			// Adress
			// 
			this.Adress.DataPropertyName = "Adress";
			this.Adress.HeaderText = "地址";
			this.Adress.Name = "Adress";
			// 
			// IsPutinMan
			// 
			this.IsPutinMan.DataPropertyName = "IsPutinMan";
			this.IsPutinMan.HeaderText = "入库员";
			this.IsPutinMan.Name = "IsPutinMan";
			this.IsPutinMan.ReadOnly = true;
			// 
			// IsRemovalMan
			// 
			this.IsRemovalMan.DataPropertyName = "IsRemovalMan";
			this.IsRemovalMan.HeaderText = "出库员";
			this.IsRemovalMan.Name = "IsRemovalMan";
			this.IsRemovalMan.ReadOnly = true;
			// 
			// ReSetPassword
			// 
			this.ReSetPassword.HeaderText = "重置密码";
			this.ReSetPassword.Name = "ReSetPassword";
			this.ReSetPassword.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ReSetPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.ReSetPassword.Text = "重置密码";
			this.ReSetPassword.UseColumnTextForLinkValue = true;
			// 
			// Edit
			// 
			this.Edit.HeaderText = "修改";
			this.Edit.Name = "Edit";
			this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
			// UserMgmtUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvUserList);
			this.Name = "UserMgmtUserControl";
			this.Size = new System.Drawing.Size(808, 494);
			((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvUserList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsPutinMan;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsRemovalMan;
		private System.Windows.Forms.DataGridViewLinkColumn ReSetPassword;
		private System.Windows.Forms.DataGridViewLinkColumn Edit;
		private System.Windows.Forms.DataGridViewLinkColumn Delete;
	}
}
