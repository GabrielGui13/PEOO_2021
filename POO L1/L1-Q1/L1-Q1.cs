using System;

namespace L1_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo.raio = double.Parse(Console.ReadLine());
            double areaCirculo = Circulo.calcArea();
            double circCirculo = Circulo.calcCirc();

            Console.WriteLine($"A area do circulo eh {areaCirculo:.00} e a circunferencia eh {circCirculo:.00}");
        }
    }

    class Circulo {
        public static double raio;
        public static double calcArea () {
            double area = Math.PI * Math.Pow(raio, 2);
            return area;
        }

        public static double calcCirc () {
            double circ = Math.PI * raio * 2;
            return circ;
        }
    }
}
