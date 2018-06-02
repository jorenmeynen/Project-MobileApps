using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Code: Joren Meynen
namespace ProjectMobileApps.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand NavigateCommand { get; private set; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            NavigateCommand = new DelegateCommand(NavigateToBlog);

        }
        private void NavigateToBlog()
        {
            NavigationService.NavigateAsync("AccountPage");
        }
    }
}
