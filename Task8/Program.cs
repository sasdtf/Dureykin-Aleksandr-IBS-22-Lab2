using Library;
namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива:");
            int arraySize = R.IntParse();
            if (arraySize < 1)
            {
                Console.WriteLine("Вы ввели размерность массива равную или меньше 0, пожалуйста, попробуйте снова");
                return;
            }
            int[] array = R.Filling(arraySize, 0, 10);
            R.Print(array);
            Functions.Search(array);
            
        }
    }
}