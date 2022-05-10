using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Data.SqlClient;
using common.cache;


namespace presentation1
{

    public partial class mainwindow : Form
    {
        userdao usredo = new userdao();
        bool click = false;
        bool clear = false;
        bool openall = false;
        int row_count = 0;
        double total;
        public mainwindow()
        {
            InitializeComponent();
            gettable();
            name.Text= usercache.firstname + " " + usercache.lastname;
            position.Text = usercache.position;
            email.Text = usercache.email;
            operation_of_item1.Hide();
            change_bill1.Hide();
            userdetails1.Hide();
            analays1.Hide(); 
           
        }

        public void gettable()
        {
            usredo.setdata_to_dataview();
            dataGridView1.DataSource = usredo.dtbl;

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchTextbox_Enter(object sender, EventArgs e)
        {
            if (SearchTextbox.text == "Search.....")
            {
               
                SearchTextbox.text = ""; 
            }
            else
            {
                SearchTextbox.text = ""; 
            }
        }

        private void SearchTextbox_Leave(object sender, EventArgs e)
        {
            if (SearchTextbox.text == "")
            {
                SearchTextbox.text = "Search.....";
                if(SearchTextbox.text == "Search....." && click == true && openall == false)
            {
                gettable();
                click = false;
                openall = true;
            }
            }

            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            click = true;
            openall = false;
            usredo.dtb2.Clear();
            
            SqlConnection con = new SqlConnection(usredo.get_connectsion());
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from Item where item_name like  '" + "%" + SearchTextbox.text+"%'", con);
            
            adap.Fill(usredo.dtb2);
            dataGridView1.DataSource = usredo.dtb2;
            con.Close();



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             usredo.dtb2.Clear();
            SqlConnection con = new SqlConnection(usredo.get_connectsion());
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select i.item_id,i.item_name,i.uni_price,c.category_id from Item i , category c  where i.category_id = c.category_id  and   c.category_name = '" + comboBox1.SelectedItem.ToString() + "'", con);

            adap.Fill(usredo.dtb2);
            dataGridView1.DataSource = usredo.dtb2;
            con.Close();
            clear = true;
            openall = false;
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" &&  clear == true && openall == false)
            {
                gettable();
                 clear = false;
                 openall = true;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
           if ( SearchTextbox.text != "Search.....")
           {
               SearchTextbox.text = "Search.....";
           }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            product_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            price.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Qnt_text.Text = "1";
            Qnt_text.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
    
            try{
                int qanty;
                double uprice;
                qanty = int.Parse(Qnt_text.Text);
                uprice = double.Parse(price.Text);
                dataGridView2.Rows.Add();
                dataGridView2.Rows[row_count].Cells[0].Value = product_name.Text;
                dataGridView2.Rows[row_count].Cells[1].Value = Qnt_text.Text;
                dataGridView2.Rows[row_count].Cells[2].Value = price.Text;
                dataGridView2.Rows[row_count].Cells[3].Value = (qanty * uprice).ToString();
                total += double.Parse(dataGridView2.Rows[row_count].Cells[3].Value.ToString());
                total_amount.Text = "Rs " + total.ToString()+".00";
                row_count++;
            }
                 
            catch(Exception exr)
            {
                
                MessageBox.Show("Pleace Insert Only Nubmers For Quantity"," ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Qnt_text.Clear();
                Qnt_text.Focus();  
            }

        }

        private void btn_cancelordere_Click(object sender, EventArgs e)
        {
            reset();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
             if (dataGridView2.SelectedRows.Count>0)
            {
              
             total = total - double.Parse((dataGridView2.Rows[(this.dataGridView2.CurrentRow.Index)].Cells[3].Value).ToString());
             total_amount.Text = "Rs " + total.ToString() + ".00";
             dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
             row_count--;
            }

        }
    
        public void getbalanace()
        {
            try
            {
                double balance;
                double pay = double.Parse(pay_amont.Text);
                balance = pay - total;
                balance_text.Text = "Rs " + balance.ToString() + ".00";
            }
            catch(Exception)
            {
                MessageBox.Show("Pleace Enter pay Amount", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pay_amont.Focus();
            }
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            getbalanace();
        }

        public void numberonly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar !=  '.')
            {
                e.Handled = true;
            }
        }
        private void Qnt_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            numberonly( sender,e);
        }

        private void pay_amont_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            numberonly(sender, e);
        }
       
