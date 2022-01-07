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
	public partial class fTableManager : Form
	{
		public fTableManager()
		{
			InitializeComponent();
		}


		private void fTableManager_Load(object sender, EventArgs e)
		{
	
		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAccountProfile f = new fAccountProfile();
			f.ShowDialog();
		}

		private void adminToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fAmin f = new fAmin();
			f.ShowDialog();
		}

		private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
		{
			fReport f = new fReport();
			f.ShowDialog();
		}

		private void label6_Click(object sender, EventArgs e)
		{

		}
		
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{	

		}

		private void button1_Click(object sender, EventArgs e)
		{
			fFlight f = new fFlight();
			f.ShowDialog();
		}
	}
}
