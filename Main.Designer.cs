namespace Software_Development_Capstone
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menu_bar = new System.Windows.Forms.MenuStrip();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_bar
            // 
            this.menu_bar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu_bar.Enabled = false;
            this.menu_bar.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homepageToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.financeToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.Size = new System.Drawing.Size(984, 28);
            this.menu_bar.TabIndex = 3;
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.homepageToolStripMenuItem.Text = "Homepage";
            this.homepageToolStripMenuItem.Click += new System.EventHandler(this.homepageToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // financeToolStripMenuItem
            // 
            this.financeToolStripMenuItem.Name = "financeToolStripMenuItem";
            this.financeToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.financeToolStripMenuItem.Text = "Finance";
            this.financeToolStripMenuItem.Click += new System.EventHandler(this.financeToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.removeUserToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            this.removeUserToolStripMenuItem.Click += new System.EventHandler(this.removeUserToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.menu_bar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_bar;
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MC2 Pilates";
            this.menu_bar.ResumeLayout(false);
            this.menu_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu_bar;
        public System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem financeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
    }
}

