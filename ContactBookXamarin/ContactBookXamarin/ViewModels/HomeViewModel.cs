using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using ContactBookXamarin.Models;
using ContactBookXamarin.Views;

using Xamarin.Forms;


namespace ContactBookXamarin.ViewModels
{
    public class HomeViewModel
    {
        public ObservableCollection<Contacts> Contactos { get; }
        public AddViewModel AddViewModel;
        public ICommand AddCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand AddPageCommand { get; }
        public ICommand ToolbarMoreCommand { get; }
        

        public HomeViewModel()
        {
            Contactos = new ObservableCollection<Contacts>
            {
               new Contacts("Maria","829-854-3269"),
               new Contacts("Pedro","809-373-9036"),
               new Contacts("Florida","849-175-8297")

            };

            


            AddCommand = new Command(OnAddContact);
            DeleteCommand = new Command<Contacts>(OnDeleteContact);
            AddPageCommand = new Command(OnAddPage);
            ToolbarMoreCommand = new Command<Contacts>(OnToolbarMore);
        }

        private async void OnToolbarMore(Contacts contacts)
        {
            string res = await App.Current.MainPage.DisplayActionSheet("Mas", "Cancelar", null, "Call", "Edit");

            switch (res)
            {
                case "Call":
                    Xamarin.Essentials.PhoneDialer.Open(contacts.Number);
                    break;

                case "Edit":
                    break;

            }
        }

        private async void OnAddPage(object obj)
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddPage());
        }

        private void OnDeleteContact(Contacts contacts)
        {
            
                Contactos.Remove(contacts);
            
            
        }

        public void OnAddContact()
        {
            Contactos.Add(new Contacts("Maria", "809-698-7412"));
        }

    }
}
