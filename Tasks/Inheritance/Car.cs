using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Starting the Car: " + Model);
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the Car: " + Model);
        }
    }
}
