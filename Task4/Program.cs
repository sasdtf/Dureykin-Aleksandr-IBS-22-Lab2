using Library;
namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraySize = R.CreateSize(5, 10);
            int[,] array = R.Filling2(arraySize, 1, 10);
            R.Print2(array);
            int summ = Functions.Sum(array);
            Console.WriteLine("\n Сумма элементов на четных позициях = {0}", summ);
        }
    }
}