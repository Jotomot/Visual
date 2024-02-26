using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    internal class Player
    {
        public string Name { get; set; }
        public int Level {get;set;}

        public Player(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

       
    }
}
