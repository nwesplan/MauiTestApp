using Maui.Content.Pages;
using Maui.Content.Pages.Test;
using Maui.Content.Pages.Test.Checkbox;
using Maui.Content.ViewModels;
using Maui.Content.ViewModels.Test;
using Maui.Content.ViewModels.Test.Checkbox;

namespace MauiTestApp;

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

		// Pages
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageViewModel>();

        // Test Pages
        builder.Services.AddScoped<MainTestComponentPage>();
        builder.Services.AddScoped<MainTestComponentPageViewModel>();

        builder.Services.AddScoped<CheckboxTestComponentPage>();
        builder.Services.AddScoped<CheckboxTestComponentViewModel>();
        return builder.Build();
	}
}
