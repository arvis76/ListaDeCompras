using ListaDeCompras.ListaDeComp.ViewModels;

namespace ListaDeCompras.ListaDeComp.Views;

public partial class ListTodoView : ContentPage
{
	public ListTodoView(ListViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}