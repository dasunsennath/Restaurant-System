using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace presentation1
{
    public partial class userdetails : UserControl
    {
        userdao newuser = new userdao();
        public userdetails()
        {
            InitializeComponent();
            newuser.getbilldatials();
            dataGridView1.DataSource = newuser.dt3;
        }

        public void removed_table()
        {
            int count = dataGridView1.Rows.Count;
            for(int i=0 ; i<count-1;i++)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
        }

      
        private void dateTimePicker_year_ValueChanged(object sender, EventArgs e)
        {
            removed_table();
            newuser.getbilldatialswhith_date(dateTimePicker_year.Text);
            dataGridView1.DataSource = newuser.dt4;
        }

        private void dateTimePicker_month_ValueChanged(object sender, EventArgs e)
        {
            removed_table();
            newuser.getbilldatialswhith_date(dateTimePicker_month.Text);
            dataGridView1.DataSource = newuser.dt4;
        }

        private void dateTimePicker_day_ValueChanged(object sender, EventArgs e)
        {
            removed_table();
            newuser.getbilldatialswhith_date(dateTimePicker_day.Text);
            dataGridView1.DataSource = newuser.dt4;
        }
    }
}
