﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine gline = new HorizontalLine(0, mapWidth - 2, 0, '.');
            HorizontalLine gline2 = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '.');

            VerticalLine vline = new VerticalLine(0, 0, mapHeight - 1, '.');
            VerticalLine vline2 = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '.');

            wallList.Add(gline);
            wallList.Add(gline2);
            wallList.Add(vline);
            wallList.Add(vline2);
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
