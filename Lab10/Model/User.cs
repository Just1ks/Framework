using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Model
{
    public class User
    {
        private string name;
        private string surname;
        private string email;

        public User(string name, string surname, string email)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetEmail()
        {
            return email;
        }

        public void SetName(string name)
        {
            this.name= name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }
    }
}
