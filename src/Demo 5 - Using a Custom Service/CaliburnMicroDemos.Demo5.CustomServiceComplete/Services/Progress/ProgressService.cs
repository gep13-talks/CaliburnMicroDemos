namespace CaliburnMicroDemos.Demo5.CustomServiceComplete.Services.Progress
{
    using System.Windows.Navigation;
    using Microsoft.Phone.Controls;
    using Microsoft.Phone.Shell;

    public class ProgressService : IProgressService
    {
        /// <summary>
        /// The DefaultText to show in the ProgressIndicator
        /// </summary>
        private const string DefaultIndicatorText = "Loading...";

        /// <summary>
        /// Local instance of the ProgressIndicator to show on the page
        /// </summary>
        private readonly ProgressIndicator progressIndicator;

        /// <summary>
        /// Initializes a new instance of the ProgressService class
        /// </summary>
        /// <param name="rootFrame">The incoming page that is being navigated to</param>
        public ProgressService(PhoneApplicationFrame rootFrame)
        {
            this.progressIndicator = new ProgressIndicator { Text = DefaultIndicatorText };

            rootFrame.Navigated += this.RootFrameOnNavigated;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the ProgressIndicator is currently visible or not
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Show the ProgressIndicator on the page
        /// </summary>
        public void Show()
        {
            this.Show(DefaultIndicatorText);
            this.IsEnabled = true;
        }

        /// <summary>
        /// Show the ProgressIndicator on the page along with a custom text string
        /// </summary>
        /// <param name="text">The Text to be shown in the ProgressIndicator</param>
        public void Show(string text)
        {
            this.progressIndicator.Text = text;
            this.progressIndicator.IsIndeterminate = true;
            this.progressIndicator.IsVisible = true;

            this.IsEnabled = true;
        }

        /// <summary>
        /// Hide the ProgressIndicator on the page
        /// </summary>
        public void Hide()
        {
            this.progressIndicator.IsIndeterminate = false;
            this.progressIndicator.IsVisible = false;

            this.IsEnabled = false;
        }

        /// <summary>
        /// Toggles the current state of the ProgressIndicator on the page
        /// </summary>
        public void Toggle()
        {
            if (this.IsEnabled)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        /// <summary>
        /// Handle the OnNavigated event to this page, in order to assign our instance of the ProgressIndicator to this page
        /// </summary>
        /// <param name="sender">The object that raised the Navigation Event</param>
        /// <param name="args">Arguments passed in with the event</param>
        private void RootFrameOnNavigated(object sender, NavigationEventArgs args)
        {
            var content = args.Content;
            var page = content as PhoneApplicationPage;

            if (page == null)
            {
                return;
            }

            page.SetValue(SystemTray.ProgressIndicatorProperty, this.progressIndicator);
        }
    }
}