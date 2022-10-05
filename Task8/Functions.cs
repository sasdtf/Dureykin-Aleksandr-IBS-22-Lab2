using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Functions
    {
        public static void Search(int[] array)
        {
            Console.WriteLine("\nвведите имкомый элемент \n");
            int search = R.IntParse();
            int check = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == search)
                {
                    Console.WriteLine("\nэллемент {1}={0}  \n",array[i],i+1);
                    check++;
                }

            }
            if(check== 0)
            {
                Console.WriteLine("\nтакого эллемента нет \n");
            }
        }
    }
}
