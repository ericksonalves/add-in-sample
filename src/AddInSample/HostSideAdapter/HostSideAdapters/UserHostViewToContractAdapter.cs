using Contract.Contracts;
using HostView.HostViews;
using System.AddIn.Pipeline;

namespace HostSideAdapter.HostSideAdapters
{
    public class UserHostViewToContractAdapter : ContractBase, IUserContract
    {
        private UserHostView hostView;

        public UserHostViewToContractAdapter(UserHostView hostView)
        {
            this.hostView = hostView;
        }

        public string Name { get => hostView.Name; set => hostView.Name = value; }
    }
}
