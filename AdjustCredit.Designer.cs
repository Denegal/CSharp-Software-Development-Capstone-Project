namespace Software_Development_Capstone
{
    partial class AdjustCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdjustCredit));
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.group_Client = new System.Windows.Forms.GroupBox();
            this.label_NewPass2 = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.textbox_LName = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.combo_Client = new System.Windows.Forms.ComboBox();
            this.label_CurrentBalance = new System.Windows.Forms.Label();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.label_NewBalance = new System.Windows.Forms.Label();
            this.textbox_Adjustment = new System.Windows.Forms.TextBox();
            this.group_Client.SuspendLayout();
            this.SuspendLayout();
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
            this.button_Save.Location = new System.Drawing.Point(50, 307);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(178, 87);
            this.button_Save.TabIndex = 13;
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
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
            this.button_Cancel.Location = new System.Drawing.Point(259, 307);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(178, 87);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // group_Client
            // 
            this.group_Client.Controls.Add(this.textbox_Adjustment);
            this.group_Client.Controls.Add(this.label_NewBalance);
            this.group_Client.Controls.Add(this.button_Remove);
            this.group_Client.Controls.Add(this.button_Add);
            this.group_Client.Controls.Add(this.label_CurrentBalance);
            this.group_Client.Controls.Add(this.combo_Client);
            this.group_Client.Controls.Add(this.label_NewPass2);
            this.group_Client.Controls.Add(this.label_Client);
            this.group_Client.Controls.Add(this.textbox_LName);
            this.group_Client.Location = new System.Drawing.Point(7, 73);
            this.group_Client.Name = "group_Client";
            this.group_Client.Size = new System.Drawing.Size(478, 228);
            this.group_Client.TabIndex = 11;
            this.group_Client.TabStop = false;
            // 
            // label_NewPass2
            // 
            this.label_NewPass2.AutoSize = true;
            this.label_NewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewPass2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NewPass2.Location = new System.Drawing.Point(38, 174);
            this.label_NewPass2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_NewPass2.Name = "label_NewPass2";
            this.label_NewPass2.Size = new System.Drawing.Size(136, 25);
            this.label_NewPass2.TabIndex = 33;
            this.label_NewPass2.Text = "Adjustment:";
            this.label_NewPass2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Client.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Client.Location = new System.Drawing.Point(19, 28);
            this.label_Client.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(153, 25);
            this.label_Client.TabIndex = 26;
            this.label_Client.Text = "Select Client:";
            this.label_Client.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_Title.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(-2, -1);
            this.label_Title.Margin = new System.Windows.Forms.Padding(0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(502, 71);
            this.label_Title.TabIndex = 10;
            this.label_Title.Text = "Adjust Client Credit";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // combo_Client
            // 
            this.combo_Client.Enabled = false;
            this.combo_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Client.FormattingEnabled = true;
            this.combo_Client.Location = new System.Drawing.Point(188, 25);
            this.combo_Client.Name = "combo_Client";
            this.combo_Client.Size = new System.Drawing.Size(277, 33);
            this.combo_Client.TabIndex = 51;
            this.combo_Client.SelectionChangeCommitted += new System.EventHandler(this.combo_Client_SelectionChangeCommitted);
            // 
            // label_CurrentBalance
            // 
            this.label_CurrentBalance.AutoSize = true;
            this.label_CurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_CurrentBalance.Location = new System.Drawing.Point(38, 86);
            this.label_CurrentBalance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_CurrentBalance.Name = "label_CurrentBalance";
            this.label_CurrentBalance.Size = new System.Drawing.Size(266, 25);
            this.label_CurrentBalance.TabIndex = 52;
            this.label_CurrentBalance.Text = "Current Credit Balance: ";
            this.label_CurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Remove
            // 
            this.button_Remove.Enabled = false;
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(361, 171);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(104, 33);
            this.button_Remove.TabIndex = 54;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Add
            // 
            this.button_Add.Enabled = false;
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(277, 171);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(78, 33);
            this.button_Add.TabIndex = 53;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // label_NewBalance
            // 
            this.label_NewBalance.AutoSize = true;
            this.label_NewBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewBalance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_NewBalance.Location = new System.Drawing.Point(71, 121);
            this.label_NewBalance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_NewBalance.Name = "label_NewBalance";
            this.label_NewBalance.Size = new System.Drawing.Size(233, 25);
            this.label_NewBalance.TabIndex = 55;
            this.label_NewBalance.Text = "New Credit Balance: ";
            this.label_NewBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Adjustment
            // 
            this.textbox_Adjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Adjustment.Location = new System.Drawing.Point(170, 171);
            this.textbox_Adjustment.MaxLength = 3;
            this.textbox_Adjustment.Name = "textbox_Adjustment";
            this.textbox_Adjustment.Size = new System.Drawing.Size(101, 31);
            this.textbox_Adjustment.TabIndex = 56;
            this.textbox_Adjustment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Adjustment_KeyPress);
            // 
            // AdjustCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 412);
            this.ControlBox = false;
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.group_Client);
            this.Controls.Add(this.label_Title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdjustCredit";
            this.ShowInTaskbar = false;
            this.group_Client.ResumeLayout(false);
            this.group_Client.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.GroupBox group_Client;
        private System.Windows.Forms.Label label_NewPass2;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.TextBox textbox_LName;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_CurrentBalance;
        private System.Windows.Forms.ComboBox combo_Client;
        private System.Windows.Forms.Label label_NewBalance;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textbox_Adjustment;
    }
}