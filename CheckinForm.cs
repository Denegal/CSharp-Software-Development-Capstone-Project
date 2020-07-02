using Backend_DB;
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
    public partial class CheckinForm : Form
    {
        int checkinID = 0;
        bool CreditChecked = false;

        public CheckinForm(int id)
        {
            InitializeComponent();

            checkinID = id;

            using (var context = new Backend_DB.DBEntities())
            {

                var checkin_client = (from clients in context.Clients where clients.ClientId == checkinID select clients).First();

                label_Name.Text = checkin_client.FName + " " + checkin_client.LName;

                Label_ClientCredit.Text = "$" + checkin_client.ClassCredit.ToString();

                if (checkin_client.Waiver == 1) { checkbox_Waiver.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; }
                if (checkin_client.Pregnant == 1) { checkbox_Pregnant.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; }
                if (checkin_client.MedicalCare == 1) { checkbox_Medical.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; }

                if (checkin_client.Injuries != "") { textbox_Injuries.Text = checkin_client.Injuries; }

                if (checkin_client.MedicalHistory != "") { textbox_MedicalHistory.Text = checkin_client.MedicalHistory; }

            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_FName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void checkbox_Credit_Click(object sender, EventArgs e)
        {
            if (CreditChecked)
            {
                checkbox_Credit.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Credit.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            CreditChecked = !CreditChecked;
        }

        private void button_checkin_Click(object sender, EventArgs e)
        {
            if (textbox_Cost.Text == "")
            {
                MessageBox.Show("Unable to check-in client. Class cost not entered.");
                return;
            }

            using (var context = new Backend_DB.DBEntities())
            {

                if (CreditChecked)
                {
                    var checkin_client = (from clients in context.Clients where clients.ClientId == checkinID select clients).First();

                    if (int.Parse(textbox_Cost.Text) > checkin_client.ClassCredit)
                    {
                        MessageBox.Show("Unable to check-in client. Client does not have enough class credit.");
                        return;
                    }

                    checkin_client.ClassCredit -= int.Parse(textbox_Cost.Text);
                    context.SaveChanges();
                    MessageBox.Show("Client Successfully checked-in. $" + int.Parse(textbox_Cost.Text) + " deducted from clients credit.");
                }
                else
                {
                    Backend_DB.Finance newincome = new Backend_DB.Finance()
                    {
                        IncomeOrExpense = "Income",
                        Type = "Private",
                        Amount = long.Parse(textbox_Cost.Text),
                        Client = (from clients in context.Clients where clients.ClientId == checkinID select clients.ClientId).First(),
                        FinanceDate = DateTime.Now.Date,
                        Desc = "Private class given to " + label_Name.Text,
                    };

                    context.Finances.Add(newincome);
                    context.SaveChanges();
                    MessageBox.Show("Client Successfully checked-in. $" + int.Parse(textbox_Cost.Text) + " added as income for single private class.");
                }
            }

            this.Close();
        }
    }
}
