namespace CaliburnMicroDemos.Demo6.ApplicationLifeCycle.ViewModels
{
    using Caliburn.Micro;
    using CaliburnMicroDemos.Demo6.ApplicationLifeCycle.Model;

    public class ApplicationLifeCycleViewModel : Screen
    {
        private BindableCollection<LifeCycleUpdate> lifecycleNotices = new BindableCollection<LifeCycleUpdate>();

        public BindableCollection<LifeCycleUpdate> LifeCycleUpdates
        {
            get { return this.lifecycleNotices; }
            set
            {
                this.lifecycleNotices = value;
                NotifyOfPropertyChange(() => LifeCycleUpdates);
            }
        }

        protected override void OnViewAttached(object view, object context)
        {
            this.LifeCycleUpdates.Clear();
            base.OnViewAttached(view, context);
            this.LifeCycleUpdates.Add(new LifeCycleUpdate("OnViewAttached"));
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
            this.LifeCycleUpdates.Add(new LifeCycleUpdate("OnInitialize"));
        }

        protected override void OnActivate()
        {
            base.OnActivate();
            this.LifeCycleUpdates.Add(new LifeCycleUpdate("OnActivate"));
        }

        protected override void OnViewReady(object view)
        {
            base.OnViewReady(view);
            this.LifeCycleUpdates.Add(new LifeCycleUpdate("OnViewReady"));
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            this.LifeCycleUpdates.Add(new LifeCycleUpdate("OnViewLoaded"));
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
            this.LifeCycleUpdates.Add(new LifeCycleUpdate("OnDeactivate"));
        }
    }
}