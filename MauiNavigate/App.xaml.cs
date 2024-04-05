using MauiNavigate.View;

namespace MauiNavigate;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        var shopList = new ShoppingListView();
        NavigationPage.SetHasNavigationBar(shopList, false);
        MainPage = new NavigationPage(shopList);        



    }
}
