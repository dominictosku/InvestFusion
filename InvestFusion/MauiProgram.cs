using InvestFusion.Core.Interfaces;
using InvestFusion.Core.Services;
using InvestFusion.Services;
using Microsoft.Extensions.Logging;
using Radzen;

namespace InvestFusion
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddRadzenComponents();
            builder.Services.AddScoped<ContextMenuService>();
            builder.Services.AddScoped<DialogService>();
            builder.Services.AddTransient<IExcelService, ExcelService>();
            builder.Services.AddTransient<AccountService>();
            builder.Services.AddTransient<AccountTransactionService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
