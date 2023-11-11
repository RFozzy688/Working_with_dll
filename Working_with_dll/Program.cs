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
            string _text;

            Console.WriteLine($"Площадь квадрата: {CalcSquare.Square(a)}");
            Console.WriteLine($"Площадь прямоугольника: {CalcSquare.Square(a, b)}");
            Console.WriteLine("Площадь треугольника: {0:f2}", CalcSquare.Square(a, b, c));

            Console.WriteLine("==============================");

            if (WorkingWithText.Palindrome("qwertewq"))
            {
                Console.WriteLine("Строка полиндром");
            }
            else
            {
                Console.WriteLine("Строка не полиндром");
            }

            using (FileStream fs = new FileStream(@"..\..\..\test.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    _text = sr.ReadToEnd();
                }
            }

            Console.WriteLine("Количество предложений: {0}", WorkingWithText.NumberOfSentences(_text));

            string str = "Таким образом постоянный количественный рост и сфера нашей активности играет важную роль в формировании дальнейших направлений развития";
            Console.WriteLine("Переворот предложения: {0}", WorkingWithText.ReverseOfSentences(str));
        }
    }
}