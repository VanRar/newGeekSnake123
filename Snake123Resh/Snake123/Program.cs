using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;

namespace Snake123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            verticalLine leftLine = new verticalLine(0, 24, 0, '+');
            verticalLine rightLine = new verticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();



            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();*/
            
            Point p = new Point(4, 5, '#');
            //p2.Draw();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();


            /*  HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
              line.Drow();

              verticalLine vert = new verticalLine(10, 15, 8, '*');
              vert.Drow();*/
            Console.ReadLine();
        }
    }
}