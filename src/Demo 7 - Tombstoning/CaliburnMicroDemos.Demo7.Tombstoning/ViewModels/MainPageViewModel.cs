namespace CaliburnMicroDemos.Demo7.Tombstoning.ViewModels
{
    using Caliburn.Micro;

    public class MainPageViewModel : Screen
    {
        private double currentNumberSlider;

        public string CurrentSliderValue { get; set; }

        public double CurrentNumberSlider
        {
            get
            {
                return this.currentNumberSlider;
            }
            set
            {
                this.currentNumberSlider = value;
                this.CurrentSliderValue = value.ToString();
                this.NotifyOfPropertyChange(() => this.CurrentNumberSlider);
                this.NotifyOfPropertyChange(() => this.CurrentSliderValue);
            }
        }
    }
}