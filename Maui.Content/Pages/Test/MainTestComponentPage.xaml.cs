using Maui.Content.ViewModels.Test;

namespace Maui.Content.Pages.Test;

public partial class MainTestComponentPage : ContentPage
{
	public MainTestComponentPage(MainTestComponentPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}