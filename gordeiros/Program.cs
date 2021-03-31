using System;

namespace gordeiros
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int y = 1; y > 0; y++) {
                Console.WriteLine("Informe um numero");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a operacao (A, a, S, s, D, d, M, m)");
                string operacao = Console.ReadLine();

                for (int i = 1; i <= 10; i++) {
                    if (operacao == "A" || operacao == "a") Console.WriteLine(num + i);
                    else if (operacao == "S" || operacao == "s") Console.WriteLine(num - i);
                    else if (operacao == "M" || operacao == "m") Console.WriteLine(num * i);
                    else if (operacao == "D" || operacao == "d") Console.WriteLine(num / i);
                    else {
                        Console.WriteLine("Ocorreu um erro");
                        i = 11;
                    }
                }
                Console.WriteLine("Deseja repetir a operacao? (S - N)");
                string seletor = Console.ReadLine();
                if (seletor == "N" || seletor == "n") y = -1;
            }
        }
    }
}
