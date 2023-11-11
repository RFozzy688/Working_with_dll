using System.Text;

namespace DLL_module
{
    public static class CalcSquare
    {
        public static Int32 Square(Int32 a)
        {
            return a * a;
        }
        public static Int32 Square(Int32 a, Int32 b)
        {
            return a * b;
        }
        public static Double Square(Int32 a, Int32 b, Int32 c)
        {
            Double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c));
        }
    }
    public static class WorkingWithText
    {
        public static Boolean Palindrome(String str)
        {
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }
        public static int NumberOfSentences(String text)
        {
            string[] separator = { ".", "!", "?" };
            string[] sentences = null;

            sentences = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            return sentences.Length;
        }
        public static String ReverseOfSentences(String str)
        {
            string[] arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arr.Length ; i++)
            {
                arr[i] = String.Join("", arr[i].Reverse());
            }
            
            str = str.Remove(0, str.Length);

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                str = str + arr[i] + " ";
            }

            return str;
        }
    }
}