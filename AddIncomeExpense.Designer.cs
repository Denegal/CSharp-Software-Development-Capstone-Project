namespace Software_Development_Capstone
{
    partial class AddIncomeExpense
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
            this.date_selector = new System.Windows.Forms.DateTimePicker();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Other = new System.Windows.Forms.Label();
            this.textbox_Other = new System.Windows.Forms.TextBox();
            this.combo_ClientType = new System.Windows.Forms.ComboBox();
            this.textbox_Desc = new System.Windows.Forms.TextBox();
            this.label_Desc = new System.Windows.Forms.Label();
            this.label_ClientType = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.textbox_Amount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.group_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Client
            // 
            this.group_Client.BackColor = System.Drawing.Color.Transparent;
            this.group_Client.Controls.Add(this.date_selector);
            this.group_Client.Controls.Add(this.label_Date);
            this.group_Client.Controls.Add(this.label_Other);
            this.group_Client.Controls.Add(this.textbox_Other);
            this.group_Client.Controls.Add(this.combo_ClientType);
            this.group_Client.Controls.Add(this.textbox_Desc);
            this.group_Client.Controls.Add(this.label_Desc);
            this.group_Client.Controls.Add(this.label_ClientType);
            this.group_Client.Controls.Add(this.label_Amount);
            this.group_Client.Controls.Add(this.textbox_Amount);
            this.group_Client.ForeColor = System.Drawing.SystemColors.Control;
            this.group_Client.Location = new System.Drawing.Point(45, 100);
            this.group_Client.Name = "group_Client";
            this.group_Client.Size = new System.Drawing.Size(804, 408);
            this.group_Client.TabIndex = 3;
            this.group_Client.TabStop = false;
            // 
            // date_selector
            // 
            this.date_selector.Checked = false;
            this.date_selector.CustomFormat = "\"yyyy/MM/dd\"";
            this.date_selector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_selector.Location = new System.Drawing.Point(134, 125);
            this.date_selector.Name = "date_selector";
            this.date_selector.Size = new System.Drawing.Size(399, 31);
            this.date_selector.TabIndex = 54;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Date.Location = new System.Drawing.Point(43, 124);
            this.label_Date.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(85, 31);
            this.label_Date.TabIndex = 53;
            this.label_Date.Text = "Date:";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Other
            // 
            this.label_Other.AutoSize = true;
            this.label_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Other.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Other.Location = new System.Drawing.Point(437, 66);
            this.label_Other.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Other.Name = "label_Other";
            this.label_Other.Size = new System.Drawing.Size(96, 31);
            this.label_Other.TabIndex = 51;
            this.label_Other.Text = "Other:";
            this.label_Other.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_Other.Visible = false;
            // 
            // textbox_Other
            // 
            this.textbox_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Other.Location = new System.Drawing.Point(539, 71);
            this.textbox_Other.MaxLength = 15;
            this.textbox_Other.Name = "textbox_Other";
            this.textbox_Other.Size = new System.Drawing.Size(239, 31);
            this.textbox_Other.TabIndex = 52;
            this.textbox_Other.Visible = false;
            // 
            // combo_ClientType
            // 
            this.combo_ClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_ClientType.FormattingEnabled = true;
            this.combo_ClientType.Items.AddRange(new object[] {
            "Education",
            "Equipment",
            "Insurance",
            "Private",
            "Other"});
            this.combo_ClientType.Location = new System.Drawing.Point(134, 69);
            this.combo_ClientType.Name = "combo_ClientType";
            this.combo_ClientType.Size = new System.Drawing.Size(277, 33);
            this.combo_ClientType.TabIndex = 50;
            this.combo_ClientType.SelectedIndexChanged += new System.EventHandler(this.combo_ClientType_SelectedIndexChanged);
            // 
            // textbox_Desc
            // 
            this.textbox_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Desc.Location = new System.Drawing.Point(107, 229);
            this.textbox_Desc.MaxLength = 250;
            this.textbox_Desc.Multiline = true;
            this.textbox_Desc.Name = "textbox_Desc";
            this.textbox_Desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_Desc.Size = new System.Drawing.Size(675, 151);
            this.textbox_Desc.TabIndex = 49;
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desc.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Desc.Location = new System.Drawing.Point(6, 182);
            this.label_Desc.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(171, 31);
            this.label_Desc.TabIndex = 47;
            this.label_Desc.Text = "Description:";
            this.label_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ClientType
            // 
            this.label_ClientType.AutoSize = true;
            this.label_ClientType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientType.ForeColor = System.Drawing.SystemColors.Control;
            this.label_ClientType.Location = new System.Drawing.Point(29, 66);
            this.label_ClientType.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_ClientType.Name = "label_ClientType";
            this.label_ClientType.Size = new System.Drawing.Size(99, 31);
            this.label_ClientType.TabIndex = 36;
            this.label_ClientType.Text = "Client:";
            this.label_ClientType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Amount.Location = new System.Drawing.Point(6, 16);
            this.label_Amount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(122, 31);
            this.label_Amount.TabIndex = 26;
            this.label_Amount.Text = "Amount:";
            this.label_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Amount
            // 
            this.textbox_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Amount.Location = new System.Drawing.Point(134, 16);
            this.textbox_Amount.MaxLength = 15;
            this.textbox_Amount.Name = "textbox_Amount";
            this.textbox_Amount.Size = new System.Drawing.Size(239, 31);
            this.textbox_Amount.TabIndex = 30;
            this.textbox_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Amount_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 22);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label_Title
            // 
            this.label_Title.BackColor = System.Drawing.Color.Black;
            this.label_Title.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Title.Location = new System.Drawing.Point(0, 22);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(893, 71);
            this.label_Title.TabIndex = 54;
            this.label_Title.Text = "New Finance";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(469, 535);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(193, 87);
            this.button_Cancel.TabIndex = 56;
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
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
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.Black;
            this.button_Save.Location = new System.Drawing.Point(225, 535);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(193, 87);
            this.button_Save.TabIndex = 55;
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // AddIncomeExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(894, 634);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group_Client);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncomeExpense";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.group_Client.ResumeLayout(false);
            this.group_Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_Client;
        private System.Windows.Forms.ComboBox combo_ClientType;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.TextBox textbox_Amount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textbox_Desc;
        private System.Windows.Forms.Label label_Desc;
        private System.Windows.Forms.Label label_ClientType;
        private System.Windows.Forms.Label label_Other;
        private System.Windows.Forms.TextBox textbox_Other;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DateTimePicker date_selector;
        private System.Windows.Forms.Label label_Date;
    }
}