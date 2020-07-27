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
            this.group_Client = new System.Windows.Forms.GroupBox();
            this.date_selector = new System.Windows.Forms.DateTimePicker();
            this.label_Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_Credits = new System.Windows.Forms.TextBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.textbox_Amount = new System.Windows.Forms.TextBox();
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
            this.group_Client.Controls.Add(this.date_selector);
            this.group_Client.Controls.Add(this.label_Date);
            this.group_Client.Controls.Add(this.label1);
            this.group_Client.Controls.Add(this.textbox_Credits);
            this.group_Client.Controls.Add(this.button_Remove);
            this.group_Client.Controls.Add(this.button_Add);
            this.group_Client.Controls.Add(this.textbox_Amount);
            this.group_Client.Controls.Add(this.label_NewBalance);
            this.group_Client.Controls.Add(this.label_CurrentBalance);
            this.group_Client.Controls.Add(this.combo_Client);
            this.group_Client.Controls.Add(this.label_Cash);
            this.group_Client.Controls.Add(this.label_Client);
            this.group_Client.Controls.Add(this.textbox_LName);
            this.group_Client.Location = new System.Drawing.Point(7, 73);
            this.group_Client.Name = "group_Client";
            this.group_Client.Size = new System.Drawing.Size(478, 345);
            this.group_Client.TabIndex = 11;
            this.group_Client.TabStop = false;
            // 
            // date_selector
            // 
            this.date_selector.Checked = false;
            this.date_selector.CustomFormat = "\"yyyy/MM/dd\"";
            this.date_selector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_selector.Location = new System.Drawing.Point(112, 286);
            this.date_selector.Name = "date_selector";
            this.date_selector.Size = new System.Drawing.Size(353, 29);
            this.date_selector.TabIndex = 62;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Date.Location = new System.Drawing.Point(38, 290);
            this.label_Date.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(68, 25);
            this.label_Date.TabIndex = 61;
            this.label_Date.Text = "Date:";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // textbox_Credits
            // 
            this.textbox_Credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Credits.Location = new System.Drawing.Point(164, 172);
            this.textbox_Credits.MaxLength = 3;
            this.textbox_Credits.Name = "textbox_Credits";
            this.textbox_Credits.Size = new System.Drawing.Size(101, 31);
            this.textbox_Credits.TabIndex = 59;
            this.textbox_Credits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Credits_KeyPress);
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(355, 172);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(104, 33);
            this.button_Remove.TabIndex = 58;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(271, 172);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(78, 33);
            this.button_Add.TabIndex = 57;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textbox_Amount
            // 
            this.textbox_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Amount.Location = new System.Drawing.Point(164, 228);
            this.textbox_Amount.MaxLength = 3;
            this.textbox_Amount.Name = "textbox_Amount";
            this.textbox_Amount.Size = new System.Drawing.Size(101, 31);
            this.textbox_Amount.TabIndex = 56;
            this.textbox_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Amount_KeyPress);
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
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.ForeColor = System.Drawing.Color.White;
            this.button_Save.Location = new System.Drawing.Point(50, 491);
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
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(259, 491);
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
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(495, 596);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.group_Client);
            this.Controls.Add(this.label_Title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox textbox_Amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textbox_Credits;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DateTimePicker date_selector;
        private System.Windows.Forms.Label label_Date;
    }
}