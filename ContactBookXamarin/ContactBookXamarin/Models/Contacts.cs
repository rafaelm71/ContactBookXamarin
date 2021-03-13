using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBookXamarin.Models
{
    public class Contacts
    {
        public Contacts(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; }
        public string Number { get; }
    }
}
