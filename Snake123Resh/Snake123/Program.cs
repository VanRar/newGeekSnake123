using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Threading;

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
                                   
            Point p = new Point(4, 5, '#');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();

            Console.ReadLine();
        }
    }
}