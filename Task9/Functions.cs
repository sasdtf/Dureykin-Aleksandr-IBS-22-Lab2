﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Functions
    {
        public static bool Code(int[] arrayOne, int[] arrayTwo)
        {
            bool result = true;
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }
    }
}
