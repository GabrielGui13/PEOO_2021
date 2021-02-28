using System;

namespace PEOO
{
    class Program {
        public static void Main (string[] args) {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double teste = Maior(a, b);

            Console.WriteLine(teste);
        }

        public static double Maior (double x, double y) {
            double big = 0;
            if (x > y) big = x;
            else if (y > x) big = y;

            return big;
        }
    }
}
