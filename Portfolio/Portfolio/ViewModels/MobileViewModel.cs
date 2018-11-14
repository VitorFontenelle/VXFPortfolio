using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Portfolio.ViewModels
{
    public class MobileViewModel : BaseViewModel
    {
        public MobileViewModel()
        {
            Title = "Mobile";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}