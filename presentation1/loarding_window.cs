using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using common.cache;
namespace presentation1
{
    public partial class loarding_window : Form
    {
        public loarding_window()
        {
            InitializeComponent();
        }
        int count = 0;
   

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            CircleProgressbar1.Value += 1;
            
            if (CircleProgressbar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                mainwindow main = new mainwindow();
                main.Show();
                this.Hide();
            }
        }

        private void loarding_window_Load_1(object sender, EventArgs e)
        {
            username.Text = usercache.firstname + " " + usercache.lastname;
            this.Opacity = 0.0;
            CircleProgressbar1.Value = 0;

            CircleProgressbar1.MaxValue = 100;
            timer1.Start();
        }
    }
}
