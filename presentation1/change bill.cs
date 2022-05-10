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
    public partial class change_bill : UserControl {
        public change_bill()
        {
            InitializeComponent();
         
        }

        userdao newuser = new userdao();

        public void getdate()
        {
            newuser.change_bill(billno_text.Text);
            this.dataGridView1.DataSource = newuser.dtb2;
            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Invalid Bill Nubmber", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bill_no = dataGridView1.Rows[0].Cells[0].Value.ToString();
                item_no = dataGridView1.Rows[0].Cells[2].Value.ToString();
            }
           
        }
       
        private void btnsearch_Click(object sender, EventArgs e)
        {
            
            if (billno_text.Text =="")
            {
                MessageBox.Show("Please enter Bill Number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(dataGridView1.Rows.Count !=1)
                {
                    clearerows();
                } 
               getdate();
               

            }




        }
        string bill_no , item_no;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
            itemname.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
           unitprice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
           quantity.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
          
           quantity.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           if( newuser.delete_bill_item(bill_no,item_no))
           {
               MessageBox.Show(" Successfully delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               cleare();
               clearerows();
               getdate();
           }
           else
           {
               MessageBox.Show(" Somthing Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        public void clearerows ()
        {
            int count = dataGridView1.Rows.Count;
                for (int i = 0; i < count-1; i++)
                {
                    this.dataGridView1.Rows.RemoveAt(0);
                }
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
           if ( newuser.update_bill(bill_no,item_no,quantity.Text))
           {
               MessageBox.Show(" Successfully Update", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               clearerows();
               getdate();
           }
           else
           {
               MessageBox.Show(" Somthing Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        public void cleare()
        {
           itemname.Text = "";
            unitprice.Text = "";
            quantity.Text = "";
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            cleare();
        }

        private void remove_Order_Click(object sender, EventArgs e)
        {
           if( newuser.delete_bill(bill_no))
           {
               cleare();
               clearerows();
               billno_text.Text = "";
               billno_text.Focus();
               MessageBox.Show(" Successfully delete", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           else
           {
               MessageBox.Show(" Somthing Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }

        

    }
}
