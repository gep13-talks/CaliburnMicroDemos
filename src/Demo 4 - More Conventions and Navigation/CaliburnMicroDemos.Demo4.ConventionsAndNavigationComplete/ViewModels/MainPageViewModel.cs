namespace CaliburnMicroDemos.Demo4.ConventionsAndNavigationComplete.ViewModels
{
    using Caliburn.Micro;

    public class MainPageViewModel : PropertyChangedBase
    {
        private readonly INavigationService navigationService;
        private bool isNavigationAllowed;
        private string settingToPassToSettingsView;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public string SettingToPassToSettingsView
        {
            get
            {
                return this.settingToPassToSettingsView;
            }
            set
            {
                this.settingToPassToSettingsView = value;
                this.NotifyOfPropertyChange(() => this.SettingToPassToSettingsView);
            }
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
                .WithParam(x => x.SettingFromMainPage, this.SettingToPassToSettingsView)
                .Navigate();
        }

        public void GoToProjectsView()
        {
            this.navigationService.UriFor<ProjectsViewModel>()
                .Navigate();
        }
    }
}