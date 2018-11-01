/***
 * Name: Tiffany Litteral
 * Assignment: In Class
 * Course: IT2045C
 * Description: Added a class for the Group GUI Project
 * Citations: Inherits from the Pokemon class Created by nicomp42
 * 
 * 
 */
using PocketMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
    class Eevee : Pokemon
    {/// <summary>
    /// Constructor for the Eevee class. Enter a name for the Eevee if you want. 
    /// </summary>
        private string mName;
        public Eevee (String Name) 
        {
            this.Name = Name;
        }
        public Eevee()
        {

        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        public override string Color()
        {
            return "Eevee's color is Brown ";
        }

        public override int Strength()
        {
            return 100;
        }
    }
}
