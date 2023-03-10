using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.Models.Routing;
using MauiTestApp.Views.Test.Checkbox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.ViewModels.Test
{
    public partial class MainTestComponentPageViewModel : ObservableObject
    {
        public MainTestComponentPageViewModel()
        {
            TestComponents = new ObservableCollection<RouteModel> { new RouteModel("Checkbox / Label", nameof(CheckboxTestComponentPage)) };
        }

        [ObservableProperty]
        ObservableCollection<RouteModel> testComponents;

        [RelayCommand]
        public async Task OpenTestPage(object obj)
        {
            try
            {
                if (obj is RouteModel routeModel)
                {
                    await Shell.Current.GoToAsync(routeModel.Route);
                }
            }
            catch (Exception ex)
            {
                // show error
            }
        }
    }
}
