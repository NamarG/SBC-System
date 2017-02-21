namespace Sphere_Booking_and_Check_in_System.Session_Managment
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblSlopeID = new System.Windows.Forms.Label();
            this.lblSessionID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(110, 49);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Session ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchBox);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Session ID:";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(78, 23);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(107, 20);
            this.txtSearchBox.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(12, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(204, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEndTime);
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.lblDate);
            this.groupBox2.Controls.Add(this.lblCustomerID);
            this.groupBox2.Controls.Add(this.lblStaffID);
            this.groupBox2.Controls.Add(this.lblSlopeID);
            this.groupBox2.Controls.Add(this.lblSessionID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 225);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session Details:";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(78, 202);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(0, 13);
            this.lblEndTime.TabIndex = 13;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(78, 171);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(0, 13);
            this.lblStartTime.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(78, 142);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 11;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(78, 113);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerID.TabIndex = 10;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(78, 86);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(0, 13);
            this.lblStaffID.TabIndex = 9;
            // 
            // lblSlopeID
            // 
            this.lblSlopeID.AutoSize = true;
            this.lblSlopeID.Location = new System.Drawing.Point(78, 56);
            this.lblSlopeID.Name = "lblSlopeID";
            this.lblSlopeID.Size = new System.Drawing.Size(0, 13);
            this.lblSlopeID.TabIndex = 8;
            // 
            // lblSessionID
            // 
            this.lblSessionID.AutoSize = true;
            this.lblSessionID.Location = new System.Drawing.Point(78, 25);
            this.lblSessionID.Name = "lblSessionID";
            this.lblSessionID.Size = new System.Drawing.Size(0, 13);
            this.lblSessionID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "End Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Start Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Customer ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Staff ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Slope ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Session ID:";
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Session";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblSlopeID;
        private System.Windows.Forms.Label lblSessionID;
    }
}