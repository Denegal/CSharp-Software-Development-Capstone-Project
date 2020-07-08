namespace Software_Development_Capstone
{
    partial class AddRemoveUser
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
            this.group_User = new System.Windows.Forms.GroupBox();
            this.textbox_Password2 = new System.Windows.Forms.TextBox();
            this.label_Password2 = new System.Windows.Forms.Label();
            this.combo_Username = new System.Windows.Forms.ComboBox();
            this.label_Username = new System.Windows.Forms.Label();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textbox_Username = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.group_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Title.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(502, 71);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Add New User";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_User
            // 
            this.group_User.BackColor = System.Drawing.Color.Transparent;
            this.group_User.Controls.Add(this.textbox_Password2);
            this.group_User.Controls.Add(this.label_Password2);
            this.group_User.Controls.Add(this.combo_Username);
            this.group_User.Controls.Add(this.label_Username);
            this.group_User.Controls.Add(this.textbox_Password);
            this.group_User.Controls.Add(this.label_Password);
            this.group_User.Controls.Add(this.textbox_Username);
            this.group_User.Location = new System.Drawing.Point(12, 74);
            this.group_User.Name = "group_User";
            this.group_User.Size = new System.Drawing.Size(478, 178);
            this.group_User.TabIndex = 10;
            this.group_User.TabStop = false;
            // 
            // textbox_Password2
            // 
            this.textbox_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Password2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_Password2.Location = new System.Drawing.Point(170, 126);
            this.textbox_Password2.MaxLength = 50;
            this.textbox_Password2.Name = "textbox_Password2";
            this.textbox_Password2.PasswordChar = '*';
            this.textbox_Password2.Size = new System.Drawing.Size(295, 31);
            this.textbox_Password2.TabIndex = 53;
            this.textbox_Password2.UseSystemPasswordChar = true;
            // 
            // label_Password2
            // 
            this.label_Password2.AutoSize = true;
            this.label_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password2.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Password2.Location = new System.Drawing.Point(71, 129);
            this.label_Password2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Password2.Name = "label_Password2";
            this.label_Password2.Size = new System.Drawing.Size(93, 25);
            this.label_Password2.TabIndex = 52;
            this.label_Password2.Text = "Retype:";
            this.label_Password2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combo_Username
            // 
            this.combo_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Username.FormattingEnabled = true;
            this.combo_Username.Items.AddRange(new object[] {
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
            this.combo_Username.Location = new System.Drawing.Point(170, 38);
            this.combo_Username.Name = "combo_Username";
            this.combo_Username.Size = new System.Drawing.Size(295, 33);
            this.combo_Username.TabIndex = 51;
            this.combo_Username.Visible = false;
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Username.Location = new System.Drawing.Point(39, 43);
            this.label_Username.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(125, 25);
            this.label_Username.TabIndex = 26;
            this.label_Username.Text = "Username:";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Password
            // 
            this.textbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Password.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_Password.Location = new System.Drawing.Point(170, 91);
            this.textbox_Password.MaxLength = 50;
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.PasswordChar = '*';
            this.textbox_Password.Size = new System.Drawing.Size(295, 31);
            this.textbox_Password.TabIndex = 32;
            this.textbox_Password.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Password.Location = new System.Drawing.Point(43, 94);
            this.label_Password.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(121, 25);
            this.label_Password.TabIndex = 28;
            this.label_Password.Text = "Password:";
            this.label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Username
            // 
            this.textbox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Username.Location = new System.Drawing.Point(170, 40);
            this.textbox_Username.MaxLength = 50;
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.Size = new System.Drawing.Size(295, 31);
            this.textbox_Username.TabIndex = 30;
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
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(46, 258);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(178, 87);
            this.button_Save.TabIndex = 12;
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
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(267, 258);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(178, 87);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AddRemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 351);
            this.ControlBox = false;
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.group_User);
            this.Controls.Add(this.label_Title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(50, 100);
            this.MaximumSize = new System.Drawing.Size(508, 357);
            this.Name = "AddRemoveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.group_User.ResumeLayout(false);
            this.group_User.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox group_User;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textbox_Username;
        private System.Windows.Forms.ComboBox combo_Username;
        private System.Windows.Forms.TextBox textbox_Password2;
        private System.Windows.Forms.Label label_Password2;
    }
}