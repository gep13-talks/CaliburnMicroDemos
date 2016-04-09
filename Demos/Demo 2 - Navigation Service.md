##Navigation Service##

1. Open the solution file located at src/Demo 2 - Navigation Service/Demo 2 - Navigation Service.sln
1. Build the Solution, which should result in no errors
1. Right click on the Views folder and select Add | New Item...
1. In the Add New Item Window, select Windows Phone Portrait Page, and change the name of page to SettingsView.xaml and click Add.
1. From the ToolBox, drag and drop a TextBlock control onto the ContentPanel GridView, and change the Text property to something of your choosing.
1. Right click on the ViewModels folder, and select Add | New Item...
1. In the Add New Item Windows, select "Class" and change the name to SettingsViewModel.cs and click Add.
1. Open the AppBootStrapper.cs file and locate the Configure section
1. Under the line which adds the MainPageViewModel on a PerRequest basis, add another line for the new SetttingsViewModel
```csharp
container.PerRequest<SettingsViewModel>();
```
1. Open MainPage.xaml and add a Button control onto the ContentPanel GridView
  - Set the Name Property to GoToSettingsView
  - Set the Content property to Settings
1. Open the MainPageViewModel.cs
  - Add a new constructor to the class
  - Add a new using Statement for Caliburn.Micro
  - Create a new private readonly field for an INavigationService object
  - In the constructor, set the new private readonly field to the parameter passed in with the constructor
```csharp
using Caliburn.Micro;

public class MainPageViewModel
{
    private readonly INavigationService navigationService;

    public MainPageViewModel(INavigationService navigationService)
    {
        this.navigationService = navigationService;
    }
```
1. Create a new public void called GoToSettingsView with the following
```csharp
public void GoToSettingsView()
{
    this.navigationService.UriFor<SettingsViewModel>().Navigate();
}
```
1. Build the application to make sure that everything is ok
1. Run the application
1. Click on the new "Settings" button that you created, and watch how it navigates to the new SettingsView with the TextBlock on it that you created.