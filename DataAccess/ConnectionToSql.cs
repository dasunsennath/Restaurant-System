using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        public readonly string connectoinstring;
        public  ConnectionToSql()
        {
           // connectoinstring = "server = LAPTOP-MK0AI95J\\SQLEXPRESS; Database = macdonald_database; integrated security = true";
            connectoinstring = "server=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\MC setup file\\database\\macdonald_database.mdf;Integrated Security=True;";
        }

        protected SqlConnection getconnection ()
        {
            SqlConnection  sdl =  new SqlConnection(connectoinstring);
            return sdl; 
        }
           
    }
}
