using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.business_objects
{
    class User
    {
        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public string Name { get; set; }
        public string Password { get; set; }
    }
}
