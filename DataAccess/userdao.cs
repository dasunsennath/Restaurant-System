using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using common.cache;
using System.Collections;

namespace DataAccess
{
    public class userdao : ConnectionToSql
    {

        public void create_account(string username, string password, string firstname, string lastname, string position, string email)
        {
            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into users values ( @username, @password, @firstname, @lastname, @position, @email)";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@email", email);
                    command.CommandType = CommandType.Text;

                    command.ExecuteNonQuery();

                }
            }
        }

        public bool login(string user, string pass)
        {
            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "  select * from users where Login_name = @user and Password =  @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usercache.userid = reader.GetInt32(0);
                            usercache.firstname = reader.GetString(3);
                            usercache.lastname = reader.GetString(4);
                            usercache.position = reader.GetString(5);
                            usercache.email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }


        public DataTable dtbl = new DataTable();
        public void setdata_to_dataview()
        {
            using (var connection = getconnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = " select * from Item order by item_id  desc";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter sqld = new SqlDataAdapter(command.CommandText, getconnection());
                    sqld.Fill(dtbl);

                }
            }
        }


        public string get_connectsion()
        {
            return connectoinstring;

        }

        public void insert_into_bil(string date, string time)
        {
            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into bill(bill_date,bill_time)values(@billdate,@cutime)";
                    command.Parameters.AddWithValue("@billdate", date);
                    command.Parameters.AddWithValue("@cutime", time);

                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }
        public void inser_bill_datail(string item_name, string qntity)
        {
            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert  into bill_items(bill_no,item_no,quantity)  values (@bill_id,@item_id,@quantity)";
                    command.Parameters.AddWithValue("@bill_id", getbilId(usercache.today, usercache.current_time));
                    command.Parameters.AddWithValue("@item_id", this.getitem_id(item_name));
                    command.Parameters.AddWithValue("@quantity", qntity);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();

                }
            }
        }

        public string getitem_id(string item_name)
        {

            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select item_id from Item where  item_name = @item_name ";
                    command.Parameters.AddWithValue("@item_name", item_name);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usercache.itemid = reader.GetString(0);
                        }
                    }
                    return usercache.itemid;
                }
            }
        }

        public int getbilId(string date, string time)
        {
            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select bill_no from bill where bill_date = @billdate and bill_time =  @cutime ";
                    command.Parameters.AddWithValue("@billdate ", date);
                    command.Parameters.AddWithValue("@cutime", time);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usercache.billid = reader.GetInt32(0);
                        }
                    }
                    return usercache.billid;
                }
            }
        }



        public void get_itemtable_with_categoryname()
        {
            using (var connection = getconnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = " select i.item_id , i.item_name,i.uni_price,c.category_name from Item  i , category c where i.category_id = c.category_id ";
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter sqld = new SqlDataAdapter(command.CommandText, getconnection());
                    sqld.Fill(dtb2);

                }
            }
        }

        public bool add_values_to_cegegory(string item_id, string item_name, string unit_price, string category_name)
        {
            bool is_succsss;

            try
            {
                using (var connection = getconnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "insert into Item values(@item_id,@item_name,@unit_price,@category_id)";
                        command.Parameters.AddWithValue("@category_id", get_cetogory_id(category_name));
                        command.Parameters.AddWithValue("@unit_price", unit_price);
                        command.Parameters.AddWithValue("@item_name", item_name);
                        command.Parameters.AddWithValue("@item_id", item_id);

                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        is_succsss = true;
                         return  is_succsss;
                    }
                }
            }
            catch(Exception)
            {
                is_succsss = false;
                return is_succsss ;
            }
       }
        
          


             public string get_cetogory_id( string category_name)
             {
                 using (var connection = getconnection())
                 {
                     connection.Open();
                     using (var command = new SqlCommand())
                     {
                         command.Connection = connection;
                         command.CommandText = "select category_id from category where category_name = @category_name ";
                         command.Parameters.AddWithValue("@category_name", category_name);
                         command.CommandType = CommandType.Text;
                         command.ExecuteNonQuery();
                         SqlDataReader reader = command.ExecuteReader();
                         if (reader.HasRows)
                         {
                             while (reader.Read())
                             {
                                 usercache.category_id = reader.GetString(0);
                             }
                         }
                         return usercache.category_id;
                     }
                 }
             }

        public bool update_ietem (string item_name, string item_no , string uni_price, string category_name)
             {
                 bool is_succes = false;
                 try
                 {
                     using (var connection = getconnection())
                     {
                         connection.Open();

                         using (var command = new SqlCommand())
                         {
                             command.Connection = connection;
                             command.CommandText = " update Item set item_name = @item_name, uni_price =@unit_price,category_id= @category_id where  item_id = @item_id";
                             command.Parameters.AddWithValue("@item_name", item_name);
                             command.Parameters.AddWithValue("@item_id", item_no);
                             command.Parameters.AddWithValue("@unit_price", uni_price);
                             command.Parameters.AddWithValue("@category_id", get_cetogory_id(category_name));
                             command.CommandType = CommandType.Text;
                             command.ExecuteNonQuery();
                             is_succes = true;
                             return  is_succes;
                         }
                     }
                 }
            catch(Exception)
                 {
                     is_succes = false;
                     return  is_succes;
                 }
             }
        
        public  bool delete_ietem(string item_id)
        {
            bool is_succes = false;

            try
            {
                using (var connection = getconnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = " delete from Item where item_id = @item_id";
                        command.Parameters.AddWithValue("@item_id", item_id);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        is_succes = true;
                        return is_succes;
                    }
                }
            }
            catch (Exception)
            {
                is_succes = false;
                return is_succes;
            }
        }


        public DataTable dtb2 = new DataTable();
        public void change_bill(String bill_id)
        {
            using (var connection = getconnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    command.CommandText = "select bill_items.bill_no ,bill_items.quantity , bill_items.item_no,Item.item_name , Item.uni_price from dbo.bill_items,dbo.Item where bill_items.item_no = Item.item_id and bill_items.bill_no= " + bill_id;
                  //  command.Parameters.AddWithValue("@bill_id", bill_id);
                    command.CommandType = CommandType.Text;
                    SqlDataAdapter sqld = new SqlDataAdapter(command.CommandText, getconnection());
                    sqld.Fill(dtb2);

                }
            }
        }

        public bool delete_bill(string bill_id)
        {
            bool is_succes = false;

                using (var connection = getconnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText =  "delete from dbo.bill_items where bill_no ='"+bill_id+"'";
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        command.Connection = connection;
                        command.CommandText = " delete from bill where bill_no = '" + bill_id + "'";
                       // command.Parameters.AddWithValue("@bill_id", bill_id);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                      //  delete_bill2(bill_id);
                        is_succes = true;
                        return is_succes;
                    }

                   
                }
            
            
        }

    /*    public bool delete_bill2(string bill_id)
        {
            bool is_succes = false;

            using (var connection = getconnection())
            {
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = " delete from bill where bill_no = '"+bill_id+"'";
                  //  command.Parameters.AddWithValue("@bill_id", bill_id);
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    is_succes = true;
                    return is_succes;
                }
            }



        }
        */

        public bool update_bill(string bill_id,string item_id,string quantity)
        {
            bool is_succes = false;

           
                using (var connection = getconnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText =  "update bill_items set quantity = @quantity where  bill_no = @bill_id and item_no = @item_id";
                        command.Parameters.AddWithValue("@bill_id", bill_id);
                        command.Parameters.AddWithValue("@item_id", item_id);
                        command.Parameters.AddWithValue("@quantity",quantity);
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        is_succes = true;
                        return is_succes;
                    }
                }
            }
           
        


        public bool delete_bill_item(string bill_id, string item_id)
        {
            bool is_succes = false;

            try
            {
                using (var connection = getconnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = " delete from bill_items where  bill_no = @bill_id and item_no = @item_id";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@bill_id", bill_id);
                        command.Parameters.AddWithValue("@item_id", item_id);
                        command.ExecuteNonQuery();
                        is_succes = true;
                        return is_succes;
                    }
                }
            }
            catch (Exception)
            {
                is_succes = false;
                return is_succes;
            }
        }

       public DataTable dt3 = new DataTable();
        public bool getbilldatials()
        {
            bool is_succes = false;

            try
            {
                using (var connection = getconnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select b.bill_no,t.item_name,i.quantity,t.uni_price,b.bill_date,b.bill_time from bill_items i,bill b,Item t where b.bill_no = i.bill_no and i.item_no = t.item_id;";
                        command.CommandType = CommandType.Text;
                        SqlDataAdapter sqld = new SqlDataAdapter(command.CommandText, getconnection());
                        sqld.Fill(dt3);
                        is_succes = true;
                        return is_succes;
                    }
                }
            }
            catch (Exception)
            {
                is_succes = false;
                return is_succes;
            }
        }


        public DataTable dt4 = new DataTable();
        public bool getbilldatialswhith_date(string date)
        {
            bool is_succes = false;

          
                using (var connection = getconnection())
                {
                    connection.Open();

                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select b.bill_no,t.item_name,i.quantity,t.uni_price,b.bill_date,b.bill_time from bill_items i,bill b,Item t where b.bill_no = i.bill_no and i.item_no = t.item_id and b.bill_date like '%"+date+"%'";
                       // command.Parameters.AddWithValue("@billdate", date);
                        command.CommandType = CommandType.Text;
                        SqlDataAdapter sqld = new SqlDataAdapter(command.CommandText, getconnection());
                        sqld.Fill(dt4);
                        is_succes = true;
                        return is_succes;
                    }
                
            }
           
        }

      // public ArrayList week_month = new ArrayList();
     //  public ArrayList profite = new ArrayList();
    //  public object[] week_month = new object[12];
      public object[] profite = new object[13];
        public void analisis(string startdate, string enddate)
        {
            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select DATEDIFF(WEEK,DATEADD(week,datediff(day,0,dateadd(month,datediff(month,0,convert (datetime ,convert(varchar,bill_date,23))),0))/7,0),convert (datetime ,convert(varchar,bill_date,23))-1)+1 as week_of,sum(quantity*uni_price) as income  from dbo.bill, bill_items b, Item i where (bill_date between '"+startdate+"' and  '"+enddate+"') and bill.bill_no = b.bill_no and i.item_id = b.item_no group by DATEDIFF(WEEK,DATEADD(week,datediff(day,0,dateadd(month,datediff(month,0,convert (datetime ,convert(varchar,bill_date,23))),0))/7,0),convert (datetime ,convert(varchar,bill_date,23))-1)+1 ";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                         // object[] week_month = new object[12];
                           //object[] profite = new object[12];
                        refres();
                        while (reader.Read())
                        {
                           // week_month.SetValue( reader.GetInt32(0),count);
                            profite.SetValue(reader.GetDouble(1), reader.GetInt32(0));
                         
                        }
                       
                    }
                    else
                    {
                        refres();
                    }
                   
                }
            }
        }



        public void analisis_2(string startdate, string enddate)
        {
            using (var connection = getconnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = " select DATEPART(MONTH,bill_date) as week , sum(quantity*uni_price)from dbo.bill,Item i,bill_items b where i.item_id = b.item_no and (bill_date between '"+startdate+"' and '"+enddate+"') and (bill.bill_no = b.bill_no) group by DATEPART(MONTH,bill_date) order by DATEPART(MONTH,bill_date)";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // object[] week_month = new object[12];
                        //object[] profite = new object[12];
                        refres();
                        while (reader.Read())
                        {
                            // week_month.SetValue( reader.GetInt32(0),count);
                            profite.SetValue(reader.GetDouble(1), reader.GetInt32(0));

                        }

                    }
                    else
                    {
                        refres();
                    }

                }
            }
        }

        public void refres()
        {
            for (int i = 0; i < profite.Length; i++)
            {
                profite.SetValue(null, i);
            }
        }
     
    }
}
