using Backend_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Capstone
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button_checkin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // If new password and retyped password do not match, display error and return
            if (textbox_NewPass1.Text != textbox_NewPass2.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (var context = new Backend_DB.DBEntities())
            {
                var user = (from users in context.Users where users.UserName == Program.LoggedinUser select users).First();

                // If old password does not match database, display error and return
                if (user.PasswordHash != Utils.GetSha1(textbox_OldPass.Text))
                {
                    MessageBox.Show("Password Incorrect!");
                    return;
                }

                // store new password in database

                user.PasswordHash = Utils.GetSha1(textbox_NewPass1.Text);
                context.SaveChanges();

                Logging.AddToLog("EventLog.txt", $"{Program.LoggedinUser} successfully changed their password.");
            }
        }
    }
}
