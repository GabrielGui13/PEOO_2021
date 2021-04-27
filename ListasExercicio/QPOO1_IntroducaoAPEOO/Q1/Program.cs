using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            circulo x;
            x = new circulo();
            x.raio = 3;
            Console.WriteLine(x.CalcArea());
            Console.WriteLine(x.CalcCirc());
        }
    }
    class circulo
    {
        public double raio;
        public string CalcArea()
        {
            return $"{Math.PI * Math.Pow(raio,2):.00}";
        }
        public string CalcCirc()
        {
            return $"{Math.PI * 2 * raio:.00}";
        }
    }
}
