using Prism.Commands;
using Plugin.Media;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using Firebase.Storage;
using Firebase.Auth;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Plugin.Media.Abstractions;

namespace ProjectMobileApps.ViewModels
{
	public class CameraPageViewModel : ViewModelBase
	{
        IPageDialogService _dialogService;

        public CameraPageViewModel(INavigationService navigationService, IPageDialogService dialogService)
            : base(navigationService)
        {
            Title = "Camera";

            _dialogService = dialogService;
            TakePhotoCommand = new DelegateCommand(TakePhoto);
        }

        private ImageSource source;
        public ImageSource Source
        {
            get { return source; }
            set { SetProperty(ref source, value); }
        }

        private string _title;

        private string _buttonTitle = "Take a Photo";

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

            try
            {
                string ApiKey = "AIzaSyBGm7LABs10dXNcZQ5CTeRvuP1zxGUYfDA";
                string Bucket = "cameraatjefb.appspot.com";
                string AuthEmail = "joren.meynen@telenet.be";
                string AuthPassword = "azertyuiop";


                // of course you can login using other method, not just email+password
                var auth = new FirebaseAuthProvider(new FirebaseConfig(ApiKey));
                var a = await auth.SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);

                //Firebase Upload
                // Constructr FirebaseStorage, path to where you want to upload the file and Put it there
                var task = new FirebaseStorage(
                    Bucket,
                    new FirebaseStorageOptions
                    {
                        AuthTokenAsyncFactory = () => Task.FromResult(a.FirebaseToken),
                    })
                    .Child("images")
                    .Child((Convert.ToString(DateTime.Now.ToString("yyyyMMdd-HHmmss")) + ".jpg"))
                    .PutAsync(file.GetStream());

                // await the task to wait until upload completes and get the download url
                var downloadUrl = await task;
                await _dialogService.DisplayAlertAsync("Download Url", downloadUrl, "OK");

                //Firebase download
                Source = downloadUrl;
            }
            catch (Exception ex)
            {
                await _dialogService.DisplayAlertAsync("Exception was thrown", ex.Message, "OK");
            }
        }
    }
}
