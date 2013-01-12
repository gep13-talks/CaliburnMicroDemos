namespace CaliburnMicroDemos.Demo4.ConventionsAndNavigationComplete.ViewModels
{
    using System.Windows;
    using Caliburn.Micro;

    public class SettingsViewModel : Screen
    {
        public string SettingFromMainPage { get; set; }

        protected override void OnViewLoaded(object view)
        {
            MessageBox.Show(this.SettingFromMainPage);
        }
    }
}