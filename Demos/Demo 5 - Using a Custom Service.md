##Using a Custom Service##

1. Open the solution file located at src/Demo 5 - Using a Custom Service/Demo 5 - Using a Custom Service.sln
1. Build the Solution, which should result in no errors
1. Open the Services\Progress\IProgressService and ProgressService classes and talk through them.  Simple class with will show or hide the default ProgressBar on a page
1. Open the AppBootstrapper.cs file
  - Add a using statement for using CaliburnMicroDemos.Demo5.CustomService.Services.Progress;
```csharp
using CaliburnMicroDemos.Demo5.CustomServiceComplete.Services.Progress;
```
  - In the Configure method, add a new Instance to the DI container
```csharp
container.Instance<IProgressService>(new ProgressService(RootFrame));
```
1. Open the MainPageViewModel.cs
  - Add a using statement for using CaliburnMicroDemos.Demo5.CustomService.Services.Progress;
```csharp
using CaliburnMicroDemos.Demo5.CustomServiceComplete.Services.Progress;
```
  - Create a private field of type IProgressService
```csharp
private IProgressService progressService;
```
  - Create a public constructor passing in an instance of IProgressService
```csharp
public MainPageViewModel(IProgressService progressService)
{
    this.progressService = progressService;
}
```
1. Open MainPage.xaml
  - Add a button
  - Set the Name property to ShowProgressBar
  - Set the Content property to Show
  - Add a button
  - Set the Name property to HideProgressBar
  - Set the Content property to Hide
  - Add a button
  - Set the Name property to ToggleProgressBar
  - Set the Content property to Toggle
1. Open MainPageViewModel.cs
1. Create a public method called ShowProgressBar
```csharp
public void ShowProgressBar()
{
    this.progressService.Show();
}
```
1. Create a public method called HideProgressBar
```csharp
public void HideProgressBar()
{
    this.progressService.Hide();
}
```
1. Create a public method called ToggleProgressBar
```csharp
public void ToggleProgressbar()
{
    this.progressService.Toggle();
}
```
1. Run the application and show it all working