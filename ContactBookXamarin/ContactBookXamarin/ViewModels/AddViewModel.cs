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
    public class AddViewModel {


        public ObservableCollection<AddContactos> AddContactos;
        

        public string LabelNombre { get; }
        public string LabelNumero { get; }
  

        public ICommand AddContactCommand { get; }

        //public AddViewModel(ObservableCollection<AddContactos> contactos) {
            

        //    AddContactCommand = new Command(OnAddContact);

          
        //}

      

        public async void OnAddContact()
        {
            
            AddContactos.Add(new AddContactos(LabelNombre, LabelNumero));
            await App.Current.MainPage.DisplayAlert("Succed", "Your contact have been save", "OK");
            await App.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
      
    
}

