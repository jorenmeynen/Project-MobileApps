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
	public class CornerPageViewModel : ViewModelBase
	{
        private ICameraatjeRepository cameraatjeRepository;

        public CornerPageViewModel(INavigationService navigationService, ICameraatjeRepository cameraatjeRepository)
            : base(navigationService)
        {
            Title = "Hoekenlijst";

            this.cameraatjeRepository = cameraatjeRepository;
        }

        private IList<Corner> corners;
        public IList<Corner> Corners
        {
            set { SetProperty(ref corners, value); }
            get { return corners; }
        }

        public async override void OnNavigatedTo(NavigationParameters parameters)
        {
            Corners = await cameraatjeRepository.GetCornersAsync();
        }
    }
}
