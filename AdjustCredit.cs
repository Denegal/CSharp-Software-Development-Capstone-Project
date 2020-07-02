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

        public AdjustCredit()
        {
            InitializeComponent();

            using (var context = new Backend_DB.DBEntities())
            {
                combo_Client.DataSource = (from clients in context.Clients select clients.FName + " " + clients.LName).ToList();
            }
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

                label_CurrentBalance.Text = "Current Credit Balance: $" + newCredit.ToString();
                label_NewBalance.Text = "New Credit Balance: $" + newCredit.ToString();
            }

        }

        private void textbox_Adjustment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numbers and decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            newCredit += int.Parse(textbox_Adjustment.Text);
            label_NewBalance.Text = "New Credit Balance: $" + newCredit.ToString();
            textbox_Adjustment.Text = "";
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            newCredit = newCredit > int.Parse(textbox_Adjustment.Text) ? newCredit - int.Parse(textbox_Adjustment.Text) : 0;
            label_NewBalance.Text = "New Credit Balance: $" + newCredit.ToString();
            textbox_Adjustment.Text = "";
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            using (var context = new Backend_DB.DBEntities())
            {
                var clientFName = combo_Client.SelectedItem.ToString().Split(' ')[0];
                var clientLName = combo_Client.SelectedItem.ToString().Split(' ')[1];

                var client = (from clients in context.Clients where clients.FName == clientFName && clients.LName == clientLName select clients).First();

                client.ClassCredit = newCredit;

                context.SaveChanges();
            }

        }
    }
}
