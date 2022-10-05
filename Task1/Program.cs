using Library;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateSize(10, 15);
            int[] array = R.Filling(arraySize, 1, 100);
            Console.WriteLine("Полученный массив:");

            R.Print(array);

            Console.WriteLine("\nМассив после сортировки:");

            Functions.Sort(array);
            R.Print(array);
            Console.WriteLine("\nНаименьшее и наибольшее значение соответственно: {0}\t{1}", array[0], array[arraySize-1]);


        }
    }
}