using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ProjectMobileApps.Contracts;
using ProjectMobileApps.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMobileApps.ViewModels
{
	public class ToddlerListPageViewModel : ViewModelBase
	{
        public ToddlerListPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Kleuterlijst";
        }


        //private IList<Toddler> toddlers;
        //public IList<Toddler> Toddlers
        //{
        //    set { SetProperty(ref toddlers, value); }
        //    get { return toddlers; }
        //}
	}
}
