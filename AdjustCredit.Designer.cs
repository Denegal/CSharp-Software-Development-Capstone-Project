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
            this.group_Client = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textbox_Adjustment = new System.Windows.Forms.TextBox();
            this.label_NewBalance = new System.Windows.Forms.Label();
            this.label_CurrentBalance = new System.Windows.Forms.Label();
            this.combo_Client = new System.Windows.Forms.ComboBox();
            this.label_Cash = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.textbox_LName = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.group_Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_Client
            // 
            this.group_Client.BackColor = System.Drawing.Color.Transparent;
            this.group_Client.Controls.Add(this.label1);
            this.group_Client.Controls.Add(this.textBox1);
            this.group_Client.Controls.Add(this.button1);
            this.group_Client.Controls.Add(this.button2);
            this.group_Client.Controls.Add(this.textbox_Adjustment);
            this.group_Client.Controls.Add(this.label_NewBalance);
            this.group_Client.Controls.Add(this.label_CurrentBalance);
            this.group_Client.Controls.Add(this.combo_Client);
            this.group_Client.Controls.Add(this.label_Cash);
            this.group_Client.Controls.Add(this.label_Client);
            this.group_Client.Controls.Add(this.textbox_LName);
            this.group_Client.Location = new System.Drawing.Point(7, 73);
            this.group_Client.Name = "group_Client";
            this.group_Client.Size = new System.Drawing.Size(478, 289);
            this.group_Client.TabIndex = 11;
            this.group_Client.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-2, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Class Credits:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(164, 172);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 31);
            this.textBox1.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 33);
            this.button1.TabIndex = 58;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(271, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 33);
            this.button2.TabIndex = 57;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textbox_Adjustment
            // 
            this.textbox_Adjustment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Adjustment.Location = new System.Drawing.Point(164, 228);
            this.textbox_Adjustment.MaxLength = 3;
            this.textbox_Adjustment.Name = "textbox_Adjustment";
            this.textbox_Adjustment.Size = new System.Drawing.Size(101, 31);
            this.textbox_Adjustment.TabIndex = 56;
            this.textbox_Adjustment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Adjustment_KeyPress);
            // 
            // label_NewBalance
            // 
            this.label_NewBalance.AutoSize = true;
            this.label_NewBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_NewBalance.Location = new System.Drawing.Point(71, 121);
            this.label_NewBalance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_NewBalance.Name = "label_NewBalance";
            this.label_NewBalance.Size = new System.Drawing.Size(233, 25);
            this.label_NewBalance.TabIndex = 55;
            this.label_NewBalance.Text = "New Credit Balance: ";
            this.label_NewBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_CurrentBalance
            // 
            this.label_CurrentBalance.AutoSize = true;
            this.label_CurrentBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CurrentBalance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_CurrentBalance.Location = new System.Drawing.Point(38, 86);
            this.label_CurrentBalance.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_CurrentBalance.Name = "label_CurrentBalance";
            this.label_CurrentBalance.Size = new System.Drawing.Size(266, 25);
            this.label_CurrentBalance.TabIndex = 52;
            this.label_CurrentBalance.Text = "Current Credit Balance: ";
            this.label_CurrentBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // combo_Client
            // 
            this.combo_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Client.FormattingEnabled = true;
            this.combo_Client.Location = new System.Drawing.Point(188, 25);
            this.combo_Client.Name = "combo_Client";
            this.combo_Client.Size = new System.Drawing.Size(277, 33);
            this.combo_Client.TabIndex = 51;
            this.combo_Client.SelectionChangeCommitted += new System.EventHandler(this.combo_Client_SelectionChangeCommitted);
            // 
            // label_Cash
            // 
            this.label_Cash.AutoSize = true;
            this.label_Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Cash.Location = new System.Drawing.Point(6, 232);
            this.label_Cash.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Cash.Name = "label_Cash";
            this.label_Cash.Size = new System.Drawing.Size(152, 25);
            this.label_Cash.TabIndex = 33;
            this.label_Cash.Text = "Amount Paid:";
            this.label_Cash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Client.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.label_Title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Title.Font = new System.Drawing.Font("Tempus Sans ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(-2, -1);
            this.label_Title.Margin = new System.Windows.Forms.Padding(0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(502, 71);
            this.label_Title.TabIndex = 10;
            this.label_Title.Text = "Adjust Client Credit";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(50, 383);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(178, 87);
            this.button_Save.TabIndex = 13;
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
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(259, 383);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(178, 87);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AdjustCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(495, 488);
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
        private System.Windows.Forms.Label label_Cash;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.TextBox textbox_LName;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_CurrentBalance;
        private System.Windows.Forms.ComboBox combo_Client;
        private System.Windows.Forms.Label label_NewBalance;
        private System.Windows.Forms.TextBox textbox_Adjustment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}