using AddInView.AddInViews;
using Contract.Contracts;
using System;
using System.AddIn.Pipeline;

namespace AddInSideAdapter.AddInAdapters
{
    public class DeviceContractToAddInViewAdapter : DeviceAddInView
    {
        private IDeviceContract contract;
        private ContractHandle handle;

        public DeviceContractToAddInViewAdapter(IDeviceContract contract)
        {
            this.contract = contract;
            handle = new ContractHandle(contract);
        }

        public override string Model { get => contract.Model; set => contract.Model = value; }

        public override ManufacturerAddInView Manufacturer => new ManufacturerContractToAddInViewAdapter(contract.Manufacturer);
    }
}
