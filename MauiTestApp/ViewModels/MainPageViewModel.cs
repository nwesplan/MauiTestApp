using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTestApp.Views.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        public MainPageViewModel()
        {

        }

        [RelayCommand]
        public async Task TestComponentsPage()
        {
            await Shell.Current.GoToAsync(nameof(MainTestComponentPage));
        }
    }
}
