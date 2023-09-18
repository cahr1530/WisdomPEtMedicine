using Microsoft.Extensions.Logging;
using WisdomPEtMedicine.DataAccess;
using WisdomPEtMedicine.Views;

namespace WisdomPEtMedicine
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
            var dbContext = new WpmDbContext();
            dbContext.Database.EnsureCreated();
            dbContext.Dispose();

            Routing.RegisterRoute(nameof(ProductDetailsPage), typeof(ProductDetailsPage));
            Routing.RegisterRoute(nameof(VisitDetailsPage), typeof(VisitDetailsPage));
#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}