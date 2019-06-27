using Contract.Contracts;
using HostView.HostViews;
using System.AddIn.Pipeline;

namespace HostSideAdapter.HostSideAdapters
{
    public class ManufacturerHostViewToContractAdapter : ContractBase, IManufacturerContract
    {
        private ManufacturerHostView hostView;

        public ManufacturerHostViewToContractAdapter(ManufacturerHostView hostView)
        {
            this.hostView = hostView;
        }

        public string Name { get => hostView.Name; set => hostView.Name = value; }
    }
}
