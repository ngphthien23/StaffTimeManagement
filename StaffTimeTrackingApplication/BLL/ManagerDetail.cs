using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffTimeTrackingApplication.BLL
{
    public class ManagerDetail
    {
        private int managerId;
        private string managerFirstName;
        private string managerLastName;
        private int phoneNumber;
        private int userId;

        public int ManagerId { get => managerId; set => managerId = value; }
        public string ManagerFirstName { get => managerFirstName; set => managerFirstName = value; }
        public string ManagerLastName { get => managerLastName; set => managerLastName = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int UserId { get => userId; set => userId = value; }
    }
}
