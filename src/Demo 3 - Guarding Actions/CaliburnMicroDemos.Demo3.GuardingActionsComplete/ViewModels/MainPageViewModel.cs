namespace CaliburnMicroDemos.Demo3.GuardingActionsComplete.ViewModels
{
    using Caliburn.Micro;

    public class MainPageViewModel : PropertyChangedBase
    {
        private readonly INavigationService navigationService;
        private bool isNavigationAllowed;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public bool IsNavigationAllowed
        {
            get
            {
                return this.isNavigationAllowed;
            }
            set
            {
                this.isNavigationAllowed = value;
                NotifyOfPropertyChange(() => this.IsNavigationAllowed);
                NotifyOfPropertyChange(() => this.CanGoToSettingsView);
            }
        }

        public bool CanGoToSettingsView
        {
            get
            {
                return this.IsNavigationAllowed;
            }
        }

        public void GoToSettingsView()
        {
            this.navigationService.UriFor<SettingsViewModel>().Navigate();
        }
    }
}