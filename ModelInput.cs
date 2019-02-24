using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


namespace SnakeNVP
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();

        public static bool KeyPress(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }

        public static void defineDirection()
        {

            if (KeyPress(Keys.Right) && Settings.directions != Directions.Left)
            {
                Settings.directions = Directions.Right;
            }
            else if (KeyPress(Keys.Left) && Settings.directions != Directions.Right)
            {
                Settings.directions = Directions.Left;
            }
            else if (KeyPress(Keys.Up) && Settings.directions != Directions.Down)
            {
                Settings.directions = Directions.Up;
            }
            else if (KeyPress(Keys.Down) && Settings.directions != Directions.Up)
            {
                Settings.directions = Directions.Down;
            }
        }

    }
}
