using System;
using System.Collections.Generic;
using System.Text;

namespace Uzun_Task_tekrar.Models
{
    internal class User:IAccount
    {
        private static int _id;
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password {
            get
            {
                return _password;
            }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }

            }
        }

        public User(string email, string password)
        {
            _id++;
            Id = _id;
            Email = email;
            Password = password;
        }

        public bool PasswordChecker(string password)
        {
            bool hasUpper = false;
            bool hasNumber = false;
            bool hasLower = false;

            if (password.Length >= 8)
            {
                foreach (var ch in password)
                {
                    if (char.IsUpper(ch))
                    {
                        hasUpper = true;
                    }
                    if (char.IsNumber(ch))
                    {
                        hasNumber = true;
                    }
                    if (char.IsLower(ch))
                    {
                        hasLower = true;
                    }
                }
            }
                return true;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id} / Fullname: {Fullname} / Email: {Email}");
        }
    }
}
