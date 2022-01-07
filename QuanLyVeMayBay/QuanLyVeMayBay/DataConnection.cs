using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeMayBay
{

	class DataConnection
	{
		string conStr;
		public DataConnection() {
			conStr = "Data Source=DESKTOP-621JGU5\\SQLEXPRESS;Initial Catalog=QL_BanVeMayBay;User ID=sa;Password=Son123456;";
		}
		public SqlConnection getConnect()
		{
			return new SqlConnection(conStr);
		}
	}
}
