using System;
using QuanLyVeMayBay.DAO;
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
	public partial class fFlight : Form
	{
		public fFlight()
		{
			InitializeComponent();
			LoadTuyenBay();
		}

		private void fFlight_Load(object sender, EventArgs e)
		{

		}
		void LoadTuyenBay()
		{
			string query = "SELECT * from TUYENBAY";
			dtgvTuyenBay.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
	}
}
