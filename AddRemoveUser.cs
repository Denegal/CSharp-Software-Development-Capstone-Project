using Backend_DB;
using Backend_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Capstone
{
    public partial class AddRemoveUser : Form
    {
        public AddRemoveUser(bool RemoveUser = false)
        {
            InitializeComponent();

            if (RemoveUser)
            {
                label_Title.Text = "Remove User";
                textbox_Username.Visible = false;
                textbox_Password.Visible = false;
                label_Password.Visible = false;
                textbox_Password2.Visible = false;
                label_Password2.Visible = false;
                combo_Username.Visible = true;


                using (var context = new Backend_DB.DBEntities())
                {
                    combo_Username.DataSource = (from users in context.Users select users.UserName).ToList();
                }
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            using (var context = new Backend_DB.DBEntities())
            {
                if (textbox_Username.Visible == true)
                {
                    // If the two password fields do not match, display error and return
                    if (textbox_Password.Text != textbox_Password2.Text)
                    {
                        MessageBox.Show("Passwords do not match");
                        return;
                    }

                    User NewUser = new User
                    {
                        UserName = textbox_Username.Text,
                        PasswordHash = Utils.GetSha1(textbox_Password.Text),
                    };

                    context.Users.Add(NewUser);

                }
                else
                {

                    DialogResult result = MessageBox.Show($"Are you sure you wish to remove the selected User? This action cannot be undone.", "Remove User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        context.Users.Remove((from users in context.Users where users.UserName == textbox_Username.Text select users).First());
                    }
                    else return;
                }

                context.SaveChanges();
            }
        }
    }
}
