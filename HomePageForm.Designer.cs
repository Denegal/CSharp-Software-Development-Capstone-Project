namespace Software_Development_Capstone
{
    partial class HomePageForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.dataView_Clients = new System.Windows.Forms.DataGridView();
            this.button_AddClient = new System.Windows.Forms.Button();
            this.button_checkin = new System.Windows.Forms.Button();
            this.button_Finance = new System.Windows.Forms.Button();
            this.button_Clients = new System.Windows.Forms.Button();
            this.Title_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Clients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView_Clients
            // 
            this.dataView_Clients.AllowUserToAddRows = false;
            this.dataView_Clients.AllowUserToDeleteRows = false;
            this.dataView_Clients.AllowUserToResizeColumns = false;
            this.dataView_Clients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataView_Clients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView_Clients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView_Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataView_Clients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView_Clients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_Clients.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataView_Clients.Location = new System.Drawing.Point(71, 165);
            this.dataView_Clients.MultiSelect = false;
            this.dataView_Clients.Name = "dataView_Clients";
            this.dataView_Clients.ReadOnly = true;
            this.dataView_Clients.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataView_Clients.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataView_Clients.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView_Clients.RowTemplate.DividerHeight = 2;
            this.dataView_Clients.RowTemplate.Height = 35;
            this.dataView_Clients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataView_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView_Clients.Size = new System.Drawing.Size(918, 548);
            this.dataView_Clients.TabIndex = 6;
            // 
            // button_AddClient
            // 
            this.button_AddClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_AddClient.AutoSize = true;
            this.button_AddClient.BackColor = System.Drawing.Color.Transparent;
            this.button_AddClient.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.NewClient;
            this.button_AddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_AddClient.FlatAppearance.BorderSize = 0;
            this.button_AddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddClient.ForeColor = System.Drawing.Color.White;
            this.button_AddClient.Location = new System.Drawing.Point(322, 743);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(178, 87);
            this.button_AddClient.TabIndex = 7;
            this.button_AddClient.UseVisualStyleBackColor = false;
            this.button_AddClient.Click += new System.EventHandler(this.button_AddClient_Click);
            // 
            // button_checkin
            // 
            this.button_checkin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_checkin.AutoSize = true;
            this.button_checkin.BackColor = System.Drawing.Color.Transparent;
            this.button_checkin.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Checkin;
            this.button_checkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_checkin.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_checkin.FlatAppearance.BorderSize = 0;
            this.button_checkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkin.ForeColor = System.Drawing.Color.White;
            this.button_checkin.Location = new System.Drawing.Point(543, 743);
            this.button_checkin.Name = "button_checkin";
            this.button_checkin.Size = new System.Drawing.Size(178, 87);
            this.button_checkin.TabIndex = 4;
            this.button_checkin.UseVisualStyleBackColor = false;
            this.button_checkin.Click += new System.EventHandler(this.button_checkin_Click);
            // 
            // button_Finance
            // 
            this.button_Finance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Finance.AutoSize = true;
            this.button_Finance.BackColor = System.Drawing.Color.Transparent;
            this.button_Finance.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Finance;
            this.button_Finance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Finance.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Finance.FlatAppearance.BorderSize = 0;
            this.button_Finance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Finance.ForeColor = System.Drawing.Color.White;
            this.button_Finance.Location = new System.Drawing.Point(1094, 323);
            this.button_Finance.Name = "button_Finance";
            this.button_Finance.Size = new System.Drawing.Size(253, 98);
            this.button_Finance.TabIndex = 2;
            this.button_Finance.UseVisualStyleBackColor = false;
            this.button_Finance.Click += new System.EventHandler(this.button_Finance_Click);
            // 
            // button_Clients
            // 
            this.button_Clients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clients.AutoSize = true;
            this.button_Clients.BackColor = System.Drawing.Color.Transparent;
            this.button_Clients.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Clients;
            this.button_Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Clients.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Clients.FlatAppearance.BorderSize = 0;
            this.button_Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clients.ForeColor = System.Drawing.Color.Transparent;
            this.button_Clients.Location = new System.Drawing.Point(1094, 182);
            this.button_Clients.Name = "button_Clients";
            this.button_Clients.Size = new System.Drawing.Size(253, 103);
            this.button_Clients.TabIndex = 1;
            this.button_Clients.UseVisualStyleBackColor = false;
            this.button_Clients.Click += new System.EventHandler(this.button_Clients_Click);
            // 
            // Title_Logo
            // 
            this.Title_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Logo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Title_Logo.Image = global::Software_Development_Capstone.Properties.Resources.Header;
            this.Title_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Title_Logo.InitialImage")));
            this.Title_Logo.Location = new System.Drawing.Point(0, 0);
            this.Title_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Title_Logo.Name = "Title_Logo";
            this.Title_Logo.Size = new System.Drawing.Size(1431, 117);
            this.Title_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title_Logo.TabIndex = 0;
            this.Title_Logo.TabStop = false;
            // 
            // HomePageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(116)))), ((int)(((byte)(235)))));
            this.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1430, 907);
            this.ControlBox = false;
            this.Controls.Add(this.button_AddClient);
            this.Controls.Add(this.dataView_Clients);
            this.Controls.Add(this.button_checkin);
            this.Controls.Add(this.button_Finance);
            this.Controls.Add(this.button_Clients);
            this.Controls.Add(this.Title_Logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomePageForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Clients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Title_Logo;
        private System.Windows.Forms.Button button_Clients;
        private System.Windows.Forms.Button button_Finance;
        private System.Windows.Forms.Button button_checkin;
        private System.Windows.Forms.DataGridView dataView_Clients;
        private System.Windows.Forms.Button button_AddClient;
    }
}