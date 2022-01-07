using QuanLyVeMayBay.DAO;
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
	public partial class fReport : Form
	{
		public fReport()
		{
			InitializeComponent();
			LoadDoanhThuNam();
			LoadDoanhThuThang();
		}
		void LoadDoanhThuThang()
		{
			string query = "SELECT * from DOANHTHUTHANG";
			dtgvDTThang.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
		void LoadDoanhThuNam()
		{
			string query = "SELECT * from DOANHTHUNAM";
			dtgvDTNam.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
		private void fReport_Load(object sender, EventArgs e)
		{
			
			this.rpDoanhThuThang.RefreshReport();
			this.rpDoanhThuNam.RefreshReport();
			
		}

		private void rpDoanhThuThang_Load(object sender, EventArgs e)
		{

		}
	}
}
