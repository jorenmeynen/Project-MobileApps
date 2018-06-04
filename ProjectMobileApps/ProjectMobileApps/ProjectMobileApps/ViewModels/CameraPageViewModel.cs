using Plugin.Media;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectMobileApps.ViewModels
{
	public class CameraPageViewModel : ViewModelBase
	{
        public CameraPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
            :base(navigationService)
        {
            Title = "Camera";

            _dialogService = dialogService;
            TakePhotoCommand = new DelegateCommand(TakePhoto);
        }

        private string _title;

        private string _buttonTitle = "Take a Photo";
        private IPageDialogService _dialogService;

        public string ButtonTitle
        {
            get { return _buttonTitle; }
            set { SetProperty(ref _title, value); }
        }


        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }

        public DelegateCommand TakePhotoCommand { get; set; }


        private async void TakePhoto()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await _dialogService.DisplayAlertAsync("No Camera", ":( No camera avaialble.", "OK");

                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await _dialogService.DisplayAlertAsync("File Location", file.Path, "OK");

            /* image.Source = ImageSource.FromStream(() =>
           {
               var stream = file.GetStream();
               file.Dispose();
               return stream;
           } 
           ); */
        }
    }
}
