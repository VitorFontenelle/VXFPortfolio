using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Desktop : ContentPage
    {
        public Desktop()
        {
            InitializeComponent();
        }

        async void GoToProjectCMC()
        {
            await Navigation.PushAsync(new CMC());
        }

        async void GoToProjectCRMFI()
        {
            await Navigation.PushAsync(new CRMFI());
        }
    }
}