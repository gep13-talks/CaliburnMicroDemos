namespace CaliburnMicroDemos.Demo1.BlankProjectComplete
{
    using CaliburnMicroDemos.Demo1.BlankProjectComplete.Resources;

    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}