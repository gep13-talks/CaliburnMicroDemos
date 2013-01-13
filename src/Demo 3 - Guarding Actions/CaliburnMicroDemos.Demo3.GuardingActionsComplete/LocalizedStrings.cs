namespace CaliburnMicroDemos.Demo3.GuardingActionsComplete
{
    using CaliburnMicroDemos.Demo3.GuardingActionsComplete.Resources;

    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}