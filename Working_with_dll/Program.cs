using DLL_module;

namespace Working_with_dll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int c = 20;

            Console.WriteLine($"Площадь квадрата: {CalcSquare.Square(a)}");
        }
    }
}