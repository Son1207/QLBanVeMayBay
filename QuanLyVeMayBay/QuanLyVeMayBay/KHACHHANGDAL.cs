using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeMayBay
{
	class KHACHHANGDAL
	{
		DataConnection dc;
		SqlDataAdapter da;
		SqlCommand cmd;
		public KHACHHANGDAL()
		{
			dc = new DataConnection();
		}
		public DataTable getAllKhachHang()
		{
			string sql = "SELECT * FROM KHACHHANG";
			SqlConnection con = dc.getConnect();
			da = new SqlDataAdapter(sql, con);
			con.Open();
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
			
		}

		public bool InsertKhachHang(KHACHHANG kh)
		{
			string sql = "INSERT INTO KHACHHANG(MAKHACHHANG,TENKH,CMND,DIENTHOAI)VALUES(@MAKHACHHANG, @TENKH,@CMND,@DIENTHOAI)";
			SqlConnection con = dc.getConnect();
			cmd = new SqlCommand(sql, con);
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaKHACHHANG", SqlDbType.Char).Value = kh.MAKHACHHANG;
				cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = kh.TENKH;
				cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = kh.CMND;
				cmd.Parameters.Add("@DIENTHOAI", SqlDbType.Char).Value = kh.DIENTHOAI;
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch(Exception e)
			{
				return false;
			}
			return true;
		}

		public bool UpdateKhachHang(KHACHHANG kh)
		{
			string sql = "UPDATE KHACHHANG SET  TENKH=@TENKH, CMND=@CMND, DIENTHOAI= @DIENTHOAI WHERE MAKHACHHANG=@MAKHACHHANG";
			SqlConnection con = dc.getConnect();
			cmd = new SqlCommand(sql, con);
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaKHACHHANG", SqlDbType.Char).Value = kh.MAKHACHHANG;
				cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = kh.TENKH;
				cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = kh.CMND;
				cmd.Parameters.Add("@DIENTHOAI", SqlDbType.Char).Value = kh.DIENTHOAI;
				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}

		public bool DeleteKhachHang(KHACHHANG kh)
		{
			string sql = "DELETE KHACHHANG WHERE MAKHACHHANG=@MAKHACHHANG";
			SqlConnection con = dc.getConnect();
			cmd = new SqlCommand(sql, con);
			try
			{
				cmd = new SqlCommand(sql, con);
				con.Open();
				cmd.Parameters.Add("@MaKHACHHANG", SqlDbType.Char).Value = kh.MAKHACHHANG;

				cmd.ExecuteNonQuery();
				con.Close();
			}
			catch (Exception e)
			{
				return false;
			}
			return true;
		}
		public DataTable FindKhachHang(string kh)
		{
			string sql = "SELECT * FROM KHACHHANG WHERE TENKH like N'%" + kh +  "%'";
			SqlConnection con = dc.getConnect();
			da = new SqlDataAdapter(sql, con);
			con.Open();
			DataTable dt = new DataTable();
			da.Fill(dt);
			con.Close();
			return dt;
		}
	}
}
