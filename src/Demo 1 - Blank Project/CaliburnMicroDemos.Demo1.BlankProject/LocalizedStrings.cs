using CaliburnMicroDemos.Demo1.BlankProject.Resources;

namespace CaliburnMicroDemos.Demo1.BlankProject
{
    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}