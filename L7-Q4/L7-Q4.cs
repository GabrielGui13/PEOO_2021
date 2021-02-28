using System;

namespace L7_Q4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine(MMC(num1, num2));
        }

        public static int MMC (int x, int y) {
            int resto = 0;
            
            int x1 = x;
            int y1 = y;

            while (resto != 0) {
                resto = x1 % y1;
                x1 = y1;
                y1 = resto;
            }

            int mmc = (x1 * y1) / resto;
            return mmc;
        }
    }
}
