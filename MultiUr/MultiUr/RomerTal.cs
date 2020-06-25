using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiUr
{
    public class RomerTal
    {
        
        public string NumberToRoman(int number)
        {
            
            if (number < 0 || number > 60)
                throw new ArgumentException("Værdien skal lægge mellem 1 - 60.");

            if (number == 0) return "N";

            int[] values = new int[] { 60, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "LX", "L", "XL", "X", "IX", "V", "IV", "I" };

            
            StringBuilder result = new StringBuilder();

            
            for (int i = 0; i < 13; i++)
            {
                
                while (number >= values[i])
                {
                    number -= values[i];
                    result.Append(numerals[i]);
                }
            }

            
            return result.ToString();
        }
    }
}

