namespace CaliburnMicroDemos.Demo3.GuardingActions
{
    using CaliburnMicroDemos.Demo3.GuardingActions.Resources;

    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}