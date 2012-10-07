using Caliburn.Micro;
namespace CaliburnMicroDemos.Demo3.GuardingActions.ViewModels
{
    public class MainPageViewModel
    {
        private readonly INavigationService navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public void GoToSettingsView()
        {
            this.navigationService.UriFor<SettingsViewModel>().Navigate();
        }
    }
}