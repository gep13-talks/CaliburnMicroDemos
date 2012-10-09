namespace CaliburnMicroDemos.Demo7.Tombstoning.Workers
{
    using Caliburn.Micro;
    using CaliburnMicroDemos.Demo7.Tombstoning.ViewModels;

    public class MainPageStorageWorker : StorageHandler<MainPageViewModel>
    {
        public override void Configure()
        {
            //this.Property(vm => vm.CurrentNumberSlider)
            //    .InAppSettings()
            //    .RestoreAfterActivation();
        }
    }
}