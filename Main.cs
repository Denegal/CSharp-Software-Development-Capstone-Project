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

        LoginForm loginform = new LoginForm();

        public Main()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            loginform.MdiParent = this;

            loginform.PerformAutoScale();
            loginform.Show();

            loginform.VisibleChanged += new EventHandler(Login_Accepted);
        }

        private void Login_Accepted(object sender, EventArgs e)
        {
            if (loginform.Visible)
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

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.GetType().ToString() == "Software_Development_Capstone.HomePageForm")
            {
                return;
            }
            else
            {
                this.ActiveMdiChild.Close();
            }
            
            HomePageForm homePage = new HomePageForm(this);

            homePage.MdiParent = this;
            homePage.PerformAutoScale();
            homePage.Show();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.GetType().ToString() == "Software_Development_Capstone.ClientsForm")
            {
                return;
            }
            else
            {
                this.ActiveMdiChild.Close();
            }

            ClientsForm clientspage = new ClientsForm(this);

            clientspage.MdiParent = this;
            clientspage.PerformAutoScale();
            clientspage.Show();
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.GetType().ToString() == "Software_Development_Capstone.FinanceForm")
            {
                return;
            }
            else
            {
                this.ActiveMdiChild.Close();
            }

            FinanceForm financepage = new FinanceForm(this) { MdiParent = this };
            financepage.PerformAutoScale();
            financepage.Show();
        }

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

        private void EnableForm(object sender, FormClosedEventArgs e)
        {
            HomePageForm homePage = new HomePageForm(this);

            homePage.MdiParent = this;
            homePage.PerformAutoScale();
            homePage.Show();
            menu_bar.Enabled = true;
        }

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
