using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace ContactApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
	.UseMauiApp<App>()
	.UseMauiCommunityToolkit();
		//         .ConfigureFonts(fonts =>
		//{
		//	fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
		//	fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
		//});
		builder.ConfigureFonts(fonts =>
		{
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
           	fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });




#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
