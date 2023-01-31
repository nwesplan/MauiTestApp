using CommunityToolkit.Mvvm.ComponentModel;
using Maui.Services.Notifications;
using MauiTestApp.Helpers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.ViewModels
{
    public abstract partial class BaseViewModel : ObservableObject
    {
        protected readonly IToastService _toastService;

        public BaseViewModel()
        {
            _toastService = ServiceHelper.GetService<IToastService>();
        }
        /*public BaseViewModel() : this(IToastService toastService)
        { 
        }*/
    }
}
