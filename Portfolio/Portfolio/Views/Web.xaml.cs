using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Web : ContentPage
    {
        public Web()
        {
            InitializeComponent();
        }

        async void GoToProjectHermes()
        {
            await Navigation.PushAsync(new Hermes());
        }
    }
}