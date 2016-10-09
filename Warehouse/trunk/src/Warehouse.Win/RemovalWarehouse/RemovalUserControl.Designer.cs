namespace Warehouse.Win
{
	partial class RemovalUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountLimit = new System.Windows.Forms.TextBox();
            this.gbxRemovalSet = new System.Windows.Forms.GroupBox();
            this.cbxDispathPlace = new System.Windows.Forms.ComboBox();
            this.btnRemovalSet = new System.Windows.Forms.Button();
            this.txtRemovalUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxPutinInfo = new System.Windows.Forms.GroupBox();
            this.dgvBarCodeList = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutInUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PutInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAlreadySacnCount = new System.Windows.Forms.Label();
            this.lblCountStatistic = new System.Windows.Forms.Label();
            this.btnStopRemoval = new System.Windows.Forms.Button();
            this.btnStartRemoval = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.gbxRemovalSet.SuspendLayout();
            this.gbxPutinInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarCodeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "二维码：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(144, 57);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.ReadOnly = true;
            this.txtBarCode.Size = new System.Drawing.Size(215, 21);
            this.txtBarCode.TabIndex = 1;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "产品类型：";
            // 
            // cbxProductType
            // 
            this.cbxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(145, 22);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(215, 20);
            this.cbxProductType.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "出库总数量：";
            // 
            // txtCountLimit
            // 
            this.txtCountLimit.Location = new System.Drawing.Point(145, 58);
            this.txtCountLimit.Name = "txtCountLimit";
            this.txtCountLimit.Size = new System.Drawing.Size(215, 21);
            this.txtCountLimit.TabIndex = 1;
            this.txtCountLimit.Validating += new System.ComponentModel.CancelEventHandler(this.txtCountLimit_Validating);
            // 
            // gbxRemovalSet
            // 
            this.gbxRemovalSet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxRemovalSet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxRemovalSet.Controls.Add(this.cbxDispathPlace);
            this.gbxRemovalSet.Controls.Add(this.btnRemovalSet);
            this.gbxRemovalSet.Controls.Add(this.label2);
            this.gbxRemovalSet.Controls.Add(this.txtRemovalUserName);
            this.gbxRemovalSet.Controls.Add(this.label5);
            this.gbxRemovalSet.Controls.Add(this.txtCountLimit);
            this.gbxRemovalSet.Controls.Add(this.label4);
            this.gbxRemovalSet.Controls.Add(this.cbxProductType);
            this.gbxRemovalSet.Controls.Add(this.label3);
            this.gbxRemovalSet.Location = new System.Drawing.Point(236, 18);
            this.gbxRemovalSet.Name = "gbxRemovalSet";
            this.gbxRemovalSet.Size = new System.Drawing.Size(474, 175);
            this.gbxRemovalSet.TabIndex = 6;
            this.gbxRemovalSet.TabStop = false;
            this.gbxRemovalSet.Text = "出库设置";
            // 
            // cbxDispathPlace
            // 
            this.cbxDispathPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispathPlace.FormattingEnabled = true;
            this.cbxDispathPlace.Location = new System.Drawing.Point(145, 95);
            this.cbxDispathPlace.Name = "cbxDispathPlace";
            this.cbxDispathPlace.Size = new System.Drawing.Size(215, 20);
            this.cbxDispathPlace.TabIndex = 5;
            // 
            // btnRemovalSet
            // 
            this.btnRemovalSet.Location = new System.Drawing.Point(384, 18);
            this.btnRemovalSet.Name = "btnRemovalSet";
            this.btnRemovalSet.Size = new System.Drawing.Size(75, 23);
            this.btnRemovalSet.TabIndex = 4;
            this.btnRemovalSet.Text = "修改";
            this.btnRemovalSet.UseVisualStyleBackColor = true;
            this.btnRemovalSet.Click += new System.EventHandler(this.btnRemovalSet_Click);
            // 
            // txtRemovalUserName
            // 
            this.txtRemovalUserName.Enabled = false;
            this.txtRemovalUserName.Location = new System.Drawing.Point(145, 132);
            this.txtRemovalUserName.Name = "txtRemovalUserName";
            this.txtRemovalUserName.Size = new System.Drawing.Size(215, 21);
            this.txtRemovalUserName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "出库人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "发往地点：";
            // 
            // gbxPutinInfo
            // 
            this.gbxPutinInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbxPutinInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxPutinInfo.Controls.Add(this.dgvBarCodeList);
            this.gbxPutinInfo.Controls.Add(this.lblAlreadySacnCount);
            this.gbxPutinInfo.Controls.Add(this.lblCountStatistic);
            this.gbxPutinInfo.Controls.Add(this.btnStopRemoval);
            this.gbxPutinInfo.Controls.Add(this.btnStartRemoval);
            this.gbxPutinInfo.Controls.Add(this.txtBarCode);
            this.gbxPutinInfo.Controls.Add(this.label1);
            this.gbxPutinInfo.Location = new System.Drawing.Point(234, 199);
            this.gbxPutinInfo.Name = "gbxPutinInfo";
            this.gbxPutinInfo.Size = new System.Drawing.Size(474, 370);
            this.gbxPutinInfo.TabIndex = 7;
            this.gbxPutinInfo.TabStop = false;
            this.gbxPutinInfo.Text = "产品信息";
            // 
            // dgvBarCodeList
            // 
            this.dgvBarCodeList.AllowUserToAddRows = false;
            this.dgvBarCodeList.AllowUserToDeleteRows = false;
            this.dgvBarCodeList.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBarCodeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBarCodeList.ColumnHeadersHeight = 20;
            this.dgvBarCodeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.BarCode,
            this.PutInUserName,
            this.Place,
            this.PutInTime});
            this.dgvBarCodeList.Location = new System.Drawing.Point(25, 127);
            this.dgvBarCodeList.Name = "dgvBarCodeList";
            this.dgvBarCodeList.ReadOnly = true;
            this.dgvBarCodeList.RowHeadersVisible = false;
            this.dgvBarCodeList.RowTemplate.Height = 23;
            this.dgvBarCodeList.Size = new System.Drawing.Size(430, 237);
            this.dgvBarCodeList.TabIndex = 4;
            // 
            // Index
            // 
            this.Index.HeaderText = "序号";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 40;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "条形码";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 105;
            // 
            // PutInUserName
            // 
            this.PutInUserName.DataPropertyName = "PutInUserName";
            this.PutInUserName.HeaderText = "入库人";
            this.PutInUserName.Name = "PutInUserName";
            this.PutInUserName.ReadOnly = true;
            this.PutInUserName.Width = 80;
            // 
            // Place
            // 
            this.Place.DataPropertyName = "Place";
            this.Place.HeaderText = "入库地点";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            // 
            // PutInTime
            // 
            this.PutInTime.DataPropertyName = "PutInTime";
            this.PutInTime.HeaderText = "入库时间";
            this.PutInTime.Name = "PutInTime";
            this.PutInTime.ReadOnly = true;
            // 
            // lblAlreadySacnCount
            // 
            this.lblAlreadySacnCount.AutoSize = true;
            this.lblAlreadySacnCount.Location = new System.Drawing.Point(247, 97);
            this.lblAlreadySacnCount.Name = "lblAlreadySacnCount";
            this.lblAlreadySacnCount.Size = new System.Drawing.Size(125, 12);
            this.lblAlreadySacnCount.TabIndex = 3;
            this.lblAlreadySacnCount.Text = "已扫描二维码数量统计";
            // 
            // lblCountStatistic
            // 
            this.lblCountStatistic.AutoSize = true;
            this.lblCountStatistic.Location = new System.Drawing.Point(64, 97);
            this.lblCountStatistic.Name = "lblCountStatistic";
            this.lblCountStatistic.Size = new System.Drawing.Size(89, 12);
            this.lblCountStatistic.TabIndex = 3;
            this.lblCountStatistic.Text = "出库总数量统计";
            // 
            // btnStopRemoval
            // 
            this.btnStopRemoval.Location = new System.Drawing.Point(271, 19);
            this.btnStopRemoval.Name = "btnStopRemoval";
            this.btnStopRemoval.Size = new System.Drawing.Size(75, 23);
            this.btnStopRemoval.TabIndex = 2;
            this.btnStopRemoval.Text = "结束出库";
            this.btnStopRemoval.UseVisualStyleBackColor = true;
            this.btnStopRemoval.Click += new System.EventHandler(this.btnStopRemoval_Click);
            // 
            // btnStartRemoval
            // 
            this.btnStartRemoval.Location = new System.Drawing.Point(144, 19);
            this.btnStartRemoval.Name = "btnStartRemoval";
            this.btnStartRemoval.Size = new System.Drawing.Size(75, 23);
            this.btnStartRemoval.TabIndex = 0;
            this.btnStartRemoval.Text = "开始出库";
            this.btnStartRemoval.UseVisualStyleBackColor = true;
            this.btnStartRemoval.Click += new System.EventHandler(this.btnStartRemoval_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RemovalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.gbxPutinInfo);
            this.Controls.Add(this.gbxRemovalSet);
            this.Name = "RemovalUserControl";
            this.Size = new System.Drawing.Size(971, 619);
            this.gbxRemovalSet.ResumeLayout(false);
            this.gbxRemovalSet.PerformLayout();
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
		private System.Windows.Forms.GroupBox gbxRemovalSet;
		private System.Windows.Forms.Button btnRemovalSet;
		private System.Windows.Forms.GroupBox gbxPutinInfo;
		private System.Windows.Forms.Button btnStartRemoval;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtRemovalUserName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnStopRemoval;
		private System.Windows.Forms.Label lblCountStatistic;
		private System.Windows.Forms.Label lblAlreadySacnCount;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.ComboBox cbxDispathPlace;
		private System.Windows.Forms.DataGridView dgvBarCodeList;
		private System.Windows.Forms.DataGridViewTextBoxColumn Index;
		private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn PutInUserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Place;
		private System.Windows.Forms.DataGridViewTextBoxColumn PutInTime;
	}
}
