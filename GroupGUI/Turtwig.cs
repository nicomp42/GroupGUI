/**
 * Patrick Willison
 * willispd
 * 11/1/2018
 * 
 * 
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
   abstract class Turtwig :Pokemon
    {
        public Turtwig(String name)
        {
            this.name = name;
        }

        public override int Strength()
            {
                return 73;

            }

            public override String Color()
            {
                return "Green";
            }

        
    }
}
