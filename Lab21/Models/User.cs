using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab22.Models
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _password;

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string password { get; set; }

        public User(string FirstName, string LastName, string Email, string Phone, string Password)
        {
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            phone = Phone;
            password = Password;
        }

    }
}