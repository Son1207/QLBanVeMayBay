using QuanLyVeMayBay.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVeMayBay
{
	public partial class fAmin : Form
	{
		string flag;
		DataTable dtKH;
		KHACHHANGBLL bllKH;
		public fAmin()
		{
			InitializeComponent();
			bllKH=new KHACHHANGBLL();
			LoadAccountList();
			LoadDateTimePickerBill();
			LoadBill();
			LoadChuyenBay();
			LoadPhieuDat();
		}
		public void ShowAllKhachHang()
		{
			DataTable dt = bllKH.getAllKhachHang();
			dtgvKhachHang.DataSource = dt;
		}

		public DataTable createTable()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("MAKHACHHANG");
			dt.Columns.Add("TenKH");
			dt.Columns.Add("CMND");
			dt.Columns.Add("DIENTHOAI");
			return dt;
		}

		void LoadAccountList()
		{
			string query = "SELECT * from TAIKHOAN";
			dtgvAcount1.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
		void LoadKHList()
		{
			string query = "SELECT * from KHACHHANG";
			dtgvKhachHang.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
		void LoadBill()
		{
			string query = "SELECT * from DOANHTHUTHANG";
			dtgvBill.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
		void LoadDateTimePickerBill()
		{
			DateTime today = DateTime.Now;
			dtpkFromDate.Value = new DateTime(2020, today.Month, today.Day);
			dtpkToDate.Value = dtpkFromDate.Value.AddYears(1);
		}
		void LoadChuyenBay()
		{
			string query = "SELECT * from CHUYENBAY";
			dtgvChuyenBay.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
		void LoadPhieuDat()
		{
			string query = "SELECT * from PHIEUDATCHO";
			dtgvPhieuDat.DataSource = DataProvider.Instance.ExecuteQuery(query);
		}
		private void panel7_Paint(object sender, PaintEventArgs e)
		{

		}

		private void fAmin_Load(object sender, EventArgs e)
		{
			
			ShowAllKhachHang();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnAddKH_Click(object sender, EventArgs e)
		{

		}

		private void tabPage2_Click(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel2_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void panel12_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				KHACHHANG kh = new KHACHHANG();
				kh.MAKHACHHANG = txbMaKH.Text;
				kh.TENKH = txbTenKhachHang.Text;
				kh.CMND = txbCMND.Text;
				kh.DIENTHOAI = txbDienThoai.Text;

				if (bllKH.InsertKhachHang(kh))
					ShowAllKhachHang();
				else
					MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi", MessageBoxButtons.OK,
						MessageBoxIcon.Stop);
			}
		}

		
		
		private void btnEditKH_Click(object sender, EventArgs e)
		{
			if (checkData())
			{
				KHACHHANG kh = new KHACHHANG();
			
				kh.MAKHACHHANG = txbMaKH.Text;
				kh.TENKH = txbTenKhachHang.Text;
				kh.CMND = txbCMND.Text;
				kh.DIENTHOAI = txbDienThoai.Text;

				if (bllKH.UpdateKhachHang(kh))
					ShowAllKhachHang();
				else
					MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi",
						MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void btnSaveKH_Click(object sender, EventArgs e)
		{
			if (flag == "add")
			{
				if (checkData())
				{
					dtKH.Rows.Add(txbMaKH.Text, txbTenKhachHang.Text, txbCMND.Text, txbDienThoai.Text);
					dtgvKhachHang.DataSource = dtKH;
					dtgvKhachHang.RefreshEdit();
				}
			
			}
		}
		public bool checkData()
		{
			if (string.IsNullOrWhiteSpace(txbMaKH.Text))
			{
				MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txbMaKH.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txbTenKhachHang.Text))
			{
				MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txbTenKhachHang.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txbCMND.Text))
			{
				MessageBox.Show("Bạn chưa nhập CMND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txbCMND.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txbDienThoai.Text))
			{
				MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txbDienThoai.Focus();
				return false;
			}
			
			return true;
		}
		
		private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				
			    txbMaKH.Text = dtgvKhachHang.Rows[index].Cells["MAKHACHHANG"].Value.ToString();
				txbTenKhachHang.Text = dtgvKhachHang.Rows[index].Cells["TENKH"].Value.ToString();
				txbCMND.Text = dtgvKhachHang.Rows[index].Cells["CMND"].Value.ToString();
				txbDienThoai.Text = dtgvKhachHang.Rows[index].Cells["DIENTHOAI"].Value.ToString();
			}
		}

		private void btnDeleteKH_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Bạn có muốn xóa hay không?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==
				DialogResult.Yes)
			{
				KHACHHANG kh = new KHACHHANG();
				kh.MAKHACHHANG = txbMaKH.Text;

				if (bllKH.DeleteKhachHang(kh))
					ShowAllKhachHang();
				else
					MessageBox.Show("Đã có lỗi xảy ra, xin thử lại sau", "Thông báo lỗi",
						MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private void txbSearchKhName_TextChanged(object sender, EventArgs e)
		{
			string value = txbSearchKhName.Text;
			if (!string.IsNullOrEmpty(value))
			{
				DataTable dt = bllKH.FindKhachHang(value);
				dtgvKhachHang.DataSource = dt;
			}
			else
				ShowAllKhachHang();
		}
	}
}
