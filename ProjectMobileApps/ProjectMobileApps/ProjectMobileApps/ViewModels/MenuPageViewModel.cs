using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace ProjectMobileApps.ViewModels
{
	public class MenuPageViewModel : ViewModelBase
	{
        public MenuPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Menu test Page";

            ToToddlerListCommand = new DelegateCommand(() =>
            {
                NavigationService.NavigateAsync("ToddlerListPage");
            });
            ToAdultLoginCommand = new DelegateCommand(() =>
            {
                NavigationService.NavigateAsync("AdultLoginPage");
            });
        }
        public ICommand ToToddlerListCommand { get; private set; }
        public ICommand ToAdultLoginCommand { get; private set; }
    }
}
