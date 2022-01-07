using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeMayBay
{
	class KHACHHANGBLL
	{
		KHACHHANGDAL dalKH;
		public KHACHHANGBLL(){
			dalKH = new KHACHHANGDAL();
		}

		public DataTable getAllKhachHang()
		{
			return dalKH.getAllKhachHang();
		} 
		public bool UpdateKhachHang(KHACHHANG kh)
		{
			return dalKH.UpdateKhachHang(kh);
		}

		public bool DeleteKhachHang(KHACHHANG kh)
		{
			return dalKH.DeleteKhachHang(kh);
		}
		public bool InsertKhachHang(KHACHHANG kh)
		{
			return dalKH.InsertKhachHang(kh);
		}
		public DataTable FindKhachHang(string kh)
		{
			return dalKH.FindKhachHang(kh);
		}
	}
}
