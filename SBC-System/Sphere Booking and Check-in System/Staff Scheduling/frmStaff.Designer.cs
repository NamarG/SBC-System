namespace Sphere_Booking_and_Check_in_System.Staff_Scheduling
{
    partial class frmStaff
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndTime = new System.Windows.Forms.MaskedTextBox();
            this.txtStartTime = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.staffSchedulingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDatabaseDataSet = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.staff_SchedulingTableAdapter = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.Staff_SchedulingTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSchedulingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndTime);
            this.groupBox1.Controls.Add(this.txtStartTime);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 131);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter record details:";
            // 
            // txtEndTime
            // 
            this.txtEndTime.Location = new System.Drawing.Point(81, 97);
            this.txtEndTime.Mask = "00:00";
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndTime.TabIndex = 6;
            this.txtEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEndTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(81, 71);
            this.txtStartTime.Mask = "00:00";
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartTime.TabIndex = 5;
            this.txtStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStartTime.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2017, 2, 28, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "End Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Start Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(81, 19);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(87, 20);
            this.txtStaffID.TabIndex = 1;
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(6, 156);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(233, 23);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.bookedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.staffSchedulingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(626, 263);
            this.dataGridView1.TabIndex = 22;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "startTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "startTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "endTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "endTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookedDataGridViewCheckBoxColumn
            // 
            this.bookedDataGridViewCheckBoxColumn.DataPropertyName = "booked";
            this.bookedDataGridViewCheckBoxColumn.HeaderText = "booked";
            this.bookedDataGridViewCheckBoxColumn.Name = "bookedDataGridViewCheckBoxColumn";
            this.bookedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // staffSchedulingBindingSource
            // 
            this.staffSchedulingBindingSource.DataMember = "Staff_Scheduling";
            this.staffSchedulingBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "mainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Red;
            this.btnRefresh.Location = new System.Drawing.Point(526, 175);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 23);
            this.btnRefresh.TabIndex = 23;
            this.btnRefresh.Text = "Manual Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 186);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scheduling Control";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(563, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // staff_SchedulingTableAdapter
            // 
            this.staff_SchedulingTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearchBox);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(265, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 82);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Control";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(78, 23);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(107, 20);
            this.txtSearchBox.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID:";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 479);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Scheduling";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffSchedulingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtEndTime;
        private System.Windows.Forms.MaskedTextBox txtStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBack;
        private mainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource staffSchedulingBindingSource;
        private mainDatabaseDataSetTableAdapters.Staff_SchedulingTableAdapter staff_SchedulingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bookedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
    }
}