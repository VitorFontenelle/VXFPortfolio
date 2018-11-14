using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mobile : ContentPage
    {
        public Mobile()
        {
            InitializeComponent();
        }

        async void GoToProjectVemGente()
        {
            await Navigation.PushAsync(new VemGente());
        }
    }
}