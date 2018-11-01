// Jacob Lynch

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
    class Wildfish:Pokemon
    {

        public Wildfish(String name)
        {
            this.name = name;
        }
        
        public override String Color()
        {
            return " Wildfish is Blue";
        }

        public override int Strength()
        {
            return 4500;
        }

            

    }
}
