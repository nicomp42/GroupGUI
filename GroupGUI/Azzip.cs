using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
    abstract class Azzip : Pokemon
    {
        public Azzip(string name)
        {
            this.name = name;
        }

        public override string Color()
        {
            return "Red";
        }

        public override int Strength()
        {
            return 44;
        }
    }
}
