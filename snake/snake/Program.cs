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

            Point p1 = new Point(1, 3, '*');
            

            Point p2 = new Point(4, 5, '#');
            

            HorizontalLine line = new HorizontalLine(5, 23, 3, '.');
            //line.Drow();

            VerticalLine vline = new VerticalLine(5, 3, 23, '.');
            //vline.Drow();

            Snake snake = new Snake(p2, 4, Direction.RIGHT);
            snake.Drow();

            for (int i = 0; i < 20; i++)
            {
                snake.Move();
                Thread.Sleep(300);
            }

            Console.ReadLine();
        }
    }
}
