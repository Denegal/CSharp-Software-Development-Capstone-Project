namespace Software_Development_Capstone
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.label_Title = new System.Windows.Forms.Label();
            this.group_Client = new System.Windows.Forms.GroupBox();
            this.label_OldPaass = new System.Windows.Forms.Label();
            this.textbox_NewPass1 = new System.Windows.Forms.TextBox();
            this.textbox_LName = new System.Windows.Forms.TextBox();
            this.label_NewPass1 = new System.Windows.Forms.Label();
            this.textbox_OldPass = new System.Windows.Forms.TextBox();
            this.label_NewPass2 = new System.Windows.Forms.Label();
            this.textbox_NewPass2 = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.group_Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(502, 71);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Change Password";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_Client
            // 
            this.group_Client.Controls.Add(this.textbox_NewPass2);
            this.group_Client.Controls.Add(this.label_NewPass2);
            this.group_Client.Controls.Add(this.label_OldPaass);
            this.group_Client.Controls.Add(this.textbox_NewPass1);
            this.group_Client.Controls.Add(this.textbox_LName);
            this.group_Client.Controls.Add(this.label_NewPass1);
            this.group_Client.Controls.Add(this.textbox_OldPass);
            this.group_Client.Location = new System.Drawing.Point(12, 74);
            this.group_Client.Name = "group_Client";
            this.group_Client.Size = new System.Drawing.Size(478, 178);
            this.group_Client.TabIndex = 3;
            this.group_Client.TabStop = false;
            // 
            // label_OldPaass
            // 
            this.label_OldPaass.AutoSize = true;
            this.label_OldPaass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OldPaass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_OldPaass.Location = new System.Drawing.Point(6, 22);
            this.label_OldPaass.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_OldPaass.Name = "label_OldPaass";
            this.label_OldPaass.Size = new System.Drawing.Size(206, 25);
            this.label_OldPaass.TabIndex = 26;
            this.label_OldPaass.Text = "Current Password:";
            this.label_OldPaass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_NewPass1
            // 
            this.textbox_NewPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_NewPass1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_NewPass1.Location = new System.Drawing.Point(210, 79);
            this.textbox_NewPass1.MaxLength = 10;
            this.textbox_NewPass1.Name = "textbox_NewPass1";
            this.textbox_NewPass1.PasswordChar = '*';
            this.textbox_NewPass1.Size = new System.Drawing.Size(247, 31);
            this.textbox_NewPass1.TabIndex = 32;
            this.textbox_NewPass1.UseSystemPasswordChar = true;
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
            // label_NewPass1
            // 
            this.label_NewPass1.AutoSize = true;
            this.label_NewPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewPass1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NewPass1.Location = new System.Drawing.Point(39, 82);
            this.label_NewPass1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_NewPass1.Name = "label_NewPass1";
            this.label_NewPass1.Size = new System.Drawing.Size(173, 25);
            this.label_NewPass1.TabIndex = 28;
            this.label_NewPass1.Text = "New Password:";
            this.label_NewPass1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_OldPass
            // 
            this.textbox_OldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_OldPass.Location = new System.Drawing.Point(210, 16);
            this.textbox_OldPass.MaxLength = 15;
            this.textbox_OldPass.Name = "textbox_OldPass";
            this.textbox_OldPass.PasswordChar = '*';
            this.textbox_OldPass.Size = new System.Drawing.Size(247, 31);
            this.textbox_OldPass.TabIndex = 30;
            this.textbox_OldPass.UseSystemPasswordChar = true;
            // 
            // label_NewPass2
            // 
            this.label_NewPass2.AutoSize = true;
            this.label_NewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewPass2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NewPass2.Location = new System.Drawing.Point(10, 116);
            this.label_NewPass2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_NewPass2.Name = "label_NewPass2";
            this.label_NewPass2.Size = new System.Drawing.Size(202, 25);
            this.label_NewPass2.TabIndex = 33;
            this.label_NewPass2.Text = "Retype Password:";
            this.label_NewPass2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_NewPass2
            // 
            this.textbox_NewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_NewPass2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_NewPass2.Location = new System.Drawing.Point(210, 116);
            this.textbox_NewPass2.MaxLength = 10;
            this.textbox_NewPass2.Name = "textbox_NewPass2";
            this.textbox_NewPass2.PasswordChar = '*';
            this.textbox_NewPass2.Size = new System.Drawing.Size(247, 31);
            this.textbox_NewPass2.TabIndex = 34;
            this.textbox_NewPass2.UseSystemPasswordChar = true;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Save.AutoSize = true;
            this.button_Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Save.BackgroundImage")));
            this.button_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(46, 258);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(178, 87);
            this.button_Save.TabIndex = 9;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.AutoSize = true;
            this.button_Cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Cancel.BackgroundImage")));
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(267, 258);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(178, 87);
            this.button_Cancel.TabIndex = 8;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_checkin_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(116)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(502, 351);
            this.ControlBox = false;
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.group_Client);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.group_Client.ResumeLayout(false);
            this.group_Client.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox group_Client;
        private System.Windows.Forms.TextBox textbox_NewPass2;
        private System.Windows.Forms.Label label_NewPass2;
        private System.Windows.Forms.Label label_OldPaass;
        private System.Windows.Forms.TextBox textbox_NewPass1;
        private System.Windows.Forms.TextBox textbox_LName;
        private System.Windows.Forms.Label label_NewPass1;
        private System.Windows.Forms.TextBox textbox_OldPass;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
    }
}