using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Portfolio.ViewModels
{
    public class DesktopViewModel : BaseViewModel
    {
        public DesktopViewModel()
        {
            Title = "Desktop";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}