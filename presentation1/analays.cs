using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DataAccess;

namespace presentation1
{
    public partial class analays : UserControl
    {
        public analays()
        {
            InitializeComponent();
        }
        userdao user = new userdao();



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             String Start_year = dateTimePicker1.Text + "-01-01";
             String end_year = dateTimePicker1.Text + "-12-31";
             user.analisis_2(Start_year, end_year);
             chart1.Series["Profit"].Points.Clear();
            // check_month();
             month_check();
        }

        public void getdata ()
        {
            chart1.Series["Profit"].Points.Clear();
          //  check_week();
            week_check();
        }

/*
        public void check_week()
        {
            if (user.profite.GetValue(1) != null)
            {
               this.chart1.Series["Profit"].Points.InsertXY(0,"1 week", user.profite.GetValue(1));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(0, "1 week", 0);

            }

            if (user.profite.GetValue(2) != null)
            {
               this.chart1.Series["Profit"].Points.InsertXY(1, "2 week", user.profite.GetValue(2));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(1, "2 week", 0);

            }

            if (user.profite.GetValue(3) != null)
            {
              this.chart1.Series["Profit"].Points.InsertXY(2, "3 week", user.profite.GetValue(3));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(2, "3 week", 0);
            }

            if (user.profite.GetValue(4) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(3, "4 week", user.profite.GetValue(4));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(3, "4 week", 0);

            }

            if (user.profite.GetValue(5) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(4, "5 week", user.profite.GetValue(5));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(4, "5 week", 0);

            }

           
        }
        */
   
        public void week_check ()
        {
            for (int i = 1; i < 6; i++ )
                if (user.profite.GetValue(i) != null)
                {
                    this.chart1.Series["Profit"].Points.InsertXY(i-1, i+" week", user.profite.GetValue(i));
                }
                else
                {
                    this.chart1.Series["Profit"].Points.InsertXY(i-1, i+" week", 0);

                }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           String start_date = dateTimePicker2.Text + "-01";
            String last_date = dateTimePicker2.Text + "-31";
            user.analisis(start_date, last_date);
            getdata();
        }

        string[] month = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        public void month_check()
        {
            for (int i = 1; i < user.profite.Length; i++)
            {
                if (user.profite.GetValue(i) != null)
                {
                    this.chart1.Series["Profit"].Points.InsertXY(i-1,month[i-1], user.profite.GetValue(i));
                }
                else
                {
                    this.chart1.Series["Profit"].Points.InsertXY(i - 1, month[i- 1], 0);

                }
            }
        }
    
     /*   public void  check_month()
        {
            if (user.profite.GetValue(1) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(0, "Jan", user.profite.GetValue(1));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(0, "Jan", 0);

            }

            if (user.profite.GetValue(2) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(1, "Feb", user.profite.GetValue(2));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(1, "Feb", 0);

            }

            if (user.profite.GetValue(3) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(2, "Mar", user.profite.GetValue(3));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(2, "Mar", 0);
            }

            if (user.profite.GetValue(4) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(3, "Apr", user.profite.GetValue(4));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(3, "Apr", 0);

            }

            if (user.profite.GetValue(5) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(4, "May", user.profite.GetValue(5));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(4, "May", 0);

            }

            if (user.profite.GetValue(6) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(5, "Jun", user.profite.GetValue(6));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(5, "Jun", 0);

            }

            if (user.profite.GetValue(7) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(6, "Jul", user.profite.GetValue(7));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(6, "Jul", 0);

            }
            if (user.profite.GetValue(8) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(7, "Aug", user.profite.GetValue(8));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(7, "Aug", 0);

            }
            if (user.profite.GetValue(9) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(8, "Sep", user.profite.GetValue(9));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(8, "Sep", 0);

            }

            if (user.profite.GetValue(10) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(9, "Oct", user.profite.GetValue(10));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(9, "Oct", 0);

            }

            if (user.profite.GetValue(11) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(10, "Nov", user.profite.GetValue(11));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(10, "Nov", 0);

            }

            if (user.profite.GetValue(12) != null)
            {
                this.chart1.Series["Profit"].Points.InsertXY(11, "Dec", user.profite.GetValue(12));
            }
            else
            {
                this.chart1.Series["Profit"].Points.InsertXY(11, "Dec", 0);

            }
        }
        */


      
    }
}
