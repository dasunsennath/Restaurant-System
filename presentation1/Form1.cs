using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;

namespace presentation1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_CLOSE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ACCEPT_Click(object sender, EventArgs e)
        {
            if (Textbox_USERNAME.Text !=  "USER NAME")
            {
                if(Textbox_PASSWORD.Text != "PASSWORD" )
                {
                    usermodel user3 = new usermodel();
                    var validlogin = user3.loginuser(Textbox_USERNAME.Text,Textbox_PASSWORD.Text);
                    if (validlogin == true)
                    {
                        loarding_window window = new loarding_window();
                        window.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgerro("Incorrect username or password. \n Please try again.");
                        Textbox_PASSWORD.Text = "PASSWORD";
                        Textbox_PASSWORD.ForeColor = Color.DimGray;
                        Textbox_PASSWORD.isPassword = false;
                        Textbox_USERNAME.Focus();
                    }
                }
                else
                {
                    msgerro("Please enter password.");
                }
                
            }
            else
            {
                msgerro("Please enter user name.");
            }
            
        }
        private void msgerro (string msg)
        {
            labeerroe.Text = msg;
            labeerroe.Visible = true;
            error_imag.Visible = true;
        }

        private void Textbox_USERNAME_Enter(object sender, EventArgs e)
        {
            if(Textbox_USERNAME.Text == "USER NAME")
            {
                Textbox_USERNAME.Text = "";
                Textbox_USERNAME.ForeColor = Color.LightGray;
            }
        }

        private void Textbox_USERNAME_Leave(object sender, EventArgs e)
        {
            if(Textbox_USERNAME.Text == "" )
            {
                Textbox_USERNAME.Text = "USER NAME";
                Textbox_USERNAME.ForeColor = Color.DimGray;
            }
        }

        private void Textbox_PASSWORD_Enter(object sender, EventArgs e)
        {
            if (Textbox_PASSWORD.Text == "PASSWORD")
            {
                Textbox_PASSWORD.Text = "";
                Textbox_PASSWORD.ForeColor = Color.LightGray;
                Textbox_PASSWORD.isPassword = true;
            }

        }

        private void Textbox_PASSWORD_Leave(object sender, EventArgs e)
        {
            if (Textbox_PASSWORD.Text == "")
            {
                Textbox_PASSWORD.Text = "PASSWORD";
                 Textbox_PASSWORD.ForeColor = Color.DimGray;
                Textbox_PASSWORD.isPassword = false;
            }
        }

        private void linkLabel_CREATEACCOUNT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            create_account accounr = new create_account();
            accounr.Show();
        }

       
    }
}
