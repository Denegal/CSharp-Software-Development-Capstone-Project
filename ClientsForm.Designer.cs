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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.dataView_Clients = new System.Windows.Forms.DataGridView();
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
            this.button_AddClient = new System.Windows.Forms.Button();
            this.button_ViewClient = new System.Windows.Forms.Button();
            this.button_EditClient = new System.Windows.Forms.Button();
            this.button_RemoveClient = new System.Windows.Forms.Button();
            this.Title_Logo = new System.Windows.Forms.PictureBox();
            this.button_Report = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Clients)).BeginInit();
            this.box_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).BeginInit();
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
            this.dataView_Clients.Location = new System.Drawing.Point(47, 230);
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
            this.dataView_Clients.Size = new System.Drawing.Size(892, 573);
            this.dataView_Clients.TabIndex = 7;
            this.dataView_Clients.Layout += new System.Windows.Forms.LayoutEventHandler(this.dataView_Clients_Layout);
            // 
            // label_ClientList
            // 
            this.label_ClientList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ClientList.BackColor = System.Drawing.Color.Transparent;
            this.label_ClientList.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientList.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ClientList.Location = new System.Drawing.Point(319, 155);
            this.label_ClientList.Name = "label_ClientList";
            this.label_ClientList.Size = new System.Drawing.Size(324, 73);
            this.label_ClientList.TabIndex = 9;
            this.label_ClientList.Text = "Client List";
            this.label_ClientList.LocationChanged += new System.EventHandler(this.label_ClientList_LocationChanged);
            // 
            // box_Search
            // 
            this.box_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.box_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.box_Search.BackColor = System.Drawing.Color.Transparent;
            this.box_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.box_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.box_Search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.box_Search.Location = new System.Drawing.Point(982, 235);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(440, 345);
            this.box_Search.TabIndex = 10;
            this.box_Search.TabStop = false;
            // 
            // textbox_Email
            // 
            this.textbox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Email.Location = new System.Drawing.Point(145, 139);
            this.textbox_Email.Name = "textbox_Email";
            this.textbox_Email.Size = new System.Drawing.Size(195, 31);
            this.textbox_Email.TabIndex = 25;
            // 
            // textbox_Phone
            // 
            this.textbox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Phone.Location = new System.Drawing.Point(145, 98);
            this.textbox_Phone.Name = "textbox_Phone";
            this.textbox_Phone.Size = new System.Drawing.Size(195, 31);
            this.textbox_Phone.TabIndex = 24;
            // 
            // textbox_LName
            // 
            this.textbox_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_LName.Location = new System.Drawing.Point(145, 57);
            this.textbox_LName.Name = "textbox_LName";
            this.textbox_LName.Size = new System.Drawing.Size(195, 31);
            this.textbox_LName.TabIndex = 23;
            // 
            // textbox_FName
            // 
            this.textbox_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_FName.Location = new System.Drawing.Point(145, 16);
            this.textbox_FName.Name = "textbox_FName";
            this.textbox_FName.Size = new System.Drawing.Size(195, 31);
            this.textbox_FName.TabIndex = 22;
            // 
            // checkbox_Pregnant
            // 
            this.checkbox_Pregnant.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Pregnant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Pregnant.Location = new System.Drawing.Point(178, 282);
            this.checkbox_Pregnant.Name = "checkbox_Pregnant";
            this.checkbox_Pregnant.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Pregnant.TabIndex = 21;
            this.checkbox_Pregnant.TabStop = false;
            this.checkbox_Pregnant.Click += new System.EventHandler(this.checkbox_Pregnant_Click);
            // 
            // checkbox_Medical
            // 
            this.checkbox_Medical.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Medical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Medical.Location = new System.Drawing.Point(176, 235);
            this.checkbox_Medical.Name = "checkbox_Medical";
            this.checkbox_Medical.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Medical.TabIndex = 20;
            this.checkbox_Medical.TabStop = false;
            this.checkbox_Medical.Click += new System.EventHandler(this.checkbox_Medical_Click);
            // 
            // checkbox_Waiver
            // 
            this.checkbox_Waiver.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Waiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Waiver.Location = new System.Drawing.Point(178, 188);
            this.checkbox_Waiver.Name = "checkbox_Waiver";
            this.checkbox_Waiver.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Waiver.TabIndex = 19;
            this.checkbox_Waiver.TabStop = false;
            this.checkbox_Waiver.Click += new System.EventHandler(this.checkbox_Waiver_Click);
            // 
            // button_Search
            // 
            this.button_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Search.AutoSize = true;
            this.button_Search.BackColor = System.Drawing.Color.Transparent;
            this.button_Search.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Search;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Search.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(256, 216);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(178, 87);
            this.button_Search.TabIndex = 18;
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(62, 288);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pregnant:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(7, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Medical Limits:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Waiver on File:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(56, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(53, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Phone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FName.ForeColor = System.Drawing.SystemColors.Control;
            this.label_FName.Location = new System.Drawing.Point(6, 16);
            this.label_FName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(133, 25);
            this.label_FName.TabIndex = 11;
            this.label_FName.Text = "First Name:";
            this.label_FName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_AddClient
            // 
            this.button_AddClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_AddClient.AutoSize = true;
            this.button_AddClient.BackColor = System.Drawing.Color.Transparent;
            this.button_AddClient.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.NewClient;
            this.button_AddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_AddClient.FlatAppearance.BorderSize = 0;
            this.button_AddClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_AddClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_AddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddClient.ForeColor = System.Drawing.Color.White;
            this.button_AddClient.Location = new System.Drawing.Point(1016, 715);
            this.button_AddClient.Name = "button_AddClient";
            this.button_AddClient.Size = new System.Drawing.Size(178, 87);
            this.button_AddClient.TabIndex = 14;
            this.button_AddClient.UseVisualStyleBackColor = false;
            this.button_AddClient.Click += new System.EventHandler(this.button_AddClient_Click);
            // 
            // button_ViewClient
            // 
            this.button_ViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ViewClient.AutoSize = true;
            this.button_ViewClient.BackColor = System.Drawing.Color.Transparent;
            this.button_ViewClient.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.ClientInfo;
            this.button_ViewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ViewClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_ViewClient.FlatAppearance.BorderSize = 0;
            this.button_ViewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_ViewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_ViewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ViewClient.ForeColor = System.Drawing.Color.White;
            this.button_ViewClient.Location = new System.Drawing.Point(1016, 620);
            this.button_ViewClient.Name = "button_ViewClient";
            this.button_ViewClient.Size = new System.Drawing.Size(178, 87);
            this.button_ViewClient.TabIndex = 13;
            this.button_ViewClient.UseVisualStyleBackColor = false;
            this.button_ViewClient.Click += new System.EventHandler(this.button_ViewClient_Click);
            // 
            // button_EditClient
            // 
            this.button_EditClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_EditClient.AutoSize = true;
            this.button_EditClient.BackColor = System.Drawing.Color.Transparent;
            this.button_EditClient.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.EditClient;
            this.button_EditClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_EditClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_EditClient.FlatAppearance.BorderSize = 0;
            this.button_EditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_EditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_EditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EditClient.ForeColor = System.Drawing.Color.White;
            this.button_EditClient.Location = new System.Drawing.Point(1217, 620);
            this.button_EditClient.Name = "button_EditClient";
            this.button_EditClient.Size = new System.Drawing.Size(178, 87);
            this.button_EditClient.TabIndex = 12;
            this.button_EditClient.UseVisualStyleBackColor = false;
            this.button_EditClient.Click += new System.EventHandler(this.button_EditClient_Click);
            // 
            // button_RemoveClient
            // 
            this.button_RemoveClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RemoveClient.AutoSize = true;
            this.button_RemoveClient.BackColor = System.Drawing.Color.Transparent;
            this.button_RemoveClient.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Remove;
            this.button_RemoveClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_RemoveClient.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_RemoveClient.FlatAppearance.BorderSize = 0;
            this.button_RemoveClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_RemoveClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_RemoveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveClient.ForeColor = System.Drawing.Color.White;
            this.button_RemoveClient.Location = new System.Drawing.Point(1217, 715);
            this.button_RemoveClient.Name = "button_RemoveClient";
            this.button_RemoveClient.Size = new System.Drawing.Size(178, 87);
            this.button_RemoveClient.TabIndex = 11;
            this.button_RemoveClient.UseVisualStyleBackColor = false;
            this.button_RemoveClient.Click += new System.EventHandler(this.button_RemoveClient_Click);
            // 
            // Title_Logo
            // 
            this.Title_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title_Logo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Title_Logo.Image = global::Software_Development_Capstone.Properties.Resources.Header;
            this.Title_Logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("Title_Logo.InitialImage")));
            this.Title_Logo.Location = new System.Drawing.Point(0, 0);
            this.Title_Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Title_Logo.Name = "Title_Logo";
            this.Title_Logo.Size = new System.Drawing.Size(1456, 117);
            this.Title_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title_Logo.TabIndex = 1;
            this.Title_Logo.TabStop = false;
            // 
            // button_Report
            // 
            this.button_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Report.AutoSize = true;
            this.button_Report.BackColor = System.Drawing.Color.Transparent;
            this.button_Report.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Report;
            this.button_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Report.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Report.FlatAppearance.BorderSize = 0;
            this.button_Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Report.ForeColor = System.Drawing.Color.White;
            this.button_Report.Location = new System.Drawing.Point(395, 809);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(178, 87);
            this.button_Report.TabIndex = 15;
            this.button_Report.UseVisualStyleBackColor = false;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // ClientsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1455, 932);
            this.ControlBox = false;
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_AddClient);
            this.Controls.Add(this.button_ViewClient);
            this.Controls.Add(this.button_EditClient);
            this.Controls.Add(this.button_RemoveClient);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.label_ClientList);
            this.Controls.Add(this.dataView_Clients);
            this.Controls.Add(this.Title_Logo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Clients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximizedBoundsChanged += new System.EventHandler(this.ClientsForm_SizedChanged);
            this.SizeChanged += new System.EventHandler(this.ClientsForm_SizedChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Clients)).EndInit();
            this.box_Search.ResumeLayout(false);
            this.box_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Title_Logo;
        private System.Windows.Forms.DataGridView dataView_Clients;
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
        private System.Windows.Forms.Button button_Report;
    }
}