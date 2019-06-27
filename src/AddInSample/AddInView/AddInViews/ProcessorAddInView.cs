using System.AddIn.Pipeline;

namespace AddInView.AddInViews
{
    [AddInBase]
    public abstract class ProcessorAddInView
    {
        public abstract string Process(ProcessorContextAddInView context);
    }
}
