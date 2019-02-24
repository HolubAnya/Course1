using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNVP
{
    class Snake
    {
        private static List<Circle> snake = new List<Circle>();

        public static List<Circle> getList()
        {
            return snake;
        }

        public static void Add(Circle circle)
        {
            snake.Add(circle);
        }

        public static void eat()
        {
            Circle body = new Circle
            {
                X = snake[snake.Count - 1].X,
                Y = snake[snake.Count - 1].Y
            };

            Snake.Add(body);
        }
    }
}
