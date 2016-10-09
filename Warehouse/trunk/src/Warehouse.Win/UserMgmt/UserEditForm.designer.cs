namespace Warehouse.Win
{
	partial class UserEditForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
			this.btnConfirm = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbxDepartment = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ckBoxIsMonitor = new System.Windows.Forms.CheckBox();
			this.ckBoxIsRemovalMan = new System.Windows.Forms.CheckBox();
			this.ckBoxIsPutinMan = new System.Windows.Forms.CheckBox();
			this.lblPermisson = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnConfirm
			// 
			this.btnConfirm.Location = new System.Drawing.Point(120, 241);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(75, 23);
			this.btnConfirm.TabIndex = 4;
			this.btnConfirm.Text = "保存";
			this.btnConfirm.UseVisualStyleBackColor = true;
			this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "用户名:";
			// 
			// txtUserName
			// 
			this.txtUserName.Enabled = false;
			this.txtUserName.Location = new System.Drawing.Point(120, 73);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(254, 21);
			this.txtUserName.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(213, 241);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cbxDepartment
			// 
			this.cbxDepartment.Enabled = false;
			this.cbxDepartment.FormattingEnabled = true;
			this.cbxDepartment.Location = new System.Drawing.Point(120, 28);
			this.cbxDepartment.Name = "cbxDepartment";
			this.cbxDepartment.Size = new System.Drawing.Size(254, 20);
			this.cbxDepartment.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(66, 31);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "部门:";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(120, 166);
			this.txtAddress.MaxLength = 50;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(254, 21);
			this.txtAddress.TabIndex = 3;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(120, 123);
			this.txtPhone.MaxLength = 11;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(254, 21);
			this.txtPhone.TabIndex = 2;
			this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(66, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "住址:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(54, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 12);
			this.label7.TabIndex = 15;
			this.label7.Text = "手机号:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ckBoxIsMonitor
			// 
			this.ckBoxIsMonitor.AutoSize = true;
			this.ckBoxIsMonitor.Location = new System.Drawing.Point(306, 211);
			this.ckBoxIsMonitor.Name = "ckBoxIsMonitor";
			this.ckBoxIsMonitor.Size = new System.Drawing.Size(48, 16);
			this.ckBoxIsMonitor.TabIndex = 17;
			this.ckBoxIsMonitor.Text = "班长";
			this.ckBoxIsMonitor.UseVisualStyleBackColor = true;
			// 
			// ckBoxIsRemovalMan
			// 
			this.ckBoxIsRemovalMan.AutoSize = true;
			this.ckBoxIsRemovalMan.Location = new System.Drawing.Point(213, 211);
			this.ckBoxIsRemovalMan.Name = "ckBoxIsRemovalMan";
			this.ckBoxIsRemovalMan.Size = new System.Drawing.Size(60, 16);
			this.ckBoxIsRemovalMan.TabIndex = 19;
			this.ckBoxIsRemovalMan.Text = "出库员";
			this.ckBoxIsRemovalMan.UseVisualStyleBackColor = true;
			// 
			// ckBoxIsPutinMan
			// 
			this.ckBoxIsPutinMan.AutoSize = true;
			this.ckBoxIsPutinMan.Location = new System.Drawing.Point(120, 211);
			this.ckBoxIsPutinMan.Name = "ckBoxIsPutinMan";
			this.ckBoxIsPutinMan.Size = new System.Drawing.Size(60, 16);
			this.ckBoxIsPutinMan.TabIndex = 18;
			this.ckBoxIsPutinMan.Text = "入库员";
			this.ckBoxIsPutinMan.UseVisualStyleBackColor = true;
			// 
			// lblPermisson
			// 
			this.lblPermisson.AutoSize = true;
			this.lblPermisson.Location = new System.Drawing.Point(66, 211);
			this.lblPermisson.Name = "lblPermisson";
			this.lblPermisson.Size = new System.Drawing.Size(35, 12);
			this.lblPermisson.TabIndex = 16;
			this.lblPermisson.Text = "权限:";
			// 
			// UserEditForm
			// 
			this.AcceptButton = this.btnConfirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(448, 298);
			this.Controls.Add(this.ckBoxIsMonitor);
			this.Controls.Add(this.ckBoxIsRemovalMan);
			this.Controls.Add(this.ckBoxIsPutinMan);
			this.Controls.Add(this.lblPermisson);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxDepartment);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnConfirm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "修改用户";
			this.Load += new System.EventHandler(this.UserInfoForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfirm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbxDepartment;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.CheckBox ckBoxIsMonitor;
		private System.Windows.Forms.CheckBox ckBoxIsRemovalMan;
		private System.Windows.Forms.CheckBox ckBoxIsPutinMan;
		private System.Windows.Forms.Label lblPermisson;

	}
}