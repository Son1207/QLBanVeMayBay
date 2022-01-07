namespace QuanLyVeMayBay
{
	partial class fLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txbUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btnExit);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(203, 194);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 284);
			this.panel1.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.DarkOrange;
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(613, 207);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(131, 54);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DarkOrange;
			this.btnLogin.Location = new System.Drawing.Point(439, 207);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(142, 54);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel3.ForeColor = System.Drawing.Color.DarkOrange;
			this.panel3.Location = new System.Drawing.Point(0, 112);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(757, 73);
			this.panel3.TabIndex = 1;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(241, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(503, 38);
			this.textBox1.TabIndex = 1;
			this.textBox1.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txbUserName);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(754, 79);
			this.panel2.TabIndex = 0;
			// 
			// txbUserName
			// 
			this.txbUserName.Location = new System.Drawing.Point(238, 33);
			this.txbUserName.Name = "txbUserName";
			this.txbUserName.Size = new System.Drawing.Size(503, 31);
			this.txbUserName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkOrange;
			this.label1.Location = new System.Drawing.Point(19, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên đăng nhập:";
			// 
			// fLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.BackgroundImage = global::QuanLyVeMayBay.Properties.Resources.background_login1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CancelButton = this.btnExit;
			this.ClientSize = new System.Drawing.Size(1200, 751);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fLogin_FormClosed);
			this.Load += new System.EventHandler(this.fLogin_Load);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txbUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnLogin;
	}
}

