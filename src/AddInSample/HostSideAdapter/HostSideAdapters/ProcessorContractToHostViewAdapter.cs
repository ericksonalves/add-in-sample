using Contract.Contracts;
using HostView.HostViews;
using System.AddIn.Pipeline;

namespace HostSideAdapter.HostSideAdapters
{
    [HostAdapter]
    public class ProcessorContractToHostViewAdapter : ProcessorHostView
    {
        private IProcessorContract contract;
        private ContractHandle handle;

        public ProcessorContractToHostViewAdapter(IProcessorContract contract)
        {
            this.contract = contract;
            handle = new ContractHandle(contract);
        }

        public override string Process(ProcessorContextHostView context)
        {
            return contract.Process(new ProcessorContextHostViewToContractAdapter(context));
        }
    }
}
