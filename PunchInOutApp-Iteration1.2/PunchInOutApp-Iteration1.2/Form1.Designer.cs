namespace PunchInOutApp_Iteration1._2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPunchIn = new System.Windows.Forms.Button();
            this.btnPunchOut = new System.Windows.Forms.Button();
            this.lblClockInTime = new System.Windows.Forms.Label();
            this.lblClockOutTime = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.listBoxClockInTimes = new System.Windows.Forms.ListBox();
            this.listBoxClockOutTimes = new System.Windows.Forms.ListBox();
            this.listBoxTotalHoursWorked = new System.Windows.Forms.ListBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelClockInTimes = new System.Windows.Forms.Label();
            this.labelClockOutTimes = new System.Windows.Forms.Label();
            this.labelTotalHours = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            this.txtCorrectionRequest = new System.Windows.Forms.TextBox();
            this.btnSendCorrection = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPunchIn
            // 
            this.btnPunchIn.Location = new System.Drawing.Point(25, 252);
            this.btnPunchIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPunchIn.Name = "btnPunchIn";
            this.btnPunchIn.Size = new System.Drawing.Size(134, 45);
            this.btnPunchIn.TabIndex = 0;
            this.btnPunchIn.Text = "PUNCH IN";
            this.btnPunchIn.UseVisualStyleBackColor = true;
            this.btnPunchIn.Click += new System.EventHandler(this.btnPunchIn_Click);
            // 
            // btnPunchOut
            // 
            this.btnPunchOut.Location = new System.Drawing.Point(176, 252);
            this.btnPunchOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPunchOut.Name = "btnPunchOut";
            this.btnPunchOut.Size = new System.Drawing.Size(134, 45);
            this.btnPunchOut.TabIndex = 1;
            this.btnPunchOut.Text = "PUNCH OUT";
            this.btnPunchOut.UseVisualStyleBackColor = true;
            this.btnPunchOut.Click += new System.EventHandler(this.btnPunchOut_Click);
            // 
            // lblClockInTime
            // 
            this.lblClockInTime.Location = new System.Drawing.Point(38, 71);
            this.lblClockInTime.Name = "lblClockInTime";
            this.lblClockInTime.Size = new System.Drawing.Size(228, 29);
            this.lblClockInTime.TabIndex = 2;
            this.lblClockInTime.Text = "label1";
            this.lblClockInTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClockOutTime
            // 
            this.lblClockOutTime.Location = new System.Drawing.Point(38, 118);
            this.lblClockOutTime.Name = "lblClockOutTime";
            this.lblClockOutTime.Size = new System.Drawing.Size(228, 29);
            this.lblClockOutTime.TabIndex = 3;
            this.lblClockOutTime.Text = "label1";
            this.lblClockOutTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.Location = new System.Drawing.Point(38, 166);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(228, 29);
            this.lblTotalHours.TabIndex = 4;
            this.lblTotalHours.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(38, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(225, 29);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label1";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 20;
            this.listBoxDates.Location = new System.Drawing.Point(14, 481);
            this.listBoxDates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(156, 544);
            this.listBoxDates.TabIndex = 6;
            // 
            // listBoxClockInTimes
            // 
            this.listBoxClockInTimes.FormattingEnabled = true;
            this.listBoxClockInTimes.ItemHeight = 20;
            this.listBoxClockInTimes.Location = new System.Drawing.Point(187, 481);
            this.listBoxClockInTimes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxClockInTimes.Name = "listBoxClockInTimes";
            this.listBoxClockInTimes.Size = new System.Drawing.Size(154, 544);
            this.listBoxClockInTimes.TabIndex = 7;
            // 
            // listBoxClockOutTimes
            // 
            this.listBoxClockOutTimes.FormattingEnabled = true;
            this.listBoxClockOutTimes.ItemHeight = 20;
            this.listBoxClockOutTimes.Location = new System.Drawing.Point(358, 481);
            this.listBoxClockOutTimes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxClockOutTimes.Name = "listBoxClockOutTimes";
            this.listBoxClockOutTimes.Size = new System.Drawing.Size(160, 544);
            this.listBoxClockOutTimes.TabIndex = 8;
            // 
            // listBoxTotalHoursWorked
            // 
            this.listBoxTotalHoursWorked.FormattingEnabled = true;
            this.listBoxTotalHoursWorked.ItemHeight = 20;
            this.listBoxTotalHoursWorked.Location = new System.Drawing.Point(537, 481);
            this.listBoxTotalHoursWorked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxTotalHoursWorked.Name = "listBoxTotalHoursWorked";
            this.listBoxTotalHoursWorked.Size = new System.Drawing.Size(166, 544);
            this.listBoxTotalHoursWorked.TabIndex = 9;
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(24, 438);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(112, 29);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "Date";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClockInTimes
            // 
            this.labelClockInTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockInTimes.Location = new System.Drawing.Point(207, 438);
            this.labelClockInTimes.Name = "labelClockInTimes";
            this.labelClockInTimes.Size = new System.Drawing.Size(112, 29);
            this.labelClockInTimes.TabIndex = 11;
            this.labelClockInTimes.Text = "Clock In";
            this.labelClockInTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClockOutTimes
            // 
            this.labelClockOutTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClockOutTimes.Location = new System.Drawing.Point(376, 438);
            this.labelClockOutTimes.Name = "labelClockOutTimes";
            this.labelClockOutTimes.Size = new System.Drawing.Size(122, 29);
            this.labelClockOutTimes.TabIndex = 12;
            this.labelClockOutTimes.Text = "Clock Out";
            this.labelClockOutTimes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalHours
            // 
            this.labelTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHours.Location = new System.Drawing.Point(549, 438);
            this.labelTotalHours.Name = "labelTotalHours";
            this.labelTotalHours.Size = new System.Drawing.Size(140, 29);
            this.labelTotalHours.TabIndex = 13;
            this.labelTotalHours.Text = "Total Hours";
            this.labelTotalHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(25, 369);
            this.btnShowData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(135, 42);
            this.btnShowData.TabIndex = 14;
            this.btnShowData.Text = "Punch History";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // txtCorrectionRequest
            // 
            this.txtCorrectionRequest.Location = new System.Drawing.Point(537, 104);
            this.txtCorrectionRequest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorrectionRequest.Multiline = true;
            this.txtCorrectionRequest.Name = "txtCorrectionRequest";
            this.txtCorrectionRequest.Size = new System.Drawing.Size(294, 175);
            this.txtCorrectionRequest.TabIndex = 15;
            // 
            // btnSendCorrection
            // 
            this.btnSendCorrection.Location = new System.Drawing.Point(749, 306);
            this.btnSendCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendCorrection.Name = "btnSendCorrection";
            this.btnSendCorrection.Size = new System.Drawing.Size(82, 29);
            this.btnSendCorrection.TabIndex = 16;
            this.btnSendCorrection.Text = "Send ";
            this.btnSendCorrection.UseVisualStyleBackColor = true;
            this.btnSendCorrection.Click += new System.EventHandler(this.btnSendCorrection_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(737, 961);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 51);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Correction Requests";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Location = new System.Drawing.Point(176, 369);
            this.btnClearHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(119, 42);
            this.btnClearHistory.TabIndex = 19;
            this.btnClearHistory.Text = "Clear History";
            this.btnClearHistory.UseVisualStyleBackColor = true;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(883, 1084);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSendCorrection);
            this.Controls.Add(this.txtCorrectionRequest);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.labelTotalHours);
            this.Controls.Add(this.labelClockOutTimes);
            this.Controls.Add(this.labelClockInTimes);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.listBoxTotalHoursWorked);
            this.Controls.Add(this.listBoxClockOutTimes);
            this.Controls.Add(this.listBoxClockInTimes);
            this.Controls.Add(this.listBoxDates);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblClockOutTime);
            this.Controls.Add(this.lblClockInTime);
            this.Controls.Add(this.btnPunchOut);
            this.Controls.Add(this.btnPunchIn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Punch Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPunchIn;
        private System.Windows.Forms.Button btnPunchOut;
        private System.Windows.Forms.Label lblClockInTime;
        private System.Windows.Forms.Label lblClockOutTime;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.ListBox listBoxClockInTimes;
        private System.Windows.Forms.ListBox listBoxClockOutTimes;
        private System.Windows.Forms.ListBox listBoxTotalHoursWorked;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelClockInTimes;
        private System.Windows.Forms.Label labelClockOutTimes;
        private System.Windows.Forms.Label labelTotalHours;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.TextBox txtCorrectionRequest;
        private System.Windows.Forms.Button btnSendCorrection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearHistory;
    }
}

