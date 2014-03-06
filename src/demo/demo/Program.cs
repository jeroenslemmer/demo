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
            Square square = new Square(1);
            do
            {
                Console.Clear();
                square.Display();
                input = Console.ReadKey();
                if (input.Key != ExitKey)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.RightArrow:
                            square.HorizontalPos++;
                            break;



                    }

                }


            } while (input.Key != ExitKey);
        }
    }
}
