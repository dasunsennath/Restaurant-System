using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace presentation1
{
    public partial class create_account : Form
    {
        public create_account()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            usermodel usermodel = new usermodel();
            usermodel.account(username.Text, password.Text, firstname.Text, lastname.Text, position.Text, email.Text);
            this.Close();
        }

        private void Button_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
