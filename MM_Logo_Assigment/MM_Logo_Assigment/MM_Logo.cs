﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MM_Logo_Assigment
{
    class MM_Logo
    {
        public int letter_Width { get; set; }

        public void PrintMM()
        {
            int mid_LinePosition = (letter_Width + 1) / 2;
            //loop for every line
            for (int linePosition = 0; linePosition < letter_Width + 1; linePosition++)
            {
                //if it's in the top fragment range
                if (linePosition < mid_LinePosition)
                {
                    PrintTop(linePosition);
                }
                //if it's in the bottom fragment range
                else
                {
                    PrintBottom(linePosition);
                }
                //end the line
                Console.WriteLine();
            }
        }

        //print the top of the letters
        private void PrintTop(int line_Position)
        {
            //print it twice, side by side
            for (int i = 0; i < 2; i++)
            {
                //left side of the letter + space
                PrintString(letter_Width - line_Position, '-');
                PrintString(letter_Width + line_Position * 2, '*');

                //middle space
                PrintString(letter_Width - line_Position * 2, '-');

                //right side of the letter + space
                PrintString(letter_Width + line_Position * 2, '*');
                PrintString(letter_Width - line_Position, '-');
            }
        }

        //print the top of the letters
        private void PrintBottom(int line_Position)
        {
            for (int i = 0; i < 2; i++)
            {
                //left side of the letter + space
                PrintString(letter_Width - line_Position, '-');
                PrintString(letter_Width, '*');

                //the middle of the letter + space
                int space = line_Position * 2 - letter_Width;
                PrintString(space, '-');
                PrintString(letter_Width * 2 - space, '*');
                PrintString(space, '-');

                //the right side of the letter + space
                PrintString(letter_Width, '*');
                PrintString(letter_Width - line_Position, '-');
            }
        }

        //print a string with lenght and specific symbol
        private void PrintString(int length, char symbol)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}
