using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffTimeTrackingApplication.BLL;

namespace StaffTimeTrackingApplication.DAL
{
    public class UserDB
    {

        //return true if User is exist in the database
        public static Boolean CheckUserAccount(User user)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdGetUser = new SqlCommand();
            cmdGetUser.Connection = conn;
            cmdGetUser.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            cmdGetUser.Parameters.AddWithValue("@Username",user.UserName);
            cmdGetUser.Parameters.AddWithValue("@Password",user.Password);
            int count = (int)cmdGetUser.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            else { return false; }
            
        }

        //return true if the input user is a manager. Only use after verified the input user is already existed
        public static Boolean CheckIfUserIsManager(User user) 
        {
            SqlConnection conn = UtilityDB.GetDBConnection();
            SqlCommand cmdcheckposition = new SqlCommand();
            cmdcheckposition.Connection = conn;
            cmdcheckposition.CommandText = "SELECT COUNT(*) FROM ManagerDetails WHERE UserId = @Userid";
            cmdcheckposition.Parameters.AddWithValue("@Userid",user.UserName);
            int count = (int)cmdcheckposition.ExecuteScalar();
            if (count > 0)
            {
                return true;
            }
            else { return false; }


        }




    }
}
