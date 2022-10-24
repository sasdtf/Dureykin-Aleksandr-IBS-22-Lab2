using Library;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateSize(10, 15);
            int[] array = R.CreateArray(arraySize, 1, 100);
            Console.WriteLine("Полученный массив:");

            R.Print(array);

            Console.WriteLine("\nМассив после сортировки:\n");

            Functions.Sort(array);
            R.Print(array);
            Console.WriteLine("\nНаименьшее и наибольшее значение соответственно: {0}\t{1}" 
                ,Functions.FindingMin(array) ,Functions.FindingMax(array) );


        }
    }
}