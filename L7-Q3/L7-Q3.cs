using System;

namespace L7_Q3
{
    class Program
    {
        public static void Main(string[] args) {
            double a = double.Parse(Console.ReadLine());
            int b;
            int c;
            Intervalo(a, out b, out c);

            Console.WriteLine($"O numero {a} esta inserido entre {b} e {c}");
        }

        public static void Intervalo(double x, out int numInicio, out int numFim) {
            numInicio = Convert.ToInt32(Math.Floor(x));
            numFim = Convert.ToInt32(Math.Ceiling(x));
        }  
    }
}
