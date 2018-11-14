using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Portfolio.ViewModels
{
    public class CurriculumViewModel : BaseViewModel
    {
        public CurriculumViewModel()
        {
            Title = "Curriculum";

            Behance = new Command(() => Device.OpenUri(new Uri("http://www.behance.net/vitorfontenelle")));

            GitHub = new Command(() => Device.OpenUri(new Uri("https://github.com/VitorFontenelle?tab=repositories")));
        }

        public ICommand Behance { get; }

        public ICommand GitHub { get; }
    }
}