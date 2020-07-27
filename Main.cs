using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Software_Development_Capstone
{
    public partial class Main : Form
    {
        // Create Login form, this form is the only perminant form in the application and will hide or show itself as needed
        LoginForm loginform = new LoginForm();

        public Main()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            // Setup the login form and show it
            // Main form is disabled by default and will only be enabled when login is successfull
            loginform.MdiParent = this;

            loginform.PerformAutoScale();
            loginform.Show();

            loginform.VisibleChanged += new EventHandler(Login_Accepted);
        }

        // This function is run whenever the login form's visability changes
        // If the visability change is due to a successful login, create a new Homepage form
        // and display it. Also, change the size of the application.
        private void Login_Accepted(object sender, EventArgs e)
        {
            if (loginform.Visible || this.MdiChildren.Count() > 1)
            {
                return;
            }

            Size = new System.Drawing.Size(1500, 1000);
            this.CenterToScreen();

            menu_bar.Enabled = true;

            HomePageForm homePage = new HomePageForm(this);

            homePage.MdiParent = this;
            homePage.PerformAutoScale();
            homePage.Show();

        }

        // Menu bar homepage button. If the homepage is not currently displayed. Close all forms except the
        // login form and create a new homepage to display
        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.GetType().ToString() == "Software_Development_Capstone.HomePageForm")
            {
                return;
            }
            else
            {
                //this.ActiveMdiChild.Close();
                foreach (Form child in this.MdiChildren)
                {
                    if (child != loginform)
                    {
                        child.Close();
                    }
                }
            }
            
            HomePageForm homePage = new HomePageForm(this);

            homePage.MdiParent = this;
            homePage.PerformAutoScale();
            homePage.Show();
        }

        // Menu bar Clients button. If the clients page is not currently displayed. Close all forms except the
        // login form and create a new clients page to display
        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.GetType().ToString() == "Software_Development_Capstone.ClientsForm")
            {
                return;
            }
            else
            {
                //this.ActiveMdiChild.Close();
                foreach (Form child in this.MdiChildren)
                {
                    if (child != loginform)
                    {
                        child.Close();
                    }
                }
            }

            ClientsForm clientspage = new ClientsForm(this);

            clientspage.MdiParent = this;
            clientspage.PerformAutoScale();
            clientspage.Show();
        }

        // Menu bar Finances button. If the finances page is not currently displayed. Close all forms except the
        // login form and create a new finances page to display
        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.GetType().ToString() == "Software_Development_Capstone.FinanceForm")
            {
                return;
            }
            else
            {
                //this.ActiveMdiChild.Close();
                foreach (Form child in this.MdiChildren)
                {
                    if (child != loginform)
                    {
                        child.Close();
                    }

                    
                }
            }

            FinanceForm financepage = new FinanceForm(this);
            financepage.MdiParent = this;
            financepage.PerformAutoScale();
            financepage.Show();
        }

        // Menu bar change password button. Close all forms except the
        // login form and create a new password change form to display
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form child in MdiChildren)
            {
                if (child != loginform)
                {
                    child.Close();
                }
            }
            

            menu_bar.Enabled = false;

            ChangePasswordForm changepass = new ChangePasswordForm();
            changepass.MdiParent = this;
            changepass.Show();

            changepass.FormClosed += new FormClosedEventHandler(EnableForm);
        }

        // enable form function is used after the change password 
        // form, add user form, or remove user form is closed.
        // It creates a new homepage form to display and re-enabled the menu bar
        private void EnableForm(object sender, FormClosedEventArgs e)
        {
            HomePageForm homePage = new HomePageForm(this);

            homePage.MdiParent = this;
            homePage.PerformAutoScale();
            homePage.Show();
            menu_bar.Enabled = true;
        }

        // Menu bar Logout button. Closes all forms except the login form and displays it.
        // Also disables the menu bar effectivly locking the program just as on first startup.
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close any child form except the login form.
            foreach (Form child in MdiChildren)
            {
                if (child != loginform)
                {
                    child.Close();
                }
            }

            menu_bar.Enabled = false;
            Program.LoggedinUser = null;

            //MinimumSize = new System.Drawing.Size(1000, 700);
            Size = new System.Drawing.Size(1000, 700);

            loginform.WindowState = FormWindowState.Maximized;
            loginform.Show();
        }

        // Menu bar add user button. Close all forms except the
        // login form and create a new add user form to display
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form child in MdiChildren)
            {
                if (child != loginform)
                {
                    child.Close();
                }
            }
            

            menu_bar.Enabled = false;

            AddRemoveUser adduser = new AddRemoveUser();
            adduser.MdiParent = this;
            adduser.WindowState = FormWindowState.Normal;
            adduser.Show();

            adduser.FormClosed += new FormClosedEventHandler(EnableForm);
        }

        // Menu bar Remove user button. Close all forms except the
        // login form and create a new remove user form to display
        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (Form child in MdiChildren)
            {
                if (child != loginform)
                {
                    child.Close();
                }
            }
            

            menu_bar.Enabled = false;

            AddRemoveUser removeuser = new AddRemoveUser(true);
            removeuser.MdiParent = this;
            removeuser.WindowState = FormWindowState.Normal;
            removeuser.Show();

            removeuser.FormClosed += new FormClosedEventHandler(EnableForm);
        }

    }
}
