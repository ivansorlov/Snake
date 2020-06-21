using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Point p1 = new Point(1, 3, '*');


            Point p2 = new Point(4, 5, '#');

            Console.SetBufferSize(80, 25);
            

            HorizontalLine gline  = new HorizontalLine(0, 78, 0, '.');
            HorizontalLine gline2 = new HorizontalLine(0, 78, 24, '.');
            
            VerticalLine vline  = new VerticalLine(0, 0, 24, '.');
            VerticalLine vline2 = new VerticalLine(78, 0, 24, '.');

            gline.Drow();
            gline2.Drow();
            vline.Drow();
            vline2.Drow();

            Snake snake = new Snake(p2, 4, Direction.RIGHT);
            snake.Drow();

            

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                Thread.Sleep(snake.SpeedSnake);
                snake.Move();
            }

            Console.ReadLine();
        }
    }
}
