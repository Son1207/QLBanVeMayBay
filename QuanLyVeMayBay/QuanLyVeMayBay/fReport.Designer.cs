namespace QuanLyVeMayBay
{
	partial class fReport
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
			if (disposing && (components != null))
			{
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dtgvDTThang = new System.Windows.Forms.DataGridView();
			this.rpDoanhThuThang = new Microsoft.Reporting.WinForms.ReportViewer();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dtgvDTNam = new System.Windows.Forms.DataGridView();
			this.rpDoanhThuNam = new Microsoft.Reporting.WinForms.ReportViewer();
			this.reportAction1 = new Microsoft.AnalysisServices.ReportAction();
			this.reportAction2 = new Microsoft.AnalysisServices.ReportAction();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvDTThang)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgvDTNam)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new System.Drawing.Point(0, 10);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1354, 739);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dtgvDTThang);
			this.tabPage1.Controls.Add(this.rpDoanhThuThang);
			this.tabPage1.Location = new System.Drawing.Point(8, 39);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1338, 692);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Báo cáo theo tháng";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dtgvDTThang
			// 
			this.dtgvDTThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvDTThang.Location = new System.Drawing.Point(0, 67);
			this.dtgvDTThang.Name = "dtgvDTThang";
			this.dtgvDTThang.RowTemplate.Height = 33;
			this.dtgvDTThang.Size = new System.Drawing.Size(1335, 619);
			this.dtgvDTThang.TabIndex = 1;
			// 
			// rpDoanhThuThang
			// 
			this.rpDoanhThuThang.Location = new System.Drawing.Point(3, 6);
			this.rpDoanhThuThang.Name = "rpDoanhThuThang";
			this.rpDoanhThuThang.ServerReport.BearerToken = null;
			this.rpDoanhThuThang.Size = new System.Drawing.Size(1332, 683);
			this.rpDoanhThuThang.TabIndex = 0;
			this.rpDoanhThuThang.Load += new System.EventHandler(this.rpDoanhThuThang_Load);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dtgvDTNam);
			this.tabPage2.Controls.Add(this.rpDoanhThuNam);
			this.tabPage2.Location = new System.Drawing.Point(8, 39);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1338, 692);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Báo cáo theo năm";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dtgvDTNam
			// 
			this.dtgvDTNam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvDTNam.Location = new System.Drawing.Point(3, 59);
			this.dtgvDTNam.Name = "dtgvDTNam";
			this.dtgvDTNam.RowTemplate.Height = 33;
			this.dtgvDTNam.Size = new System.Drawing.Size(1335, 633);
			this.dtgvDTNam.TabIndex = 1;
			// 
			// rpDoanhThuNam
			// 
			this.rpDoanhThuNam.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rpDoanhThuNam.Location = new System.Drawing.Point(3, 3);
			this.rpDoanhThuNam.Name = "rpDoanhThuNam";
			this.rpDoanhThuNam.ServerReport.BearerToken = null;
			this.rpDoanhThuNam.Size = new System.Drawing.Size(1332, 686);
			this.rpDoanhThuNam.TabIndex = 0;
			// 
			// reportAction1
			// 
			this.reportAction1.Application = null;
			this.reportAction1.Description = null;
			this.reportAction1.Name = null;
			this.reportAction1.OwningCollection = null;
			this.reportAction1.Path = null;
			this.reportAction1.ReportServer = null;
			
			// 
			// reportAction2
			// 
			this.reportAction2.Application = null;
			this.reportAction2.Description = null;
			this.reportAction2.Name = "fd";
			this.reportAction2.OwningCollection = null;
			this.reportAction2.Path = null;
			this.reportAction2.ReportServer = null;
			
			// 
			// fReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1354, 749);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Báo cáo doanh thu";
			this.Load += new System.EventHandler(this.fReport_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvDTThang)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgvDTNam)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private Microsoft.AnalysisServices.ReportAction reportAction1;
		private Microsoft.AnalysisServices.ReportAction reportAction2;
		private Microsoft.Reporting.WinForms.ReportViewer rpDoanhThuThang;
		private Microsoft.Reporting.WinForms.ReportViewer rpDoanhThuNam;
		private System.Windows.Forms.DataGridView dtgvDTThang;
		private System.Windows.Forms.DataGridView dtgvDTNam;
	}
}