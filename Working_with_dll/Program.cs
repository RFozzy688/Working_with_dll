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
            Console.WriteLine($"Площадь прямоугольника: {CalcSquare.Square(a, b)}");
            Console.WriteLine("Площадь треугольника: {0:f2}", CalcSquare.Square(a, b, c));
        }
    }
}