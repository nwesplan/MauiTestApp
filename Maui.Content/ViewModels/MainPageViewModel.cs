using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.Content.Pages.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui.Content.ViewModels
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
