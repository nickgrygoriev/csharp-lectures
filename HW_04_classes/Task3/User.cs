using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class User
    {
        readonly string _creationDate;

        public User(string login, string name, string surname, uint age, string creationDate)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            _creationDate = creationDate;
        }

        public string Login { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public uint Age { get; set; }

        public string CreationDate
        {
            get { return _creationDate; }
        }

    }
}