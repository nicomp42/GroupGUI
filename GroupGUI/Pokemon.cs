using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketMonsters
{
    abstract class Pokemon
    {
        private String mName;
        public String name
        {
            get { return mName; }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("PocketMonsters.Pokemon.set Name: length cannot be zero");
                }
            }
        }
        public abstract int Strength();
        public abstract String Color();
       
    }
}
