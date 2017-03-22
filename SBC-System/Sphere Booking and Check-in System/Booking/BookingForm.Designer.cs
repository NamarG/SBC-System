namespace Sphere_Booking_and_Check_in_System.Booking
{
    partial class BookingForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.checkId = new System.Windows.Forms.Button();
            this.checkEmail = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.AvLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cusidBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.memcheck = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.staffschBox = new System.Windows.Forms.TextBox();
            this.sessionTableAdapter = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.SessionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sessionBox = new System.Windows.Forms.TextBox();
            this.fKBookingSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.BookingTableAdapter();
            this.staffSchedulingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staff_SchedulingTableAdapter = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.Staff_SchedulingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBookingSessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSchedulingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checking Cusomer ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Checking Cusomer Email: ";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(244, 9);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(122, 20);
            this.idBox.TabIndex = 2;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(244, 38);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(122, 20);
            this.emailBox.TabIndex = 3;
            // 
            // checkId
            // 
            this.checkId.Location = new System.Drawing.Point(373, 9);
            this.checkId.Name = "checkId";
            this.checkId.Size = new System.Drawing.Size(75, 23);
            this.checkId.TabIndex = 4;
            this.checkId.Text = "Check";
            this.checkId.UseVisualStyleBackColor = true;
            this.checkId.Click += new System.EventHandler(this.CheckId_Click);
            // 
            // checkEmail
            // 
            this.checkEmail.Location = new System.Drawing.Point(373, 35);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(75, 23);
            this.checkEmail.TabIndex = 5;
            this.checkEmail.Text = "Check";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.Click += new System.EventHandler(this.checkEmail_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(455, 18);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 13);
            this.idLabel.TabIndex = 6;
            this.idLabel.Text = ".......";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(455, 43);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(28, 13);
            this.emailLabel.TabIndex = 7;
            this.emailLabel.Text = ".......";
            // 
            // AvLabel
            // 
            this.AvLabel.AutoSize = true;
            this.AvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvLabel.Location = new System.Drawing.Point(149, 135);
            this.AvLabel.Name = "AvLabel";
            this.AvLabel.Size = new System.Drawing.Size(246, 30);
            this.AvLabel.TabIndex = 9;
            this.AvLabel.Text = "Session Availabilty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(328, 165);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(200, 23);
            this.search.TabIndex = 16;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(519, 185);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sessionBindingSource
            // 
            this.sessionBindingSource.DataMember = "Session";
            this.sessionBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "mainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 21;
            this.label6.Text = "Booking";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 560);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Customer ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Staff Schedule ID:";
            // 
            // cusidBox
            // 
            this.cusidBox.Location = new System.Drawing.Point(183, 562);
            this.cusidBox.Name = "cusidBox";
            this.cusidBox.Size = new System.Drawing.Size(84, 20);
            this.cusidBox.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(311, 585);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Required Payment:";
            // 
            // memcheck
            // 
            this.memcheck.AutoSize = true;
            this.memcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memcheck.Location = new System.Drawing.Point(347, 605);
            this.memcheck.Name = "memcheck";
            this.memcheck.Size = new System.Drawing.Size(83, 15);
            this.memcheck.TabIndex = 35;
            this.memcheck.Text = "...................";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(9, 635);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(432, 23);
            this.Submit.TabIndex = 38;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // staffschBox
            // 
            this.staffschBox.Location = new System.Drawing.Point(183, 609);
            this.staffschBox.Name = "staffschBox";
            this.staffschBox.Size = new System.Drawing.Size(84, 20);
            this.staffschBox.TabIndex = 39;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(447, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 64);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(519, 68);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(16, 415);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(510, 111);
            this.dataGridView3.TabIndex = 42;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 30);
            this.label4.TabIndex = 43;
            this.label4.Text = "Staff Availabilty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 585);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Session ID:";
            // 
            // sessionBox
            // 
            this.sessionBox.Location = new System.Drawing.Point(183, 585);
            this.sessionBox.Name = "sessionBox";
            this.sessionBox.Size = new System.Drawing.Size(84, 20);
            this.sessionBox.TabIndex = 45;
            // 
            // fKBookingSessionBindingSource
            // 
            this.fKBookingSessionBindingSource.DataMember = "FK_Booking_Session";
            this.fKBookingSessionBindingSource.DataSource = this.sessionBindingSource;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // staffSchedulingBindingSource
            // 
            this.staffSchedulingBindingSource.DataMember = "Staff_Scheduling";
            this.staffSchedulingBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // staff_SchedulingTableAdapter
            // 
            this.staff_SchedulingTableAdapter.ClearBeforeFill = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 667);
            this.Controls.Add(this.sessionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staffschBox);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.memcheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cusidBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AvLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.checkId);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKBookingSessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSchedulingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button checkId;
        private System.Windows.Forms.Button checkEmail;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label AvLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private mainDatabaseDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cusidBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label memcheck;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox staffschBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sessionBox;
        private System.Windows.Forms.BindingSource fKBookingSessionBindingSource;
        private mainDatabaseDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource staffSchedulingBindingSource;
        private mainDatabaseDataSetTableAdapters.Staff_SchedulingTableAdapter staff_SchedulingTableAdapter;
    }
}