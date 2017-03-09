namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    partial class frmFindSession
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApply = new DevComponents.DotNetBar.ButtonX();
            this.calendarView1 = new DevComponents.DotNetBar.Schedule.CalendarView();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxHour = new System.Windows.Forms.ComboBox();
            this.comboBoxMinute = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxMinute);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnApply);
            this.groupBox1.Controls.Add(this.comboBoxHour);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter:";
            // 
            // btnApply
            // 
            this.btnApply.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnApply.Location = new System.Drawing.Point(6, 102);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(188, 23);
            this.btnApply.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // calendarView1
            // 
            this.calendarView1.AutoScrollMinSize = new System.Drawing.Size(252, 980);
            this.calendarView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.calendarView1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.calendarView1.ContainerControlProcessDialogKey = true;
            this.calendarView1.EnableDragCopy = false;
            this.calendarView1.EnableDragDrop = false;
            this.calendarView1.ForeColor = System.Drawing.Color.Black;
            this.calendarView1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.calendarView1.Location = new System.Drawing.Point(219, 13);
            this.calendarView1.MultiUserTabHeight = 21;
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Week;
            this.calendarView1.Size = new System.Drawing.Size(617, 480);
            this.calendarView1.TabIndex = 1;
            this.calendarView1.Text = "calendarView1";
            this.calendarView1.TimeIndicator.BorderColor = System.Drawing.Color.Empty;
            this.calendarView1.TimeIndicator.Tag = null;
            this.calendarView1.TimeSlotDuration = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(16, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Time:";
            // 
            // comboBoxHour
            // 
            this.comboBoxHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxHour.ForeColor = System.Drawing.Color.Black;
            this.comboBoxHour.FormattingEnabled = true;
            this.comboBoxHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxHour.Location = new System.Drawing.Point(73, 21);
            this.comboBoxHour.Name = "comboBoxHour";
            this.comboBoxHour.Size = new System.Drawing.Size(55, 21);
            this.comboBoxHour.TabIndex = 7;
            this.comboBoxHour.Text = "HH";
            // 
            // comboBoxMinute
            // 
            this.comboBoxMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxMinute.ForeColor = System.Drawing.Color.Black;
            this.comboBoxMinute.FormattingEnabled = true;
            this.comboBoxMinute.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.comboBoxMinute.Location = new System.Drawing.Point(139, 21);
            this.comboBoxMinute.Name = "comboBoxMinute";
            this.comboBoxMinute.Size = new System.Drawing.Size(55, 21);
            this.comboBoxMinute.TabIndex = 9;
            this.comboBoxMinute.Text = "MM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comboBox1.Location = new System.Drawing.Point(73, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Limit (<):";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox2.Location = new System.Drawing.Point(73, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Slope:";
            // 
            // frmFindSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 505);
            this.Controls.Add(this.calendarView1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFindSession";
            this.Text = "Find Session";
            this.Load += new System.EventHandler(this.frmFindSession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnApply;
        private DevComponents.DotNetBar.Schedule.CalendarView calendarView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxHour;
        private System.Windows.Forms.ComboBox comboBoxMinute;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
    }
}