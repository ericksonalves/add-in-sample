using System.AddIn.Contract;

namespace Contract.Contracts
{
    public interface IProcessorContextContract : IContract
    {
        IDeviceContract Device { get; }
        IUserContract User { get; }
    }
}
