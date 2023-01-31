using Maui.Content.ViewModels.Test.Checkbox;

namespace Maui.Content.Pages.Test.Checkbox;

public partial class CheckboxTestComponentPage : ContentPage
{
	public CheckboxTestComponentPage(CheckboxTestComponentViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}