using Contract.Contracts;
using HostView.HostViews;
using System.AddIn.Pipeline;

namespace HostSideAdapter.HostSideAdapters
{
    public class ProcessorContextHostViewToContractAdapter : ContractBase, IProcessorContextContract
    {
        private ProcessorContextHostView hostView;

        public ProcessorContextHostViewToContractAdapter(ProcessorContextHostView hostView)
        {
            this.hostView = hostView;
        }

        public IDeviceContract Device => new DeviceHostViewToContractAdapter(hostView.Device);

        public IUserContract User => new UserHostViewToContractAdapter(hostView.User);
    }
}
