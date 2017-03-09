namespace Sphere_Booking_and_Check_in_System.Session_Managment.V2
{
    partial class frmManagerLogin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.btnRecovery = new DevComponents.DotNetBar.ButtonX();
            this.btnBack = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 83);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please login to continue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(76, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(151, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(76, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(151, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.Location = new System.Drawing.Point(34, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(186, 23);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRecovery
            // 
            this.btnRecovery.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRecovery.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRecovery.Location = new System.Drawing.Point(130, 129);
            this.btnRecovery.Name = "btnRecovery";
            this.btnRecovery.Size = new System.Drawing.Size(90, 23);
            this.btnRecovery.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRecovery.TabIndex = 17;
            this.btnRecovery.Text = "Recovery";
            this.btnRecovery.Click += new System.EventHandler(this.btnRecovery_Click);
            // 
            // btnBack
            // 
            this.btnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBack.Location = new System.Drawing.Point(34, 129);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 23);
            this.btnBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 162);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRecovery);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManagerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.ButtonX btnRecovery;
        private DevComponents.DotNetBar.ButtonX btnBack;
    }
}