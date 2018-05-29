using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.ViewModels
{
    class MasterDetailPage1ViewModel : BindableBase
    {
        public MasterDetailPage1ViewModel(INavigationService navigationService)
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
                    _navigationService.NavigateAsync("NavigationPage/ViewA");
                    break;
                case "ViewB":
                    _navigationService.NavigateAsync("NavigationPage/ViewB");
                    break;
                case "BasePage":
                    _navigationService.NavigateAsync("NavigationPage/BasePage");
                    break;
                case "Logout":
                    _navigationService.NavigateAsync("NavigationPage/LoginPage");
                    break;
                default:
                    break;
            }
        }

        private INavigationService _navigationService;
    }
}
