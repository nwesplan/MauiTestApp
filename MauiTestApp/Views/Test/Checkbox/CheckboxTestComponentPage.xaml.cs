using MauiTestApp.ViewModels.Test.Checkbox;

namespace MauiTestApp.Views.Test.Checkbox;

public partial class CheckboxTestComponentPage : ContentPage
{
    public CheckboxTestComponentPage(CheckboxTestComponentViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}