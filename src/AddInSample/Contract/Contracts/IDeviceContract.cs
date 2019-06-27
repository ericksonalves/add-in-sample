using System.AddIn.Contract;

namespace Contract.Contracts
{
    public interface IDeviceContract : IContract
    {
        string Model { get; set; }

        IManufacturerContract Manufacturer { get; }
    }
}
