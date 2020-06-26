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

        public FinanceForm(Main Parent)
        {
            InitializeComponent();

            Update_datagrid();

            dataView_Finance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            /*
            dataView_Finance.Columns[0].FillWeight = 80;
            dataView_Finance.Columns[1].FillWeight = 80;
            dataView_Finance.Columns[2].FillWeight = 80;
            dataView_Finance.Columns[3].FillWeight = 125;
            dataView_Finance.Columns[4].FillWeight = 50;
            dataView_Finance.Columns[5].FillWeight = 50;
            dataView_Finance.Columns[6].FillWeight = 75;
            dataView_Finance.Columns[7].FillWeight = 80;
            dataView_Finance.Columns[8].FillWeight = 75;
            */

            dataView_Finance.AutoResizeColumns();

        }

        private void Update_datagrid()
        {
            //TODO: Look at making list sortable when dataview column headers are clicked
            //      by sending header name or index to function. Possibly have to use switch
            //      statement with orderby clause.
            using (var context = new Backend_DB.DBEntities())
            {
                var finances = from finance in context.Finances
                               join clients in context.Clients on finance.Client equals clients.ClientId into clients
                               from Client in clients.DefaultIfEmpty()
                               orderby finance.FinanceDate
                               select new FinanceList
                               {
                                   ID = finance.FinanceId,
                                   IncomeExpense = finance.IncomeOrExpense,
                                   Date = finance.FinanceDate,
                                   Amount = finance.Amount,
                                   Type = finance.Type,
                                   Desc = finance.Desc,   
                                   Client = finance.Client == null ? "" : finance.Client1.FName + " " + finance.Client1.LName,

                               };

                var results = finances.ToList();

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
    }
}
