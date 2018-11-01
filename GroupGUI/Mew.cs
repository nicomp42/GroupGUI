/**John Locklear
 * Stupid pokemon class
 * he is pink and stuff
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
    class Mew : PocketMonsters.Pokemon
    {
        public Mew(String name)
        {
            this.name = name;
        }
        public override string Color()
        {
            return "Pink";
        }

        public override int Strength()
        {
            return 510001010;
        }
    }
}