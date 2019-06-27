namespace HostView.HostViews
{
    public abstract class ProcessorContextHostView
    {
        public abstract DeviceHostView Device { get; }
        public abstract UserHostView User { get; }
    }
}
