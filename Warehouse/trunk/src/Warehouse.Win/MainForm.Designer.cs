namespace Warehouse.Win
{
	partial class MainForm
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

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            System.Windows.Forms.Button btnChangeUser;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Button btnLoginOut;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSbtnPutIn = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemoval = new System.Windows.Forms.ToolStripButton();
            this.tsBtnWarehouseCheck = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUserMgmt = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPersonalInfo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmIViewPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIEditPersonInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblCompanyInfo = new System.Windows.Forms.Label();
            btnChangeUser = new System.Windows.Forms.Button();
            btnLoginOut = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeUser
            // 
            resources.ApplyResources(btnChangeUser, "btnChangeUser");
            btnChangeUser.Name = "btnChangeUser";
            btnChangeUser.UseVisualStyleBackColor = true;
            btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnLoginOut
            // 
            resources.ApplyResources(btnLoginOut, "btnLoginOut");
            btnLoginOut.Name = "btnLoginOut";
            btnLoginOut.UseVisualStyleBackColor = true;
            btnLoginOut.Click += new System.EventHandler(this.btnLoginOut_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSbtnPutIn,
            this.tsBtnRemoval,
            this.tsBtnWarehouseCheck,
            this.tsBtnUserMgmt,
            this.tsBtnPersonalInfo,
            this.toolStripButton2});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tSbtnPutIn
            // 
            this.tSbtnPutIn.CheckOnClick = true;
            resources.ApplyResources(this.tSbtnPutIn, "tSbtnPutIn");
            this.tSbtnPutIn.Name = "tSbtnPutIn";
            this.tSbtnPutIn.Click += new System.EventHandler(this.tSbtnPutIn_Click);
            // 
            // tsBtnRemoval
            // 
            this.tsBtnRemoval.CheckOnClick = true;
            resources.ApplyResources(this.tsBtnRemoval, "tsBtnRemoval");
            this.tsBtnRemoval.Name = "tsBtnRemoval";
            this.tsBtnRemoval.Click += new System.EventHandler(this.tsBtnRemoval_Click);
            // 
            // tsBtnWarehouseCheck
            // 
            this.tsBtnWarehouseCheck.CheckOnClick = true;
            resources.ApplyResources(this.tsBtnWarehouseCheck, "tsBtnWarehouseCheck");
            this.tsBtnWarehouseCheck.Name = "tsBtnWarehouseCheck";
            this.tsBtnWarehouseCheck.Click += new System.EventHandler(this.tsBtnWarehouseCheck_Click);
            // 
            // tsBtnUserMgmt
            // 
            this.tsBtnUserMgmt.CheckOnClick = true;
            resources.ApplyResources(this.tsBtnUserMgmt, "tsBtnUserMgmt");
            this.tsBtnUserMgmt.Name = "tsBtnUserMgmt";
            this.tsBtnUserMgmt.Click += new System.EventHandler(this.txtUserMgmt_Click);
            // 
            // tsBtnPersonalInfo
            // 
            this.tsBtnPersonalInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIViewPersonInfo,
            this.tsmIEditPersonInfo,
            this.tsmIChangePassword});
            resources.ApplyResources(this.tsBtnPersonalInfo, "tsBtnPersonalInfo");
            this.tsBtnPersonalInfo.Name = "tsBtnPersonalInfo";
            this.tsBtnPersonalInfo.Click += new System.EventHandler(this.tsBtnPersonalInfo_Click);
            // 
            // tsmIViewPersonInfo
            // 
            this.tsmIViewPersonInfo.Name = "tsmIViewPersonInfo";
            resources.ApplyResources(this.tsmIViewPersonInfo, "tsmIViewPersonInfo");
            this.tsmIViewPersonInfo.Click += new System.EventHandler(this.tsmIViewPersonInfo_Click);
            // 
            // tsmIEditPersonInfo
            // 
            this.tsmIEditPersonInfo.Name = "tsmIEditPersonInfo";
            resources.ApplyResources(this.tsmIEditPersonInfo, "tsmIEditPersonInfo");
            this.tsmIEditPersonInfo.Click += new System.EventHandler(this.tsmIEditPersonInfo_Click);
            // 
            // tsmIChangePassword
            // 
            this.tsmIChangePassword.Name = "tsmIChangePassword";
            resources.ApplyResources(this.tsmIChangePassword, "tsmIChangePassword");
            this.tsmIChangePassword.Click += new System.EventHandler(this.tsmIChangePassword_Click);
            // 
            // toolStripButton2
            // 
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // pnlMain
            // 
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Name = "pnlMain";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(129)))), ((int)(((byte)(186)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(btnChangeUser);
            this.panel1.Controls.Add(btnLoginOut);
            this.panel1.Controls.Add(this.lblCurrentUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // lblCurrentUser
            // 
            resources.ApplyResources(this.lblCurrentUser, "lblCurrentUser");
            this.lblCurrentUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentUser.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUser.Name = "lblCurrentUser";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // lblCompanyInfo
            // 
            resources.ApplyResources(this.lblCompanyInfo, "lblCompanyInfo");
            this.lblCompanyInfo.Name = "lblCompanyInfo";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.Controls.Add(this.lblCompanyInfo);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCurrentUser;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton tSbtnPutIn;
		private System.Windows.Forms.ToolStripButton tsBtnRemoval;
		private System.Windows.Forms.ToolStripButton tsBtnWarehouseCheck;
		private System.Windows.Forms.ToolStripButton tsBtnUserMgmt;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.ToolStripDropDownButton tsBtnPersonalInfo;
		private System.Windows.Forms.ToolStripMenuItem tsmIViewPersonInfo;
		private System.Windows.Forms.ToolStripMenuItem tsmIEditPersonInfo;
		private System.Windows.Forms.ToolStripMenuItem tsmIChangePassword;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.Label lblCompanyInfo;


	}
}

