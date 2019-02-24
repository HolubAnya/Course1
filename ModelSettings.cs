using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeNVP
{
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };

    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Scors { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static bool GameStarted { get; set; }
        public static Directions directions { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
            Speed = 5;
            Scors = 0;
            Points = 15;
            GameOver = false;
            directions = Directions.Right;
        }

        public static Brush defineColour (int i)
        {
            Brush colour = null;
            if (i == 0)
            {
                colour = Brushes.DarkGreen;
            }
            else
            {
                colour = Brushes.Green;
            }
            return colour;
        }


    }
}
