using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Square
    {
        public int id { get; set; }
        public int HorizontalPos { get; set; }
        public int VerticalPos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor Color { get; set; }

        public void Display()
        {
            Console.Write('┌');
            Console.Write('┐');
            Console.WriteLine();
            Console.Write('└');
            Console.Write('┘');
            Console.WriteLine();
        }
    }

  
}
