using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Portfolio.ViewModels
{
    public class WebViewModel : BaseViewModel
    {
        public WebViewModel()
        {
            Title = "Web";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}