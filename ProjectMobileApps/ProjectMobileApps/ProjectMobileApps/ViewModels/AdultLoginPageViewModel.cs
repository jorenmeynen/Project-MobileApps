using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMobileApps.ViewModels
{
	public class AdultLoginPageViewModel : ViewModelBase
	{
        public AdultLoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Adult Login Page";
        }
	}
}
