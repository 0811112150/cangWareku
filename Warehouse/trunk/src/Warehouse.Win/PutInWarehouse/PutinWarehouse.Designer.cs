namespace Warehouse.Win
{
	partial class PutinWarehouse
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountLimit = new System.Windows.Forms.TextBox();
            this.gbxPutinSet = new System.Windows.Forms.GroupBox();
            this.btnPutinSet = new System.Windows.Forms.Button();
            this.txtPrintCount = new System.Windows.Forms.TextBox();
            this.txtPutinUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPutinAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxPutinInfo = new System.Windows.Forms.GroupBox();
            this.btnMannualPrint = new System.Windows.Forms.Button();
            this.dgvBarCodeList = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrintCountStatistic = new System.Windows.Forms.Label();
            this.lblAlreadyPrintCount = new System.Windows.Forms.Label();
            this.lblCountStatistic = new System.Windows.Forms.Label();
            this.btnStopPutin = new System.Windows.Forms.Button();
            this.btnStartPutin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxPutinSet.SuspendLayout();
            this.gbxPutinInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "条形码：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(144, 60);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.ReadOnly = true;
            this.txtBarCode.Size = new System.Drawing.Size(215, 21);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "产品类型：";
            // 
            // cbxProductType
            // 
            this.cbxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(145, 24);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(215, 20);
            this.cbxProductType.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "入库总数量：";
            // 
            // txtCountLimit
            // 
            this.txtCountLimit.Location = new System.Drawing.Point(145, 62);
            this.txtCountLimit.Name = "txtCountLimit";
            this.txtCountLimit.Size = new System.Drawing.Size(215, 21);
            this.txtCountLimit.TabIndex = 1;
            this.txtCountLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrintCount_Validating);
            // 
            // gbxPutinSet
            // 
            this.gbxPutinSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxPutinSet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxPutinSet.Controls.Add(this.btnPutinSet);
            this.gbxPutinSet.Controls.Add(this.label2);
            this.gbxPutinSet.Controls.Add(this.txtPrintCount);
            this.gbxPutinSet.Controls.Add(this.txtPutinUserName);
            this.gbxPutinSet.Controls.Add(this.label6);
            this.gbxPutinSet.Controls.Add(this.txtPutinAddress);
            this.gbxPutinSet.Controls.Add(this.label5);
            this.gbxPutinSet.Controls.Add(this.txtCountLimit);
            this.gbxPutinSet.Controls.Add(this.label4);
            this.gbxPutinSet.Controls.Add(this.cbxProductType);
            this.gbxPutinSet.Controls.Add(this.label3);
            this.gbxPutinSet.Location = new System.Drawing.Point(236, 15);
            this.gbxPutinSet.Name = "gbxPutinSet";
            this.gbxPutinSet.Size = new System.Drawing.Size(474, 209);
            this.gbxPutinSet.TabIndex = 0;
            this.gbxPutinSet.TabStop = false;
            this.gbxPutinSet.Text = "入库设置";
            // 
            // btnPutinSet
            // 
            this.btnPutinSet.Location = new System.Drawing.Point(384, 23);
            this.btnPutinSet.Name = "btnPutinSet";
            this.btnPutinSet.Size = new System.Drawing.Size(75, 23);
            this.btnPutinSet.TabIndex = 5;
            this.btnPutinSet.Text = "修改";
            this.btnPutinSet.UseVisualStyleBackColor = true;
            this.btnPutinSet.Click += new System.EventHandler(this.btnPutinSet_Click);
            // 
            // txtPrintCount
            // 
            this.txtPrintCount.Location = new System.Drawing.Point(145, 100);
            this.txtPrintCount.Name = "txtPrintCount";
            this.txtPrintCount.Size = new System.Drawing.Size(215, 21);
            this.txtPrintCount.TabIndex = 2;
            this.txtPrintCount.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrintCount_Validating);
            // 
            // txtPutinUserName
            // 
            this.txtPutinUserName.Enabled = false;
            this.txtPutinUserName.Location = new System.Drawing.Point(145, 174);
            this.txtPutinUserName.Name = "txtPutinUserName";
            this.txtPutinUserName.Size = new System.Drawing.Size(215, 21);
            this.txtPutinUserName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "二维码打印频数：";
            // 
            // txtPutinAddress
            // 
            this.txtPutinAddress.Enabled = false;
            this.txtPutinAddress.Location = new System.Drawing.Point(145, 137);
            this.txtPutinAddress.Name = "txtPutinAddress";
            this.txtPutinAddress.Size = new System.Drawing.Size(215, 21);
            this.txtPutinAddress.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "入库人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "入库地点：";
            // 
            // gbxPutinInfo
            // 
            this.gbxPutinInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxPutinInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxPutinInfo.Controls.Add(this.btnMannualPrint);
            this.gbxPutinInfo.Controls.Add(this.dgvBarCodeList);
            this.gbxPutinInfo.Controls.Add(this.lblPrintCountStatistic);
            this.gbxPutinInfo.Controls.Add(this.lblAlreadyPrintCount);
            this.gbxPutinInfo.Controls.Add(this.lblCountStatistic);
            this.gbxPutinInfo.Controls.Add(this.btnStopPutin);
            this.gbxPutinInfo.Controls.Add(this.btnStartPutin);
            this.gbxPutinInfo.Controls.Add(this.txtBarCode);
            this.gbxPutinInfo.Controls.Add(this.label1);
            this.gbxPutinInfo.Location = new System.Drawing.Point(236, 230);
            this.gbxPutinInfo.Name = "gbxPutinInfo";
            this.gbxPutinInfo.Size = new System.Drawing.Size(474, 389);
            this.gbxPutinInfo.TabIndex = 0;
            this.gbxPutinInfo.TabStop = false;
            this.gbxPutinInfo.Text = "产品信息";
            // 
            // btnMannualPrint
            // 
            this.btnMannualPrint.Location = new System.Drawing.Point(384, 19);
            this.btnMannualPrint.Name = "btnMannualPrint";
            this.btnMannualPrint.Size = new System.Drawing.Size(75, 23);
            this.btnMannualPrint.TabIndex = 6;
            this.btnMannualPrint.Text = "强制打印";
            this.btnMannualPrint.UseVisualStyleBackColor = true;
            this.btnMannualPrint.Click += new System.EventHandler(this.btnMannualPrint_Click);
            // 
            // dgvBarCodeList
            // 
            this.dgvBarCodeList.AllowUserToAddRows = false;
            this.dgvBarCodeList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBarCodeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBarCodeList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBarCodeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarCodeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.BarCode});
            this.dgvBarCodeList.Location = new System.Drawing.Point(19, 123);
            this.dgvBarCodeList.Name = "dgvBarCodeList";
            this.dgvBarCodeList.ReadOnly = true;
            this.dgvBarCodeList.RowHeadersVisible = false;
            this.dgvBarCodeList.RowTemplate.Height = 23;
            this.dgvBarCodeList.Size = new System.Drawing.Size(431, 232);
            this.dgvBarCodeList.TabIndex = 5;
            // 
            // Index
            // 
            this.Index.HeaderText = "序号";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // BarCode
            // 
            this.BarCode.HeaderText = "条形码";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 200;
            // 
            // lblPrintCountStatistic
            // 
            this.lblPrintCountStatistic.AutoSize = true;
            this.lblPrintCountStatistic.Location = new System.Drawing.Point(14, 98);
            this.lblPrintCountStatistic.Name = "lblPrintCountStatistic";
            this.lblPrintCountStatistic.Size = new System.Drawing.Size(113, 12);
            this.lblPrintCountStatistic.TabIndex = 2;
            this.lblPrintCountStatistic.Text = "二维码包含数量统计";
            // 
            // lblAlreadyPrintCount
            // 
            this.lblAlreadyPrintCount.AutoSize = true;
            this.lblAlreadyPrintCount.Location = new System.Drawing.Point(325, 98);
            this.lblAlreadyPrintCount.Name = "lblAlreadyPrintCount";
            this.lblAlreadyPrintCount.Size = new System.Drawing.Size(125, 12);
            this.lblAlreadyPrintCount.TabIndex = 4;
            this.lblAlreadyPrintCount.Text = "已打印二维码数量统计";
            // 
            // lblCountStatistic
            // 
            this.lblCountStatistic.AutoSize = true;
            this.lblCountStatistic.Location = new System.Drawing.Point(186, 98);
            this.lblCountStatistic.Name = "lblCountStatistic";
            this.lblCountStatistic.Size = new System.Drawing.Size(89, 12);
            this.lblCountStatistic.TabIndex = 3;
            this.lblCountStatistic.Text = "入库总数量统计";
            // 
            // btnStopPutin
            // 
            this.btnStopPutin.Location = new System.Drawing.Point(271, 19);
            this.btnStopPutin.Name = "btnStopPutin";
            this.btnStopPutin.Size = new System.Drawing.Size(75, 23);
            this.btnStopPutin.TabIndex = 2;
            this.btnStopPutin.Text = "结束入库";
            this.btnStopPutin.UseVisualStyleBackColor = true;
            this.btnStopPutin.Click += new System.EventHandler(this.btnStopPutin_Click);
            // 
            // btnStartPutin
            // 
            this.btnStartPutin.Location = new System.Drawing.Point(144, 19);
            this.btnStartPutin.Name = "btnStartPutin";
            this.btnStartPutin.Size = new System.Drawing.Size(75, 23);
            this.btnStartPutin.TabIndex = 0;
            this.btnStartPutin.Text = "开始入库";
            this.btnStartPutin.UseVisualStyleBackColor = true;
            this.btnStartPutin.Click += new System.EventHandler(this.btnStartPutin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PutinWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.gbxPutinInfo);
            this.Controls.Add(this.gbxPutinSet);
            this.Name = "PutinWarehouse";
            this.Size = new System.Drawing.Size(971, 619);
            this.Load += new System.EventHandler(this.PutinWarehouse_Load);
            this.gbxPutinSet.ResumeLayout(false);
            this.gbxPutinSet.PerformLayout();
            this.gbxPutinInfo.ResumeLayout(false);
            this.gbxPutinInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBarCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxProductType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCountLimit;
		private System.Windows.Forms.GroupBox gbxPutinSet;
		private System.Windows.Forms.Button btnPutinSet;
		private System.Windows.Forms.GroupBox gbxPutinInfo;
		private System.Windows.Forms.Button btnStartPutin;
		private System.Windows.Forms.TextBox txtPutinAddress;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPutinUserName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnStopPutin;
		private System.Windows.Forms.Label lblCountStatistic;
		private System.Windows.Forms.TextBox txtPrintCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblPrintCountStatistic;
		private System.Windows.Forms.Label lblAlreadyPrintCount;
		private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvBarCodeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.Button btnMannualPrint;
	}
}
