using Backend_DB;
using Backend_Logic;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Capstone
{
    public partial class FinanceForm : Form
    {
        Main parent = new Main();
        bool IncomeChecked = false;
        bool ExpenseChecked = false;

        public FinanceForm(Main Parent)
        {
            InitializeComponent();

            parent = Parent;

            this.BackColor = Color.Magenta;
            this.TransparencyKey = Color.Magenta;

            this.DoubleBuffered = true;

            Update_datagrid();

            using (var context = new Backend_DB.DBEntities()) { button_Credit.Enabled = context.Clients.Count() > 0; }

            dataView_Finance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataView_Finance.Columns[0].FillWeight = 50;  // ID
            dataView_Finance.Columns[1].FillWeight = 60;  // Income/Expense
            dataView_Finance.Columns[2].FillWeight = 60;  // Amount
            dataView_Finance.Columns[3].FillWeight = 60;  // Date
            dataView_Finance.Columns[4].FillWeight = 80; // Type
            dataView_Finance.Columns[5].FillWeight = 130; // Desc
            dataView_Finance.Columns[6].FillWeight = 100; // Client

            dataView_Finance.AutoResizeColumns();

            combobox_Type.SelectedIndex = 0;

            FinanceForm_SizeChanged(this, new EventArgs());
        }

        private void Update_datagrid(bool filter = false)
        {
            //TODO: Look at making list sortable when dataview column headers are clicked
            //      by sending header name or index to function. Possibly have to use switch
            //      statement with orderby clause.
            using (var context = new Backend_DB.DBEntities())
            {
                var finances = from finance in context.Finances
                               join clients in context.Clients on finance.Client equals clients.ClientId into clients
                               from Client in clients.DefaultIfEmpty()
                               orderby finance.FinanceDate, finance.FinanceId
                               select new FinanceList
                               {
                                   ID = finance.FinanceId,
                                   Category = finance.IncomeOrExpense,
                                   Date = finance.FinanceDate,
                                   Amount = finance.Amount,
                                   Type = finance.Type,
                                   Desc = finance.Desc,
                                   Client = finance.Client == null ? "" : finance.Client1.FName + " " + finance.Client1.LName,

                               };

                var results = finances.ToList();

                // if filtering results, edit the list before updating the dataview
                // use of lambda functions here greatly decreases the code size and increases readability
                // each line can be read as 'remove all finances where the client does not contain what is being searched for'.
                if (filter)
                {

                    if (!IncomeChecked && ExpenseChecked) { results.RemoveAll(transaction => transaction.Category == "Income"); }
                    if (!ExpenseChecked && IncomeChecked) { results.RemoveAll(transaction => transaction.Category == "Expense"); }
                    if (textbox_Desc.Text != "") { results.RemoveAll(transaction => !transaction.Desc.ToLower().Contains(textbox_Desc.Text.ToLower())); }
                    if (date_start.Checked) { results.RemoveAll(transaction => transaction.Date < date_start.Value.AddDays(-1)); }
                    if (date_end.Checked) { results.RemoveAll(transaction => transaction.Date > date_end.Value); }
                    if (texbox_AFrom.Text != "") { results.RemoveAll(transaction => Math.Abs(transaction.Amount) < long.Parse(texbox_AFrom.Text)); }
                    if (textbox_ATo.Text != "") { results.RemoveAll(transaction => Math.Abs(transaction.Amount) > long.Parse(textbox_ATo.Text)); }
                    if (combobox_Type.SelectedIndex != 0) { results.RemoveAll(transaction => transaction.Type != combobox_Type.SelectedItem.ToString()); }

                }


                button_Remove.Enabled = results.Count > 0;
                button_Report.Enabled = results.Count > 0;

                dataView_Finance.DataSource = results;

                decimal total = new decimal();
                foreach (DataGridViewRow row in dataView_Finance.Rows)
                {

                    total += decimal.Parse(row.Cells[2].Value.ToString());
                }
                label_Total.Text = "Total:   $ " + total;
            }
        }

        // Cell formating to make expenses red and income green
        private void dataView_Finance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataView_Finance.Rows[e.RowIndex].Cells[0].Value.ToString() == "Expense")
            {
                e.CellStyle.ForeColor = Color.Red;
            }
            else
            {
                e.CellStyle.ForeColor = Color.DarkGreen;
            }

        }

        private void button_AddIncome_Click(object sender, EventArgs e)
        {

            AddIncomeExpense addincomeform = new AddIncomeExpense(true);
            addincomeform.Show(this);
            addincomeform.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;

        }

        private void EnableForm(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            parent.Enabled = true;
            Update_datagrid();
        }

        private void button_AddExpense_Click(object sender, EventArgs e)
        {
            AddIncomeExpense addexpenseform = new AddIncomeExpense(false);
            addexpenseform.Show(this);
            addexpenseform.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you wish to remove the selected financial transaction? This action cannot be undone.", "Remove Finance", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new Backend_DB.DBEntities())
                {
                    var removeid = int.Parse(dataView_Finance.SelectedCells[0].Value.ToString());

                    var removeFinance = (from finance in context.Finances where finance.FinanceId == removeid select finance).First();
                    context.Finances.Remove(removeFinance);
                    context.SaveChanges();
                    Update_datagrid();
                }
            }
        }

        private void button_Credit_Click(object sender, EventArgs e)
        {
            AdjustCredit adjustCreditForm = new AdjustCredit();
            adjustCreditForm.Show(this);
            adjustCreditForm.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            Update_datagrid(true);
        }

        private void checkbox_Income_Click(object sender, EventArgs e)
        {
            if (IncomeChecked)
            {
                checkbox_Income.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Income.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            IncomeChecked = !IncomeChecked;
        }

        private void checkbox_Expense_Click(object sender, EventArgs e)
        {
            if (ExpenseChecked)
            {
                checkbox_Expense.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Expense.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            ExpenseChecked = !ExpenseChecked;
        }

        private void FinanceForm_SizeChanged(object sender, EventArgs e)
        {

        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveReportdialog = new SaveFileDialog();
            saveReportdialog.Filter = "PDF File|*.pdf";
            saveReportdialog.Title = "Save Finance Report";
            saveReportdialog.FileName = "MC2 Finance Report - " + DateTime.Now.ToShortDateString().Replace('/', '-');
            saveReportdialog.ShowDialog();

            if (saveReportdialog.FileName != "")
            {
                try
                {
                    DataTable financeTable = Utils.ListtoDataTable((List<FinanceList>)dataView_Finance.DataSource);
                    Utils.GeneratePDF(saveReportdialog.FileName, financeTable, "MC2 Finances Report");

                    MessageBox.Show("Report generated");
                }
                catch
                {
                    MessageBox.Show("There was a problem generating the Report.");
                }

            }
        }

        private void label_FinanceList_LocationChanged(object sender, EventArgs e)
        {


        }

        private void dataView_Finance_SizeChanged(object sender, EventArgs e)
        {
            label_FinanceList.Left = dataView_Finance.Left + (dataView_Finance.Width / 2) - label_FinanceList.Width / 2;
            label_FinanceList.Top = dataView_Finance.Top - 85;

            if (box_Search.Top < label_FinanceList.Top) { box_Search.Top = label_FinanceList.Top; }
            if (box_Search.Top > dataView_Finance.Top) { box_Search.Top = dataView_Finance.Top; }

            box_Search.Left = dataView_Finance.Left + dataView_Finance.Width + 40;

            button_AddIncome.Top = box_Search.Top + 375;
            button_AddIncome.Left = dataView_Finance.Left + dataView_Finance.Width + 85;

            button_AddExpense.Top = box_Search.Top + 375;
            button_AddExpense.Left = dataView_Finance.Left + dataView_Finance.Width + 285;

            button_Credit.Top = box_Search.Top + 470;
            button_Credit.Left = dataView_Finance.Left + dataView_Finance.Width + 85;

            button_Remove.Top = box_Search.Top + 470;
            button_Remove.Left = dataView_Finance.Left + dataView_Finance.Width + 285;

            button_Report.Top = dataView_Finance.Top + dataView_Finance.Height + label_Total.Height;
            button_Report.Left = dataView_Finance.Left + dataView_Finance.Width / 2 - 100;

            label_Total.Left = dataView_Finance.Left;
            label_Total.Width = dataView_Finance.Width;
            label_Total.Top = dataView_Finance.Top + dataView_Finance.Height;
        }
    }
}
