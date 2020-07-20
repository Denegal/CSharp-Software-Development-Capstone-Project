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
    public partial class AdjustCredit : Form
    {
        int newCredit = 0;
        int oldCredit = 0;

        public AdjustCredit()
        {
            InitializeComponent();

            using (var context = new Backend_DB.DBEntities())
            {
                combo_Client.DataSource = (from clients in context.Clients select clients.FName + " " + clients.LName).ToList();
            }

            combo_Client_SelectionChangeCommitted(this, new EventArgs());
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combo_Client_SelectionChangeCommitted(object sender, EventArgs e)
        {

            using (var context = new Backend_DB.DBEntities())
            {
                var clientFName = combo_Client.SelectedItem.ToString().Split(' ')[0];
                var clientLName = combo_Client.SelectedItem.ToString().Split(' ')[1];

                var clientbalance = (from clients in context.Clients where clients.FName == clientFName && clients.LName == clientLName select clients.ClassCredit).First();

                newCredit = clientbalance;
                oldCredit = clientbalance;

                label_CurrentBalance.Text = "Current Credit Balance: " + newCredit.ToString();
                label_NewBalance.Text = "New Credit Balance: " + newCredit.ToString();
            }

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
                if (!char.IsControl(e.KeyChar)) {
                    e.Handled = true;
                }
            }
        }
        private void textbox_Credits_KeyPress(object sender, KeyPressEventArgs e)
            {
                // only allow numbers
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        private void button_Add_Click(object sender, EventArgs e)
        {
            newCredit += int.Parse(textbox_Credits.Text);
            label_NewBalance.Text = "New Credit Balance: " + newCredit.ToString();
            textbox_Credits.Text = "";
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            newCredit = newCredit > int.Parse(textbox_Credits.Text) ? newCredit - int.Parse(textbox_Credits.Text) : 0;
            label_NewBalance.Text = "New Credit Balance: " + newCredit.ToString();
            textbox_Credits.Text = "";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textbox_Amount.Text == "")
            {
                MessageBox.Show("Error: Amount must not be blank.");
                return;
            }
            else if (newCredit == oldCredit)
            {
                DialogResult result = MessageBox.Show($"New class credit amount is the same as previous class credit amount. Are you sure you wish to continue?", "No Credit Change", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            

            using (var context = new Backend_DB.DBEntities())
            {
                var clientFName = combo_Client.SelectedItem.ToString().Split(' ')[0];
                var clientLName = combo_Client.SelectedItem.ToString().Split(' ')[1];

                var client = (from clients in context.Clients where clients.FName == clientFName && clients.LName == clientLName select clients).First();

                client.ClassCredit = newCredit;

                Backend_DB.Finance newincome = new Backend_DB.Finance()
                {
                    IncomeOrExpense = newCredit > oldCredit ? "Income" : "Expense",
                    Type = "Class Prepay",
                    Amount = long.Parse(textbox_Amount.Text),
                    Client = (from clients in context.Clients where clients.FName == clientFName && clients.LName == clientLName select clients.ClientId).First(),
                    FinanceDate = date_selector.Value.Date,
                    Desc = "Client " + clientFName + " " + clientLName + " prepaid for classes.",
                };

                context.Finances.Add(newincome);

                context.SaveChanges();
            }

            this.Close();
        }

       
    }
}
