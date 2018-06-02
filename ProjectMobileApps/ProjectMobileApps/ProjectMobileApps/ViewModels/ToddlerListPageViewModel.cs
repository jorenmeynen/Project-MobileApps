using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMobileApps.ViewModels
{
	public class ToddlerListPageViewModel : ViewModelBase
	{
        private IToddlerRepository toddlerRepository;

        public ToddlerListPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
	}
}
