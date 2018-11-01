/*Name: Connor Cook
 * Assignment: In class 11/1/2018
 * Description: In class presentation on committing a project to Github from Visual Studio
 * Sources: Original project by Bill Nicholson
 *          https://www.google.com/search?rlz=1C1EJFC_enUS807US807&q=Blastoise&stick=H4sIAAAAAAAAAONgFmJQ4tTP1TcwNC0uMNfi9S7wKQ_Iz07Nzc9zzXvEKMct8PLHPWEp0UlrTl5j5OdClecBAAXrsaI_AAAA&npsic=-3840&sa=X&ved=0ahUKEwjMy7WU-7PeAhUhwYMKHUwKCtMQ-BYIigE
 */
using PocketMonsters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGUI
{
    class Blastoise : Pokemon
    {
        public Blastoise()
        {
        }
        public override int Strength()
        {
            return 10;
        }
        public override string Color()
        {
            return "Blue, Yellow, Brown and White";
        }
    }
}
