using ListaDeCompras.ListaDeComp.ViewModels;

namespace ListaDeCompras.ListaDeComp.Views;

public partial class EditView : ContentPage
{
	public EditView(EditViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}