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
}