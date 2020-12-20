using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractProject
{
    class Program
    {
        static void Main(string[] args)
        {            
            Figure rect = new RectangleFigure();
            rect.Draw();

            rect = new CircleFigure();
            rect.Draw();

            Console.ReadLine();
        }
    }

    abstract class Figure
    {
        public int Left { get; set; }
        public int Top { get; set; }

        abstract public void Draw();
    }

    class RectangleFigure : Figure
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Это класс прямоугольника");
        }
    }

    class CircleFigure : Figure
    {
        public int Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Это класс круга");
        }
    }
}
