using Microsoft.Extensions.Logging;
using MovieRatingApp.Controls;
using MovieRatingApp.Handlers;
using MovieRatingApp.ViewModels;

namespace MovieRatingApp
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
                    fonts.AddFont("MaterialDesignIcons.ttf", "MaterialDesignIcons");
                });

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.ConfigureMauiHandlers(handlers =>
                {
                    handlers.AddHandler(typeof(RatingView), typeof(RatingHandler));
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
