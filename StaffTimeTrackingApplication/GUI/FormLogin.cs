using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StaffTimeTrackingApplication.BLL;

namespace StaffTimeTrackingApplication.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.UserName = Convert.ToInt32(textBoxUsername.Text);
            user.Password = textBoxPassword.Text;

            //condition to check if the input usernname and password are matched with an exist user in the database
            // if return true --> Go to the second condition to check if the user is either manager or staff
            // if return false --> message box error
            if (user.CheckUser(user))
            {

                //Condition to check either user is manager of staff
                // if return true --> user is a manager
                // if return false --> user is a staff
                if (user.CheckUserIsManager(user))
                {
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm();
                    managerForm.ShowDialog();
                }
                else { 
                    this.Hide(); 
                    StaffForm staffForm = new StaffForm();
                    staffForm.ShowDialog();
                
                }




            }
            else
            {
                MessageBox.Show("The Username or password you've enter doesn't match any account. Please try again", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
