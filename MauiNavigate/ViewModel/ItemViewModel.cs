using MauiNavigate.Model;
using MauiNavigate.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiNavigate.ViewModel
{
    internal class ItemViewModel : BindableObject
    {
        public ObservableCollection<Item> items = null;

        //public ObservableCollection<Item> Items
        //{
        //    get { return items; }
        //    set { items = value; OnPropertyChanged(); }
        //}

        private Item item = new Item();

        public Item ItemProp
        {
            get { return item; }
            set { item = value; OnPropertyChanged(); }
        }

        public ICommand AddItem => new Command(async () =>
        {
            items.Add(item);    
            await App.Current.MainPage.Navigation.PopAsync(true);

        });


        public ICommand BackToList => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PopAsync(true);

        });
    }
}
