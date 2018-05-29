using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;

namespace TestApp.ViewModels
{
    public class LoginPageViewModel : BindableBase, INavigationAware
    {
        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));

        private void Login()
        {
            _navigationService.NavigateAsync("/MasterDetailPage1/NavigationPage/BasePage");
        }

        private INavigationService _navigationService;
    }
}
