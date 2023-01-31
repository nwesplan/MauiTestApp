using Android.Service.QuickSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.Helpers.Services
{
    public static class ServiceHelper
    {
        public static TService GetService<TService>() => Current.GetService<TService>();
        public static IServiceProvider Current => MauiApplication.Current.Services;
    }
}
