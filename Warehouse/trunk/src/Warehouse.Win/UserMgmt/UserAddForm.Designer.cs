namespace Warehouse.Win
{
	partial class UserAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddForm));
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxDepartment = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ckBoxIsPutinMan = new System.Windows.Forms.CheckBox();
			this.ckBoxIsRemovalMan = new System.Windows.Forms.CheckBox();
			this.ckBoxIsMonitor = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(110, 135);
			this.txtPassword.MaxLength = 20;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(195, 21);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(56, 138);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "密码:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "用户名:";
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(110, 374);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "确定";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(203, 374);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(110, 91);
			this.txtUserName.MaxLength = 20;
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(195, 21);
			this.txtUserName.TabIndex = 1;
			this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(110, 183);
			this.txtConfirmPassword.MaxLength = 20;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.PasswordChar = '*';
			this.txtConfirmPassword.Size = new System.Drawing.Size(195, 21);
			this.txtConfirmPassword.TabIndex = 3;
			this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 186);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "确认密码:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(44, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 12);
			this.label4.TabIndex = 5;
			this.label4.Text = "手机号:";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(110, 232);
			this.txtPhone.MaxLength = 11;
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(195, 21);
			this.txtPhone.TabIndex = 4;
			this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(56, 292);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 12);
			this.label5.TabIndex = 5;
			this.label5.Text = "住址:";
			// 
			// txtAddress
			// 
			this.txtAddress.CausesValidation = false;
			this.txtAddress.Location = new System.Drawing.Point(110, 289);
			this.txtAddress.MaxLength = 50;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(303, 21);
			this.txtAddress.TabIndex = 5;
			this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(56, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 12);
			this.label6.TabIndex = 5;
			this.label6.Text = "部门:";
			// 
			// cbxDepartment
			// 
			this.cbxDepartment.FormattingEnabled = true;
			this.cbxDepartment.Location = new System.Drawing.Point(110, 34);
			this.cbxDepartment.Name = "cbxDepartment";
			this.cbxDepartment.Size = new System.Drawing.Size(195, 20);
			this.cbxDepartment.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(56, 341);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 12);
			this.label7.TabIndex = 5;
			this.label7.Text = "权限:";
			// 
			// ckBoxIsPutinMan
			// 
			this.ckBoxIsPutinMan.AutoSize = true;
			this.ckBoxIsPutinMan.Location = new System.Drawing.Point(110, 341);
			this.ckBoxIsPutinMan.Name = "ckBoxIsPutinMan";
			this.ckBoxIsPutinMan.Size = new System.Drawing.Size(60, 16);
			this.ckBoxIsPutinMan.TabIndex = 10;
			this.ckBoxIsPutinMan.Text = "入库员";
			this.ckBoxIsPutinMan.UseVisualStyleBackColor = true;
			// 
			// ckBoxIsRemovalMan
			// 
			this.ckBoxIsRemovalMan.AutoSize = true;
			this.ckBoxIsRemovalMan.Location = new System.Drawing.Point(203, 341);
			this.ckBoxIsRemovalMan.Name = "ckBoxIsRemovalMan";
			this.ckBoxIsRemovalMan.Size = new System.Drawing.Size(60, 16);
			this.ckBoxIsRemovalMan.TabIndex = 10;
			this.ckBoxIsRemovalMan.Text = "出库员";
			this.ckBoxIsRemovalMan.UseVisualStyleBackColor = true;
			// 
			// ckBoxIsMonitor
			// 
			this.ckBoxIsMonitor.AutoSize = true;
			this.ckBoxIsMonitor.Location = new System.Drawing.Point(296, 341);
			this.ckBoxIsMonitor.Name = "ckBoxIsMonitor";
			this.ckBoxIsMonitor.Size = new System.Drawing.Size(48, 16);
			this.ckBoxIsMonitor.TabIndex = 10;
			this.ckBoxIsMonitor.Text = "班长";
			this.ckBoxIsMonitor.UseVisualStyleBackColor = true;
			// 
			// UserAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(467, 420);
			this.Controls.Add(this.ckBoxIsMonitor);
			this.Controls.Add(this.ckBoxIsRemovalMan);
			this.Controls.Add(this.ckBoxIsPutinMan);
			this.Controls.Add(this.cbxDepartment);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "UserAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "添加用户";
			this.Validating += new System.ComponentModel.CancelEventHandler(this.UserAddForm_Validating);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbxDepartment;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox ckBoxIsMonitor;
		private System.Windows.Forms.CheckBox ckBoxIsRemovalMan;
		private System.Windows.Forms.CheckBox ckBoxIsPutinMan;
	}
}