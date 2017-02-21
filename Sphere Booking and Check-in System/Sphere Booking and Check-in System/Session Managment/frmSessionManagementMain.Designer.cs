namespace Sphere_Booking_and_Check_in_System.Session_Managment
{
    partial class frmSessionManagementMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCurrentManager = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(1003, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(185, 736);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(177, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "News";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtCurrentManager});
            this.statusStrip1.Location = new System.Drawing.Point(0, 760);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1188, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "Manager Logged in: ";
            // 
            // txtCurrentManager
            // 
            this.txtCurrentManager.Name = "txtCurrentManager";
            this.txtCurrentManager.Size = new System.Drawing.Size(118, 17);
            this.txtCurrentManager.Text = "toolStripStatusLabel2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewSessionToolStripMenuItem,
            this.updateSessionToolStripMenuItem,
            this.deleteSessionToolStripMenuItem,
            this.viewSessionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.toolsToolStripMenuItem.Text = "Session Management";
            // 
            // addNewSessionToolStripMenuItem
            // 
            this.addNewSessionToolStripMenuItem.Name = "addNewSessionToolStripMenuItem";
            this.addNewSessionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addNewSessionToolStripMenuItem.Text = "Add new Session";
            this.addNewSessionToolStripMenuItem.Click += new System.EventHandler(this.addNewSessionToolStripMenuItem_Click);
            // 
            // updateSessionToolStripMenuItem
            // 
            this.updateSessionToolStripMenuItem.Name = "updateSessionToolStripMenuItem";
            this.updateSessionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateSessionToolStripMenuItem.Text = "Update Session";
            this.updateSessionToolStripMenuItem.Click += new System.EventHandler(this.updateSessionToolStripMenuItem_Click);
            // 
            // deleteSessionToolStripMenuItem
            // 
            this.deleteSessionToolStripMenuItem.Name = "deleteSessionToolStripMenuItem";
            this.deleteSessionToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deleteSessionToolStripMenuItem.Text = "Delete Session";
            this.deleteSessionToolStripMenuItem.Click += new System.EventHandler(this.deleteSessionToolStripMenuItem_Click);
            // 
            // viewSessionsToolStripMenuItem
            // 
            this.viewSessionsToolStripMenuItem.Name = "viewSessionsToolStripMenuItem";
            this.viewSessionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewSessionsToolStripMenuItem.Text = "View Sessions";
            this.viewSessionsToolStripMenuItem.Click += new System.EventHandler(this.viewSessionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(177, 710);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Recent Events";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmSessionManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 782);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmSessionManagementMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Management - Dashboard";
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtCurrentManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
    }
}