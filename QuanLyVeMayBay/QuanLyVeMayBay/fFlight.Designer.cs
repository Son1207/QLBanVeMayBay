namespace QuanLyVeMayBay
{
	partial class fFlight
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFlight));
			this.dtgvTuyenBay = new System.Windows.Forms.DataGridView();
			this.MATUYENBAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SANBAYDI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SANBAYDEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenBay)).BeginInit();
			this.SuspendLayout();
			// 
			// dtgvTuyenBay
			// 
			this.dtgvTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgvTuyenBay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATUYENBAY,
            this.SANBAYDI,
            this.SANBAYDEN});
			this.dtgvTuyenBay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgvTuyenBay.Location = new System.Drawing.Point(0, 0);
			this.dtgvTuyenBay.Name = "dtgvTuyenBay";
			this.dtgvTuyenBay.RowTemplate.Height = 33;
			this.dtgvTuyenBay.Size = new System.Drawing.Size(1354, 749);
			this.dtgvTuyenBay.TabIndex = 0;
			// 
			// MATUYENBAY
			// 
			this.MATUYENBAY.DataPropertyName = "MATUYENBAY";
			this.MATUYENBAY.HeaderText = "Mã Tuyến Bay";
			this.MATUYENBAY.Name = "MATUYENBAY";
			this.MATUYENBAY.Width = 200;
			// 
			// SANBAYDI
			// 
			this.SANBAYDI.DataPropertyName = "SANBAYDI";
			this.SANBAYDI.HeaderText = "Sân bay đi";
			this.SANBAYDI.Name = "SANBAYDI";
			this.SANBAYDI.Width = 200;
			// 
			// SANBAYDEN
			// 
			this.SANBAYDEN.DataPropertyName = "SANBAYDEN";
			this.SANBAYDEN.HeaderText = "Sân bay đến";
			this.SANBAYDEN.Name = "SANBAYDEN";
			this.SANBAYDEN.Width = 200;
			// 
			// fFlight
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1354, 749);
			this.Controls.Add(this.dtgvTuyenBay);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fFlight";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tuyến Bay";
			this.Load += new System.EventHandler(this.fFlight_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenBay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dtgvTuyenBay;
		private System.Windows.Forms.DataGridViewTextBoxColumn MATUYENBAY;
		private System.Windows.Forms.DataGridViewTextBoxColumn SANBAYDI;
		private System.Windows.Forms.DataGridViewTextBoxColumn SANBAYDEN;
	}
}