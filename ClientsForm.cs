using Backend_Logic;
using Org.BouncyCastle.Crypto.Digests;
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
    public partial class ClientsForm : Form
    {
        Main parent = new Main();

        private bool WaiverChecked = false;
        private bool MedicalChecked = false;
        private bool PregnantChecked = false;

        public ClientsForm(Main Parent)
        {
            InitializeComponent();

            parent = Parent;

            Update_datagrid();

            dataView_Clients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataView_Clients.Columns[0].FillWeight = 80;
            dataView_Clients.Columns[1].FillWeight = 80;
            dataView_Clients.Columns[2].FillWeight = 80;
            dataView_Clients.Columns[3].FillWeight = 125;
            dataView_Clients.Columns[4].FillWeight = 50;
            dataView_Clients.Columns[5].FillWeight = 50;
            dataView_Clients.Columns[6].FillWeight = 75;
            dataView_Clients.Columns[7].FillWeight = 80;
            dataView_Clients.Columns[8].FillWeight = 75;

            dataView_Clients.AutoResizeColumns();
        }

        private void Update_datagrid()
        {

            //TODO: Look at making list sortable when dataview column headers are clicked
            //      by sending header name or index to function. Possibly have to use switch
            //      statement with orderby clause.
            using (var context = new Backend_DB.DBEntities())
            {
                var clients = from client in context.Clients
                              orderby client.ClassCredit
                              select new ClientList
                              {
                                  First = client.FName,
                                  Last = client.LName,
                                  Phone = client.Phone,
                                  Email = client.Email,
                                  Waiver = client.Waiver == 1,
                                  Injuries = !(client.Injuries == ""),
                                  Pregnant = client.Pregnant == 1,
                                  MedicalCare = client.MedicalCare == 1,
                                  Credits = client.ClassCredit,
                              };

                var results = clients.ToList();

                // Sample data. REMOVE FOR PRODUCTION
                /*
                var sample1 = new ClientList { First = "Jane", Last = "Doe", Phone = "(111) 111-1111", Email = "JDow@sample.com", Waiver = true, Injuries = false, MedicalCare = false, Pregnant = false, Credits = 0 };
                var sample2 = new ClientList { First = "John", Last = "Doe", Phone = "(111) 222-2222", Email = "JohnD@sample.com", Waiver = true, Injuries = true, MedicalCare = false, Pregnant = false, Credits = 2 };

                results.Add(sample1);
                results.Add(sample2);
                */

                dataView_Clients.DataSource = results;
            }

        }

        private void checkbox_Waiver_Click(object sender, EventArgs e)
        {
            if (WaiverChecked)
            {
                checkbox_Waiver.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Waiver.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            WaiverChecked = !WaiverChecked;
        }

        private void checkbox_Medical_Click(object sender, EventArgs e)
        {
            if (MedicalChecked)
            {
                checkbox_Medical.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Medical.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            MedicalChecked = !MedicalChecked;
        }

        private void checkbox_Pregnant_Click(object sender, EventArgs e)
        {
            if (PregnantChecked)
            {
                checkbox_Pregnant.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Pregnant.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            PregnantChecked = !PregnantChecked;
        }

        private void button_AddClient_Click(object sender, EventArgs e)
        {
            AddEditClient addclientform = new AddEditClient();
            addclientform.Show(this);
            addclientform.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;
        }

        private void EnableForm(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            parent.Enabled = true;
            Update_datagrid();
        }

        private void button_EditClient_Click(object sender, EventArgs e)
        {
            int id = -1;

            using (var context = new Backend_DB.DBEntities())
            {
                var firstname = dataView_Clients.SelectedCells[0].Value.ToString();
                var lastname = dataView_Clients.SelectedCells[1].Value.ToString();
                id = (from clients in context.Clients where clients.FName == firstname && clients.LName == lastname select clients).First().ClientId;
            }
            
            AddEditClient editclientform = new AddEditClient(id);
            editclientform.Show(this);
            editclientform.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;

        }

        private void button_RemoveClient_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you wish to remove the selected Client? This action cannot be undone.", "Remove Client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new Backend_DB.DBEntities())
                {
                    var firstname = dataView_Clients.SelectedCells[0].Value.ToString();
                    var lastname = dataView_Clients.SelectedCells[1].Value.ToString();
                    var removeid = (from clients in context.Clients where clients.FName == firstname && clients.LName == lastname select clients).First().ClientId;
                    var removeClient = (from clients in context.Clients where clients.ClientId == removeid select clients).First();
                    context.Clients.Remove(removeClient);
                    context.SaveChanges();
                    Update_datagrid();
                }
            }
        }

        private void button_ViewClient_Click(object sender, EventArgs e)
        {
            int id = -1;

            using (var context = new Backend_DB.DBEntities())
            {
                var firstname = dataView_Clients.SelectedCells[0].Value.ToString();
                var lastname = dataView_Clients.SelectedCells[1].Value.ToString();
                id = (from clients in context.Clients where clients.FName == firstname && clients.LName == lastname select clients).First().ClientId;
            }

            ViewClient viewclientform = new ViewClient(id);
            viewclientform.Show(this);
            viewclientform.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;
        }
    }
}
