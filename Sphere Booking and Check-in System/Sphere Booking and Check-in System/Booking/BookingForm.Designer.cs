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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startTimeBox = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textStartTime = new System.Windows.Forms.MaskedTextBox();
            this.textEndTime = new System.Windows.Forms.MaskedTextBox();
            this.slopeComboBox = new System.Windows.Forms.ComboBox();
            this.cusID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.memcheck = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.staffID = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slopeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSet();
            this.sessionTableAdapter = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.SessionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
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
            this.AvLabel.Location = new System.Drawing.Point(204, 77);
            this.AvLabel.Name = "AvLabel";
            this.AvLabel.Size = new System.Drawing.Size(140, 30);
            this.AvLabel.TabIndex = 9;
            this.AvLabel.Text = "Availabilty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Start Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "End Time:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(340, 126);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(189, 55);
            this.search.TabIndex = 16;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.slopeIDDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 231);
            this.dataGridView1.TabIndex = 17;
            // 
            // startTimeBox
            // 
            this.startTimeBox.Location = new System.Drawing.Point(116, 154);
            this.startTimeBox.Mask = "00:00";
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.startTimeBox.Size = new System.Drawing.Size(63, 20);
            this.startTimeBox.TabIndex = 19;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(271, 154);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskedTextBox1.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 30);
            this.label6.TabIndex = 21;
            this.label6.Text = "Booking";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Customer ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Staff ID(op):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Slope ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 582);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Start Time:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 605);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "End Time:";
            // 
            // textStartTime
            // 
            this.textStartTime.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textStartTime.Location = new System.Drawing.Point(134, 581);
            this.textStartTime.Mask = "00:00";
            this.textStartTime.Name = "textStartTime";
            this.textStartTime.Size = new System.Drawing.Size(131, 20);
            this.textStartTime.TabIndex = 27;
            this.textStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // textEndTime
            // 
            this.textEndTime.Location = new System.Drawing.Point(134, 607);
            this.textEndTime.Mask = "00:00";
            this.textEndTime.Name = "textEndTime";
            this.textEndTime.Size = new System.Drawing.Size(131, 20);
            this.textEndTime.TabIndex = 28;
            this.textEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // slopeComboBox
            // 
            this.slopeComboBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.slopeComboBox.FormattingEnabled = true;
            this.slopeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.slopeComboBox.Location = new System.Drawing.Point(134, 531);
            this.slopeComboBox.Name = "slopeComboBox";
            this.slopeComboBox.Size = new System.Drawing.Size(131, 21);
            this.slopeComboBox.TabIndex = 29;
            this.slopeComboBox.Text = "Select Slope....";
            // 
            // cusID
            // 
            this.cusID.Location = new System.Drawing.Point(134, 479);
            this.cusID.Name = "cusID";
            this.cusID.Size = new System.Drawing.Size(131, 20);
            this.cusID.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dateTimePicker2.Location = new System.Drawing.Point(134, 555);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(316, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Required Payment";
            // 
            // memcheck
            // 
            this.memcheck.AutoSize = true;
            this.memcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memcheck.Location = new System.Drawing.Point(337, 531);
            this.memcheck.Name = "memcheck";
            this.memcheck.Size = new System.Drawing.Size(119, 15);
            this.memcheck.TabIndex = 35;
            this.memcheck.Text = "............................";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(316, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "Accepted Payment";
            // 
            // payment
            // 
            this.payment.Location = new System.Drawing.Point(340, 579);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(100, 20);
            this.payment.TabIndex = 37;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(16, 637);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(436, 23);
            this.Submit.TabIndex = 38;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // staffID
            // 
            this.staffID.Location = new System.Drawing.Point(134, 505);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(131, 20);
            this.staffID.TabIndex = 39;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // slopeIDDataGridViewTextBoxColumn
            // 
            this.slopeIDDataGridViewTextBoxColumn.DataPropertyName = "slopeID";
            this.slopeIDDataGridViewTextBoxColumn.HeaderText = "slopeID";
            this.slopeIDDataGridViewTextBoxColumn.Name = "slopeIDDataGridViewTextBoxColumn";
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "startTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "endTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "endTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
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
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(458, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staffID);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.memcheck);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cusID);
            this.Controls.Add(this.slopeComboBox);
            this.Controls.Add(this.textEndTime);
            this.Controls.Add(this.textStartTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.startTimeBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private mainDatabaseDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slopeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox startTimeBox;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox textStartTime;
        private System.Windows.Forms.MaskedTextBox textEndTime;
        private System.Windows.Forms.ComboBox slopeComboBox;
        private System.Windows.Forms.TextBox cusID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label memcheck;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox staffID;
        private System.Windows.Forms.Button button1;
    }
}