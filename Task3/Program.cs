using Library;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateSize(5, 10);
            int[] array = R.Filling(arraySize, -100, 100);
            R.Print(array);
            int summ = Functions.Summ(array);
            Console.WriteLine("\nСумма всех неотрицательных значений массива = {0}", summ);
        }
    }
}