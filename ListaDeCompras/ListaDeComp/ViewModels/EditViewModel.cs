using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListaDeCompras.ListaDeComp.Models;
using ListaDeCompras.Services;


namespace ListaDeCompras.ListaDeComp.ViewModels;

public partial class EditViewModel : ObservableObject, IQueryAttributable
{
    private readonly ShoppingService _shoppingService;

    public EditViewModel(ShoppingService shoppingService)
    {
        _shoppingService = shoppingService;
    }


    [ObservableProperty]
    private ShoppingList item = new();

    

    [RelayCommand]
    private async Task Update()
    {
        _shoppingService.Update(Item);
        Item = new();

        await Shell.Current.GoToAsync("//ListTodoView");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Item = (query["Item"] as ShoppingList)!;
    }
}
