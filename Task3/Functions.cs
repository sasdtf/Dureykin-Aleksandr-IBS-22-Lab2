using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Functions
    {
        public static int Summ(int[] array)
        {
            int summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                }
            }
            return summ;
        }
    }
    
}
