using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace StaffTimeTrackingApplication.DAL
{
    public static class UtilityDB
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=DESKTOP-D6OML9F\\SQLEXPRESS;database=StaffTimeTrackingDB;user=sa;password=123";
            conn.Open();
            return conn;



        }

    }
}
