using Prism.Commands;
using Prism.Events;
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
        private ICameraatjeRepository cameraatjeRepository;

        public ToddlerListPageViewModel(INavigationService navigationService, ICameraatjeRepository cameraatjeRepository)
            : base(navigationService)
        {
            Title = "Kleuterlijst";

            this.cameraatjeRepository = cameraatjeRepository;


        }
        private IList<Toddler> toddlers;
        public IList<Toddler> Toddlers
        {
            set { SetProperty(ref toddlers, value); }
            get { return toddlers; }
        }

        private Toddler selectedToddler;
        public Toddler SelectedToddler
        {
            get { return selectedToddler; }
            set
            {
                if (SetProperty(ref selectedToddler, value) && selectedToddler != null)
                {
                    var p = new NavigationParameters();
                    p.Add("Toddler", SelectedToddler);
                    NavigationService.NavigateAsync("CornerPage", p);
                    SelectedToddler = null;
                }
            }
        }

        public async override void OnNavigatedTo(NavigationParameters parameters)
        {
            Toddlers = await cameraatjeRepository.GetToddlersAsync();
        }
    }
}
