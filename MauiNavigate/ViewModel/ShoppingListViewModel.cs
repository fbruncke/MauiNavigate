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
    internal class ShoppingListViewModel : BindableObject
    {
        #region getters/setters
        private String testString = "Test Value";

        public String TestString
        {
            get { return testString; }
            set { testString = value; OnPropertyChanged(); }
        }

        private ObservableCollection<Item> items = new ObservableCollection<Item>();

        public ObservableCollection<Item> Items
        {
            get { return items; }
            set { items = value; OnPropertyChanged(); }
        }


        #endregion

        internal ShoppingListViewModel()
        {
            this.Items.Add(new Item {Description="Radio", Price=99, Quantity=1 });
        }

        public ICommand AddItem => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new ItemView(ref this.items));
        });

        public ICommand ItemTapCMD => new Command<Item>(async (Item selectedItem) => {
            System.Diagnostics.Debug.WriteLine("selectedItem: " + selectedItem.Description);
            
        });


    }
}
