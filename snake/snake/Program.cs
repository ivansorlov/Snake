using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            //Drow(x1, y1, sym1);

            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';

            //Drow(x2, y2, sym2);


            Point p1 = new Point(1, 3, '*');
            // p1.x = 1;
            // p1.y = 3;
            // p1.sym = '*';
            p1.Drow();

            Point p2 = new Point(4, 5, '#');
            // p2.x = 4;
            // p2.y = 5;
            // p2.sym = '#';
            p2.Drow();

            List<int> numList = new List<int>();

            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            // Список с нашими координатами

            List<Point> pList = new List<Point>();

            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }
    }
}
