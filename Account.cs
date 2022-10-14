using System;
using System.Collections.Generic;
using System.Text;

namespace Create_Class
{
    class Account
    {

        public string Login(string username, string password)
        {

            if (CheckUser(username, password))
            {
                return "Access is successful.";
            }
            else
            {
                return "Username or password is wrong.";
            }
        }

        public bool CheckUser(string username, string password)
        {
            if (username == "cavid123" && password == "Cavid1993")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
