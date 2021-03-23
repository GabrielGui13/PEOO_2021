using System;

namespace Q1
{
     class Program {
        static void Main(string[] args) {
            Circulo x = new Circulo();
            x.SetRaio(5);
            Console.WriteLine($"a area eh: {x.CalcArea():.00}");
            Console.WriteLine($"a circunferencia eh: {x.CalcCircunferencia():.00}");
        }
    }
    class Circulo {
        private double raio;
        public void SetRaio(double entradaraio) {
            this.raio = entradaraio;
        }
        public double GetRaio() {
            return raio;
        }
        public double CalcArea() {
            return Math.PI * Math.Pow(raio,2);
        }
        public double CalcCircunferencia(){
            return 2 * Math.PI*raio;
        }
    }
}
