using HostView.HostViews;
using System;
using System.AddIn.Hosting;

namespace HostApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = Environment.CurrentDirectory;
            AddInStore.Update(path);

            var tokens = AddInStore.FindAddIns(typeof(ProcessorHostView), path);

            var user = new User("Erickson");
            var manufacturer = new Manufacturer("Samsung");
            var device = new Device("Galaxy S10+", manufacturer);
            var context = new ProcessorContext(device, user);

            foreach (var token in tokens)
            {
                var addIn = token.Activate<ProcessorHostView>(AddInSecurityLevel.Internet);

                Console.WriteLine(addIn.Process(context));
            }

            Console.ReadKey();
        }
    }

    public class User : UserHostView
    {
        public override string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }

    public class Device : DeviceHostView
    {
        public override string Model { get; set; }

        public override ManufacturerHostView Manufacturer { get; }

        public Device(string model, ManufacturerHostView manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }
    }

    public class Manufacturer : ManufacturerHostView
    {
        public override string Name { get; set; }

        public Manufacturer(string name)
        {
            Name = name;
        }
    }

    public class ProcessorContext : ProcessorContextHostView
    {
        public override DeviceHostView Device { get; }

        public override UserHostView User { get; }

        public ProcessorContext(DeviceHostView device, UserHostView user)
        {
            Device = device;
            User = user;
        }
    }
}