        public void reset()
        {
            dataGridView2.Rows.Clear();
            row_count = 0;
            total = 0.00;
            total_amount.Text = "";
            pay_amont.Text = "";
            balance_text.Text = "";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
           inserinto_bill();
           insert_bill(); 
          printPreviewDialog1.ShowDialog();
           printDialog1.ShowDialog();
            reset();
        }

        
        public void inserinto_bill()
        {
            usercache.today = DateTime.Now.ToString("yyyy-MM-dd");
            usercache.current_time = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            usredo.insert_into_bil(usercache.today, usercache.current_time);
        }

        public void  insert_bill()
        {
           
            for (int i = 0; i< dataGridView2.Rows.Count-1;i++)
            {
                int bill_quantity = int.Parse(this.dataGridView2.Rows[i].Cells[1].Value.ToString());
                usercache.itemname = this.dataGridView2.Rows[i].Cells[0].Value.ToString();
                usredo.inser_bill_datail(usercache.itemname, bill_quantity.ToString());
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
         
            e.Graphics.DrawString("MC Donal's Foods",new Font("Segoe UI", 18, FontStyle.Bold),Brushes.Red,new Point(320,25));
            e.Graphics.DrawLine(new Pen(Brushes.Red), new Point(300, 55), new Point(560,55));
            e.Graphics.DrawString("Date  :  " +DateTime.Now.ToString("yyyy-MM-dd").ToString() , new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(25, 110));
            e.Graphics.DrawString("Time  :  " + DateTime.Now.ToString("hh:mm tt", System.Globalization.DateTimeFormatInfo.InvariantInfo).ToString(), new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(670, 110));
            e.Graphics.DrawString("Invoice No : "+usercache.billid, new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(25, 142));
            e.Graphics.DrawString("Product Name", new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(85,200));
            e.Graphics.DrawString("Quantity", new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(360, 200));
            e.Graphics.DrawString("Unit Price", new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(480, 200));
            e.Graphics.DrawString("Amount", new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(630,200));

           /* Bitmap bm = new Bitmap(this.dataGridView2.Width,this.dataGridView2.Height);
            dataGridView2.DrawToBitmap(bm, new Rectangle(125, 230, this.dataGridView2.Width, this.dataGridView2.Height));*/
            e.Graphics.DrawLine(new Pen(Brushes.Black), new Point(80, 235), new Point(700, 235));

            int space = 250; 
          for (int i = 0; i <this.dataGridView2.RowCount-1; i++)
        {
                e.Graphics.DrawString(this.dataGridView2.Rows[i].Cells[0].Value.ToString(), new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(85, space));
                e.Graphics.DrawString(this.dataGridView2.Rows[i].Cells[1].Value.ToString(), new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(368, space));
                e.Graphics.DrawString(this.dataGridView2.Rows[i].Cells[2].Value.ToString(), new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(485, space));
                e.Graphics.DrawString(this.dataGridView2.Rows[i].Cells[3].Value.ToString(), new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(630, space));
               space += 45;
      }

          e.Graphics.DrawString("Total amount :  " , new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(500, space + 45));
          e.Graphics.DrawString("Cash amount  :  " , new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(500, space + 75));
          e.Graphics.DrawString("Balance      :  ", new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(500, space + 100));
          e.Graphics.DrawString(total_amount.Text, new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(650, space+45));
          e.Graphics.DrawString("RS."+ pay_amont.Text, new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(650, space+75));
          e.Graphics.DrawString( balance_text.Text, new Font("Segoe UI", 13, FontStyle.Regular), Brushes.Black, new Point(650, space+100));


           
         
         //   e.Graphics.DrawString("hellow pringting", new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(25, 100));
            // e.Graphics.DrawString("hellow pringting", new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(25,100));
        }

        private void make_bill_Click(object sender, EventArgs e)
        {
           panel3.Show();
           operation_of_item1.Hide();
           change_bill1.Hide();
           userdetails1.Hide();
           analays1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            analays1.Hide();
            userdetails1.Hide();
            change_bill1.Hide();
           operation_of_item1.Show();
           operation_of_item1.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            analays1.Hide();
            userdetails1.Hide();
            operation_of_item1.Hide();
            change_bill1.Show();
            change_bill1.Focus();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            analays1.Hide();
            change_bill1.Hide();
            operation_of_item1.Hide();
            userdetails1.Show();
            userdetails1.Focus();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            operation_of_item1.Hide();
            change_bill1.Hide();
            userdetails1.Hide();
            analays1.Show();
            analays1.Focus();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Form1 intro = new Form1();
            intro.Show();
            this.Hide();
        }

    
       
    }
}
