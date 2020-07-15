using Backend_DB;
using Backend_Logic;
using MySqlX.XDevAPI.Common;
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
    public partial class HomePageForm : Form
    {
        Main parent = new Main();

        // Constructor sets the parent as the main form and initializes the datagridview
        public HomePageForm(Main Parent)
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
                                  Credit = client.ClassCredit,
                              };

                var results = clients.ToList();

                button_checkin.Enabled = results.Count > 0;

                dataView_Clients.DataSource = results;
            }
                
        }

        // Clients button calls the programs menu bar item for the clients page
        private void button_Clients_Click(object sender, EventArgs e)
        {
            parent.clientsToolStripMenuItem.PerformClick();
        }

        private void button_Finance_Click(object sender, EventArgs e)
        {
            parent.financeToolStripMenuItem.PerformClick();
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

        private void button_checkin_Click(object sender, EventArgs e)
        {
            int id = -1;

            using (var context = new Backend_DB.DBEntities())
            {
                var firstname = dataView_Clients.SelectedCells[0].Value.ToString();
                var lastname = dataView_Clients.SelectedCells[1].Value.ToString();
                id = (from clients in context.Clients where clients.FName == firstname && clients.LName == lastname select clients).First().ClientId;
            }

            CheckinForm checkinForm = new CheckinForm(id);
            checkinForm.Show(this);
            checkinForm.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;
        }


        private void button_AddClient_LocationChanged(object sender, EventArgs e)
        {
            button_AddClient.Left = dataView_Clients.Left + (dataView_Clients.Size.Width / 2) - 150;
            button_checkin.Left = dataView_Clients.Left + (dataView_Clients.Size.Width / 2);
        }

    }
}
