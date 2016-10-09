namespace Warehouse.Win
{
	partial class WarehouseMgmt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseMgmt));
			this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
			this.t = new System.Windows.Forms.ToolStrip();
			this.tsBtnPutInCheck = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsBtnWarehouseCheck = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsBtnRemovalCheck = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnShowAlarmTable = new System.Windows.Forms.ToolStripButton();
			this.pnlCheckControlContainer = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.toolStripContainer1.ContentPanel.SuspendLayout();
			this.toolStripContainer1.SuspendLayout();
			this.t.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer1
			// 
			this.toolStripContainer1.BottomToolStripPanelVisible = false;
			// 
			// toolStripContainer1.ContentPanel
			// 
			this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.White;
			this.toolStripContainer1.ContentPanel.Controls.Add(this.t);
			this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(107, 567);
			this.toolStripContainer1.Location = new System.Drawing.Point(3, 7);
			this.toolStripContainer1.Name = "toolStripContainer1";
			this.toolStripContainer1.RightToolStripPanelVisible = false;
			this.toolStripContainer1.Size = new System.Drawing.Size(107, 567);
			this.toolStripContainer1.TabIndex = 0;
			this.toolStripContainer1.Text = "toolStripContainer1";
			this.toolStripContainer1.TopToolStripPanelVisible = false;
			// 
			// t
			// 
			this.t.AutoSize = false;
			this.t.BackColor = System.Drawing.Color.White;
			this.t.Dock = System.Windows.Forms.DockStyle.Left;
			this.t.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnPutInCheck,
            this.toolStripSeparator1,
            this.tsBtnWarehouseCheck,
            this.toolStripSeparator2,
            this.tsBtnRemovalCheck,
            this.toolStripSeparator3,
            this.btnShowAlarmTable});
			this.t.Location = new System.Drawing.Point(0, 0);
			this.t.Name = "t";
			this.t.Size = new System.Drawing.Size(107, 567);
			this.t.TabIndex = 0;
			this.t.Text = "报警记录查询";
			// 
			// tsBtnPutInCheck
			// 
			this.tsBtnPutInCheck.CheckOnClick = true;
			this.tsBtnPutInCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnPutInCheck.Image")));
			this.tsBtnPutInCheck.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.tsBtnPutInCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsBtnPutInCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnPutInCheck.Name = "tsBtnPutInCheck";
			this.tsBtnPutInCheck.Size = new System.Drawing.Size(105, 53);
			this.tsBtnPutInCheck.Text = "入库记录查询";
			this.tsBtnPutInCheck.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			this.tsBtnPutInCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsBtnPutInCheck.Click += new System.EventHandler(this.tsBtnPutInCheck_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(105, 6);
			// 
			// tsBtnWarehouseCheck
			// 
			this.tsBtnWarehouseCheck.CheckOnClick = true;
			this.tsBtnWarehouseCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnWarehouseCheck.Image")));
			this.tsBtnWarehouseCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsBtnWarehouseCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnWarehouseCheck.Name = "tsBtnWarehouseCheck";
			this.tsBtnWarehouseCheck.Size = new System.Drawing.Size(105, 53);
			this.tsBtnWarehouseCheck.Text = "库存查询";
			this.tsBtnWarehouseCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsBtnWarehouseCheck.Click += new System.EventHandler(this.tsBtnWarehouseCheck_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.toolStripSeparator2.Size = new System.Drawing.Size(105, 6);
			// 
			// tsBtnRemovalCheck
			// 
			this.tsBtnRemovalCheck.CheckOnClick = true;
			this.tsBtnRemovalCheck.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRemovalCheck.Image")));
			this.tsBtnRemovalCheck.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.tsBtnRemovalCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsBtnRemovalCheck.Name = "tsBtnRemovalCheck";
			this.tsBtnRemovalCheck.Size = new System.Drawing.Size(105, 53);
			this.tsBtnRemovalCheck.Text = "出库记录单查询";
			this.tsBtnRemovalCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsBtnRemovalCheck.Click += new System.EventHandler(this.tsBtnRemovalCheck_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.toolStripSeparator3.Size = new System.Drawing.Size(105, 6);
			// 
			// btnShowAlarmTable
			// 
			this.btnShowAlarmTable.CheckOnClick = true;
			this.btnShowAlarmTable.Image = ((System.Drawing.Image)(resources.GetObject("btnShowAlarmTable.Image")));
			this.btnShowAlarmTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnShowAlarmTable.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnShowAlarmTable.Name = "btnShowAlarmTable";
			this.btnShowAlarmTable.Size = new System.Drawing.Size(105, 53);
			this.btnShowAlarmTable.Text = "报警记录查询";
			this.btnShowAlarmTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnShowAlarmTable.Click += new System.EventHandler(this.btnShowAlarmTable_Click);
			// 
			// pnlCheckControlContainer
			// 
			this.pnlCheckControlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCheckControlContainer.AutoScroll = true;
			this.pnlCheckControlContainer.AutoSize = true;
			this.pnlCheckControlContainer.Location = new System.Drawing.Point(125, 4);
			this.pnlCheckControlContainer.Name = "pnlCheckControlContainer";
			this.pnlCheckControlContainer.Size = new System.Drawing.Size(930, 639);
			this.pnlCheckControlContainer.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel1.Location = new System.Drawing.Point(113, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 571);
			this.panel1.TabIndex = 2;
			// 
			// WarehouseMgmt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlCheckControlContainer);
			this.Controls.Add(this.toolStripContainer1);
			this.Name = "WarehouseMgmt";
			this.Size = new System.Drawing.Size(1059, 646);
			this.Load += new System.EventHandler(this.WarehouseMgmt_Load);
			this.toolStripContainer1.ContentPanel.ResumeLayout(false);
			this.toolStripContainer1.ResumeLayout(false);
			this.toolStripContainer1.PerformLayout();
			this.t.ResumeLayout(false);
			this.t.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripContainer toolStripContainer1;
		private System.Windows.Forms.ToolStrip t;
		private System.Windows.Forms.ToolStripButton tsBtnPutInCheck;
		private System.Windows.Forms.ToolStripButton tsBtnWarehouseCheck;
		private System.Windows.Forms.ToolStripButton tsBtnRemovalCheck;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.Panel pnlCheckControlContainer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnShowAlarmTable;

	}
}
