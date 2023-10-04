using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaffTimeTrackingApplication.DAL;

namespace StaffTimeTrackingApplication.BLL
{
    public class User
    {
        private int userId;
        private int userName;
        private string password;

        public int UserId { get => userId; set => userId = value; }
        public int UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }


        public Boolean CheckUser(User user) 
        { 
        return UserDB.CheckUserAccount(user);
        }

        public Boolean CheckUserIsManager(User user) 
        { 
        return UserDB.CheckIfUserIsManager(user);
        }


    }
}
