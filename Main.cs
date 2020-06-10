﻿using System;
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

            label1.Visible = true;
        }
    }
}
