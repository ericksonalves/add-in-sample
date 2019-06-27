using AddInView.AddInViews;
using System.AddIn;

namespace SimpleAddIn
{
    [AddIn("Simple Processor", Version = "1.0.0.0", Publisher = "Simple Publisher", Description = "Simple Description")]
    public class SimpleProcessor : ProcessorAddInView
    {
        public override string Process(ProcessorContextAddInView context)
        {
            return $"{context.Device.Manufacturer.Name} {context.Device.Model} belongs to {context.User.Name}";
        }
    }
}
