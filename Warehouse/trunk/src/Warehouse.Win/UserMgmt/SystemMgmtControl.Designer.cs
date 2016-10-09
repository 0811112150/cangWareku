namespace Warehouse.Win
{
	partial class SystemMgmtControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemMgmtControl));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.pnlControlContainer = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsBtnUserMgmt = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsBtnDepartment = new System.Windows.Forms.ToolStripButton();
			this.tsBtnProductType = new System.Windows.Forms.ToolStripButton();
			this.tooStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.tooStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.White;
			this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.tooStrip1);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(107, 516);
			this.toolStripContainer1.Location = new System.Drawing.Point(0, 3);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(107, 516);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// pnlControlContainer
			// 
			this.pnlControlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlControlContainer.BackColor = System.Drawing.Color.Lavender;
			this.pnlControlContainer.Location = new System.Drawing.Point(123, 3);
			this.pnlControlContainer.Name = "pnlControlContainer";
			this.pnlControlContainer.Size = new System.Drawing.Size(711, 516);
			this.pnlControlContainer.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel1.Location = new System.Drawing.Point(107, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 519);
			this.panel1.TabIndex = 0;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(3);
			this.toolStripSeparator2.Size = new System.Drawing.Size(83, 6);
			// 
			// tsBtnUserMgmt
			// 
			this.tsBtnUserMgmt.AutoToolTip = false;
			this.tsBtnUserMgmt.CheckOnClick = true;
			this.tsBtnUserMgmt.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnUserMgmt.Image")));
			this.tsBtnUserMgmt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsBtnUserMgmt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnUserMgmt.Name = "tsBtnUserMgmt";
			this.tsBtnUserMgmt.Size = new System.Drawing.Size(83, 53);
			this.tsBtnUserMgmt.Text = "用户管理";
			this.tsBtnUserMgmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsBtnUserMgmt.Click += new System.EventHandler(this.tsBtnUserMgmt_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(3);
			this.toolStripSeparator1.Size = new System.Drawing.Size(83, 6);
			// 
			// tsBtnDepartment
			// 
			this.tsBtnDepartment.CheckOnClick = true;
			this.tsBtnDepartment.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnDepartment.Image")));
			this.tsBtnDepartment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsBtnDepartment.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnDepartment.Name = "tsBtnDepartment";
			this.tsBtnDepartment.Size = new System.Drawing.Size(83, 53);
			this.tsBtnDepartment.Text = "部门管理";
			this.tsBtnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsBtnDepartment.ToolTipText = "部门管理";
			this.tsBtnDepartment.Click += new System.EventHandler(this.tsBtnDepartment_Click);
			// 
			// tsBtnProductType
			// 
			this.tsBtnProductType.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnProductType.Image")));
			this.tsBtnProductType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsBtnProductType.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnProductType.Name = "tsBtnProductType";
			this.tsBtnProductType.Size = new System.Drawing.Size(83, 53);
			this.tsBtnProductType.Text = "产品型号";
			this.tsBtnProductType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsBtnProductType.Click += new System.EventHandler(this.tsBtnProductType_Click);
			// 
			// tooStrip1
			// 
			this.tooStrip1.AutoSize = false;
			this.tooStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.tooStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsBtnUserMgmt,
            this.toolStripSeparator1,
            this.tsBtnDepartment,
            this.toolStripSeparator3,
            this.tsBtnProductType});
			this.tooStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.tooStrip1.Location = new System.Drawing.Point(10, 10);
			this.tooStrip1.Name = "tooStrip1";
			this.tooStrip1.Size = new System.Drawing.Size(85, 316);
			this.tooStrip1.TabIndex = 0;
			this.tooStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Padding = new System.Windows.Forms.Padding(3);
			this.toolStripSeparator3.Size = new System.Drawing.Size(83, 6);
			// 
			// SystemMgmtControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlControlContainer);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "SystemMgmtControl";
			this.Size = new System.Drawing.Size(837, 522);
			this.Load += new System.EventHandler(this.UserfunctionUserControl_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.tooStrip1.ResumeLayout(false);
			this.tooStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.Panel pnlControlContainer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStrip tooStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsBtnUserMgmt;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsBtnDepartment;
		private System.Windows.Forms.ToolStripButton tsBtnProductType;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	}
}
