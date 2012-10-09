namespace CaliburnMicroDemos.Demo6.ApplicationLifeCycle.Framework
{
    using System;
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;
    using CaliburnMicroDemos.Demo6.ApplicationLifeCycle.ViewModels;
    using Microsoft.Phone.Controls;
    using Caliburn.Micro;
    using Microsoft.Phone.Shell;

    public class AppBootstrapper : PhoneBootstrapper
    {
        PhoneContainer container;

        protected override void Configure()
        {
            container = new PhoneContainer(RootFrame);

            container.RegisterPhoneServices();
            container.PerRequest<MainPageViewModel>();
            container.PerRequest<ApplicationLifeCycleViewModel>();

            // get the caliburn phone service to handle even more lifecycle hooks
            var phoneService = container.GetInstance(typeof(IPhoneService), null) as IPhoneService;
            phoneService.Resurrecting += this.phoneService_Resurrecting;
            phoneService.Continuing += this.phoneService_Continuing;

            AddCustomConventions();
        }

        protected override void OnLaunch(object sender, LaunchingEventArgs e)
        {
            base.OnLaunch(sender, e);
            MessageBox.Show("Demo 6 Application is Launching!");
        }

        void phoneService_Continuing()
        {
            MessageBox.Show("Demo 6 Application is Continuing!");
        }

        void phoneService_Resurrecting()
        {
            MessageBox.Show("Demo 6 Application is Resurrecting!");
        }

        protected override void OnDeactivate(object sender, DeactivatedEventArgs e)
        {
            base.OnDeactivate(sender, e);
            MessageBox.Show("Demo 6 Application is Deactivating!");
        }

        protected override void OnClose(object sender, ClosingEventArgs e)
        {
            base.OnClose(sender, e);
            MessageBox.Show("Demo 6 Application is Closing!");
        }

        protected override object GetInstance(Type service, string key)
        {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            container.BuildUp(instance);
        }

        static void AddCustomConventions()
        {
            ConventionManager.AddElementConvention<Pivot>(Pivot.ItemsSourceProperty, "SelectedItem", "SelectionChanged").ApplyBinding =
                (viewModelType, path, property, element, convention) =>
                {
                    if (ConventionManager
                        .GetElementConvention(typeof(ItemsControl))
                        .ApplyBinding(viewModelType, path, property, element, convention))
                    {
                        ConventionManager
                            .ConfigureSelectedItem(element, Pivot.SelectedItemProperty, viewModelType, path);
                        ConventionManager
                            .ApplyHeaderTemplate(element, Pivot.HeaderTemplateProperty, null, viewModelType);
                        return true;
                    }

                    return false;
                };

            ConventionManager.AddElementConvention<Panorama>(Panorama.ItemsSourceProperty, "SelectedItem", "SelectionChanged").ApplyBinding =
                (viewModelType, path, property, element, convention) =>
                {
                    if (ConventionManager
                        .GetElementConvention(typeof(ItemsControl))
                        .ApplyBinding(viewModelType, path, property, element, convention))
                    {
                        ConventionManager
                            .ConfigureSelectedItem(element, Panorama.SelectedItemProperty, viewModelType, path);
                        ConventionManager
                            .ApplyHeaderTemplate(element, Panorama.HeaderTemplateProperty, null, viewModelType);
                        return true;
                    }

                    return false;
                };
        }
    }
}