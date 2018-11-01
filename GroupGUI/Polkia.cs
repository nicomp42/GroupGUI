using PocketMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGUI
{
    class Polkia : Pokemon
    {
        public Polkia(string name) : base() { }

        public override string Color()
        {
            string color = "This is a shiny Polkia. It's colors are Pink and Purple.";
            return color;
        }

        public override int Strength()
        {
            int strength = 99;
            return strength;
        }
    }
}
