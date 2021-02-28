using System;

namespace PEOO
{
    class Program {
        public static void Main (string[] args) {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
  
            Ordenar(ref num1, ref num2, ref num3);
        }

        public static void Ordenar (ref double x, ref double y, ref double z) {
            double maior = 0;
            double meio = 0;
            double menor = 0;

            if (x > y && x > z) maior = x;
            else if (y > x && y > z) maior = y;
            else if (z > x && z > y) maior = z;

            if (x < y && x < z) menor = x;
            else if (y < x && y < z) menor = y;
            else if (z < y && z < x) menor = z;

            if (x != maior && x != menor) meio = x;
            else if (y != maior && y != menor) meio = y;
            else if (z != maior && z != menor) meio = z;

            Console.WriteLine($"Maior = {maior}");
            Console.WriteLine($"Medio = {meio}");
            Console.WriteLine($"Menor = {menor}");
        }
    }
}
