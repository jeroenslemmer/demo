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
                            if (input.Modifiers == ConsoleModifiers.Control)
                            {
                                square.GrowWidth();
                            }
                            else
                            {
                                square.MoveRight();
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            square.MoveLeft();
                            break;
                        case ConsoleKey.DownArrow:
                            square.MoveDown();
                            break;
                        case ConsoleKey.UpArrow:
                            square.MoveUp();
                            break;
                    }
                }


            } while (input.Key != ExitKey);
        }
    }
}
