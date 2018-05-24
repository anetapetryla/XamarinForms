using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Diagnostics;

namespace TestApp.ViewModels
{
    public class BasePageViewModel : BindableBase, INavigationAware
    {
        public BasePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("OnNavigatedTo");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("OnNavigatingTo");
        }

        private DelegateCommand _navigationCommand;
        public DelegateCommand NavigationCommand => _navigationCommand ?? (_navigationCommand = new DelegateCommand(NavigationMethod));

        private void NavigationMethod()
        {
            _navigationService.NavigateAsync("ViewA");               
        }

        private INavigationService _navigationService;
    }
}
