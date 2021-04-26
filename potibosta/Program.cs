using System;

namespace potibosta
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = {30, 17, 16, 32, 20, 28, -8, 33, 1, -1};
            int soma = 0;

            for (int i = 0; i < num.Length; i++) {
                if (i % 2 == 0) soma += num[i];
                else soma -= num[i];
            }
            Console.WriteLine(soma);
        }
    }
}
