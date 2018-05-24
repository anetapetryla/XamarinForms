using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace TestApp.ViewModels
{
    public class MasterPageViewModel : BindableBase
    {
        public MasterPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private DelegateCommand<string> _navigationCommand;
        public DelegateCommand<string> NavigationCommand => _navigationCommand ?? (_navigationCommand = new DelegateCommand<string>(NavigationMethod));

        private void NavigationMethod(string obj)
        {
            switch (obj)
            {
                case "ViewA":
                    _navigationService.NavigateAsync("MasterDetailPage1/NavigationPage/ViewA");
                    break;
                case "ViewB":
                    _navigationService.NavigateAsync("MasterDetailPage1/NavigationPage/ViewB");
                    break;
                case "BasePage":
                    _navigationService.NavigateAsync("MasterDetailPage1/NavigationPage/BasePage");
                    break;
                default:
                    break;
            }
        }

        private INavigationService _navigationService;
    }
}
