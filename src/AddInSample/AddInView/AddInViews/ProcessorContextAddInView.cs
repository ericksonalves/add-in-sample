namespace AddInView.AddInViews
{
    public abstract class ProcessorContextAddInView
    {
        public abstract DeviceAddInView Device { get; }
        public abstract UserAddInView User { get; }
    }
}
