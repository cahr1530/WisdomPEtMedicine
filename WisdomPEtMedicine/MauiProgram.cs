using Microsoft.Extensions.Logging;
using WisdomPEtMedicine.DataAccess;
using WisdomPEtMedicine.Extensions;
using WisdomPEtMedicine.Services;
using WisdomPEtMedicine.ViewModels;
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
            builder.ConfigureWisdomPetMedicine();
#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}