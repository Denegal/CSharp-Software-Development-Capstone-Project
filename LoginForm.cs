using Backend_Logic;
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
    public partial class LoginForm
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //Check credentials, if incorrect clear and display error message
            //If credentials are correct, close form

            textbox_password.Enabled = false;
            textbox_username.Enabled = false;
            using (var context = new Backend_DB.DBEntities())
            {
                IEnumerable<string> password = from users in context.users where users.userName == textbox_username.Text select users.password;

                //if (password.Count() > 0 && password.ElementAt(0) == Translater.GetSha1(textbox_password.Text))
                //{
                if (password.Count() > 0 && password.ElementAt(0) == textbox_password.Text)
                {

                    Logging.AddToLog("AuthLog.txt", $"Successful login by User: {textbox_username.Text}");
                    Program.LoggedinUser = (from users in context.users where users.userName == textbox_username.Text select users.userName).First();
                    textbox_password.Text = "";
                    textbox_username.Text = "";
                    this.Hide();
                }
                else
                {
                    Logging.AddToLog("AuthLog.txt", $"Failed log in attempt. Username: {textbox_username.Text}");
                    MessageBox.Show();
                }

                textbox_password.Text = "";
                textbox_password.Enabled = true;
                textbox_username.Enabled = true;
            }
        }

    }
}
