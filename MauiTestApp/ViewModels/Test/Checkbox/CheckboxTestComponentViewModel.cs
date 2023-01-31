using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Maui.Services.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.ViewModels.Test.Checkbox
{
    public partial class CheckboxTestComponentViewModel : BaseViewModel
    {
        public CheckboxTestComponentViewModel()
        {

        }

        [RelayCommand]
        public async Task CheckedChanged(bool result)
        {
            await _toastService.ShowToast($"Checked Changed: '{result}'");
        }
    }
}
