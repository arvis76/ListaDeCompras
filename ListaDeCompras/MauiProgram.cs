using ListaDeCompras.ListaDeComp.ViewModels;
using ListaDeCompras.ListaDeComp.Views;
using ListaDeCompras.Services;
using Microsoft.Extensions.Logging;

namespace ListaDeCompras
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ShoppingService>();

            builder.Services.AddSingleton<ListViewModel>();
            builder.Services.AddSingleton<ListTodoView>();

            builder.Services.AddSingleton<AddViewModel>();
            builder.Services.AddSingleton<AddView>();

            builder.Services.AddSingleton<EditViewModel>();
            builder.Services.AddSingleton<EditView>();

            return builder.Build();
        }
    }
}
