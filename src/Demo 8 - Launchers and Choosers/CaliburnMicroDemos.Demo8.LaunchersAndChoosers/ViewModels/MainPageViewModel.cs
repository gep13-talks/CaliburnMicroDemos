namespace CaliburnMicroDemos.Demo8.LaunchersAndChoosers.ViewModels
{
    using System.Windows;
    using Caliburn.Micro;
    using Microsoft.Phone.Tasks;

    public class MainPageViewModel : Screen, IHandle<TaskCompleted<PhoneNumberResult>>
    {
        private readonly IEventAggregator eventAggregator;

        public MainPageViewModel(IEventAggregator eventAggregator)
        {
            this.eventAggregator = eventAggregator;
        }

        public void ChoosePhoneNumber()
        {
            this.eventAggregator.RequestTask<PhoneNumberChooserTask>();
        }

        public void Handle(TaskCompleted<PhoneNumberResult> message)
        {
            MessageBox.Show(
                string.Format("The result was {0}", message.Result.DisplayName), this.DisplayName, MessageBoxButton.OK);
        }

        protected override void OnActivate()
        {
            this.eventAggregator.Subscribe(this);
            base.OnActivate();
        }

        protected override void OnDeactivate(bool close)
        {
            this.eventAggregator.Unsubscribe(this);
            base.OnDeactivate(close);
        }
    }
}