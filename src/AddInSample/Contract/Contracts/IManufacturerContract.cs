using System.AddIn.Contract;

namespace Contract.Contracts
{
    public interface IManufacturerContract : IContract
    {
        string Name { get; set; }
    }
}
