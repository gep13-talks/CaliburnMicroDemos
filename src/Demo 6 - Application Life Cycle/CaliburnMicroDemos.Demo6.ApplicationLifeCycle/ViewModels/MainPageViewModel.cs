namespace CaliburnMicroDemos.Demo6.ApplicationLifeCycle.ViewModels
{
    using Caliburn.Micro;

    public class MainPageViewModel
    {
        private readonly INavigationService navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public void GoToLifeCycleView()
        {
            this.navigationService.UriFor<ApplicationLifeCycleViewModel>()
                .Navigate();
        }
    }
}