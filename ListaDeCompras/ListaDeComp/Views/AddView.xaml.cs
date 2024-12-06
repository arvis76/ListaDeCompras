using ListaDeCompras.ListaDeComp.ViewModels;

namespace ListaDeCompras.ListaDeComp.Views;

public partial class AddView : ContentPage
{
	public AddView(AddViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}