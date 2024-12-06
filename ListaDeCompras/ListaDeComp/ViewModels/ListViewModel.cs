using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListaDeCompras.ListaDeComp.Models;
using ListaDeCompras.Services;
using System.Collections.ObjectModel;


namespace ListaDeCompras.ListaDeComp.ViewModels;

public partial class ListViewModel : ObservableObject
{
    private readonly ShoppingService _shoppingservice;

    public ListViewModel(ShoppingService shoppingservice)
    {
        _shoppingservice = shoppingservice;

        _shoppingservice.ShoppingListUpdated += (sender, e) =>
        {
            ShoppingLists = new ObservableCollection<ShoppingList>(_shoppingservice.GetAll());
        };
    }


    [ObservableProperty]
    public ObservableCollection<ShoppingList> shoppingLists = [];

   

    [RelayCommand]
    private async Task NavigateToAdd(ShoppingList item)
    {
        await Shell.Current.GoToAsync("AddView");
    }

    [RelayCommand]
    private async Task NavigateToEdit(ShoppingList item)
    {
        var parameters = new ShellNavigationQueryParameters
        {
            {"Item", item }
        };
        await Shell.Current.GoToAsync("EditView", parameters);
    }
    [RelayCommand]
    private void Remove(ShoppingList item)
    {
        _shoppingservice.Remove(item);
        ShoppingLists = new ObservableCollection<ShoppingList>(_shoppingservice.GetAll());
    }
}
