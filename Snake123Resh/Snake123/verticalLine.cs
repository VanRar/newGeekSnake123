using System;
using System.Collections.Generic;
using System.Text;

namespace Snake123
{
    class verticalLine : Figure
    {
        public verticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }
    }
}
