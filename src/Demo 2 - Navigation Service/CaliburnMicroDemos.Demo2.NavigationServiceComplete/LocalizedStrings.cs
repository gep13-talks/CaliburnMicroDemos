namespace CaliburnMicroDemos.Demo2.NavigationServiceComplete
{
    using CaliburnMicroDemos.Demo2.NavigationServiceComplete.Resources;

    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}