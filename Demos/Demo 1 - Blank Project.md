##Blank Project##

1. Open the solution file located at src/Demo 1 - Blank Project/Demo 1 - Blank Project.sln
1. Build the Solution, which should result in no errors
1. Right click on the Project in Solution Explorer and choose "Manage Nuget Packages..."
1. In the "Manage Nuget Packages" window, search for "Caliburn"
1. Click "Install" on the Caliburn.Micro.Start Package and wait for the installation to complete.
1. Click "Close" in the "Manage Nuget Packages" window
1. OPTIONAL: Depending on whether you are checking the code into some form of Source Control, you may want to enable Nuget Package Restore on your solution, rather than checking in the package into Source Control.
1. Take a look and see all the new files that have been added (i.e. the packages folder, AppBootStrapper.cs, MainPageViewModel.cs) and also the files that have changed (i.e. the csproj file)
1. Clear out your App.xaml.cs file so that there is literally nothing left except from the App() constructor with the call to InitializeComponent() method
1. Clear out the AppliationLifetimeObjects from the App.xaml file
1. Add a folder at the root of the project called "Views"
    - Move the MainPage.xaml file into the Views folder
    - Update the MainPage.xaml.cs file to include Views in the namespace
    - Update the MainPage.xaml file to include Views in the x:Class definition
1. Add a folder at the root of the project called "ViewModels"
    - Move the MainPageViewModel.cs file into the ViewModels folder
    - Update the MainPageViewModel.cs to include ViewModels in the namespace
1. Add a folder at the root of the project called "Framework"
   - Move the AppBootStrapper.cs file into this folder
   - Update the namespace of the AppBootstrapper.cs file to include Framework
   - Add a using statement for the new ViewModels namespace
1. Open the App.xaml file, and add the AppBootStrapper to the Application.Resources section:

```xml
<Application
    x:Class="CaliburnMicroDemos.Demo1.BlankProject.App"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:phone="clr-namespace:Microsoft.Phone.Controls;assembly=Microsoft.Phone"
    xmlns:shell="clr-namespace:Microsoft.Phone.Shell;assembly=Microsoft.Phone"
    xmlns:local="clr-namespace:CaliburnMicroDemos.Demo1.BlankProject.Framework">

    <!--Application Resources-->
    <Application.Resources>
        <local:AppBootstrapper x:Key="bootstapper" />
    </Application.Resources>
</Application>
```

1. Open the WMAppManifest.xml file and change the NavigationPage attribute of the DefaultTask node to correctly point at the new location of the MainPage.xaml file.