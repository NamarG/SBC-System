namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    partial class frmViewSessions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staffID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staffID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            this.staffIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slopeIDDataGridViewTextBoxColumn
            // 
            this.slopeIDDataGridViewTextBoxColumn.DataPropertyName = "slopeID";
            this.slopeIDDataGridViewTextBoxColumn.HeaderText = "slopeID";
            this.slopeIDDataGridViewTextBoxColumn.Name = "slopeIDDataGridViewTextBoxColumn";
            this.slopeIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(656, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmViewSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 463);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmViewSessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Sessions";
            this.Load += new System.EventHandler(this.frmViewSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private mainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource sessionBindingSource;
        private mainDatabaseDataSetTableAdapters.SessionTableAdapter sessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slopeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefresh;
    }
}