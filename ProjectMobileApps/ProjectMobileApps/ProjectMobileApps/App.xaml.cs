using Prism;
using Prism.Ioc;
using ProjectMobileApps.ViewModels;
using ProjectMobileApps.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Unity;
using ProjectMobileApps.Contracts;
using ProjectMobileApps.Data;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProjectMobileApps
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<AccountPage>();
            containerRegistry.RegisterForNavigation<ToddlerListPage>();
            containerRegistry.RegisterInstance<ICameraatjeDbContext>(new CameraatjeDbContext("Data Source=cameraatjedb.database.windows.net;Initial Catalog=cameraatjeDB;Integrated Security=False;User ID=eloict;Password=Password0;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
            containerRegistry.RegisterForNavigation<AdultLoginPage>();
        }
    }
}
