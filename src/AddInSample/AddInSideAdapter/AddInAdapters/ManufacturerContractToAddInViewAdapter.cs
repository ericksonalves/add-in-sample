using AddInView.AddInViews;
using Contract.Contracts;
using System.AddIn.Pipeline;

namespace AddInSideAdapter.AddInAdapters
{
    public class ManufacturerContractToAddInViewAdapter : ManufacturerAddInView
    {
        private IManufacturerContract contract;
        private ContractHandle handle;
        
        public ManufacturerContractToAddInViewAdapter(IManufacturerContract contract)
        {
            this.contract = contract;
            handle = new ContractHandle(contract);
        }

        public override string Name { get => contract.Name; set => contract.Name = value; }
    }
}
