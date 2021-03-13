using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ContactBookXamarin.Models
{
    public class AddContactos
    {
        private ObservableCollection<Contacts> contactos;

        public AddContactos(string name, string number)
        {
            Name = name;
            Number = number;
        }

        public string Name { get; }
        public string Number { get; }
    }
}
