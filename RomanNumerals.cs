using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class RomanNumerals
    {
        public static Dictionary<char, int> RomanNumeral = new Dictionary<char, int>()
        {
            { 'I' , 1 },
            { 'V' , 5 },
            { 'X' , 10 },
            { 'L' , 50 },
            { 'C' , 100 },
            { 'D' , 500 },
            { 'M' , 1000 }
        };
        public static int RomanSolution (string roman)
        {
            //Found the solution on stackoverflow. I got lazy with trying to figure out how to code with enums so I looked it up and stumbled on this answer. I'll try again when I have a little more time. For now I understand how this solution works. 
            int number = 0;
            //Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer.
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanNumeral [roman[i]] < RomanNumeral [roman[i + 1]])
                {
                    number -= RomanNumeral[roman[i]];
                }
                else
                {
                    number += RomanNumeral[roman[i]];
                }
            }
            return number;
        }
    }
}
