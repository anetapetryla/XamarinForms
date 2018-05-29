using Prism;
using Prism.Navigation;
using Prism.Ioc;
using Prism.Unity;
using TestApp.ViewModels;
using TestApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace TestApp
{
	public partial class App : PrismApplication
    {
        public static NavigationPage nav;

        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MasterDetailPage1, MasterDetailPage1ViewModel>();
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
            containerRegistry.RegisterForNavigation<BasePage, BasePageViewModel>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        }

        protected async override void OnInitialized()
        {
            await NavigationService.NavigateAsync("LoginPage");
        }
    }
}
