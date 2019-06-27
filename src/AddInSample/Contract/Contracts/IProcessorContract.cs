using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace Contract.Contracts
{
    [AddInContract]
    public interface IProcessorContract : IContract
    {
        string Process(IProcessorContextContract context);
    }
}
