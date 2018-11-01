/***************************************************
 * Name: Bruce Rich
 * 
 * CLass number and section: IT3045C 001
 * 
 * Assignment: In class GroupGUI
 * 
 * Due Date: 11/1/2018
 * 
 * *Description:  This class implements the Strength and Color methods from the Pokemon class.
 * 
 * Citation: Paul Deitel "Visual C# How to Program"
 * 
 * Anything else:
 **************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
    class Lunala : Pokemon 
    {
        public override int Strength()
        {
            return 1000000000;
        }
        public override string Color()
        {
            return "Purple";
        }
    }
}
