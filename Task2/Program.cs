using Library;
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = Functions.CreateArray(3, -9, 9);
            Console.WriteLine(" массив:");
            R.Print3(array);
            Functions.Replace(array);
            Console.WriteLine("Вид массива после изменений:");
            R.Print3(array);
        }
    }
}