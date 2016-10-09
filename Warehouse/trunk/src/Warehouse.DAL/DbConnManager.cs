using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Warehouse.DAL
{
	internal class DbConnManager
	{
		private static string _mySqlConn = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

		internal static string MySqlConn
		{
			get
			{
				return _mySqlConn;
			}
		}

		internal static MySqlConnection SqlConnection
		{
			get
			{
				return new MySqlConnection(MySqlConn);
			}
		}
	}
}
