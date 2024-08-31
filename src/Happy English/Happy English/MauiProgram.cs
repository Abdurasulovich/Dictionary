using CommunityToolkit.Maui;
using epj.RouteGenerator;
using Happy_English.Pages;
using Happy_English.ViewModels;
using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace Happy_English
{
    [AutoRoutes("Page")]
    [ExtraRoute("Dashboard")]
    [ExtraRoute("AddWord")]
    [ExtraRoute("Quiz")]
    [ExtraRoute("QuizStart")]
    [ExtraRoute("QuizResult")]
    [ExtraRoute("Translate")]
    [ExtraRoute("TranslateSaved")]
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<Dashboard>();
            builder.Services.AddTransient<Search>();
            builder.Services.AddTransient<Settings>();
            builder.Services.AddTransient<AddWord>();
            builder.Services.AddTransient<Quiz>();
            builder.Services.AddTransient<QuizStart>();
            builder.Services.AddTransient<QuizResult>();
            builder.Services.AddTransient<Translate>();
            builder.Services.AddTransient<TranslateSaved>();
            // Register ViewModels
            builder.Services.AddScoped<SearchPageViewModel>();
            builder.Services.AddScoped<SettingsPageViewModel>();
            builder.Services.AddScoped<DashboardPageViewModel>();
            builder.Services.AddScoped<AddWordPageViewModel>();
            builder.Services.AddScoped<QuizPageViewModel>();
            builder.Services.AddScoped<QuizStartPageViewModel>();
            builder.Services.AddScoped<QuizResultPageViewModel>();
            builder.Services.AddScoped<TranslatePageViewModel>();
            builder.Services.AddScoped<TranslateSavedPageViewModel>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
