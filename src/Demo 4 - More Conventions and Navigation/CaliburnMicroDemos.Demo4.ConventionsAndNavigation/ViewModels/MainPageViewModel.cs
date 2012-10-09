namespace CaliburnMicroDemos.Demo4.ConventionsAndNavigation.ViewModels
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
                this.NotifyOfPropertyChange(() => this.IsNavigationAllowed);
                this.NotifyOfPropertyChange(() => this.CanGoToSettingsView);
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
            this.navigationService.UriFor<SettingsViewModel>()
                .Navigate();
        }

        public void GoToProjectsView()
        {
            this.navigationService.UriFor<ProjectsViewModel>()
                .Navigate();
        }
    }
}