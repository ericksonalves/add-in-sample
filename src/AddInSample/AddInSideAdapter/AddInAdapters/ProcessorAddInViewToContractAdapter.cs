using AddInView.AddInViews;
using Contract.Contracts;
using System.AddIn.Pipeline;

namespace AddInSideAdapter.AddInAdapters
{
    [AddInAdapter]
    public class ProcessorAddInViewToContractAdapter : ContractBase, IProcessorContract
    {
        private ProcessorAddInView addInView;

        public ProcessorAddInViewToContractAdapter(ProcessorAddInView addInView)
        {
            this.addInView = addInView;
        }

        public string Process(IProcessorContextContract context)
        {
            return addInView.Process(new ProcessorContextContractToAddInViewAdapter(context));
        }
    }
}
