namespace Software_Development_Capstone
{
    partial class FinanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceForm));
            this.label_FinanceList = new System.Windows.Forms.Label();
            this.dataView_Finance = new System.Windows.Forms.DataGridView();
            this.box_Search = new System.Windows.Forms.GroupBox();
            this.combobox_Type = new System.Windows.Forms.ComboBox();
            this.textbox_ATo = new System.Windows.Forms.TextBox();
            this.texbox_AFrom = new System.Windows.Forms.TextBox();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.label_ATo = new System.Windows.Forms.Label();
            this.label_DTo = new System.Windows.Forms.Label();
            this.label_AFrom = new System.Windows.Forms.Label();
            this.textbox_Desc = new System.Windows.Forms.TextBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Expense = new System.Windows.Forms.Label();
            this.label_Income = new System.Windows.Forms.Label();
            this.label_Desc = new System.Windows.Forms.Label();
            this.label_Amount = new System.Windows.Forms.Label();
            this.label_DFrom = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.button_Credit = new System.Windows.Forms.Button();
            this.button_AddIncome = new System.Windows.Forms.Button();
            this.button_AddExpense = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.checkbox_Expense = new System.Windows.Forms.PictureBox();
            this.checkbox_Income = new System.Windows.Forms.PictureBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.Title_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Finance)).BeginInit();
            this.box_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Income)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_FinanceList
            // 
            this.label_FinanceList.AutoSize = true;
            this.label_FinanceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FinanceList.Location = new System.Drawing.Point(147, 161);
            this.label_FinanceList.Name = "label_FinanceList";
            this.label_FinanceList.Size = new System.Drawing.Size(687, 73);
            this.label_FinanceList.TabIndex = 12;
            this.label_FinanceList.Text = "Income and Expenses";
            this.label_FinanceList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataView_Finance
            // 
            this.dataView_Finance.AllowUserToAddRows = false;
            this.dataView_Finance.AllowUserToDeleteRows = false;
            this.dataView_Finance.AllowUserToResizeColumns = false;
            this.dataView_Finance.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataView_Finance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataView_Finance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView_Finance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataView_Finance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataView_Finance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataView_Finance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView_Finance.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataView_Finance.Location = new System.Drawing.Point(47, 237);
            this.dataView_Finance.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dataView_Finance.MultiSelect = false;
            this.dataView_Finance.Name = "dataView_Finance";
            this.dataView_Finance.ReadOnly = true;
            this.dataView_Finance.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataView_Finance.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataView_Finance.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataView_Finance.RowTemplate.DividerHeight = 2;
            this.dataView_Finance.RowTemplate.Height = 35;
            this.dataView_Finance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataView_Finance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView_Finance.Size = new System.Drawing.Size(892, 480);
            this.dataView_Finance.TabIndex = 10;
            this.dataView_Finance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataView_Finance_CellFormatting);
            // 
            // box_Search
            // 
            this.box_Search.Controls.Add(this.combobox_Type);
            this.box_Search.Controls.Add(this.textbox_ATo);
            this.box_Search.Controls.Add(this.texbox_AFrom);
            this.box_Search.Controls.Add(this.date_end);
            this.box_Search.Controls.Add(this.date_start);
            this.box_Search.Controls.Add(this.label_ATo);
            this.box_Search.Controls.Add(this.label_DTo);
            this.box_Search.Controls.Add(this.label_AFrom);
            this.box_Search.Controls.Add(this.textbox_Desc);
            this.box_Search.Controls.Add(this.checkbox_Expense);
            this.box_Search.Controls.Add(this.checkbox_Income);
            this.box_Search.Controls.Add(this.button_Search);
            this.box_Search.Controls.Add(this.label_Type);
            this.box_Search.Controls.Add(this.label_Expense);
            this.box_Search.Controls.Add(this.label_Income);
            this.box_Search.Controls.Add(this.label_Desc);
            this.box_Search.Controls.Add(this.label_Amount);
            this.box_Search.Controls.Add(this.label_DFrom);
            this.box_Search.Controls.Add(this.label_Date);
            this.box_Search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.box_Search.Location = new System.Drawing.Point(979, 237);
            this.box_Search.Name = "box_Search";
            this.box_Search.Size = new System.Drawing.Size(464, 480);
            this.box_Search.TabIndex = 15;
            this.box_Search.TabStop = false;
            // 
            // combobox_Type
            // 
            this.combobox_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combobox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_Type.FormattingEnabled = true;
            this.combobox_Type.Items.AddRange(new object[] {
            "Any",
            "Classes",
            "Education",
            "Equipment",
            "Insurance"});
            this.combobox_Type.Location = new System.Drawing.Point(100, 394);
            this.combobox_Type.Name = "combobox_Type";
            this.combobox_Type.Size = new System.Drawing.Size(157, 28);
            this.combobox_Type.TabIndex = 33;
            // 
            // textbox_ATo
            // 
            this.textbox_ATo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ATo.Location = new System.Drawing.Point(300, 294);
            this.textbox_ATo.Name = "textbox_ATo";
            this.textbox_ATo.Size = new System.Drawing.Size(101, 31);
            this.textbox_ATo.TabIndex = 32;
            this.textbox_ATo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // texbox_AFrom
            // 
            this.texbox_AFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texbox_AFrom.Location = new System.Drawing.Point(121, 294);
            this.texbox_AFrom.Name = "texbox_AFrom";
            this.texbox_AFrom.Size = new System.Drawing.Size(101, 31);
            this.texbox_AFrom.TabIndex = 31;
            this.texbox_AFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // date_end
            // 
            this.date_end.CustomFormat = "\"yyyy/MM/dd\"";
            this.date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_end.Location = new System.Drawing.Point(121, 211);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(273, 26);
            this.date_end.TabIndex = 30;
            // 
            // date_start
            // 
            this.date_start.CustomFormat = "\"yyyy/MM/dd\"";
            this.date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_start.Location = new System.Drawing.Point(121, 175);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(273, 26);
            this.date_start.TabIndex = 29;
            // 
            // label_ATo
            // 
            this.label_ATo.AutoSize = true;
            this.label_ATo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ATo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_ATo.Location = new System.Drawing.Point(248, 297);
            this.label_ATo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_ATo.Name = "label_ATo";
            this.label_ATo.Size = new System.Drawing.Size(46, 25);
            this.label_ATo.TabIndex = 28;
            this.label_ATo.Text = "To:";
            this.label_ATo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_DTo
            // 
            this.label_DTo.AutoSize = true;
            this.label_DTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_DTo.Location = new System.Drawing.Point(69, 211);
            this.label_DTo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_DTo.Name = "label_DTo";
            this.label_DTo.Size = new System.Drawing.Size(46, 25);
            this.label_DTo.TabIndex = 27;
            this.label_DTo.Text = "To:";
            this.label_DTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_AFrom
            // 
            this.label_AFrom.AutoSize = true;
            this.label_AFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_AFrom.Location = new System.Drawing.Point(43, 297);
            this.label_AFrom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_AFrom.Name = "label_AFrom";
            this.label_AFrom.Size = new System.Drawing.Size(72, 25);
            this.label_AFrom.TabIndex = 26;
            this.label_AFrom.Text = "From:";
            this.label_AFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textbox_Desc
            // 
            this.textbox_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_Desc.Location = new System.Drawing.Point(175, 79);
            this.textbox_Desc.Name = "textbox_Desc";
            this.textbox_Desc.Size = new System.Drawing.Size(271, 31);
            this.textbox_Desc.TabIndex = 25;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Type.Location = new System.Drawing.Point(6, 387);
            this.label_Type.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(88, 31);
            this.label_Type.TabIndex = 17;
            this.label_Type.Text = "Type:";
            this.label_Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Expense
            // 
            this.label_Expense.AutoSize = true;
            this.label_Expense.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Expense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Expense.Location = new System.Drawing.Point(247, 16);
            this.label_Expense.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Expense.Name = "label_Expense";
            this.label_Expense.Size = new System.Drawing.Size(135, 31);
            this.label_Expense.TabIndex = 16;
            this.label_Expense.Text = "Expense:";
            this.label_Expense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Income
            // 
            this.label_Income.AutoSize = true;
            this.label_Income.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Income.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Income.Location = new System.Drawing.Point(42, 16);
            this.label_Income.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Income.Name = "label_Income";
            this.label_Income.Size = new System.Drawing.Size(118, 31);
            this.label_Income.TabIndex = 15;
            this.label_Income.Text = "Income:";
            this.label_Income.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Desc.Location = new System.Drawing.Point(6, 79);
            this.label_Desc.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(171, 31);
            this.label_Desc.TabIndex = 14;
            this.label_Desc.Text = "Description:";
            this.label_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Amount
            // 
            this.label_Amount.AutoSize = true;
            this.label_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Amount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Amount.Location = new System.Drawing.Point(6, 256);
            this.label_Amount.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Amount.Name = "label_Amount";
            this.label_Amount.Size = new System.Drawing.Size(122, 31);
            this.label_Amount.TabIndex = 12;
            this.label_Amount.Text = "Amount:";
            this.label_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_DFrom
            // 
            this.label_DFrom.AutoSize = true;
            this.label_DFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_DFrom.Location = new System.Drawing.Point(43, 176);
            this.label_DFrom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_DFrom.Name = "label_DFrom";
            this.label_DFrom.Size = new System.Drawing.Size(72, 25);
            this.label_DFrom.TabIndex = 11;
            this.label_DFrom.Text = "From:";
            this.label_DFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_Date.Location = new System.Drawing.Point(6, 135);
            this.label_Date.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(85, 31);
            this.label_Date.TabIndex = 13;
            this.label_Date.Text = "Date:";
            this.label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Total
            // 
            this.label_Total.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_Total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.Location = new System.Drawing.Point(47, 717);
            this.label_Total.Margin = new System.Windows.Forms.Padding(0);
            this.label_Total.MaximumSize = new System.Drawing.Size(892, 62);
            this.label_Total.MinimumSize = new System.Drawing.Size(892, 62);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(892, 62);
            this.label_Total.TabIndex = 20;
            this.label_Total.Text = "Total:   $ 0";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Credit
            // 
            this.button_Credit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Credit.AutoSize = true;
            this.button_Credit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Credit.BackgroundImage")));
            this.button_Credit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Credit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Credit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Credit.ForeColor = System.Drawing.Color.White;
            this.button_Credit.Location = new System.Drawing.Point(1035, 816);
            this.button_Credit.Name = "button_Credit";
            this.button_Credit.Size = new System.Drawing.Size(178, 87);
            this.button_Credit.TabIndex = 21;
            this.button_Credit.Text = "Credit";
            this.button_Credit.UseVisualStyleBackColor = true;
            this.button_Credit.Click += new System.EventHandler(this.button_Credit_Click);
            // 
            // button_AddIncome
            // 
            this.button_AddIncome.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_AddIncome.AutoSize = true;
            this.button_AddIncome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddIncome.BackgroundImage")));
            this.button_AddIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddIncome.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_AddIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddIncome.ForeColor = System.Drawing.Color.White;
            this.button_AddIncome.Location = new System.Drawing.Point(1035, 723);
            this.button_AddIncome.Name = "button_AddIncome";
            this.button_AddIncome.Size = new System.Drawing.Size(178, 87);
            this.button_AddIncome.TabIndex = 18;
            this.button_AddIncome.UseVisualStyleBackColor = true;
            this.button_AddIncome.Click += new System.EventHandler(this.button_AddIncome_Click);
            // 
            // button_AddExpense
            // 
            this.button_AddExpense.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_AddExpense.AutoSize = true;
            this.button_AddExpense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddExpense.BackgroundImage")));
            this.button_AddExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddExpense.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_AddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddExpense.ForeColor = System.Drawing.Color.White;
            this.button_AddExpense.Location = new System.Drawing.Point(1236, 723);
            this.button_AddExpense.Name = "button_AddExpense";
            this.button_AddExpense.Size = new System.Drawing.Size(178, 87);
            this.button_AddExpense.TabIndex = 17;
            this.button_AddExpense.UseVisualStyleBackColor = true;
            this.button_AddExpense.Click += new System.EventHandler(this.button_AddExpense_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Remove.AutoSize = true;
            this.button_Remove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Remove.BackgroundImage")));
            this.button_Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Remove.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Remove.ForeColor = System.Drawing.Color.White;
            this.button_Remove.Location = new System.Drawing.Point(1236, 816);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(178, 87);
            this.button_Remove.TabIndex = 16;
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // checkbox_Expense
            // 
            this.checkbox_Expense.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Expense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Expense.Location = new System.Drawing.Point(388, 16);
            this.checkbox_Expense.Name = "checkbox_Expense";
            this.checkbox_Expense.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Expense.TabIndex = 20;
            this.checkbox_Expense.TabStop = false;
            // 
            // checkbox_Income
            // 
            this.checkbox_Income.BackgroundImage = global::Software_Development_Capstone.Properties.Resources.empty_checkbox;
            this.checkbox_Income.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkbox_Income.Location = new System.Drawing.Point(166, 16);
            this.checkbox_Income.Name = "checkbox_Income";
            this.checkbox_Income.Size = new System.Drawing.Size(41, 41);
            this.checkbox_Income.TabIndex = 19;
            this.checkbox_Income.TabStop = false;
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
            this.button_Search.Location = new System.Drawing.Point(280, 365);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(178, 87);
            this.button_Search.TabIndex = 18;
            this.button_Search.UseVisualStyleBackColor = false;
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
            this.Title_Logo.Size = new System.Drawing.Size(1455, 125);
            this.Title_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title_Logo.TabIndex = 2;
            this.Title_Logo.TabStop = false;
            // 
            // FinanceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(116)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1455, 932);
            this.ControlBox = false;
            this.Controls.Add(this.button_Credit);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.button_AddIncome);
            this.Controls.Add(this.button_AddExpense);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.box_Search);
            this.Controls.Add(this.label_FinanceList);
            this.Controls.Add(this.dataView_Finance);
            this.Controls.Add(this.Title_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinanceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Finances";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataView_Finance)).EndInit();
            this.box_Search.ResumeLayout(false);
            this.box_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Expense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkbox_Income)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Title_Logo;
        private System.Windows.Forms.Label label_FinanceList;
        private System.Windows.Forms.DataGridView dataView_Finance;
        private System.Windows.Forms.Button button_AddIncome;
        private System.Windows.Forms.Button button_AddExpense;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.GroupBox box_Search;
        private System.Windows.Forms.TextBox textbox_Desc;
        private System.Windows.Forms.PictureBox checkbox_Expense;
        private System.Windows.Forms.PictureBox checkbox_Income;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Expense;
        private System.Windows.Forms.Label label_Income;
        private System.Windows.Forms.Label label_Desc;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Amount;
        private System.Windows.Forms.Label label_DFrom;
        private System.Windows.Forms.ComboBox combobox_Type;
        private System.Windows.Forms.TextBox textbox_ATo;
        private System.Windows.Forms.TextBox texbox_AFrom;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.Label label_ATo;
        private System.Windows.Forms.Label label_DTo;
        private System.Windows.Forms.Label label_AFrom;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Button button_Credit;
    }
}