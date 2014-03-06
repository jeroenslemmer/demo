using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            const ConsoleKey ExitKey = ConsoleKey.Q;
            ConsoleKeyInfo input;
            Square square = new Square();
            do
            {
                square.Display();
                input = Console.ReadKey();
                if (input.Key != ExitKey)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.RightArrow:
                            Console.WriteLine("right");
                            break;



                    }

                }


            } while (input.Key != ExitKey);
        }
    }
}
