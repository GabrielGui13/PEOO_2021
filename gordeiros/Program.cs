using System;

namespace gordeiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, c1 = 0, c2 = 0, c3 = 0, c4 = 0;

            do {
                numero = int.Parse(Console.ReadLine());

                if (numero >= 0 && numero <= 25) c1++;
                else if (numero > 26 && numero <= 50) c2++;
                else if (numero > 51 && numero <= 75) c3++;
                else if (numero > 76 && numero <= 100) c4++;

            } while (numero > -1);

            Console.WriteLine("Numeros entre 0 e 25 = " + c1);
            Console.WriteLine("Numeros entre 26 e 50 = " + c2);
            Console.WriteLine("Numeros entre 51 e 75 = " + c3);
            Console.WriteLine("Numeros entre 76 e 100 = " + c4);
        }
    }
}
