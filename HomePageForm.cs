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

        // Clients button calls the programs menu bar item for the clients page
        private void button_Clients_Click(object sender, EventArgs e)
        {
            parent.clientsToolStripMenuItem.PerformClick();
        }

        private void button_Finance_Click(object sender, EventArgs e)
        {
            parent.financeToolStripMenuItem.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
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
        }
    }
}
