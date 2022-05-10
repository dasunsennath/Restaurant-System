using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


namespace Domain
{
    public class usermodel
    {
        userdao userdao = new userdao();
        public bool loginuser (string user, string pass)
        {
            return userdao.login(user, pass);
        }

        public void account (string username,string password , string firstname , string lastname,string position,string email)
        {
            userdao.create_account(username, password, firstname, lastname, position, email);
        }

    }
}
