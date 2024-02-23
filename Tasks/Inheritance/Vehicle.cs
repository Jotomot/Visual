using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Vehicle
    {
        public string Model { get; set; }

        public abstract void Start();
        public abstract void Stop();
    }
}
