using System;

namespace Weekly_10_11
{
    class Program
    {
        static double UniqueFract()
        {
            double result = 0.0;
            for (int num = 1; num < 9; num++)
            {
                for (int den = num + 1; den < 10; den++)
                {
                    if (!((den % 2 == 0 && num % 2 == 0) || (den % 3 == 0 && num % 3 == 0)))
                        result += (double)num / (double)den;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(UniqueFract());
        }
    }
}
