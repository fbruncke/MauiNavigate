using MauiNavigate.Model;
using MauiNavigate.ViewModel;
using System.Collections.ObjectModel;

namespace MauiNavigate.View;

public partial class ItemView : ContentPage
{
    private ItemViewModel ivm = null;
    public ItemView(ref ObservableCollection<Item> items)
	{
        

        InitializeComponent();

        ivm = new ItemViewModel();
        BindingContext = ivm;
        ivm.items = items;

    }
}