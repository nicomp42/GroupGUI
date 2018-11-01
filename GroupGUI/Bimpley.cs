/******************************************************************
Alex Hargett
InClass Pokemon Example
Contemprary Programing (001)
2188-1_34IT3045C001 (18FS-Full)
Description: Create a new class for a pokemon that inherits from the pokemon class
Date: 11/01/2018
*******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
    class Bimpley: Pokemon
    {
        public override int Strength()
        {
            return 10000;
        }

        public override String Color()
        {
            return "Pink";
        }
    }
}
