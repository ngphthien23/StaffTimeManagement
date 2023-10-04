using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PunchInOutApp_Iteration1._2
{
    public partial class Form1 : Form
    {
        private bool isPunchedIn = false; // Track whether the user is punched in or not.
        private DateTime punchInTime; // Record the time when punched in.
        private DateTime punchOutTime; // Record the time when punched out.
        private List<string> dates = new List<string>(); // List to store dates.
        private List<string> clockInTimes = new List<string>(); // List to store clock-in times.
        private List<string> clockOutTimes = new List<string>(); // List to store clock-out times.
        private List<string> totalHoursWorked = new List<string>(); // List to store total hours worked.
        private List<string> correctionRequests = new List<string>(); // List to store correction requests.
        private bool listsVisible = false; // Track the visibility state of the lists.
        private Timer autoLogoutTimer; // Timer for automatic logout
        private int autoLogoutInterval = 1800000; // 30 minutes in milliseconds
        public Form1()
        {
            InitializeComponent();
            InitializeUI();
            InitializeAutoLogoutTimer();
        }
        private void InitializeAutoLogoutTimer()
        {
            autoLogoutTimer = new Timer();
            autoLogoutTimer.Interval = autoLogoutInterval;
           // autoLogoutTimer.Tick += new EventHandler(AutoLogoutTimer_Tick);
            autoLogoutTimer.Start();
        }
       
        private void InitializeUI()
        {
            lblClockInTime.Text = "Clock In Time: Not punched in yet";
            lblClockOutTime.Text = "Clock Out Time: Not punched out yet";
            lblDate.Text = "Date: N/A";
            lblTotalHours.Text = "Total Hours Worked: 0.00 hours";

            listBoxDates.Visible = false; // Initially hide the list boxes.
            listBoxClockInTimes.Visible = false;
            listBoxClockOutTimes.Visible = false;
            listBoxTotalHoursWorked.Visible = false;

        }

        private void btnPunchIn_Click(object sender, EventArgs e)
        {
            if (!isPunchedIn)
            {
                DateTime now = DateTime.Now;
                punchInTime = DateTime.Now; // Record the punch in time.
                lblDate.Text = $"Date: {now.ToString("MM/dd/yyyy")}";
                lblClockInTime.Text = $"Clock In Time: {punchInTime.ToString("HH:mm:ss")}";
                string punchInString = now.ToString("MM/dd/yyyy HH:mm:ss");
                dates.Add(now.ToString("MM/dd/yyyy"));
                clockInTimes.Add(now.ToString("HH:mm:ss"));
               

                UpdatePunchList(); // Update the list box with punch times.


                MessageBox.Show("You have successfully punched in.", "Punch In");
                isPunchedIn = true;
                btnPunchIn.Enabled = false; // Disable Punch In button when already punched in.
                btnPunchOut.Enabled = true; // Enable Punch Out button when punched in.
            }
            else
            {
                MessageBox.Show("You are already punched in.", "Punch In");
            }
        }

        private void btnPunchOut_Click(object sender, EventArgs e)
        {
            if (isPunchedIn)
            {
                DateTime now = DateTime.Now;
                punchOutTime = DateTime.Now; // Record the punch out time.
                lblClockOutTime.Text = $"Clock Out Time: {punchOutTime.ToString("HH:mm:ss")}";
                string punchOutString = now.ToString("MM/dd/yyyy HH:mm:ss");
                clockOutTimes.Add(now.ToString("HH:mm:ss"));
                totalHoursWorked.Add("0.00 hours");

                UpdatePunchList(); // Update the list box with punch times.


                TimeSpan hoursWorked = punchOutTime - punchInTime;
                lblTotalHours.Text = $"Total Hours Worked: {hoursWorked.TotalHours:N2} hours";

                MessageBox.Show("You have successfully punched out.", "Punch Out");
                isPunchedIn = false;
                btnPunchIn.Enabled = true; // Enable Punch In button when punched out.
                btnPunchOut.Enabled = false; // Disable Punch Out button when already punched out.
            }
            else
            {
                MessageBox.Show("You cannot punch out without punching in first.", "Punch Out");
            }
        }
        private void UpdatePunchList()
        {

            listBoxDates.Items.Clear();
            listBoxDates.Items.AddRange(dates.ToArray());

            listBoxClockInTimes.Items.Clear();
            listBoxClockInTimes.Items.AddRange(clockInTimes.ToArray());

            listBoxClockOutTimes.Items.Clear();
            listBoxClockOutTimes.Items.AddRange(clockOutTimes.ToArray());

            listBoxTotalHoursWorked.Items.Clear();
            listBoxTotalHoursWorked.Items.AddRange(totalHoursWorked.ToArray());
        }


        private void btnShowData_Click(object sender, EventArgs e)
        {

            // Toggle the visibility of the list boxes when the button is clicked.
            listsVisible = !listsVisible;
            listBoxDates.Visible = listsVisible;
            listBoxClockInTimes.Visible = listsVisible;
            listBoxClockOutTimes.Visible = listsVisible;
            listBoxTotalHoursWorked.Visible = listsVisible;
        }

        private void btnSendCorrection_Click(object sender, EventArgs e)
        {
            if (isPunchedIn)
            {
                MessageBox.Show("You cannot send a correction request while punched in. Please punch out first.", "Send Correction");
            }
            else
            {
                string correctionRequest = txtCorrectionRequest.Text.Trim();

                if (!string.IsNullOrWhiteSpace(correctionRequest))
                {
                    DateTime now = DateTime.Now;
                    string requestString = $"Request Correction: {now.ToString("MM/dd/yyyy HH:mm:ss")} - {correctionRequest}";
                    correctionRequests.Add(requestString);

                    MessageBox.Show("Correction request sent successfully.", "Send Correction");


                    // Clear the correction request TextBox
                    txtCorrectionRequest.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a correction request before sending.", "Send Correction");
                }
            }
        }
        private void txtCorrectionRequest_TextChanged(object sender, EventArgs e)
        {
            // Enable the Send button if the correction request TextBox is not empty, 
            // otherwise, disable it.
            btnSendCorrection.Enabled = !string.IsNullOrWhiteSpace(txtCorrectionRequest.Text);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application when the Exit button is clicked
            Application.Exit();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            // Clear all the lists and update the corresponding list boxes
            dates.Clear();
            clockInTimes.Clear();
            clockOutTimes.Clear();
            totalHoursWorked.Clear();
            correctionRequests.Clear();

            UpdatePunchList(); // Update the punch lists
            
        }
    }
}
    

