namespace Warehouse.Win
{
	partial class CustomPageControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPageControl));
			this.btnGo = new System.Windows.Forms.Button();
			this.btnPrePage = new System.Windows.Forms.Button();
			this.cbxPageIndex = new System.Windows.Forms.ComboBox();
			this.btnNextPage = new System.Windows.Forms.Button();
			this.btnFirstPage = new System.Windows.Forms.Button();
			this.btnLastPage = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.txtPageSize = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.Location = new System.Drawing.Point(648, 16);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(47, 20);
			this.btnGo.TabIndex = 11;
			this.btnGo.Text = "确定";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// btnPrePage
			// 
			this.btnPrePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrePage.Image = ((System.Drawing.Image)(resources.GetObject("btnPrePage.Image")));
			this.btnPrePage.Location = new System.Drawing.Point(435, 17);
			this.btnPrePage.Name = "btnPrePage";
			this.btnPrePage.Size = new System.Drawing.Size(32, 20);
			this.btnPrePage.TabIndex = 8;
			this.btnPrePage.UseVisualStyleBackColor = true;
			this.btnPrePage.Click += new System.EventHandler(this.btnPrePage_Click);
			// 
			// cbxPageIndex
			// 
			this.cbxPageIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxPageIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxPageIndex.FormattingEnabled = true;
			this.cbxPageIndex.Location = new System.Drawing.Point(584, 16);
			this.cbxPageIndex.Name = "cbxPageIndex";
			this.cbxPageIndex.Size = new System.Drawing.Size(37, 20);
			this.cbxPageIndex.TabIndex = 10;
			// 
			// btnNextPage
			// 
			this.btnNextPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
			this.btnNextPage.Location = new System.Drawing.Point(475, 17);
			this.btnNextPage.Name = "btnNextPage";
			this.btnNextPage.Size = new System.Drawing.Size(32, 20);
			this.btnNextPage.TabIndex = 9;
			this.btnNextPage.UseVisualStyleBackColor = true;
			this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
			// 
			// btnFirstPage
			// 
			this.btnFirstPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.Image")));
			this.btnFirstPage.Location = new System.Drawing.Point(395, 17);
			this.btnFirstPage.Name = "btnFirstPage";
			this.btnFirstPage.Size = new System.Drawing.Size(32, 20);
			this.btnFirstPage.TabIndex = 12;
			this.btnFirstPage.UseVisualStyleBackColor = true;
			this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
			// 
			// btnLastPage
			// 
			this.btnLastPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLastPage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPage.Image")));
			this.btnLastPage.Location = new System.Drawing.Point(515, 17);
			this.btnLastPage.Name = "btnLastPage";
			this.btnLastPage.Size = new System.Drawing.Size(32, 20);
			this.btnLastPage.TabIndex = 13;
			this.btnLastPage.UseVisualStyleBackColor = true;
			this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(562, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 12);
			this.label1.TabIndex = 14;
			this.label1.Text = "第";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(625, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 15;
			this.label2.Text = "页";
			// 
			// lblDisplay
			// 
			this.lblDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblDisplay.AutoSize = true;
			this.lblDisplay.Location = new System.Drawing.Point(24, 19);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(41, 12);
			this.lblDisplay.TabIndex = 16;
			this.lblDisplay.Text = "label3";
			// 
			// txtPageSize
			// 
			this.txtPageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPageSize.Location = new System.Drawing.Point(281, 15);
			this.txtPageSize.Name = "txtPageSize";
			this.txtPageSize.Size = new System.Drawing.Size(51, 21);
			this.txtPageSize.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(249, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 18;
			this.label3.Text = "每页";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(336, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 12);
			this.label4.TabIndex = 18;
			this.label4.Text = "条";
			// 
			// CustomPageControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPageSize);
			this.Controls.Add(this.lblDisplay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLastPage);
			this.Controls.Add(this.btnFirstPage);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.btnPrePage);
			this.Controls.Add(this.cbxPageIndex);
			this.Controls.Add(this.btnNextPage);
			this.Name = "CustomPageControl";
			this.Size = new System.Drawing.Size(738, 54);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Button btnPrePage;
		private System.Windows.Forms.ComboBox cbxPageIndex;
		private System.Windows.Forms.Button btnNextPage;
		private System.Windows.Forms.Button btnFirstPage;
		private System.Windows.Forms.Button btnLastPage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.TextBox txtPageSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;

	}
}
