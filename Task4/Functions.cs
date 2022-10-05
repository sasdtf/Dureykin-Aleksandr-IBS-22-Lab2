using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Functions
    {
        public static int Sum(int[,] array)
        {
            int sum = 0;
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(0); y++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        sum += array[x, y];
                    }
                }
            }
            return sum;
        
        }
        
    }
}
