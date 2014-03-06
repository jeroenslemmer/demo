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
            int index;
            Console.CursorVisible = false;
            ConsoleKeyInfo input;
            Rectangle selectedRectangle;
            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(new Rectangle());
            selectedRectangle = rectangles[0];
            do
            {
                Console.Clear();
                DisplayRectangles(rectangles, selectedRectangle);
                input = Console.ReadKey();
                if (input.Key != exitKey)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.PageUp:
                            if (selectedRectangle != null)
                            {
                                index = rectangles.IndexOf(selectedRectangle);
                                index++;
                                if (index > rectangles.Count - 1)
                                {
                                    index = 0;
                                }
                                rectangles.Remove(selectedRectangle);
                                rectangles.Insert(index, selectedRectangle);
                            }
                            break;
                        case ConsoleKey.PageDown:
                            if (selectedRectangle != null)
                            {
                                index = rectangles.IndexOf(selectedRectangle);
                                index--;
                                if (index < 0)
                                {
                                    index = rectangles.Count - 1;
                                }
                                rectangles.Remove(selectedRectangle);
                                rectangles.Insert(index, selectedRectangle);
                            }
                            break;
                        case ConsoleKey.Tab:
                            if (selectedRectangle != null)
                            {
                                if (input.Modifiers == ConsoleModifiers.Shift)
                                {
                                    index = rectangles.IndexOf(selectedRectangle) - 1;
                                    if (index >= 0)
                                    {
                                        selectedRectangle = rectangles[index];
                                    }
                                    else
                                    {
                                        selectedRectangle = rectangles[rectangles.Count - 1];
                                    }
                                }
                                else
                                {
                                    index = rectangles.IndexOf(selectedRectangle) + 1;
                                    if (index < rectangles.Count)
                                    {
                                        selectedRectangle = rectangles[index];
                                    }
                                    else
                                    {
                                        selectedRectangle = rectangles[0];
                                    }
                                }
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            rectangles.Add(new Rectangle());
                            selectedRectangle = rectangles[rectangles.Count - 1];
                            break;
                        case ConsoleKey.Delete:
                            if (selectedRectangle != null)
                            {
                                index = rectangles.IndexOf(selectedRectangle);
                                rectangles.Remove(selectedRectangle);
                                if (index < rectangles.Count)
                                {
                                    selectedRectangle = rectangles[index];
                                }
                                else
                                {
                                    index--;
                                    if (index >= 0)
                                    {
                                        selectedRectangle = rectangles[index];
                                    }
                                    else
                                    {
                                        selectedRectangle = null;
                                    }
                                }
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            if (selectedRectangle != null)
                            {
                                if (input.Modifiers == ConsoleModifiers.Control)
                                {
                                    selectedRectangle.GrowWidth();
                                }
                                else
                                {
                                    selectedRectangle.MoveRight();
                                }
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (selectedRectangle != null)
                            {
                                if (input.Modifiers == ConsoleModifiers.Control)
                                {
                                    selectedRectangle.ShrinkWidth();
                                }
                                else
                                {
                                    selectedRectangle.MoveLeft();
                                }
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            if (selectedRectangle != null)
                            {
                                if (input.Modifiers == ConsoleModifiers.Control)
                                {
                                    selectedRectangle.GrowHeight();
                                }
                                else
                                {
                                    selectedRectangle.MoveDown();
                                }
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            if (selectedRectangle != null)
                            {
                                if (input.Modifiers == ConsoleModifiers.Control)
                                {
                                    selectedRectangle.ShrinkHeight();
                                }
                                else
                                {
                                    selectedRectangle.MoveUp();
                                }
                            }
                            break;
                    }
                }


            } while (input.Key != exitKey);
        }

        public static void DisplayRectangles(List<Rectangle> rectangles, Rectangle selectedRectangle)
        {
            foreach(var rectangle in rectangles)
            {
                if (rectangle == selectedRectangle)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray; 
                }
                
                
                rectangle.Display();
            }

        }
    }
}
