namespace CaliburnMicroDemos.Demo5.CustomServiceComplete.ViewModels
{
    using CaliburnMicroDemos.Demo5.CustomServiceComplete.Services.Progress;

    public class MainPageViewModel
    {
        private IProgressService progressService;

        public MainPageViewModel(IProgressService progressService)
        {
            this.progressService = progressService;
        }

        public void ShowProgressBar()
        {
            this.progressService.Show();
        }

        public void HideProgressBar()
        {
            this.progressService.Hide();
        }

        public void ToggleProgressbar()
        {
            this.progressService.Toggle();
        }
    }
}