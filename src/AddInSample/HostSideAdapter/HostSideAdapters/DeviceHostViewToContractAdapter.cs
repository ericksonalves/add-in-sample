using Contract.Contracts;
using HostView.HostViews;
using System.AddIn.Pipeline;

namespace HostSideAdapter.HostSideAdapters
{
    public class DeviceHostViewToContractAdapter : ContractBase, IDeviceContract
    {
        private DeviceHostView hostView;

        public DeviceHostViewToContractAdapter(DeviceHostView hostView)
        {
            this.hostView = hostView;
        }

        public string Model { get => hostView.Model; set => hostView.Model = value; }

        public IManufacturerContract Manufacturer => new ManufacturerHostViewToContractAdapter(hostView.Manufacturer);
    }
}
