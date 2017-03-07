namespace Sphere_Booking_and_Check_in_System.Scheduling
{
    partial class frmDelete
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
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.TimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.cbopleid = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "End Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Start Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Slope ID:";
            // 
            // TimePickerEnd
            // 
            this.TimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerEnd.Location = new System.Drawing.Point(82, 99);
            this.TimePickerEnd.Name = "TimePickerEnd";
            this.TimePickerEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimePickerEnd.ShowUpDown = true;
            this.TimePickerEnd.Size = new System.Drawing.Size(121, 20);
            this.TimePickerEnd.TabIndex = 52;
            this.TimePickerEnd.Value = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // TimePickerStart
            // 
            this.TimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePickerStart.Location = new System.Drawing.Point(82, 73);
            this.TimePickerStart.Name = "TimePickerStart";
            this.TimePickerStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimePickerStart.ShowUpDown = true;
            this.TimePickerStart.Size = new System.Drawing.Size(121, 20);
            this.TimePickerStart.TabIndex = 51;
            this.TimePickerStart.Value = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // DatePicker
            // 
            this.DatePicker.Location = new System.Drawing.Point(82, 47);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DatePicker.Size = new System.Drawing.Size(121, 20);
            this.DatePicker.TabIndex = 50;
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
            this.cbopleid.Location = new System.Drawing.Point(82, 20);
            this.cbopleid.Name = "cbopleid";
            this.cbopleid.Size = new System.Drawing.Size(121, 21);
            this.cbopleid.TabIndex = 49;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(128, 139);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 53;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 174);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TimePickerEnd);
            this.Controls.Add(this.TimePickerStart);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.cbopleid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "frmDelete";
            this.Text = "frmDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimePickerEnd;
        private System.Windows.Forms.DateTimePicker TimePickerStart;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ComboBox cbopleid;
        private System.Windows.Forms.Button BtnDelete;
    }
}