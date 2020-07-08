namespace Software_Development_Capstone
{
    partial class AddEditClient
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
            this.label_Title = new System.Windows.Forms.Label();
            this.group_Client = new System.Windows.Forms.GroupBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.combo_History = new System.Windows.Forms.ComboBox();
            this.textbox_MedicalHistory = new System.Windows.Forms.TextBox();
            this.checkbox_History = new System.Windows.Forms.PictureBox();
            this.label_MedicalHistory = new System.Windows.Forms.Label();
            this.textbox_Injuries = new System.Windows.Forms.TextBox();
            this.checkbox_Injury = new System.Windows.Forms.PictureBox();
            this.label_Injuries = new System.Windows.Forms.Label();
            this.checkbox_Pregnant = new System.Windows.Forms.PictureBox();
            this.checkbox_Medical = new System.Windows.Forms.PictureBox();
            this.checkbox_Waiver = new System.Windows.Forms.PictureBox();
            this.label_Pregnant = new System.Windows.Forms.Label();
            this.label_MedicalCare = new System.Windows.Forms.Label();
            this.label_Waiver = new System.Windows.Forms.Label();
            this.textbox_EContactPhone = new System.Windows.Forms.TextBox();
            this.label_EContactPhone = new System.Windows.Forms.Label();
            this.label_EContact = new System.Windows.Forms.Label();
            this.textbox_EContact = new System.Windows.Forms.TextBox();
            this.textbox_Email = new System.Windows.Forms.TextBox();
            this.label_FName = new System.Windows.Forms.Label();
            this.textbox_Phone = new System.Windows.Forms.TextBox();
            this.label_LName = new System.Windows.Forms.Label();
            this.textbox_LName = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textbox_FName = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_History)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Injury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.Black;
            this.label_Title.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Title.Location = new System.Drawing.Point(0, 22);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(893, 71);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "New Client";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_Client
            // 
            this.group_Client.BackColor = System.Drawing.Color.Transparent;
            this.group_Client.Controls.Add(this.button_Remove);
            this.group_Client.Controls.Add(this.button_Add);
            this.group_Client.Controls.Add(this.combo_History);
            this.group_Client.Controls.Add(this.textbox_MedicalHistory);
            this.group_Client.Controls.Add(this.checkbox_History);
            this.group_Client.Controls.Add(this.label_MedicalHistory);
            this.group_Client.Controls.Add(this.textbox_Injuries);
            this.group_Client.Controls.Add(this.checkbox_Injury);
            this.group_Client.Controls.Add(this.label_Injuries);
            this.group_Client.Controls.Add(this.checkbox_Pregnant);
            this.group_Client.Controls.Add(this.checkbox_Medical);
            this.group_Client.Controls.Add(this.checkbox_Waiver);
            this.group_Client.Controls.Add(this.label_Pregnant);
            this.group_Client.Controls.Add(this.label_MedicalCare);
            this.group_Client.Controls.Add(this.label_Waiver);
            this.group_Client.Controls.Add(this.textbox_EContactPhone);
            this.group_Client.Controls.Add(this.label_EContactPhone);
            this.group_Client.Controls.Add(this.label_EContact);
            this.group_Client.Controls.Add(this.textbox_EContact);
            this.group_Client.Controls.Add(this.textbox_Email);
            this.group_Client.Controls.Add(this.label_FName);
            this.group_Client.Controls.Add(this.textbox_Phone);
            this.group_Client.Controls.Add(this.label_LName);
            this.group_Client.Controls.Add(this.textbox_LName);
            this.group_Client.Controls.Add(this.label_Phone);
            this.group_Client.Controls.Add(this.textbox_FName);
            this.group_Client.Controls.Add(this.label_Email);
            this.group_Client.Location = new System.Drawing.Point(51, 104);
            this.group_Client.Name = "group_Client";
            this.group_Client.Size = new System.Drawing.Size(804, 595);
            this.group_Client.TabIndex = 2;
            this.group_Client.TabStop = false;
            // 
            // button_Remove
            // 
            this.button_Remove.Enabled = false;
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(678, 431);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(104, 33);
            this.button_Remove.TabIndex = 52;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Add
            // 
            this.button_Add.Enabled = false;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(594, 431);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(78, 33);
            this.button_Add.TabIndex = 51;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // combo_History
            // 
            this.combo_History.Enabled = false;
            this.combo_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_History.FormattingEnabled = true;
            this.combo_History.Items.AddRange(new object[] {
            "Diabetes",
            "High Blood Pressure",
            "Surgery on Head, Neck, or Spine",
            "Abdominal Surgery",
            "Shoulder Injury",
            "Knee Injury",
            "Ankle Injury",
            "Wrist Injury",
            "Low Back Pain or Injury",
            "Neck Pain or Injury",
            "Fractures",
            "Osteoporosis",
            "Osteoarthritis",
            "Rheumatoid Arthritis",
            "Scoliosis"});
            this.combo_History.Location = new System.Drawing.Point(304, 431);
            this.combo_History.Name = "combo_History";
            this.combo_History.Size = new System.Drawing.Size(277, 33);
            this.combo_History.TabIndex = 50;
            // 
            // textbox_MedicalHistory
            // 
            this.textbox_MedicalHistory.Enabled = false;
            this.textbox_MedicalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_MedicalHistory.Location = new System.Drawing.Point(107, 475);
            this.textbox_MedicalHistory.MaxLength = 250;
            this.textbox_MedicalHistory.Multiline = true;
            this.textbox_MedicalHistory.Name = "textbox_MedicalHistory";
            this.textbox_MedicalHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_MedicalHistory.Size = new System.Drawing.Size(675, 106);
            this.textbox_MedicalHistory.TabIndex = 49;
            // 
            // checkbox_History
            // 
            this.checkbox_History.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_History.Location = new System.Drawing.Point(236, 428);
            this.checkbox_History.Name = "checkbox_History";
            this.checkbox_History.Size = new System.Drawing.Size(41, 41);
            this.checkbox_History.TabIndex = 48;
            this.checkbox_History.TabStop = false;
            this.checkbox_History.Click += new System.EventHandler(this.checkbox_History_Click);
            // 
            // label_MedicalHistory
            // 
            this.label_MedicalHistory.AutoSize = true;
            this.label_MedicalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MedicalHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.label_MedicalHistory.Location = new System.Drawing.Point(6, 428);
            this.label_MedicalHistory.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_MedicalHistory.Name = "label_MedicalHistory";
            this.label_MedicalHistory.Size = new System.Drawing.Size(224, 31);
            this.label_MedicalHistory.TabIndex = 47;
            this.label_MedicalHistory.Text = "Medical History:";
            this.label_MedicalHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Injuries
            // 
            this.textbox_Injuries.Enabled = false;
            this.textbox_Injuries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Injuries.Location = new System.Drawing.Point(107, 328);
            this.textbox_Injuries.MaxLength = 250;
            this.textbox_Injuries.Multiline = true;
            this.textbox_Injuries.Name = "textbox_Injuries";
            this.textbox_Injuries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_Injuries.Size = new System.Drawing.Size(675, 83);
            this.textbox_Injuries.TabIndex = 46;
            // 
            // checkbox_Injury
            // 
            this.checkbox_Injury.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Injury.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Injury.Location = new System.Drawing.Point(221, 281);
            this.checkbox_Injury.Name = "checkbox_Injury";
            this.checkbox_Injury.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Injury.TabIndex = 45;
            this.checkbox_Injury.TabStop = false;
            this.checkbox_Injury.Click += new System.EventHandler(this.checkbox_Injury_Click);
            // 
            // label_Injuries
            // 
            this.label_Injuries.AutoSize = true;
            this.label_Injuries.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Injuries.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Injuries.Location = new System.Drawing.Point(6, 281);
            this.label_Injuries.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Injuries.Name = "label_Injuries";
            this.label_Injuries.Size = new System.Drawing.Size(215, 31);
            this.label_Injuries.TabIndex = 44;
            this.label_Injuries.Text = "Curent Injuries:";
            this.label_Injuries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkbox_Pregnant
            // 
            this.checkbox_Pregnant.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Pregnant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Pregnant.Location = new System.Drawing.Point(461, 214);
            this.checkbox_Pregnant.Name = "checkbox_Pregnant";
            this.checkbox_Pregnant.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Pregnant.TabIndex = 43;
            this.checkbox_Pregnant.TabStop = false;
            this.checkbox_Pregnant.Click += new System.EventHandler(this.checkbox_Pregnant_Click);
            // 
            // checkbox_Medical
            // 
            this.checkbox_Medical.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Medical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Medical.Location = new System.Drawing.Point(741, 214);
            this.checkbox_Medical.Name = "checkbox_Medical";
            this.checkbox_Medical.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Medical.TabIndex = 42;
            this.checkbox_Medical.TabStop = false;
            this.checkbox_Medical.Click += new System.EventHandler(this.checkbox_Medical_Click);
            // 
            // checkbox_Waiver
            // 
            this.checkbox_Waiver.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Waiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Waiver.Location = new System.Drawing.Point(221, 214);
            this.checkbox_Waiver.Name = "checkbox_Waiver";
            this.checkbox_Waiver.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Waiver.TabIndex = 41;
            this.checkbox_Waiver.TabStop = false;
            this.checkbox_Waiver.Click += new System.EventHandler(this.checkbox_Waiver_Click);
            // 
            // label_Pregnant
            // 
            this.label_Pregnant.AutoSize = true;
            this.label_Pregnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pregnant.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Pregnant.Location = new System.Drawing.Point(314, 214);
            this.label_Pregnant.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Pregnant.Name = "label_Pregnant";
            this.label_Pregnant.Size = new System.Drawing.Size(141, 31);
            this.label_Pregnant.TabIndex = 40;
            this.label_Pregnant.Text = "Pregnant:";
            this.label_Pregnant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_MedicalCare
            // 
            this.label_MedicalCare.AutoSize = true;
            this.label_MedicalCare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MedicalCare.ForeColor = System.Drawing.SystemColors.Control;
            this.label_MedicalCare.Location = new System.Drawing.Point(541, 214);
            this.label_MedicalCare.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_MedicalCare.Name = "label_MedicalCare";
            this.label_MedicalCare.Size = new System.Drawing.Size(194, 31);
            this.label_MedicalCare.TabIndex = 39;
            this.label_MedicalCare.Text = "Medical Care:";
            this.label_MedicalCare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Waiver
            // 
            this.label_Waiver.AutoSize = true;
            this.label_Waiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Waiver.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Waiver.Location = new System.Drawing.Point(6, 214);
            this.label_Waiver.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Waiver.Name = "label_Waiver";
            this.label_Waiver.Size = new System.Drawing.Size(209, 31);
            this.label_Waiver.TabIndex = 38;
            this.label_Waiver.Text = "Waiver on File:";
            this.label_Waiver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_EContactPhone
            // 
            this.textbox_EContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_EContactPhone.Location = new System.Drawing.Point(382, 167);
            this.textbox_EContactPhone.MaxLength = 10;
            this.textbox_EContactPhone.Name = "textbox_EContactPhone";
            this.textbox_EContactPhone.Size = new System.Drawing.Size(199, 31);
            this.textbox_EContactPhone.TabIndex = 37;
            this.textbox_EContactPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_EContactPhone_KeyPress);
            // 
            // label_EContactPhone
            // 
            this.label_EContactPhone.AutoSize = true;
            this.label_EContactPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EContactPhone.ForeColor = System.Drawing.SystemColors.Control;
            this.label_EContactPhone.Location = new System.Drawing.Point(6, 164);
            this.label_EContactPhone.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_EContactPhone.Name = "label_EContactPhone";
            this.label_EContactPhone.Size = new System.Drawing.Size(370, 31);
            this.label_EContactPhone.TabIndex = 36;
            this.label_EContactPhone.Text = "Emergency Contact Phone:";
            this.label_EContactPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_EContact
            // 
            this.label_EContact.AutoSize = true;
            this.label_EContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EContact.ForeColor = System.Drawing.SystemColors.Control;
            this.label_EContact.Location = new System.Drawing.Point(6, 116);
            this.label_EContact.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_EContact.Name = "label_EContact";
            this.label_EContact.Size = new System.Drawing.Size(279, 31);
            this.label_EContact.TabIndex = 34;
            this.label_EContact.Text = "Emergency Contact:";
            this.label_EContact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_EContact
            // 
            this.textbox_EContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_EContact.Location = new System.Drawing.Point(291, 119);
            this.textbox_EContact.MaxLength = 50;
            this.textbox_EContact.Name = "textbox_EContact";
            this.textbox_EContact.Size = new System.Drawing.Size(290, 31);
            this.textbox_EContact.TabIndex = 35;
            // 
            // textbox_Email
            // 
            this.textbox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Email.Location = new System.Drawing.Point(519, 56);
            this.textbox_Email.MaxLength = 30;
            this.textbox_Email.Name = "textbox_Email";
            this.textbox_Email.Size = new System.Drawing.Size(263, 31);
            this.textbox_Email.TabIndex = 33;
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FName.ForeColor = System.Drawing.SystemColors.Control;
            this.label_FName.Location = new System.Drawing.Point(6, 16);
            this.label_FName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(166, 31);
            this.label_FName.TabIndex = 26;
            this.label_FName.Text = "First Name:";
            this.label_FName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Phone
            // 
            this.textbox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Phone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_Phone.Location = new System.Drawing.Point(178, 53);
            this.textbox_Phone.MaxLength = 10;
            this.textbox_Phone.Name = "textbox_Phone";
            this.textbox_Phone.Size = new System.Drawing.Size(195, 31);
            this.textbox_Phone.TabIndex = 32;
            this.textbox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Phone_KeyPress);
            // 
            // label_LName
            // 
            this.label_LName.AutoSize = true;
            this.label_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LName.ForeColor = System.Drawing.SystemColors.Control;
            this.label_LName.Location = new System.Drawing.Point(418, 16);
            this.label_LName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(163, 31);
            this.label_LName.TabIndex = 27;
            this.label_LName.Text = "Last Name:";
            this.label_LName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_LName
            // 
            this.textbox_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_LName.Location = new System.Drawing.Point(587, 16);
            this.textbox_LName.MaxLength = 20;
            this.textbox_LName.Name = "textbox_LName";
            this.textbox_LName.Size = new System.Drawing.Size(195, 31);
            this.textbox_LName.TabIndex = 31;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Phone.Location = new System.Drawing.Point(66, 53);
            this.label_Phone.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(106, 31);
            this.label_Phone.TabIndex = 28;
            this.label_Phone.Text = "Phone:";
            this.label_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_FName
            // 
            this.textbox_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_FName.Location = new System.Drawing.Point(178, 16);
            this.textbox_FName.MaxLength = 15;
            this.textbox_FName.Name = "textbox_FName";
            this.textbox_FName.Size = new System.Drawing.Size(195, 31);
            this.textbox_FName.TabIndex = 30;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Email.Location = new System.Drawing.Point(418, 56);
            this.label_Email.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(95, 31);
            this.label_Email.TabIndex = 29;
            this.label_Email.Text = "Email:";
            this.label_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Save.AutoSize = true;
            this.button_Save.BackColor = System.Drawing.Color.Transparent;
            this.button_Save.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.MainSave;
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.Black;
            this.button_Save.Location = new System.Drawing.Point(231, 705);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(193, 87);
            this.button_Save.TabIndex = 15;
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.AutoSize = true;
            this.button_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Cancel;
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(475, 705);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(193, 87);
            this.button_Cancel.TabIndex = 16;
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 22);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AddEditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(116)))), ((int)(((byte)(235)))));
            this.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(894, 794);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.group_Client);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.group_Client.ResumeLayout(false);
            this.group_Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_History)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Injury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox group_Client;
        private System.Windows.Forms.TextBox textbox_Email;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.TextBox textbox_Phone;
        private System.Windows.Forms.Label label_LName;
        private System.Windows.Forms.TextBox textbox_LName;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textbox_FName;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textbox_EContactPhone;
        private System.Windows.Forms.Label label_EContactPhone;
        private System.Windows.Forms.Label label_EContact;
        private System.Windows.Forms.TextBox textbox_EContact;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.ComboBox combo_History;
        private System.Windows.Forms.TextBox textbox_MedicalHistory;
        private System.Windows.Forms.PictureBox checkbox_History;
        private System.Windows.Forms.Label label_MedicalHistory;
        private System.Windows.Forms.TextBox textbox_Injuries;
        private System.Windows.Forms.PictureBox checkbox_Injury;
        private System.Windows.Forms.Label label_Injuries;
        private System.Windows.Forms.PictureBox checkbox_Pregnant;
        private System.Windows.Forms.PictureBox checkbox_Medical;
        private System.Windows.Forms.PictureBox checkbox_Waiver;
        private System.Windows.Forms.Label label_Pregnant;
        private System.Windows.Forms.Label label_MedicalCare;
        private System.Windows.Forms.Label label_Waiver;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
    }
}