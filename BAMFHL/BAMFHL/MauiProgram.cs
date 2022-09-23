using BAMFHL.Services;
using BAMFHL.ViewModels;
using BAMFHL.Views;

namespace BAMFHL;

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

		builder.Services.AddSingleton<AuthenticationService>();
		builder.Services.AddSingleton<WelcomeViewModel>();
		builder.Services.AddSingleton<WelcomePage>();

		return builder.Build();
	}
}
