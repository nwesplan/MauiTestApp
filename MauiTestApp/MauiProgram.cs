using CommunityToolkit.Maui;
using Maui.Services.Notifications;
using MauiTestApp.ViewModels;
using MauiTestApp.ViewModels.Test;
using MauiTestApp.ViewModels.Test.Checkbox;
using MauiTestApp.Views;
using MauiTestApp.Views.Test;
using MauiTestApp.Views.Test.Checkbox;

namespace MauiTestApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
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

		// Services
		builder.Services.AddSingleton<IToastService, ToastService>();

        return builder.Build();
	}
}
