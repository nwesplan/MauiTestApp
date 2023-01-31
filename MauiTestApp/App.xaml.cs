﻿using Maui.Content.Pages.Test;
using Maui.Content.Pages.Test.Checkbox;

namespace MauiTestApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		// Test Pages
		Routing.RegisterRoute(nameof(MainTestComponentPage), typeof(MainTestComponentPage));
        Routing.RegisterRoute(nameof(CheckboxTestComponentPage), typeof(CheckboxTestComponentPage));
    }
}
