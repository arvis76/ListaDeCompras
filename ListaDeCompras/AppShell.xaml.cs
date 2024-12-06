using ListaDeCompras.ListaDeComp.Views;
namespace ListaDeCompras
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ListTodoView), typeof(ListTodoView));
            Routing.RegisterRoute(nameof(AddView), typeof(AddView));
            Routing.RegisterRoute(nameof(EditView), typeof(EditView));
        }
    }
}
