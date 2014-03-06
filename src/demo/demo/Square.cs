using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Square
    {
        public int Id { get; set; }
        public int HorizontalPos { get; set; }
        public int VerticalPos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor Color { get; set; }

        public Square(int id)
        {
            Id = id;
            HorizontalPos = 0;
            VerticalPos = 0;
            Width = 2;
            Height = 2;
        }

        private void DisplayTopBorder()
        {
            Console.Write('┌');
            Console.Write('┐');
        }

        private void DisplayBottomBorder()
        {
            Console.Write('└');
            Console.Write('┘');
        }

        public void MoveRight()
        {
              if (HorizontalPos < Console.BufferWidth-1)
              {
                  HorizontalPos++;
              }
        }

        public void MoveLeft()
        {
            if (HorizontalPos > 0)
            {
                HorizontalPos--;
            }
        }


        public void Display()
        {
            Console.CursorTop = VerticalPos;
            Console.CursorLeft = HorizontalPos;
            DisplayTopBorder();

            Console.CursorTop = VerticalPos + Height - 1;
            Console.CursorLeft = HorizontalPos;
            DisplayBottomBorder();

        }
    }

  
}
