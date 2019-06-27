using AddInView.AddInViews;
using Contract.Contracts;
using System.AddIn.Pipeline;

namespace AddInSideAdapter.AddInAdapters
{
    public class UserContractToAddInViewAdapter : UserAddInView
    {
        private IUserContract contract;
        private ContractHandle handle;

        public UserContractToAddInViewAdapter(IUserContract contract)
        {
            this.contract = contract;
            handle = new ContractHandle(contract);
        }

        public override string Name { get => contract.Name; set => contract.Name = value; }
    }
}
