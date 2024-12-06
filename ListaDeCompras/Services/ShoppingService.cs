using ListaDeCompras.ListaDeComp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListaDeCompras.Services;

public class ShoppingService
{
    private List<ShoppingList> _shoppingList = [];


    public event EventHandler? ShoppingListUpdated;


    public void Add(ShoppingList item)
    {
        _shoppingList.Add(item);
        ShoppingListUpdated?.Invoke(this, EventArgs.Empty);
    }

    public IEnumerable<ShoppingList> GetAll()
    {
        return _shoppingList;
    }

    public void Update(ShoppingList item)
    {
        var shoppingList = _shoppingList.FirstOrDefault(x => x.Item == item.Item);
        if (shoppingList != null)
        {
            shoppingList = item;
            ShoppingListUpdated?.Invoke(this, EventArgs.Empty);
        }
    }

    public void Remove(ShoppingList item)
    {
        var shoppingList = _shoppingList.FirstOrDefault(x => x.Item == item.Item);
        if (shoppingList != null)
        {
            _shoppingList.Remove(shoppingList);
            ShoppingListUpdated?.Invoke(this, EventArgs.Empty);
        }
    }


}
