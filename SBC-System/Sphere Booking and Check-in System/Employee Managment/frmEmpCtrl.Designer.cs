namespace Sphere_Booking_and_Check_in_System.Employee_Managment
{
    partial class frmEmpCtrl
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
            this.mainDatabaseDataSet = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.StaffTableAdapter();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNameT = new System.Windows.Forms.TextBox();
            this.AddLabel = new System.Windows.Forms.Label();
            this.UNameT = new System.Windows.Forms.TextBox();
            this.EmailT = new System.Windows.Forms.TextBox();
            this.PNT = new System.Windows.Forms.TextBox();
            this.AdT = new System.Windows.Forms.TextBox();
            this.LNameT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PWordT = new System.Windows.Forms.TextBox();
            this.PRoleT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddBTN = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.TableAdapterManager();
            this.UpdtBTN = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Rid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Employees";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mainDatabaseDataSet
            // 
            this.mainDatabaseDataSet.DataSetName = "mainDatabaseDataSet";
            this.mainDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.mainDatabaseDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(12, 351);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(978, 313);
            this.staffDataGridView.TabIndex = 3;
            this.staffDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.staffDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "firstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "lastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn4.HeaderText = "address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "phoneNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "phoneNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "emailAddress";
            this.dataGridViewTextBoxColumn6.HeaderText = "emailAddress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn7.HeaderText = "username";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn8.HeaderText = "password";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "preferWork";
            this.dataGridViewTextBoxColumn9.HeaderText = "preferWork";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // FNameT
            // 
            this.FNameT.Location = new System.Drawing.Point(108, 44);
            this.FNameT.Name = "FNameT";
            this.FNameT.Size = new System.Drawing.Size(151, 20);
            this.FNameT.TabIndex = 4;
            // 
            // AddLabel
            // 
            this.AddLabel.AutoSize = true;
            this.AddLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLabel.Location = new System.Drawing.Point(12, 9);
            this.AddLabel.Name = "AddLabel";
            this.AddLabel.Size = new System.Drawing.Size(146, 21);
            this.AddLabel.TabIndex = 5;
            this.AddLabel.Text = "Add New Employee";
            this.AddLabel.Click += new System.EventHandler(this.AddLabel_Click);
            // 
            // UNameT
            // 
            this.UNameT.Location = new System.Drawing.Point(108, 174);
            this.UNameT.Name = "UNameT";
            this.UNameT.Size = new System.Drawing.Size(151, 20);
            this.UNameT.TabIndex = 6;
            // 
            // EmailT
            // 
            this.EmailT.Location = new System.Drawing.Point(108, 148);
            this.EmailT.Name = "EmailT";
            this.EmailT.Size = new System.Drawing.Size(151, 20);
            this.EmailT.TabIndex = 7;
            // 
            // PNT
            // 
            this.PNT.Location = new System.Drawing.Point(108, 122);
            this.PNT.Name = "PNT";
            this.PNT.Size = new System.Drawing.Size(151, 20);
            this.PNT.TabIndex = 8;
            // 
            // AdT
            // 
            this.AdT.Location = new System.Drawing.Point(108, 96);
            this.AdT.Name = "AdT";
            this.AdT.Size = new System.Drawing.Size(151, 20);
            this.AdT.TabIndex = 9;
            // 
            // LNameT
            // 
            this.LNameT.Location = new System.Drawing.Point(108, 70);
            this.LNameT.Name = "LNameT";
            this.LNameT.Size = new System.Drawing.Size(151, 20);
            this.LNameT.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Username";
            // 
            // PWordT
            // 
            this.PWordT.Location = new System.Drawing.Point(108, 200);
            this.PWordT.Name = "PWordT";
            this.PWordT.Size = new System.Drawing.Size(151, 20);
            this.PWordT.TabIndex = 17;
            // 
            // PRoleT
            // 
            this.PRoleT.Location = new System.Drawing.Point(108, 226);
            this.PRoleT.Name = "PRoleT";
            this.PRoleT.Size = new System.Drawing.Size(151, 20);
            this.PRoleT.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Preferred Role";
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(108, 252);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(151, 30);
            this.AddBTN.TabIndex = 21;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 21);
            this.label10.TabIndex = 22;
            this.label10.Text = "Remove Current Entry";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.SessionTableAdapter = null;
            this.tableAdapterManager.SlopeTableAdapter = null;
            this.tableAdapterManager.Staff_SchedulingTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sphere_Booking_and_Check_in_System.mainDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UpdtBTN
            // 
            this.UpdtBTN.Location = new System.Drawing.Point(420, 83);
            this.UpdtBTN.Name = "UpdtBTN";
            this.UpdtBTN.Size = new System.Drawing.Size(151, 30);
            this.UpdtBTN.TabIndex = 39;
            this.UpdtBTN.Text = "Remove";
            this.UpdtBTN.UseVisualStyleBackColor = true;
            this.UpdtBTN.Click += new System.EventHandler(this.UpdtBTN_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(394, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 17);
            this.label18.TabIndex = 29;
            this.label18.Text = "ID";
            // 
            // Rid
            // 
            this.Rid.Location = new System.Drawing.Point(420, 44);
            this.Rid.Name = "Rid";
            this.Rid.Size = new System.Drawing.Size(202, 20);
            this.Rid.TabIndex = 23;
            this.Rid.TextChanged += new System.EventHandler(this.Rid_TextChanged);
            // 
            // frmEmpCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 676);
            this.Controls.Add(this.UpdtBTN);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Rid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PRoleT);
            this.Controls.Add(this.PWordT);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LNameT);
            this.Controls.Add(this.AdT);
            this.Controls.Add(this.PNT);
            this.Controls.Add(this.EmailT);
            this.Controls.Add(this.UNameT);
            this.Controls.Add(this.AddLabel);
            this.Controls.Add(this.FNameT);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "frmEmpCtrl";
            this.Text = "Employee Controls";
            this.Load += new System.EventHandler(this.frmEmpCtrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private mainDatabaseDataSet mainDatabaseDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private mainDatabaseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox FNameT;
        private System.Windows.Forms.Label AddLabel;
        private System.Windows.Forms.TextBox UNameT;
        private System.Windows.Forms.TextBox EmailT;
        private System.Windows.Forms.TextBox PNT;
        private System.Windows.Forms.TextBox AdT;
        private System.Windows.Forms.TextBox LNameT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PWordT;
        private System.Windows.Forms.TextBox PRoleT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.Label label10;
        private mainDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button UpdtBTN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Rid;
    }
}