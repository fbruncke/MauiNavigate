using MauiNavigate.ViewModel;

namespace MauiNavigate.View;

public partial class ShoppingListView : ContentPage
{
	private ShoppingListViewModel slvm = null;
    public ShoppingListView()
	{
        slvm = new ShoppingListViewModel();
		BindingContext = slvm;
		InitializeComponent();
	}
}