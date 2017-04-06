namespace Sphere_Booking_and_Check_in_System.Scheduling
{
    partial class frmAddNew
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
            this.button1 = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.cbopleid = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 44;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(78, 23);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatePicker.Size = new System.Drawing.Size(121, 20);
            this.DatePicker.TabIndex = 43;
            this.DatePicker.Value = new System.DateTime(2017, 2, 28, 20, 0, 57, 0);
            // 
            // cbopleid
            // 
            this.cbopleid.FormattingEnabled = true;
            this.cbopleid.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbopleid.Location = new System.Drawing.Point(78, 101);
            this.cbopleid.Name = "cbopleid";
            this.cbopleid.Size = new System.Drawing.Size(121, 21);
            this.cbopleid.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "End Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Staff ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Slope ID:";
            // 
            // TimePickerStart
            // 
            this.TimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerStart.Location = new System.Drawing.Point(78, 49);
            this.TimePickerStart.Name = "TimePickerStart";
            this.TimePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimePickerStart.ShowUpDown = true;
            this.TimePickerStart.Size = new System.Drawing.Size(121, 20);
            this.TimePickerStart.TabIndex = 47;
            this.TimePickerStart.Value = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerEnd.Location = new System.Drawing.Point(78, 75);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimePickerEnd.ShowUpDown = true;
            this.TimePickerEnd.Size = new System.Drawing.Size(121, 20);
            this.TimePickerEnd.TabIndex = 48;
            this.TimePickerEnd.Value = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(78, 128);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(121, 20);
            this.txtStaff.TabIndex = 50;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "check";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 193);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.TimePickerEnd);
            this.Controls.Add(this.TimePickerStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.cbopleid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmAddNew";
            this.Text = "frmAddNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox cbopleid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TimePickerStart;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}