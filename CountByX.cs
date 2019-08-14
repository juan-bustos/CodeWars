using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class CountByX
    {
        public static int [] CountBy (int x, int n)
        {
            int[] z = new int[n];
            for (int i = 0; i != z.Length; i++)
            {
                z[i] = (i + 1) * x;
                Console.WriteLine(z[i]);
            }
            return z;
        }
    }
}
