##Guarding Actions##

1. Open the solution file located at src/Demo 3 - Guarding Actions/Demo 3 - Guarding Actions.sln
1. Build the Solution, which should result in no errors
1. Open the MainPage.xaml file
1. Add a CheckBox control to the ContentPanel GridView
  - Set the Content property to "Is Navigation Allowed?"
  - Set the Name property to "IsNavigationAllowed"
1. Open the MainPageViewModel.cs file
1. Inherit from the PropertyChangedBase class
```csharp
public class MainPageViewModel : PropertyChangedBase
```
1. Create a private boolean field called isNavigationAllowed
```csharp
private bool isNavigationAllowed;
```
1. Create a public boolean property called IsNavigationAllowed with the following
```csharp
        public bool IsNavigationAllowed
        {
            get
            {
                return this.isNavigationAllowed;
            }
            set
            {
                this.isNavigationAllowed = value;
                NotifyOfPropertyChange(() => this.IsNavigationAllowed);
                NotifyOfPropertyChange(() => this.CanGoToSettingsView);
            }
        }
```
1. Create a public boolean method with the following
```csharp
        public bool CanGoToSettingsView
        {
            get
            {
                return this.IsNavigationAllowed;
            }
        }
```
1. Run the application and show the Settings button enabling and disabling based on changing the Checked property of the CheckBox