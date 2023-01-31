using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Maui.Services.Notifications
{
    public interface IToastService
    {
        Task ShowToast(string message, ToastDuration duration = ToastDuration.Short);
    }
    public class ToastService : IToastService
    {
        private const double FONTSIZE = 14;
        public async Task ShowToast(string message, ToastDuration duration = ToastDuration.Short)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            IToast toast = Toast.Make(message, duration, FONTSIZE);

            await toast.Show(cancellationTokenSource.Token);
        }
    }
}
