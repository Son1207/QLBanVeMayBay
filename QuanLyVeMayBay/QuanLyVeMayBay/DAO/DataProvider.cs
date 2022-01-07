using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVeMayBay.DAO
{
	class DataProvider
	{
		private static DataProvider instance;
		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
			private set { DataProvider.instance = value; }
		}

		private string connectionSTR = @"Data Source=DESKTOP-621JGU5\SQLEXPRESS;Initial Catalog=QL_BanVeMayBay;Persist Security Info=True;User ID=sa;Password=Son123456";
		public DataTable ExecuteQuery(string query = null, object[] parameter = null)
		{
			DataTable data = new DataTable();
			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();
				SqlCommand comand = new SqlCommand(query, connection);
				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							comand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				SqlDataAdapter adapter = new SqlDataAdapter(comand);
				adapter.Fill(data);
				connection.Close();
			}
			return data;
		}

		public int ExecuteNonQuery(string query, object[] parameter = null)
		{
			int data = 0;
			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();
				SqlCommand comand = new SqlCommand(query, connection);
				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							comand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				data = comand.ExecuteNonQuery();
				connection.Close();
			}
			return data;
		}

		public object ExecuteScalar(string query, object[] parameter = null)
		{
			object data = 0;
			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();
				SqlCommand comand = new SqlCommand(query, connection);
				if (parameter != null)
				{
					string[] listPara = query.Split(' ');
					int i = 0;
					foreach (string item in listPara)
					{
						if (item.Contains('@'))
						{
							comand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}
				data = comand.ExecuteScalar();
				connection.Close();
			}
			return data;
		}
	}
}

