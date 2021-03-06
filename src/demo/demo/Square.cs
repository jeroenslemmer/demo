﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Rectangle
    {
        public int Id { get; set; }
        public int HorizontalPos { get; set; }
        public int VerticalPos { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ConsoleColor Color { get; set; }

        public Rectangle()
        {
            HorizontalPos = 0;
            VerticalPos = 0;
            Width = 2;
            Height = 2;
        }

        public void MoveRight()
        {
              if (HorizontalPos + Width < Console.BufferWidth)
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

        public void MoveDown()
        {
            if (VerticalPos + Height < Console.WindowHeight)
            {
                VerticalPos++;
            }
        }

        public void MoveUp()
        {
            if (VerticalPos > 0)
            {
                VerticalPos--;
            }
        }

        public void GrowWidth()
        {
            if (HorizontalPos + Width < Console.BufferWidth)
            {
                Width++;
            }
        }

        public void GrowHeight()
        {
            if (VerticalPos + Height < Console.WindowHeight)
            {
                Height++;
            }
        }

        public void ShrinkWidth()
        {
            Width--;
            if (Width < 2)
            {
                Width = 2;
            }
        }

        public void ShrinkHeight()
        {
            Height--;
            if (Height < 2)
            {
                Height = 2;
            }
        }

        private void DisplayHorizontalBorderLine()
        {
            for (int c = 1; c <= Width - 2; c++) // R
            {
                Console.Write('─');
            }
        }

        private void DisplayVerticalBorderLine()
        {
            int left = Console.CursorLeft; // to restore cursorposition left
            int top = Console.CursorTop;
            for (int c = 0; c < Height - 2; c++) // R
            {
                Console.CursorLeft = left;
                Console.CursorTop = top + c;
                Console.Write('│');
            }
        }

        private void DisplayTopBorder()
        {
            Console.Write('┌');
            DisplayHorizontalBorderLine();
            Console.Write('┐');
        }

        private void DisplayBottomBorder()
        {
            Console.Write('└');
            DisplayHorizontalBorderLine();
            Console.Write('┘');
        }

        public void Display()
        {
            Console.CursorTop = VerticalPos;
            Console.CursorLeft = HorizontalPos;
            DisplayTopBorder();

            Console.CursorTop = VerticalPos + 1;
            Console.CursorLeft = HorizontalPos;
            DisplayVerticalBorderLine();

            Console.CursorTop = VerticalPos + 1;
            Console.CursorLeft = HorizontalPos + Width - 1;
            DisplayVerticalBorderLine();

            Console.CursorTop = VerticalPos + Height - 1;
            Console.CursorLeft = HorizontalPos;
            DisplayBottomBorder();

        }
    }

  
}
