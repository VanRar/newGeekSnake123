using System;
using System.Collections.Generic;
using System.Text;

namespace Snake123
{
    class verticalLine
    {
        List<Point> vList;
        public verticalLine(int yLeft, int yRight, int x, char sym)
        {
            vList = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                Point v = new Point(x, y, sym);
                vList.Add(v);
            }

        }

        public void Drow()
        {
            foreach (Point v in vList)
            {
                v.Draw();
            }
        }
    }
}
