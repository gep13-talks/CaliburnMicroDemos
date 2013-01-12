namespace CaliburnMicroDemos.Demo5.CustomServiceComplete.Services.Progress
{
    public interface IProgressService
    {
        /// <summary>
        /// Gets or sets a value indicating whether the ProgressIndicator is currently visible or not
        /// </summary>
        bool IsEnabled { get; set; }

        /// <summary>
        /// Show the ProgressIndicator on the page
        /// </summary>
        void Show();

        /// <summary>
        /// Show the ProgressIndicator on the page along with a custom text string
        /// </summary>
        /// <param name="text">The Text to be shown in the ProgressIndicator</param>
        void Show(string text);

        /// <summary>
        /// Hide the ProgressIndicator on the page
        /// </summary>
        void Hide();

        /// <summary>
        /// Toggles the current state of the ProgressIndicator on the page
        /// </summary>
        void Toggle();
    }
}