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
        public HomePageForm()
        {
            InitializeComponent();

            Update_datagrid(this, new EventArgs());
        }

        private void Update_datagrid(HomePageForm homePageForm, EventArgs eventArgs)
        {
            using (var context = new Backend_DB.DBEntities())
            {
                var clients = from client in context.Clients
                              select new ClientList
                              {
                                  FName = client.FName,
                                  LName = client.LName,
                                  Phone = client.Phone,
                                  Email = client.Email,
                                  Waiver = client.Waiver == 1,
                                  Injuries = !(client.Injuries == ""),
                                  Pregnant = client.Pregnant ==1,
                                  MedicalCare = client.MedicalCare == 1,
                                  ClassCredit = client.ClassCredit,
                              };

                var sample1 = new ClientList { FName = "Jane", LName = "Doe", Phone = "(111) 111-1111", Email = "JDow@sample.com", Waiver = true, Injuries = false, MedicalCare = false, Pregnant = false, ClassCredit = 0 };
                var sample2 = new ClientList { FName = "John", LName = "Doe", Phone = "(111) 222-2222", Email = "JohnD@sample.com", Waiver = true, Injuries = true, MedicalCare = false, Pregnant = false, ClassCredit = 2 };

                
                var results = clients.ToList();
                results.Add(sample1);
                results.Add(sample2);

                dataView_Clients.DataSource = results;
            }

            dataView_Clients.RowHeadersVisible = false;
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
    }
}
