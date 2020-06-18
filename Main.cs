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
    public partial class Main : Form
    {

        LoginForm loginform = new LoginForm();

        public Main()
        {
            InitializeComponent();

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

            MinimumSize = new System.Drawing.Size(1500, 1000);

            menu_bar.Enabled = true;

            HomePageForm homePage = new HomePageForm();

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

            HomePageForm homePage = new HomePageForm();

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

            ClientsForm clientspage = new ClientsForm();

            clientspage.MdiParent = this;
            clientspage.PerformAutoScale();
            clientspage.Show();
        }
    }
}
