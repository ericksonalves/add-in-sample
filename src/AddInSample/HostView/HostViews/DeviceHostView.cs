namespace HostView.HostViews
{
    public abstract class DeviceHostView
    {
        public abstract string Model { get; set; }

        public abstract ManufacturerHostView Manufacturer { get; }
    }
}
