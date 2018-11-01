//Daniel Cullen
using PocketMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGUI
{
    class Oddish : Pokemon
    {
        public Oddish(String name)
        {
            this.name = name;
        }
        public override string Color()
        {
            return "Blue";
        }
        public override int Strength()
        {
            return 20;
        }
    }
}
