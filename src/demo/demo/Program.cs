using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            const ConsoleKey exitKey = ConsoleKey.Q;

            Console.CursorVisible = false;
            ConsoleKeyInfo input;
            Rectangle selectedRectangle;
            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(new Rectangle());
            selectedRectangle = rectangles[0];
            do
            {
                Console.Clear();
                DisplayRectangles(rectangles);
                input = Console.ReadKey();
                if (input.Key != exitKey)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.Tab:
                            int index = rectangles.IndexOf(selectedRectangle) + 1;
                            if (index < rectangles.Count)
                            {
                                selectedRectangle = rectangles[index];
                            }
                            else
                            {
                                selectedRectangle = rectangles[0];
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            rectangles.Add(new Rectangle());
                            selectedRectangle = rectangles[rectangles.Count - 1];
                            break;
                        case ConsoleKey.RightArrow:
                            if (input.Modifiers == ConsoleModifiers.Control)
                            {
                                selectedRectangle.GrowWidth();
                            }
                            else
                            {
                                selectedRectangle.MoveRight();
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            selectedRectangle.MoveLeft();
                            break;
                        case ConsoleKey.DownArrow:
                            selectedRectangle.MoveDown();
                            break;
                        case ConsoleKey.UpArrow:
                            selectedRectangle.MoveUp();
                            break;
                    }
                }


            } while (input.Key != exitKey);
        }
        public static void DisplayRectangles(List<Rectangle> rectangles)
        {
            foreach(var rectangle in rectangles)
            {
                rectangle.Display();
            }

        }
    }
}
