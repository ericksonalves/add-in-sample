namespace AddInView.AddInViews
{
    public abstract class DeviceAddInView
    {
        public abstract string Model { get; set; }

        public abstract ManufacturerAddInView Manufacturer { get; }
    }
}
