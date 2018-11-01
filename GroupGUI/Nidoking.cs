/**********************************************************************
 * Name: Ben Tenhover
 * Email: tenhovbe@mail.uc.edu
 * Course/Section/Semester: IT3045C/001/Fall 2018
 * Due Date: 11/01/2018
 * Description: Add a pokemon and commit it to the project on Github
 * ********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGUI
{
    class Nidoking : PocketMonsters.Pokemon
    {
        public Nidoking(String name)
        {
            this.name = name;
        }
        public override string Color()
        {
            return "purple with a white belly";
        }

        public override int Strength()
        {
            return 5000000;
        }
    }
}
