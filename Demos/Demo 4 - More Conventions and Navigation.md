##More Conventions and Navigation##

1. Open the solution file located at src/Demo 4 - More Conventions and Navigation/Demo 4 - More Conventions and Navigation.sln
1. Build the Solution, which should result in no errors
1. Open MainPage.xaml and show that there is a new button to take you to a ProjectsView
1. Open MainPageViewModel.cs and show the supporting method
1. Open ProjectView.xaml and show that all there is is a simple ListBox, that has been configured with a simple DataTemplate, and whose name has been specified as Projects
1. Open ProjectsViewModel.cs and show that there is a top level Projects BindableCollection, as well as a property called SelectedProject
1. Show that there is a very simple method to populate some projects within the constructor
1. Run the project and click the Projects button, show how clicking on each ListBox item results in showing the MessageBox with the name of the currently selected project
1. Open MainPage.xaml and add a TextBox to the ContentPanel GridView
  - Set the Text property to an empty string
  - Set the Name property to SettingToPassToSettingsView
1. Open the SettingsViewModel and derive from the Caliburn.Micro.Screen class
```csharp
using Caliburn.Micro;

public class SettingsViewModel : Screen
```
1. Create a public property called SettingsFromMainPage
```csharp
public string SettingFromMainPage { get; set; }
```
1. Override the OnViewLoaded method to use the SettingFromMainPage property once it has been set by Caliburn.Micro
```csharp
protected override void OnViewLoaded(object view)
{
    MessageBox.Show(this.SettingFromMainPage);
}
```
NOTE: You will need to add the following using statement
```csharp
using System.Windows;
```
1. Open the MainPageViewModel.cs and create a private string field called settingToPassToSettingsView
```csharp
private string settingToPassToSettingsView;
```
1. Create a public string property with both getter and setter called SettingToPassToSettingsView
```csharp
public string SettingToPassToSettingsView
{
    get
    {
        return this.settingToPassToSettingsView;
    }
    set
    {
        this.settingToPassToSettingsView = value;
        this.NotifyOfPropertyChange(() => this.SettingToPassToSettingsView);
    }
}
```
1. Update the GoToSettingsView method to specify the setting of the property
```csharp
public void GoToSettingsView()
{
    this.navigationService.UriFor<SettingsViewModel>()
        .WithParam(x => x.SettingFromMainPage, this.SettingToPassToSettingsView)
        .Navigate();
}
```
1. Run the project, enter some information in the TextBox and show how it can be passed through to the SettingsView