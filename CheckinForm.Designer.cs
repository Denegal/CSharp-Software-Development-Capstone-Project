namespace Software_Development_Capstone
{
    partial class CheckinForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_Client = new System.Windows.Forms.GroupBox();
            this.ClassCredit = new System.Windows.Forms.Label();
            this.Label_ClientCredit = new System.Windows.Forms.Label();
            this.textbox_MedicalHistory = new System.Windows.Forms.TextBox();
            this.textbox_Injuries = new System.Windows.Forms.TextBox();
            this.label_MedicalHistory = new System.Windows.Forms.Label();
            this.label_Injuries = new System.Windows.Forms.Label();
            this.checkbox_Pregnant = new System.Windows.Forms.PictureBox();
            this.checkbox_Medical = new System.Windows.Forms.PictureBox();
            this.checkbox_Waiver = new System.Windows.Forms.PictureBox();
            this.label_Pregnant = new System.Windows.Forms.Label();
            this.label_MedicalCare = new System.Windows.Forms.Label();
            this.label_Waiver = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Cost = new System.Windows.Forms.Label();
            this.textbox_Cost = new System.Windows.Forms.TextBox();
            this.checkbox_Credit = new System.Windows.Forms.PictureBox();
            this.label_PrePaid = new System.Windows.Forms.Label();
            this.button_checkin = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Credit)).BeginInit();
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
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Check-In Client";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 22);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // group_Client
            // 
            this.group_Client.BackColor = System.Drawing.Color.Transparent;
            this.group_Client.Controls.Add(this.ClassCredit);
            this.group_Client.Controls.Add(this.Label_ClientCredit);
            this.group_Client.Controls.Add(this.textbox_MedicalHistory);
            this.group_Client.Controls.Add(this.textbox_Injuries);
            this.group_Client.Controls.Add(this.label_MedicalHistory);
            this.group_Client.Controls.Add(this.label_Injuries);
            this.group_Client.Controls.Add(this.checkbox_Pregnant);
            this.group_Client.Controls.Add(this.checkbox_Medical);
            this.group_Client.Controls.Add(this.checkbox_Waiver);
            this.group_Client.Controls.Add(this.label_Pregnant);
            this.group_Client.Controls.Add(this.label_MedicalCare);
            this.group_Client.Controls.Add(this.label_Waiver);
            this.group_Client.Controls.Add(this.ClientName);
            this.group_Client.Controls.Add(this.label_Name);
            this.group_Client.Location = new System.Drawing.Point(52, 96);
            this.group_Client.Name = "group_Client";
            this.group_Client.Size = new System.Drawing.Size(804, 493);
            this.group_Client.TabIndex = 4;
            this.group_Client.TabStop = false;
            // 
            // ClassCredit
            // 
            this.ClassCredit.AutoSize = true;
            this.ClassCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCredit.ForeColor = System.Drawing.SystemColors.Control;
            this.ClassCredit.Location = new System.Drawing.Point(20, 68);
            this.ClassCredit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.ClassCredit.Name = "ClassCredit";
            this.ClassCredit.Size = new System.Drawing.Size(184, 31);
            this.ClassCredit.TabIndex = 54;
            this.ClassCredit.Text = "Class Credit:";
            this.ClassCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_ClientCredit
            // 
            this.Label_ClientCredit.AutoSize = true;
            this.Label_ClientCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ClientCredit.ForeColor = System.Drawing.SystemColors.Control;
            this.Label_ClientCredit.Location = new System.Drawing.Point(213, 68);
            this.Label_ClientCredit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.Label_ClientCredit.Name = "Label_ClientCredit";
            this.Label_ClientCredit.Size = new System.Drawing.Size(44, 31);
            this.Label_ClientCredit.TabIndex = 55;
            this.Label_ClientCredit.Text = "$0";
            this.Label_ClientCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_MedicalHistory
            // 
            this.textbox_MedicalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_MedicalHistory.Location = new System.Drawing.Point(414, 225);
            this.textbox_MedicalHistory.MaxLength = 250;
            this.textbox_MedicalHistory.Multiline = true;
            this.textbox_MedicalHistory.Name = "textbox_MedicalHistory";
            this.textbox_MedicalHistory.ReadOnly = true;
            this.textbox_MedicalHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_MedicalHistory.Size = new System.Drawing.Size(366, 239);
            this.textbox_MedicalHistory.TabIndex = 53;
            // 
            // textbox_Injuries
            // 
            this.textbox_Injuries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Injuries.Location = new System.Drawing.Point(29, 225);
            this.textbox_Injuries.MaxLength = 250;
            this.textbox_Injuries.Multiline = true;
            this.textbox_Injuries.Name = "textbox_Injuries";
            this.textbox_Injuries.ReadOnly = true;
            this.textbox_Injuries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_Injuries.Size = new System.Drawing.Size(321, 239);
            this.textbox_Injuries.TabIndex = 52;
            // 
            // label_MedicalHistory
            // 
            this.label_MedicalHistory.AutoSize = true;
            this.label_MedicalHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MedicalHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.label_MedicalHistory.Location = new System.Drawing.Point(408, 181);
            this.label_MedicalHistory.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_MedicalHistory.Name = "label_MedicalHistory";
            this.label_MedicalHistory.Size = new System.Drawing.Size(224, 31);
            this.label_MedicalHistory.TabIndex = 47;
            this.label_MedicalHistory.Text = "Medical History:";
            this.label_MedicalHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Injuries
            // 
            this.label_Injuries.AutoSize = true;
            this.label_Injuries.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Injuries.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Injuries.Location = new System.Drawing.Point(26, 184);
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
            this.checkbox_Pregnant.Location = new System.Drawing.Point(464, 123);
            this.checkbox_Pregnant.Name = "checkbox_Pregnant";
            this.checkbox_Pregnant.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Pregnant.TabIndex = 43;
            this.checkbox_Pregnant.TabStop = false;
            // 
            // checkbox_Medical
            // 
            this.checkbox_Medical.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Medical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Medical.Location = new System.Drawing.Point(744, 123);
            this.checkbox_Medical.Name = "checkbox_Medical";
            this.checkbox_Medical.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Medical.TabIndex = 42;
            this.checkbox_Medical.TabStop = false;
            // 
            // checkbox_Waiver
            // 
            this.checkbox_Waiver.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Waiver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Waiver.Location = new System.Drawing.Point(238, 123);
            this.checkbox_Waiver.Name = "checkbox_Waiver";
            this.checkbox_Waiver.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Waiver.TabIndex = 41;
            this.checkbox_Waiver.TabStop = false;
            // 
            // label_Pregnant
            // 
            this.label_Pregnant.AutoSize = true;
            this.label_Pregnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pregnant.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Pregnant.Location = new System.Drawing.Point(317, 123);
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
            this.label_MedicalCare.Location = new System.Drawing.Point(544, 123);
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
            this.label_Waiver.Location = new System.Drawing.Point(23, 123);
            this.label_Waiver.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Waiver.Name = "label_Waiver";
            this.label_Waiver.Size = new System.Drawing.Size(209, 31);
            this.label_Waiver.TabIndex = 38;
            this.label_Waiver.Text = "Waiver on File:";
            this.label_Waiver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName.ForeColor = System.Drawing.SystemColors.Control;
            this.ClientName.Location = new System.Drawing.Point(20, 16);
            this.ClientName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(183, 31);
            this.ClientName.TabIndex = 26;
            this.ClientName.Text = "Client Name:";
            this.ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Name.Location = new System.Drawing.Point(210, 16);
            this.label_Name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(127, 31);
            this.label_Name.TabIndex = 27;
            this.label_Name.Text = "First Last";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Cost
            // 
            this.label_Cost.AutoSize = true;
            this.label_Cost.BackColor = System.Drawing.Color.Transparent;
            this.label_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cost.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Cost.Location = new System.Drawing.Point(72, 617);
            this.label_Cost.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(166, 31);
            this.label_Cost.TabIndex = 27;
            this.label_Cost.Text = "Class Cost:";
            this.label_Cost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Cost
            // 
            this.textbox_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Cost.Location = new System.Drawing.Point(233, 620);
            this.textbox_Cost.MaxLength = 3;
            this.textbox_Cost.Name = "textbox_Cost";
            this.textbox_Cost.Size = new System.Drawing.Size(95, 31);
            this.textbox_Cost.TabIndex = 31;
            this.textbox_Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_FName_KeyPress);
            // 
            // checkbox_Credit
            // 
            this.checkbox_Credit.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Credit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Credit.Location = new System.Drawing.Point(243, 676);
            this.checkbox_Credit.Name = "checkbox_Credit";
            this.checkbox_Credit.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Credit.TabIndex = 55;
            this.checkbox_Credit.TabStop = false;
            this.checkbox_Credit.Click += new System.EventHandler(this.checkbox_Credit_Click);
            // 
            // label_PrePaid
            // 
            this.label_PrePaid.AutoSize = true;
            this.label_PrePaid.BackColor = System.Drawing.Color.Transparent;
            this.label_PrePaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PrePaid.ForeColor = System.Drawing.SystemColors.Control;
            this.label_PrePaid.Location = new System.Drawing.Point(76, 676);
            this.label_PrePaid.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_PrePaid.Name = "label_PrePaid";
            this.label_PrePaid.Size = new System.Drawing.Size(162, 31);
            this.label_PrePaid.TabIndex = 54;
            this.label_PrePaid.Text = "Use Credit:";
            this.label_PrePaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.button_checkin.Location = new System.Drawing.Point(426, 620);
            this.button_checkin.Name = "button_checkin";
            this.button_checkin.Size = new System.Drawing.Size(178, 87);
            this.button_checkin.TabIndex = 56;
            this.button_checkin.UseVisualStyleBackColor = false;
            this.button_checkin.Click += new System.EventHandler(this.button_checkin_Click);
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
            this.button_Cancel.Location = new System.Drawing.Point(644, 620);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(193, 87);
            this.button_Cancel.TabIndex = 57;
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // CheckinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(116)))), ((int)(((byte)(235)))));
            this.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Background;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(894, 746);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_checkin);
            this.Controls.Add(this.checkbox_Credit);
            this.Controls.Add(this.textbox_Cost);
            this.Controls.Add(this.label_PrePaid);
            this.Controls.Add(this.label_Cost);
            this.Controls.Add(this.group_Client);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckinForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_Client.ResumeLayout(false);
            this.group_Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Pregnant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Medical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Waiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Credit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox group_Client;
        private System.Windows.Forms.TextBox textbox_MedicalHistory;
        private System.Windows.Forms.TextBox textbox_Injuries;
        private System.Windows.Forms.Label label_MedicalHistory;
        private System.Windows.Forms.Label label_Injuries;
        private System.Windows.Forms.PictureBox checkbox_Pregnant;
        private System.Windows.Forms.PictureBox checkbox_Medical;
        private System.Windows.Forms.PictureBox checkbox_Waiver;
        private System.Windows.Forms.Label label_Pregnant;
        private System.Windows.Forms.Label label_MedicalCare;
        private System.Windows.Forms.Label label_Waiver;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.Label ClassCredit;
        private System.Windows.Forms.Label Label_ClientCredit;
        private System.Windows.Forms.TextBox textbox_Cost;
        private System.Windows.Forms.PictureBox checkbox_Credit;
        private System.Windows.Forms.Label label_PrePaid;
        private System.Windows.Forms.Button button_checkin;
        private System.Windows.Forms.Button button_Cancel;
    }
}