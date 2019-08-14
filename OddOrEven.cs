using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class OddOrEven
    {
        public static string EvenOrOdd (int[] array)
        {            
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                Console.WriteLine(sum);
            }
            int isOdd = sum % 2;
            if (isOdd == 1 || isOdd == -1)
            {
                Console.WriteLine("The sum is odd");
            }
            else if (sum == 0)
            {
                Console.WriteLine("The sum is even");
            }
            else
                Console.WriteLine("The sum is even");
            return sum.ToString();
        }
    }
}
