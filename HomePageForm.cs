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

            // Adjust the sizes of the columns to better show the data.
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

        // This function retrieves a list of clients from the database and formats them for the datagrid view.
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

                // Only enable the check-in button if there is at least one client in the list
                button_checkin.Enabled = results.Count > 0;

                dataView_Clients.DataSource = results;
            }
                
        }

        // Clients button calls the programs menu bar item for the clients page
        private void button_Clients_Click(object sender, EventArgs e)
        {
            parent.clientsToolStripMenuItem.PerformClick();
        }

        // Finances button calls the programs menu bar item for the finances page
        private void button_Finance_Click(object sender, EventArgs e)
        {
            parent.financeToolStripMenuItem.PerformClick();
        }

        // The Add Client button creates a new Add Client form to display and 
        // disables this form. Add an event handler, EnableForm, to the Add User form close event
        private void button_AddClient_Click(object sender, EventArgs e)
        {
            AddEditClient addclientform = new AddEditClient();
            addclientform.Show(this);
            addclientform.FormClosed += new FormClosedEventHandler(EnableForm);
            this.Enabled = false;
            parent.Enabled = false;
        }

        // This function is simply used to re-enable the homepage form and menu bar
        // it is used as an event handler and tied to an open modal form close event
        private void EnableForm(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            parent.Enabled = true;
            Update_datagrid();
        }

        // The checkin button creates a new checkin form, passing the selected client ID, to display and 
        // disables this form. Add an event handler, EnableForm, to the checkin form close event
        private void button_checkin_Click(object sender, EventArgs e)
        {
            int id = -1;

            // Get the ID of the currently selected client using thier first and last name
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

        // Whenever the location of the add client button changes, adjust the location of the checkin button as well
        // This is used to help keep the form looking correct on resize
        private void button_AddClient_LocationChanged(object sender, EventArgs e)
        {
            button_AddClient.Left = dataView_Clients.Left + (dataView_Clients.Size.Width / 2) - 150;
            button_checkin.Left = dataView_Clients.Left + (dataView_Clients.Size.Width / 2);
        }

    }
}
