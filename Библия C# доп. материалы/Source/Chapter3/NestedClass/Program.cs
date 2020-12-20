using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Shed
    {
        // Здесь идут свойства и метода Shed

        public class Window
        {
            // Здесь идут свойства и метода Window
        }

        Window window = new Window();
        public Window FrontWindow
        {
            get { return window; }
            set { window = value; }
        }

        public Shed()
        {
        }

        // Здесь идут свойства и метода Shed
    }
}
