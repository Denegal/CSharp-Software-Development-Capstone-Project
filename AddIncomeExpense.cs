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
    public partial class AddIncomeExpense : Form
    {
        private bool isincome = false;
        public AddIncomeExpense(bool isIncome)
        {
            InitializeComponent();

            isincome = isIncome;

            if (isincome)
            {
                using (var context = new Backend_DB.DBEntities())
                {
                    combo_ClientType.DataSource = (from clients in context.Clients select clients.FName + " " + clients.LName).ToList();

                    label_Title.Text = "Add Income";
                    label_ClientType.Text = "Client";
                }
            }
            else
            {
                label_Title.Text = "Add Expense";
                label_ClientType.Text = "Type";
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_ClientType_SelectedIndexChanged(object sender, EventArgs e)
        {

            label_Other.Visible = combo_ClientType.SelectedItem.ToString() == "Other";
            textbox_Other.Visible = combo_ClientType.SelectedItem.ToString() == "Other";

        }

        private void textbox_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numbers and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && textbox_Amount.Text.Contains('.'))
            {
                e.Handled = true;
            }
            
            // only allow two numbrs after decimal point
            if (textbox_Amount.Text.IndexOf('.') == (textbox_Amount.Text.Length - 3) && textbox_Amount.Text.IndexOf('.') != -1)
            {
                if (!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            // Perform form validation
            try { validate_form(); }
            catch (Exception error) { MessageBox.Show(error.Message); return; }

            using (var context = new Backend_DB.DBEntities())
            {
                if (isincome)
                {
                    var clientFName = combo_ClientType.SelectedItem.ToString().Split(' ')[0];
                    var clientLName = combo_ClientType.SelectedItem.ToString().Split(' ')[1];

                    Backend_DB.Finance newincome = new Backend_DB.Finance()
                    {
                        IncomeOrExpense = "Income",
                        Type = "Private",
                        Amount = long.Parse(textbox_Amount.Text),
                        Client = (from clients in context.Clients where clients.FName == clientFName && clients.LName == clientLName select clients.ClientId).First(),
                        FinanceDate = DateTime.Now.Date,
                        Desc = textbox_Desc.Text,
                    };

                    context.Finances.Add(newincome);
                    context.SaveChanges();
                }

                else
                {
                    var expenseType = combo_ClientType.SelectedItem.ToString() != "other" ? combo_ClientType.SelectedItem.ToString() : textbox_Other.Text;
                    Backend_DB.Finance newexpense = new Backend_DB.Finance()
                    {
                        IncomeOrExpense = "Expense",
                        Amount = 0 - long.Parse(textbox_Amount.Text),
                        Type = expenseType,
                        FinanceDate = DateTime.Now.Date,
                        Desc = textbox_Desc.Text,
                    };

                    context.Finances.Add(newexpense);
                    context.SaveChanges();
                }
            }

            this.Close();
        }

        private void validate_form()
        {
            // Check if any required fields were left blank
            if (textbox_Amount.Text == "")
            {
                throw new MissingFieldException("Amount field cannot be blank.");
            }
            else if (combo_ClientType.SelectedItem.ToString() == "" && !isincome)
            {
                throw new MissingFieldException("Type field cannot be blank.");
            }

            // Check to ensure that the amount field only has integer values
            try
            {
                long.Parse(textbox_Amount.Text);
            }
            catch
            {
                throw new ArgumentException("Amount field is not valid. Please ensure field contains only numbers and a decimal point. Ex: 123.45");
            }

            return;
        }
    }
}
