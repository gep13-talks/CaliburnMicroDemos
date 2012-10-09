namespace CaliburnMicroDemos.Demo6.ApplicationLifeCycle.Model
{
    using System;

    public class LifeCycleUpdate
    {
        public LifeCycleUpdate() { }

        public LifeCycleUpdate(string lifecycleEvent)
        {
            this.LifecycleEvent = lifecycleEvent;
            this.Timestamp = DateTime.Now;
        }

        public string LifecycleEvent { get; set; }
        public DateTime Timestamp { get; set; }
    }
}