using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Motorcycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Starting the Motorcycle: " + Model);
        }
        public override void Stop()
        {
            Console.WriteLine("Stopping the Motorcycle: " + Model);
        }
    }
}
