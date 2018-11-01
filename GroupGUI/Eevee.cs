using PocketMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGUI
{
    class Eevee : Pokemon
    {
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
