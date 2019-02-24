using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNVP
{
    class Game
    {
        public static Circle food { get; set; }

        public static void movePlayer(int maxXpos, int maxYpos)
        {
            for (int i = Snake.getList().Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case Directions.Right:
                            Snake.getList()[i].X++;
                            break;
                        case Directions.Left:
                            Snake.getList()[i].X--;
                            break;
                        case Directions.Up:
                            Snake.getList()[i].Y--;
                            break;
                        case Directions.Down:
                            Snake.getList()[i].Y++;
                            break;

                    }

                    if (Snake.getList()[i].X < 0 || Snake.getList()[i].Y < 0 || Snake.getList()[i].X > maxXpos || Snake.getList()[i].Y > maxYpos)
                    {
                        die();
                    }

                    for (int j = 1; j < Snake.getList().Count; j++)
                    {
                        if (Snake.getList()[i].X == Snake.getList()[j].X && Snake.getList()[i].Y == Snake.getList()[j].Y)
                            die();
                    }

                    if (Snake.getList()[0].X == food.X && Snake.getList()[0].Y == food.Y)
                    {
                        eat();
                    }
                }
                else
                {
                    Snake.getList()[i].X = Snake.getList()[i - 1].X;
                    Snake.getList()[i].Y = Snake.getList()[i - 1].Y;
                }

            }

        }

        public static void die()
        {
            Settings.GameOver = true;
        }

        public static void eat()
        {
            Snake.eat();
            Settings.Scors += Settings.Points;
            generateFood();

        }

        public static void generateFood()
        {
            Random rnd = new Random();
            food = new Circle { X = Convert.ToInt32(rnd.Next(0, Settings.Width)), Y = Convert.ToInt32(rnd.Next(0, Settings.Height)) };
        }

        public static void start()
        { 
            new Settings();
            Snake.getList().Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);
            generateFood();
        }
    }
}
