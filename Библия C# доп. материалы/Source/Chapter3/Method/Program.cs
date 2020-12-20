using System;
using System.Text;

namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Shed myFirstShed = new Shed();
            myFirstShed.Height = 10;
            myFirstShed.Width = 20;
            myFirstShed.Lengthwise = myFirstShed.Width;

            Console.WriteLine("Высота: " + myFirstShed.Height);
            Console.WriteLine("Ширина: " + myFirstShed.Width);
            Console.WriteLine("Глубина: " + myFirstShed.Lengthwise);

            int size = myFirstShed.GetSize();
            Console.WriteLine("Объем: " + size);
            Console.WriteLine("Объем: " + myFirstShed.GetSize());
            
            Console.ReadLine();
        }
    }

    class Shed
    {
        int width;
        int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Lengthwise { get; set; }


        // Метод, возвращающий размер сарая
        public int GetSize()
        {
            int size = width * height * Lengthwise;
            return size;
        }
    }
}
