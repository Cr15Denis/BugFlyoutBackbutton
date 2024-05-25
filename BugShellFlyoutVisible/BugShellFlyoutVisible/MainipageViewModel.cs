using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BugShellFlyoutVisible
{
    public class MainipageViewModel
    {
        public ICommand OpenPageCommand { get;}
        //public Command GoBackCommand { get; }
        public MainipageViewModel()
        {
            OpenPageCommand = new Command(OpenPage);
            //GoBackCommand = new Command(ExecuteGoBack);
        }

        private async void OpenPage()
        {
            await Shell.Current.GoToAsync(nameof(Page2));
        }
        //private async void ExecuteGoBack()
        //{
        //    await Shell.Current.Navigation.PopAsync();
        //}
    }
}
