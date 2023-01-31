using MauiTestApp.ViewModels.Test;

namespace MauiTestApp.Views.Test;

public partial class MainTestComponentPage : ContentPage
{
    public MainTestComponentPage(MainTestComponentPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}