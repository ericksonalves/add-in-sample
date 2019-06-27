using System.AddIn.Contract;

namespace Contract.Contracts
{
    public interface IUserContract : IContract
    {
        string Name { get; set; }
    }
}
