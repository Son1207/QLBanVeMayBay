using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeMayBay
{
	public partial class fAccountProfile : Form
	{
		public fAccountProfile()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void fAccountProfile_Load(object sender, EventArgs e)
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
		}
	}
}
