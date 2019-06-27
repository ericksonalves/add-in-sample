using AddInView.AddInViews;
using Contract.Contracts;
using System.AddIn.Pipeline;

namespace AddInSideAdapter.AddInAdapters
{
    class ProcessorContextContractToAddInViewAdapter : ProcessorContextAddInView
    {
        private IProcessorContextContract contract;
        private ContractHandle handle;

        public ProcessorContextContractToAddInViewAdapter(IProcessorContextContract contract)
        {
            this.contract = contract;
            handle = new ContractHandle(contract);
        }

        public override DeviceAddInView Device => new DeviceContractToAddInViewAdapter(contract.Device);

        public override UserAddInView User => new UserContractToAddInViewAdapter(contract.User);
    }
}
