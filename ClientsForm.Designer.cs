namespace Software_Development_Capstone
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Title_Logo = new System.Windows.Forms.PictureBox();
            this.dataView_Clients = new System.Windows.Forms.DataGridView();
            this.button_SaveReport = new System.Windows.Forms.Button();
            this.label_ClientList = new System.Windows.Forms.Label();
            this.box_Search = new System.Windows.Forms.GroupBox();
            this.textbox_Email = new System.Windows.Forms.TextBox();
            this.textbox_Phone = new System.Windows.Forms.TextBox();
            this.textbox_LName = new System.Windows.Forms.TextBox();
            this.textbox_FName = new System.Windows.Forms.TextBox();
            this.checkbox_Pregnant = new System.Windows.Forms.PictureBox();
            this.checkbox_Medical = new System.Windows.Forms.PictureBox();
            this.checkbox_Waiver = new System.Windows.Forms.PictureBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_FName = new System.Windows.Forms.Label();
            this.button_RemoveClient = new System.Windows.Forms.Button();
            this.button_EditClient = new System.Windows.Forms.Button();
            this.button_ViewClient = new System.Windows.Forms.Button();
            this.button_AddClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Clients)).BeginInit();
            this.box_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).BeginInit();
            this.SuspendLayout();
            // 
            // Title_Logo
            // 
            this.Title_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Logo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Title_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Title_Logo.Image")));
            this.Title_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Title_Logo.InitialImage")));
            this.Title_Logo.Location = new System.Drawing.Point(0, 0);
            this.Title_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Title_Logo.Name = "Title_Logo";
            this.Title_Logo.Size = new System.Drawing.Size(1481, 117);
            this.Title_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title_Logo.TabIndex = 1;
            this.Title_Logo.TabStop = false;
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
            this.dataView_Clients.Location = new System.Drawing.Point(47, 237);
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
            this.dataView_Clients.Size = new System.Drawing.Size(917, 598);
            this.dataView_Clients.TabIndex = 7;
            // 
            // button_SaveReport
            // 
            this.button_SaveReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_SaveReport.AutoSize = true;
            this.button_SaveReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_SaveReport.BackgroundImage")));
            this.button_SaveReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_SaveReport.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_SaveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveReport.ForeColor = System.Drawing.Color.White;
            this.button_SaveReport.Location = new System.Drawing.Point(396, 841);
            this.button_SaveReport.Name = "button_SaveReport";
            this.button_SaveReport.Size = new System.Drawing.Size(178, 87);
            this.button_SaveReport.TabIndex = 8;
            this.button_SaveReport.UseVisualStyleBackColor = true;
            // 
            // label_ClientList
            // 
            this.label_ClientList.AutoSize = true;
            this.label_ClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientList.Location = new System.Drawing.Point(319, 161);
            this.label_ClientList.Name = "label_ClientList";
            this.label_ClientList.Size = new System.Drawing.Size(324, 73);
            this.label_ClientList.TabIndex = 9;
            this.label_ClientList.Text = "Client List";
            // 
            // box_Search
            // 
            this.box_Search.Controls.Add(this.textbox_Email);
            this.box_Search.Controls.Add(this.textbox_Phone);
            this.box_Search.Controls.Add(this.textbox_LName);
            this.box_Search.Controls.Add(this.textbox_FName);
            this.box_Search.Controls.Add(this.checkbox_Pregnant);
            this.box_Search.Controls.Add(this.checkbox_Medical);
            this.box_Search.Controls.Add(this.checkbox_Waiver);
            this.box_Search.Controls.Add(this.button_Search);
            this.box_Search.Controls.Add(this.label6);
            this.box_Search.Controls.Add(this.label5);
            this.box_Search.Controls.Add(this.label4);
            this.box_Search.Controls.Add(this.label3);
            this.box_Search.Controls.Add(this.label2);
            this.box_Search.Controls.Add(this.label1);
            this.box_Search.Controls.Add(this.label_FName);
            this.box_Search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.box_Search.Location = new System.Drawing.Point(1067, 237);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(379, 500);
            this.box_Search.TabIndex = 10;
            this.box_Search.TabStop = false;
            // 
            // textbox_Email
            // 
            this.textbox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Email.Location = new System.Drawing.Point(178, 139);
            this.textbox_Email.Name = "textbox_Email";
            this.textbox_Email.Size = new System.Drawing.Size(195, 31);
            this.textbox_Email.TabIndex = 25;
            // 
            // textbox_Phone
            // 
            this.textbox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Phone.Location = new System.Drawing.Point(178, 98);
            this.textbox_Phone.Name = "textbox_Phone";
            this.textbox_Phone.Size = new System.Drawing.Size(195, 31);
            this.textbox_Phone.TabIndex = 24;
            // 
            // textbox_LName
            // 
            this.textbox_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_LName.Location = new System.Drawing.Point(178, 57);
            this.textbox_LName.Name = "textbox_LName";
            this.textbox_LName.Size = new System.Drawing.Size(195, 31);
            this.textbox_LName.TabIndex = 23;
            // 
            // textbox_FName
            // 
            this.textbox_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_FName.Location = new System.Drawing.Point(178, 16);
            this.textbox_FName.Name = "textbox_FName";
            this.textbox_FName.Size = new System.Drawing.Size(195, 31);
            this.textbox_FName.TabIndex = 22;
            // 
            // checkbox_Pregnant
            // 
            this.checkbox_Pregnant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkbox_Pregnant.BackgroundImage")));
            this.checkbox_Pregnant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Pregnant.Location = new System.Drawing.Point(220, 325);
            this.checkbox_Pregnant.Name = "checkbox_Pregnant";
            this.checkbox_Pregnant.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Pregnant.TabIndex = 21;
            this.checkbox_Pregnant.TabStop = false;
            // 
            // checkbox_Medical
            // 
            this.checkbox_Medical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkbox_Medical.BackgroundImage")));
            this.checkbox_Medical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Medical.Location = new System.Drawing.Point(221, 271);
            this.checkbox_Medical.Name = "checkbox_Medical";
            this.checkbox_Medical.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Medical.TabIndex = 20;
            this.checkbox_Medical.TabStop = false;
            // 
            // checkbox_Waiver
            // 
            this.checkbox_Waiver.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Waiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Waiver.Location = new System.Drawing.Point(221, 220);
            this.checkbox_Waiver.Name = "checkbox_Waiver";
            this.checkbox_Waiver.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Waiver.TabIndex = 19;
            this.checkbox_Waiver.TabStop = false;
            // 
            // button_Search
            // 
            this.button_Search.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Search.AutoSize = true;
            this.button_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_Search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Search.BackgroundImage")));
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Search.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(195, 407);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(178, 87);
            this.button_Search.TabIndex = 18;
            this.button_Search.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(73, 325);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 31);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pregnant:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Medical Limits:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Waiver on File:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(77, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_FName.Location = new System.Drawing.Point(6, 16);
            this.label_FName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(166, 31);
            this.label_FName.TabIndex = 11;
            this.label_FName.Text = "First Name:";
            this.label_FName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_RemoveClient
            // 
            this.button_RemoveClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_RemoveClient.AutoSize = true;
            this.button_RemoveClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_RemoveClient.BackgroundImage")));
            this.button_RemoveClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_RemoveClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_RemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveClient.ForeColor = System.Drawing.Color.White;
            this.button_RemoveClient.Location = new System.Drawing.Point(1262, 841);
            this.button_RemoveClient.Name = "button_RemoveClient";
            this.button_RemoveClient.Size = new System.Drawing.Size(178, 87);
            this.button_RemoveClient.TabIndex = 11;
            this.button_RemoveClient.UseVisualStyleBackColor = true;
            // 
            // button_EditClient
            // 
            this.button_EditClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_EditClient.AutoSize = true;
            this.button_EditClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_EditClient.BackgroundImage")));
            this.button_EditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_EditClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_EditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditClient.ForeColor = System.Drawing.Color.White;
            this.button_EditClient.Location = new System.Drawing.Point(1262, 748);
            this.button_EditClient.Name = "button_EditClient";
            this.button_EditClient.Size = new System.Drawing.Size(178, 87);
            this.button_EditClient.TabIndex = 12;
            this.button_EditClient.UseVisualStyleBackColor = true;
            // 
            // button_ViewClient
            // 
            this.button_ViewClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_ViewClient.AutoSize = true;
            this.button_ViewClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ViewClient.BackgroundImage")));
            this.button_ViewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ViewClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ViewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ViewClient.ForeColor = System.Drawing.Color.White;
            this.button_ViewClient.Location = new System.Drawing.Point(1061, 748);
            this.button_ViewClient.Name = "button_ViewClient";
            this.button_ViewClient.Size = new System.Drawing.Size(178, 87);
            this.button_ViewClient.TabIndex = 13;
            this.button_ViewClient.UseVisualStyleBackColor = true;
            // 
            // button_AddClient
            // 
            this.button_AddClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_AddClient.AutoSize = true;
            this.button_AddClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddClient.BackgroundImage")));
            this.button_AddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_AddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddClient.ForeColor = System.Drawing.Color.White;
            this.button_AddClient.Location = new System.Drawing.Point(1061, 841);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(178, 87);
            this.button_AddClient.TabIndex = 14;
            this.button_AddClient.UseVisualStyleBackColor = true;
            // 
            // ClientsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(116)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1480, 957);
            this.ControlBox = false;
            this.Controls.Add(this.button_AddClient);
            this.Controls.Add(this.button_ViewClient);
            this.Controls.Add(this.button_EditClient);
            this.Controls.Add(this.button_RemoveClient);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.label_ClientList);
            this.Controls.Add(this.button_SaveReport);
            this.Controls.Add(this.dataView_Clients);
            this.Controls.Add(this.Title_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Title_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Clients)).EndInit();
            this.box_Search.ResumeLayout(false);
            this.box_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Title_Logo;
        private System.Windows.Forms.DataGridView dataView_Clients;
        private System.Windows.Forms.Button button_SaveReport;
        private System.Windows.Forms.Label label_ClientList;
        private System.Windows.Forms.GroupBox box_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.PictureBox checkbox_Pregnant;
        private System.Windows.Forms.PictureBox checkbox_Medical;
        private System.Windows.Forms.PictureBox checkbox_Waiver;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textbox_FName;
        private System.Windows.Forms.TextBox textbox_Email;
        private System.Windows.Forms.TextBox textbox_Phone;
        private System.Windows.Forms.TextBox textbox_LName;
        private System.Windows.Forms.Button button_RemoveClient;
        private System.Windows.Forms.Button button_EditClient;
        private System.Windows.Forms.Button button_ViewClient;
        private System.Windows.Forms.Button button_AddClient;
    }
}