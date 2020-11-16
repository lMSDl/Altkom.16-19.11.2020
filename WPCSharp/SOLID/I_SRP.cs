using System;
using System.Collections.Generic;
using System.Text;

namespace WPCSharp.SOLID.S
{
    /*public abstract class ReportPrinter
    {
        public abstract string GetData();
        public abstract void FormatDocument();
        public abstract void PrintReport();
    }*/


    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    class Validator
    {
        public bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }

    /*class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public bool ValidateEmail()
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(Email);
                return addr.Address == Email;
            }
            catch
            {
                return false;
            }
        }
    }*/
}
