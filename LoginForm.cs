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
    public partial class LoginForm : Form
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
            label_message.Text = "";

            using (var context = new Backend_DB.DBEntities())
            {
                // Retrieve the password hash of the specified username
                IEnumerable<string> password = from users in context.Users where users.UserName == textbox_username.Text select users.PasswordHash;

                // hash the text from the password field and compare it to the hash retrieved from the database
                // If they match, the password is correct. Hide this form. 
                if (password.Count() > 0 && password.ElementAt(0) == Utils.GetSha1(textbox_password.Text))
                {

                    Logging.AddToLog("AuthLog.txt", $"Successful login by User: {textbox_username.Text}");
                    Program.LoggedinUser = (from users in context.Users where users.UserName == textbox_username.Text select users.UserName).First();
                    textbox_password.Text = "";
                    textbox_username.Text = "";
                    this.Hide();
                    
                }
                else
                {
                    Logging.AddToLog("AuthLog.txt", $"Failed log in attempt. Username: {textbox_username.Text}");
                    label_message.Text = "Login Failed";
                }

                textbox_password.Text = "";
                textbox_password.Enabled = true;
                textbox_username.Enabled = true;
            }
        }

        // When user hits the enter key in the password field, run the login button click function
        private void textbox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                button_login_Click(sender, new EventArgs());
            }
        }
    }
}
