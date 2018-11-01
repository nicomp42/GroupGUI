/*
 * Name: Evan Batsch
 * Class: Contemporary Programming
 * Description: Magnet Pokemon
 * Citations: N/A
 * Other: N/A
 */

using PocketMonsters;

namespace GroupGUI
{
    class Magnemite : Pokemon
    {
        // constructor
        public Magnemite()
        {
        }
        public override int Strength()
        {
            int strength = 35;
            return strength;
        }
        public override string Color()
        {
            string color = "Gray";
            return color;
        }
    }
}
