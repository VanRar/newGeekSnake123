using System;
using System.Collections.Generic;
using System.Text;

namespace Snake123
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            //отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            verticalLine leftLine = new verticalLine(0, 24, 0, '+');
            verticalLine rightLine = new verticalLine(0, 24, 78, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);

            /* upLine.Drow();
             downLine.Drow();
             leftLine.Drow();
             rightLine.Drow();
            */
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw();
        
         foreach (var wall in wallList)
            {
                wall.Draw();
            }
}
    }
}
