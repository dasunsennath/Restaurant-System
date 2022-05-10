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
using System.Data.SqlClient;
using common.cache;

namespace presentation1
{
       public partial class operation_of_item : UserControl
    {
           userdao userdao = new userdao();
           bool click = false;
           bool openall = false;
        public operation_of_item()
        {
            InitializeComponent();
            set_date_to_gridview();
        }


        public void set_date_to_gridview()
        {
            userdao.dtb2.Clear();
            userdao.get_itemtable_with_categoryname();
            dataGridView1.DataSource = userdao.dtb2;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
           product_no_text.Text =  dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           product_name_text.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           product_price_text.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           product_no_combo.SelectedItem = dataGridView1.SelectedRows[0].Cells[3].Value;
           product_no_text.ReadOnly = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (product_no_text.Text == "")
            {
                MessageBox.Show(" Pleace Insert Product Number ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                product_no_text.Focus();
            }
            else
            {
                add();
            }
           
           
        }

          public void add()
          {
              string category_name = product_no_combo.SelectedItem.ToString();
              bool result =   userdao.add_values_to_cegegory(product_no_text.Text, product_name_text.Text, product_price_text.Text,category_name );
              if(result == false)
              {
                  MessageBox.Show("Product Number Already Added try deferant Number", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else
              {

                  defualt();
              }


        }

           public void defualt()
          {
              MessageBox.Show("succes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
              product_name_text.Text = "";
              product_no_combo.Text = "";
              product_no_text.Text = "";
              product_price_text.Text = "";
              product_no_text.ReadOnly = false;
              set_date_to_gridview();
          }

          
          private void btn_update_Click(object sender, EventArgs e)
          {    
              string category_name = product_no_combo.SelectedItem.ToString();
           bool result =   userdao.update_ietem(product_name_text.Text, product_no_text.Text, product_price_text.Text, category_name);
              if(result == false)
              {
                  MessageBox.Show("Somthing Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else
              {
                  defualt();
              }
          }

          private void btn_delete_Click(object sender, EventArgs e)
          {
              string category_name = product_no_combo.SelectedItem.ToString();
              bool result = userdao.delete_ietem(product_no_text.Text);
              if(result == false)
              {
                  MessageBox.Show("Somthing Wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              else
              {
                  defualt();
              }
          }

          private void bunifuThinButton21_Click(object sender, EventArgs e)
          {
              defualt();
          }

          private void SearchTextbox_Enter(object sender, EventArgs e)
          {
              if (SearchTextbox.Text == "Search.....")
              {

                  SearchTextbox.Text = "";
              }
              else
              {
                  SearchTextbox.Text = "";
              }
          }

          private void SearchTextbox_Leave(object sender, EventArgs e)
          {
              if (SearchTextbox.Text == "")
              {
                  SearchTextbox.Text = "Search.....";
                  if (SearchTextbox.Text == "Search....." && click == true && openall == false)
                  {
                      set_date_to_gridview();
                      click = false;
                      openall = true;
                  }
              }
          }

          private void button1_Click(object sender, EventArgs e)
          {
              click = true;
              openall = false;
              userdao.dtb2.Clear();

              SqlConnection con = new SqlConnection(userdao.get_connectsion());
              con.Open();
              SqlDataAdapter adap = new SqlDataAdapter("select item_id,item_name,uni_price,category_name from Item,category where Item.category_id = category.category_id and item_name like  '" + "%" + SearchTextbox.Text + "%'", con);

              adap.Fill(userdao.dtb2);
              dataGridView1.DataSource = userdao.dtb2;
              con.Close();

          }
    }
}
