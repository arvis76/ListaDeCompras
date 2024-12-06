using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListaDeCompras.ListaDeComp.Models;
using ListaDeCompras.Services;

namespace ListaDeCompras.ListaDeComp.ViewModels;

public partial class AddViewModel : ObservableObject
{
    private readonly ShoppingService _shoppingService;

    public AddViewModel(ShoppingService shoppingService)
    {
        _shoppingService = shoppingService;
    }

    [ObservableProperty]
    private ShoppingList item = new ();

    

    [RelayCommand]
    private async Task Add()
    {
        _shoppingService.Add(Item);
        Item = new();
        await Shell.Current.GoToAsync("//ListTodoView");
    }
}
