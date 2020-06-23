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
    public partial class ViewClient : Form
    {
        private int viewClientID = -1;

        public ViewClient(int id)
        {
            InitializeComponent();

            viewClientID = id;

            using (var context = new Backend_DB.DBEntities())
            {

                var view_client = (from clients in context.Clients where clients.ClientId == viewClientID select clients).First();

                label_Name.Text = view_client.FName + view_client.LName;
                label_Phone.Text = view_client.Phone;
                label_Email.Text = view_client.Email;
                label_EContact.Text = view_client.EmergencyContact;
                label_EPhone.Text = view_client.EmergencyContactPhone;

                if (view_client.Waiver == 1) { checkbox_Waiver.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; }
                if (view_client.Pregnant == 1) { checkbox_Pregnant.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; }
                if (view_client.MedicalCare == 1) { checkbox_Medical.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; }

                if (view_client.Injuries != "") { textbox_Injuries.Text = view_client.Injuries; }

                if (view_client.MedicalHistory != "") { textbox_MedicalHistory.Text = view_client.MedicalHistory; }


            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
